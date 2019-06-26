using System;
using System.Windows.Forms;

namespace GuessNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RandNum();
        }

        private void input_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 限制只能輸入數字
            // 使用 Char.IsDigit 方法 : 指示指定的 Unicode 字元是否分類為十進位數字。
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9

            // Char.IsControl 方法 : 指示指定的 Unicode 字元是否分類為控制字元。
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void rule_btn_Click(object sender, EventArgs e)
        {
            // 規則
            MessageBox.Show("請輸入4個不重複數字，如果數字與位置和正確答案相同則會顯示A，" +
                "例:輸入1234與答案2234，則會顯示3A。" +
                "如果只有數字與正確答案相同則會顯示B，例:輸入4582與答案2234，則會顯示2B。\n輸入後請按enter。" + 
                "祝好運!");
        }

        private System.Collections.ArrayList MakeRand()
        {
            // 產生不重複亂數
            System.Collections.ArrayList arrayRand = new System.Collections.ArrayList();
            Random random = new Random((int)DateTime.Now.Ticks);
            int intRnd;
            while (arrayRand.Count < 4)
            {
                intRnd = random.Next(0, 9 + 1);
                if (!arrayRand.Contains(intRnd))
                {
                    arrayRand.Add(intRnd);
                }
            }
            return arrayRand;
        }

        int[] ans = new int[4];

        public void RandNum()
        {
            // 存入亂數
            System.Collections.ArrayList rnd = MakeRand();           
            ans = (int[])rnd.ToArray(typeof(int));            
        }

        public void check()
        { 
            int[] user_guess = new int[4];// 使用者的數字
            //XAOB
            int a = 0;// 位置正確數(A)
            int b = 0;// 數字正確數(B)
            int tempnum = int.Parse(input_num.Text);// 暫存使用者數字
            for(int i = 3;i >= 0;i--)
            {
                // 轉成4個數字
                user_guess[i] = tempnum % 10;
                tempnum /= 10;                
            }

            for(int i = 0;i < 4;i++)
            {
               if(ans[i] == user_guess[i])// 檢查位置
                {
                    a++;
                }
               else
                {
                    for(int j = 0;j < 4;j++)
                    {
                        if(ans[i] == user_guess[j])// 檢查數字
                        {
                            b++;
                        }
                    }
                }
            }

            guess_info.Text = a.ToString() + "A" + b.ToString() + "B";
            Log_list.Items.Add(input_num.Text + "  " + guess_info.Text);
            if(a == 4)
            {
                MessageBox.Show("恭喜答對!");
            }

        }

        private void input_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)// 按下enter
            {
                check();
            }
        }

        private void Show_ans_btn_Click(object sender, EventArgs e)
        {
            Ans_label.Text = "";
            for (int i = 0; i < 4; i++)// 顯示答案
            {
               Ans_label.Text += ans[i].ToString();
            }          
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /*private void Form1_FormClosed()//關閉程式用
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }*/
    }
}
