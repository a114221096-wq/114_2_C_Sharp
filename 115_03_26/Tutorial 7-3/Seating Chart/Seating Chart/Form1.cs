using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            //const int MAX_ROWS = 5;
            //const int MAX_COLS = 4;
            int row, col;

            decimal[,] seatPrice = { { 450m, 450m, 450m, 450m},
                                    {425m, 425m, 425m, 425m},
                                    {400m, 400m, 400m, 400m},
                                    {375m, 375m, 375m, 375m},
                                    {375m, 375m, 375m, 375m},
                                    {350m, 350m, 350m, 350m},
                                    };
            if (int.TryParse(rowTextBox.Text, out row) && (((row - 1) < seatPrice.GetLength(0)) && (row > 0)))
            {
                if (int.TryParse(rowTextBox.Text, out col) && (((col - 1) < seatPrice.GetLength(1)) && (col > 0)))
                {
                    priceLabel.Text = seatPrice[row - 1, col - 1].ToString("C");
                }
                else
                {
                    MessageBox.Show("請輸入有效行數");
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效列數");
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
