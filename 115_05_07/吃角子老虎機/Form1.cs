using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Random rng = new Random();
        private decimal initialBalance = 000m;
        private decimal balance;
        private decimal lastWin = 0m;
        private int totalSpins = 0;
        private int winCount = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            balance = initialBalance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化下注選項（若 designer 已設定 items，確保選到第一項）
            if (comboBox_bet.Items.Count == 0)
            {
                comboBox_bet.Items.AddRange(new object[] { "$1", "$5", "$10", "$20" });
            }

            if (comboBox_bet.SelectedIndex < 0)
            {
                comboBox_bet.SelectedIndex = 0;
            }

            // 先顯示三張隨機圖片
            getImage();
            UpdateUI();
        }

        /// <summary>
        /// 亂數決定並立即顯示三個圖片，傳回所選索引陣列
        /// </summary>
        private int[] getImage()
        {
            int count = imageList1.Images.Count;
            if (count == 0)
            {
                // 若沒有圖片，清掉 PictureBox
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                return new int[] { -1, -1, -1 };
            }

            int i1 = rng.Next(0, count);
            int i2 = rng.Next(0, count);
            int i3 = rng.Next(0, count);

            pictureBox1.Image = imageList1.Images[i1];
            pictureBox2.Image = imageList1.Images[i2];
            pictureBox3.Image = imageList1.Images[i3];

            return new int[] { i1, i2, i3 };
        }

        /// <summary>
        /// 存入按鈕：驗證輸入並加到餘額
        /// </summary>
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string txt = textBox_deposit.Text?.Trim();
            if (string.IsNullOrEmpty(txt))
            {
                MessageBox.Show("請輸入存入金額。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 允許包含千分位或小數點
            if (decimal.TryParse(txt, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal amount) && amount > 0m)
            {
                balance += amount;
                textBox_deposit.Clear();
                UpdateUI();
            }
            else
            {
                MessageBox.Show("請輸入有效數字（大於 0）。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 判斷三段賠率：三個相同 -> 10x；兩個相同 -> 2x；否則 0
        /// 傳回中獎金額（單位同下注）
        /// </summary>
        private decimal checkWinner(int[] indices, decimal bet)
        {
            if (indices == null || indices.Length != 3) return 0m;

            int a = indices[0], b = indices[1], c = indices[2];
            if (a == b && b == c)
            {
                // 三個相同：10 倍
                return bet * 10m;
            }
            if (a == b || b == c || a == c)
            {
                // 兩個相同：2 倍（含下注回收）
                return bet * 2m;
            }
            return 0m;
        }

        /// <summary>
        /// 旋轉按鈕：扣款、顯示圖片、判斷並更新狀態
        /// </summary>
        private void btnSpin_Click(object sender, EventArgs e)
        {
            // 讀取下注金額
            if (comboBox_bet.SelectedItem == null)
            {
                MessageBox.Show("請選擇下注金額。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string betText = comboBox_bet.SelectedItem.ToString().Trim();
            if (betText.StartsWith("$")) betText = betText.Substring(1);
            if (!decimal.TryParse(betText, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal bet) || bet <= 0m)
            {
                MessageBox.Show("下注金額格式錯誤。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (balance < bet)
            {
                MessageBox.Show("餘額不足，請先存入金額。", "餘額不足", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 扣款
            balance -= bet;

            // 立即顯示圖片（簡易版，沒有動畫）
            int[] result = getImage();

            // 判斷中獎
            decimal win = checkWinner(result, bet);
            lastWin = win;

            // 若中獎，將中獎金額加回餘額
            if (win > 0m)
            {
                balance += win;
                winCount++;
            }

            totalSpins++;

            // 更新 UI 與統計
            UpdateStats();
            UpdateUI();

            // 顯示本次結果摘要（可去掉以免太多訊息）
            if (win > 0m)
            {
                MessageBox.Show(string.Format(CultureInfo.CurrentCulture, "中獎！ 獲得 NT${0:0.00}", win), "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 更新介面上的餘額 / 本次獲得 / 按鈕啟用狀態
        /// </summary>
        private void UpdateUI()
        {
            label_balance.Text = string.Format(CultureInfo.CurrentCulture, "餘額： NT${0:0.00}", balance);
            label_lastWin.Text = string.Format(CultureInfo.CurrentCulture, "本次獲得： NT${0:0.00}", lastWin);

            // enable spin 若餘額 >= 選擇的下注
            decimal currentBet = 0m;
            if (comboBox_bet.SelectedItem != null)
            {
                string betText = comboBox_bet.SelectedItem.ToString().Trim();
                if (betText.StartsWith("$")) betText = betText.Substring(1);
                decimal.TryParse(betText, NumberStyles.Number, CultureInfo.CurrentCulture, out currentBet);
            }

            button1.Enabled = balance >= currentBet && currentBet > 0m;
            button_deposit.Enabled = true;
            comboBox_bet.Enabled = true;
            button2.Enabled = true;
        }

        /// <summary>
        /// 更新三個統計標籤（旋轉 / 中獎 / 勝率）
        /// </summary>
        private void UpdateStats()
        {
            label_totalSpins.Text = string.Format(CultureInfo.CurrentCulture, "旋轉： {0} 次", totalSpins);
            label_winCount.Text = string.Format(CultureInfo.CurrentCulture, "中獎： {0} 次", winCount);
            double rate = totalSpins > 0 ? (100.0 * winCount / totalSpins) : 0.0;
            label_winRate.Text = string.Format(CultureInfo.CurrentCulture, "勝率： {0:0.0}%", rate);
        }

        /// <summary>
        /// 離開 / 結算：顯示摘要與盈虧，然後關閉視窗
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            decimal net = balance - initialBalance;
            string sign = net >= 0m ? "獲利" : "虧損";
            string msg = string.Format(CultureInfo.CurrentCulture,
                "遊戲摘要：\n\n初始餘額： NT${0:0.00}\n目前餘額： NT${1:0.00}\n本次{4}： NT${2:0.00}\n總旋轉次數： {3}\n中獎次數： {5}\n勝率： {6:0.0}%",
                initialBalance, balance, Math.Abs(net), totalSpins, sign, winCount, totalSpins > 0 ? (100.0 * winCount / totalSpins) : 0.0);

            MessageBox.Show(msg, "結算摘要", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
