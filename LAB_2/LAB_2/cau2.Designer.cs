namespace LAB_2
{
    partial class cau2
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnPhanCong = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Ng Văn A", "Trần Thị B", "Lê Văn C" });
            listBox1.Location = new Point(12, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(209, 354);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Items.AddRange(new object[] { "10A1", "10A2", "10A3", "11A1", "11A2", "11A3" });
            listBox2.Location = new Point(270, 52);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(114, 354);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(533, 52);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(325, 354);
            listBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 17);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 3;
            label1.Text = "Giáo Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 17);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 4;
            label2.Text = "Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(615, 17);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 5;
            label3.Text = "Phân Công";
            // 
            // btnPhanCong
            // 
            btnPhanCong.Location = new Point(400, 175);
            btnPhanCong.Name = "btnPhanCong";
            btnPhanCong.Size = new Size(112, 34);
            btnPhanCong.TabIndex = 6;
            btnPhanCong.Text = "Phân công";
            btnPhanCong.UseVisualStyleBackColor = true;
            btnPhanCong.Click += btnPhanCong_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1088, 417);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // cau2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 463);
            Controls.Add(btnThoat);
            Controls.Add(btnPhanCong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "cau2";
            Text = "cau2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnPhanCong;
        private Button btnThoat;
    }
}