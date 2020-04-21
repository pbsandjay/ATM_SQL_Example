namespace WindowsFormsApplication15
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tbxAccData = new System.Windows.Forms.TextBox();
            this.cbxAccounts = new System.Windows.Forms.ComboBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.tbxPin = new System.Windows.Forms.TextBox();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.btBalance = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 166);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(220, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 51);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(58, 319);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 51);
            this.button8.TabIndex = 7;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(139, 319);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 51);
            this.button9.TabIndex = 8;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(220, 319);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 51);
            this.button10.TabIndex = 9;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumberClick);
            // 
            // tbxAccData
            // 
            this.tbxAccData.Location = new System.Drawing.Point(58, 12);
            this.tbxAccData.Multiline = true;
            this.tbxAccData.Name = "tbxAccData";
            this.tbxAccData.Size = new System.Drawing.Size(318, 63);
            this.tbxAccData.TabIndex = 11;
            this.tbxAccData.TextChanged += new System.EventHandler(this.tbxAccData_TextChanged);
            // 
            // cbxAccounts
            // 
            this.cbxAccounts.FormattingEnabled = true;
            this.cbxAccounts.Location = new System.Drawing.Point(382, 93);
            this.cbxAccounts.Name = "cbxAccounts";
            this.cbxAccounts.Size = new System.Drawing.Size(156, 21);
            this.cbxAccounts.TabIndex = 15;
            this.cbxAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxAccounts_SelectedIndexChanged);
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(301, 81);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(75, 20);
            this.btEnter.TabIndex = 21;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // tbxPin
            // 
            this.tbxPin.Location = new System.Drawing.Point(161, 115);
            this.tbxPin.Name = "tbxPin";
            this.tbxPin.Size = new System.Drawing.Size(100, 20);
            this.tbxPin.TabIndex = 22;
            this.tbxPin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btWithdraw
            // 
            this.btWithdraw.Location = new System.Drawing.Point(301, 136);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btWithdraw.TabIndex = 24;
            this.btWithdraw.Text = "Withdraw";
            this.btWithdraw.UseVisualStyleBackColor = true;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // btBalance
            // 
            this.btBalance.Location = new System.Drawing.Point(302, 107);
            this.btBalance.Name = "btBalance";
            this.btBalance.Size = new System.Drawing.Size(75, 23);
            this.btBalance.TabIndex = 25;
            this.btBalance.Text = "Balance";
            this.btBalance.UseVisualStyleBackColor = true;
            this.btBalance.Click += new System.EventHandler(this.btBalance_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(301, 165);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 26;
            this.btClear.Text = "Clear Text";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.button11_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 382);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btBalance);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.tbxPin);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.cbxAccounts);
            this.Controls.Add(this.tbxAccData);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tbxAccData;
        private System.Windows.Forms.ComboBox cbxAccounts;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbxPin;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.Button btBalance;
        private System.Windows.Forms.Button btClear;
    }
}

