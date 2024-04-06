namespace LAB_2
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResult = new TextBox();
            btnOpnhan = new Button();
            btnOptru = new Button();
            btnOpcong = new Button();
            btnNumber = new Button();
            btnDot = new Button();
            btnOpchia = new Button();
            btnCal = new Button();
            btnClear = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 21);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(389, 31);
            txtResult.TabIndex = 0;
            // 
            // btnOpnhan
            // 
            btnOpnhan.Location = new Point(306, 235);
            btnOpnhan.Name = "btnOpnhan";
            btnOpnhan.Size = new Size(59, 55);
            btnOpnhan.TabIndex = 5;
            btnOpnhan.Text = "*";
            btnOpnhan.UseVisualStyleBackColor = true;
            btnOpnhan.Click += btnOpcong_Click;
            // 
            // btnOptru
            // 
            btnOptru.Location = new Point(306, 174);
            btnOptru.Name = "btnOptru";
            btnOptru.Size = new Size(59, 55);
            btnOptru.TabIndex = 7;
            btnOptru.Text = "-";
            btnOptru.UseVisualStyleBackColor = true;
            btnOptru.Click += btnOpcong_Click;
            // 
            // btnOpcong
            // 
            btnOpcong.Location = new Point(306, 113);
            btnOpcong.Name = "btnOpcong";
            btnOpcong.Size = new Size(59, 55);
            btnOpcong.TabIndex = 11;
            btnOpcong.Text = "+";
            btnOpcong.UseVisualStyleBackColor = true;
            btnOpcong.Click += btnOpcong_Click;
            // 
            // btnNumber
            // 
            btnNumber.Location = new Point(67, 296);
            btnNumber.Name = "btnNumber";
            btnNumber.Size = new Size(59, 55);
            btnNumber.TabIndex = 12;
            btnNumber.Text = "0";
            btnNumber.UseVisualStyleBackColor = true;
            btnNumber.Click += btnNumber_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(144, 367);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(59, 55);
            btnDot.TabIndex = 14;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnNumber_Click;
            // 
            // btnOpchia
            // 
            btnOpchia.Location = new Point(306, 296);
            btnOpchia.Name = "btnOpchia";
            btnOpchia.Size = new Size(59, 55);
            btnOpchia.TabIndex = 15;
            btnOpchia.Text = "/";
            btnOpchia.UseVisualStyleBackColor = true;
            btnOpchia.Click += btnOpcong_Click;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(223, 296);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(59, 55);
            btnCal.TabIndex = 16;
            btnCal.Text = "=";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(144, 296);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(59, 55);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(67, 235);
            button1.Name = "button1";
            button1.Size = new Size(59, 55);
            button1.TabIndex = 18;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 235);
            button2.Name = "button2";
            button2.Size = new Size(59, 55);
            button2.TabIndex = 19;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNumber_Click;
            // 
            // button3
            // 
            button3.Location = new Point(223, 174);
            button3.Name = "button3";
            button3.Size = new Size(59, 55);
            button3.TabIndex = 20;
            button3.Text = "6";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(144, 174);
            button4.Name = "button4";
            button4.Size = new Size(59, 55);
            button4.TabIndex = 21;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumber_Click;
            // 
            // button5
            // 
            button5.Location = new Point(144, 235);
            button5.Name = "button5";
            button5.Size = new Size(59, 55);
            button5.TabIndex = 22;
            button5.Text = "2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(223, 113);
            button6.Name = "button6";
            button6.Size = new Size(59, 55);
            button6.TabIndex = 23;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnNumber_Click;
            // 
            // button7
            // 
            button7.Location = new Point(144, 113);
            button7.Name = "button7";
            button7.Size = new Size(59, 55);
            button7.TabIndex = 24;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumber_Click;
            // 
            // button8
            // 
            button8.Location = new Point(67, 113);
            button8.Name = "button8";
            button8.Size = new Size(59, 55);
            button8.TabIndex = 25;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnNumber_Click;
            // 
            // button9
            // 
            button9.Location = new Point(67, 174);
            button9.Name = "button9";
            button9.Size = new Size(59, 55);
            button9.TabIndex = 26;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnNumber_Click;
            // 
            // button10
            // 
            button10.Location = new Point(306, 367);
            button10.Name = "button10";
            button10.Size = new Size(59, 55);
            button10.TabIndex = 27;
            button10.Text = ")";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnNumber_Click;
            // 
            // button11
            // 
            button11.Location = new Point(223, 367);
            button11.Name = "button11";
            button11.Size = new Size(59, 55);
            button11.TabIndex = 28;
            button11.Text = "(";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnNumber_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
            Controls.Add(btnOpchia);
            Controls.Add(btnDot);
            Controls.Add(btnNumber);
            Controls.Add(btnOpcong);
            Controls.Add(btnOptru);
            Controls.Add(btnOpnhan);
            Controls.Add(txtResult);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnOpnhan;
        private Button btnOptru;
        private Button btnOpcong;
        private Button btnNumber;
        private Button btnDot;
        private Button btnOpchia;
        private Button btnCal;
        private Button btnClear;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}
