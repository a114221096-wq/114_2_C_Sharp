using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Random _rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            // 確保介面支援 18pt 可讀性
            var bigFont = new Font("微軟正黑體", 18F);
            txtNum1.Font = bigFont;
            txtNum2.Font = bigFont;
            txtNum3.Font = bigFont;
            txtNum4.Font = bigFont;
            txtNum5.Font = bigFont;
            btnGenerate.Font = bigFont;
            btnDraw.Font = bigFont;
            btnExit.Font = bigFont;
            lstResults.Font = bigFont;
            lblTitle.Font = bigFont;

            // 初始化 ListBox 顯示標題
            lstResults.Items.Clear();
            lstResults.Items.Add("本期開獎號碼：");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 使用基本陣列與迴圈產生 5 個不重複號碼（1-49）
            try
            {
                int[] nums = GenerateUniqueNumbers(5, 1, 49);
                txtNum1.Text = nums[0].ToString();
                txtNum2.Text = nums[1].ToString();
                txtNum3.Text = nums[2].ToString();
                txtNum4.Text = nums[3].ToString();
                txtNum5.Text = nums[4].ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "產生號碼錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // 開啟檔案並解析五行數字（每行一個數字）
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "文字檔|*.txt|所有檔案|*.*";
                dlg.Title = "選取開獎號碼檔案（每行一個數字，共五行）";
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                int[] drawNums = new int[5];
                try
                {
                    using (var sr = new StreamReader(dlg.FileName))
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            string line = sr.ReadLine();
                            if (line == null)
                                throw new FormatException($"檔案不足五行（在第 {i + 1} 行結束）。");

                            line = line.Trim();
                            int value;
                            if (!int.TryParse(line, out value))
                                throw new FormatException($"第 {i + 1} 行格式錯誤（無法轉為整數）：\"{line}\"");

                            if (value < 1 || value > 49)
                                throw new FormatException($"第 {i + 1} 行數字超出範圍 (1-49)：{value}");

                            // 檢查檔案內是否有重複
                            for (int j = 0; j < i; j++)
                            {
                                if (drawNums[j] == value)
                                    throw new FormatException($"第 {i + 1} 行與第 {j + 1} 行號碼重複：{value}");
                            }

                            drawNums[i] = value;
                        }

                        // 若檔案還有多於五行，忽略其餘內容（但不視為錯誤）
                    }
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show($"讀取檔案發生錯誤：{ioEx.Message}", "檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (FormatException fmEx)
                {
                    MessageBox.Show($"檔案內容錯誤：{fmEx.Message}", "檔案格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"無法處理檔案：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 顯示開獎號碼於 ListBox（保留首行標題）
                if (lstResults.Items.Count > 0)
                {
                    var header = lstResults.Items[0];
                    lstResults.Items.Clear();
                    lstResults.Items.Add(header);
                }
                for (int i = 0; i < drawNums.Length; i++)
                {
                    lstResults.Items.Add($"第{i + 1}個號碼: {drawNums[i]}");
                }

                // 如果使用者已產生號碼，進行比對並顯示結果
                if (!string.IsNullOrWhiteSpace(txtNum1.Text))
                {
                    try
                    {
                        int[] userNums = new int[5];
                        userNums[0] = int.Parse(txtNum1.Text);
                        userNums[1] = int.Parse(txtNum2.Text);
                        userNums[2] = int.Parse(txtNum3.Text);
                        userNums[3] = int.Parse(txtNum4.Text);
                        userNums[4] = int.Parse(txtNum5.Text);

                        var compareResult = CompareNumbers(userNums, drawNums);
                        string prize = GetPrizeByMatchCount(compareResult.matchCount);
                        string matchedText = compareResult.matchCount > 0 ? string.Join(", ", compareResult.matchedNumbers) : "無";

                        // 顯示比對結果
                        MessageBox.Show(
                            $"比對完成。\n中獎數量：{compareResult.matchCount}\n中獎號碼：{matchedText}\n獎項：{prize}",
                            "比對結果",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // 同步寫入 ListBox
                        lstResults.Items.Add($"比對結果：中獎數量 {compareResult.matchCount}，中獎號碼：{matchedText}，獎項：{prize}");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("產生的號碼格式不正確，請重新產生。", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("已載入開獎號碼。如需比對請先按「產生號碼」產生您的號碼。", "開獎已載入", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 使用基本陣列與迴圈實作不重複亂數產生，並以選擇排序排序結果（避免使用進階資料結構與 LINQ）
        private int[] GenerateUniqueNumbers(int count, int minInclusive, int maxInclusive)
        {
            int range = maxInclusive - minInclusive + 1;
            if (range < count)
                throw new ArgumentException("指定範圍無法產生足夠的不重複數字。");

            int[] result = new int[count];
            int filled = 0;
            while (filled < count)
            {
                int n = _rnd.Next(minInclusive, maxInclusive + 1);
                bool exists = false;
                for (int i = 0; i < filled; i++)
                {
                    if (result[i] == n)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    result[filled] = n;
                    filled++;
                }
            }

            // 選擇排序 (簡單排序以提升顯示可讀性)
            for (int i = 0; i < count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (result[j] < result[minIndex])
                        minIndex = j;
                }
                if (minIndex != i)
                {
                    int tmp = result[i];
                    result[i] = result[minIndex];
                    result[minIndex] = tmp;
                }
            }

            return result;
        }

        // 比對兩組長度皆為 5 的陣列，回傳中獎數量與中獎號碼列表
        private (int matchCount, int[] matchedNumbers) CompareNumbers(int[] userNums, int[] drawNums)
        {
            int[] matched = new int[5];
            int matchCount = 0;

            for (int i = 0; i < userNums.Length; i++)
            {
                for (int j = 0; j < drawNums.Length; j++)
                {
                    if (userNums[i] == drawNums[j])
                    {
                        matched[matchCount] = userNums[i];
                        matchCount++;
                        break; // 一個使用者號碼只算一次
                    }
                }
            }

            // 建立僅含匹配數字的陣列回傳
            int[] matchedTrimmed = new int[matchCount];
            for (int k = 0; k < matchCount; k++)
                matchedTrimmed[k] = matched[k];

            return (matchCount, matchedTrimmed);
        }

        // 根據中獎數量回傳獎項名稱（可依需求調整規則）
        private string GetPrizeByMatchCount(int matchCount)
        {
            if (matchCount >= 5) return "頭獎";
            if (matchCount == 4) return "貳獎";
            if (matchCount == 3) return "參獎";
            if (matchCount == 2) return "安慰獎";
            if (matchCount == 1) return "未列入獎項（有中但未達門檻）";
            return "未中獎";
        }
    }
}
