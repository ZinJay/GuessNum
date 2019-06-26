namespace GuessNum
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.input_num = new System.Windows.Forms.TextBox();
            this.guess_info = new System.Windows.Forms.Label();
            this.rule_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Ans_label = new System.Windows.Forms.Label();
            this.Show_ans_btn = new System.Windows.Forms.Button();
            this.Log_list = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Res_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_num
            // 
            this.input_num.Location = new System.Drawing.Point(16, 61);
            this.input_num.Margin = new System.Windows.Forms.Padding(4);
            this.input_num.MaxLength = 4;
            this.input_num.Name = "input_num";
            this.input_num.ShortcutsEnabled = false;
            this.input_num.Size = new System.Drawing.Size(139, 25);
            this.input_num.TabIndex = 0;
            this.input_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_num_KeyDown);
            this.input_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_num_KeyPress);
            // 
            // guess_info
            // 
            this.guess_info.AutoSize = true;
            this.guess_info.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.guess_info.Location = new System.Drawing.Point(216, 59);
            this.guess_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guess_info.Name = "guess_info";
            this.guess_info.Size = new System.Drawing.Size(0, 30);
            this.guess_info.TabIndex = 1;
            // 
            // rule_btn
            // 
            this.rule_btn.Location = new System.Drawing.Point(16, 98);
            this.rule_btn.Margin = new System.Windows.Forms.Padding(4);
            this.rule_btn.Name = "rule_btn";
            this.rule_btn.Size = new System.Drawing.Size(113, 39);
            this.rule_btn.TabIndex = 2;
            this.rule_btn.Text = "規則";
            this.rule_btn.UseVisualStyleBackColor = true;
            this.rule_btn.Click += new System.EventHandler(this.rule_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer:";
            // 
            // Ans_label
            // 
            this.Ans_label.AutoSize = true;
            this.Ans_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Ans_label.Location = new System.Drawing.Point(137, 311);
            this.Ans_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ans_label.Name = "Ans_label";
            this.Ans_label.Size = new System.Drawing.Size(0, 30);
            this.Ans_label.TabIndex = 4;
            // 
            // Show_ans_btn
            // 
            this.Show_ans_btn.Location = new System.Drawing.Point(16, 262);
            this.Show_ans_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Show_ans_btn.Name = "Show_ans_btn";
            this.Show_ans_btn.Size = new System.Drawing.Size(113, 45);
            this.Show_ans_btn.TabIndex = 5;
            this.Show_ans_btn.Text = "顯示答案";
            this.Show_ans_btn.UseVisualStyleBackColor = true;
            this.Show_ans_btn.Click += new System.EventHandler(this.Show_ans_btn_Click);
            // 
            // Log_list
            // 
            this.Log_list.FormattingEnabled = true;
            this.Log_list.ItemHeight = 15;
            this.Log_list.Location = new System.Drawing.Point(221, 138);
            this.Log_list.Margin = new System.Windows.Forms.Padding(4);
            this.Log_list.Name = "Log_list";
            this.Log_list.Size = new System.Drawing.Size(128, 169);
            this.Log_list.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "輸入數字:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(217, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "您的紀錄";
            // 
            // Res_btn
            // 
            this.Res_btn.Location = new System.Drawing.Point(16, 176);
            this.Res_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Res_btn.Name = "Res_btn";
            this.Res_btn.Size = new System.Drawing.Size(113, 41);
            this.Res_btn.TabIndex = 9;
            this.Res_btn.Text = "重新開始";
            this.Res_btn.UseVisualStyleBackColor = true;
            this.Res_btn.Click += new System.EventHandler(this.Res_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 389);
            this.Controls.Add(this.Res_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Log_list);
            this.Controls.Add(this.Show_ans_btn);
            this.Controls.Add(this.Ans_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rule_btn);
            this.Controls.Add(this.guess_info);
            this.Controls.Add(this.input_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "GuessNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_num;
        private System.Windows.Forms.Label guess_info;
        private System.Windows.Forms.Button rule_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ans_label;
        private System.Windows.Forms.Button Show_ans_btn;
        private System.Windows.Forms.ListBox Log_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Res_btn;
    }
}

