namespace LAB_2
{
    partial class cau3
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
            listBangso = new ListBox();
            btTatca = new Button();
            btChinnut = new Button();
            btKhonggiam = new Button();
            btBasotang = new Button();
            btGanh = new Button();
            btDoixung = new Button();
            btThoat = new Button();
            lbdem = new Label();
            SuspendLayout();
            // 
            // listBangso
            // 
            listBangso.FormattingEnabled = true;
            listBangso.ItemHeight = 25;
            listBangso.Location = new Point(22, 12);
            listBangso.Name = "listBangso";
            listBangso.Size = new Size(286, 429);
            listBangso.TabIndex = 0;
            // 
            // btTatca
            // 
            btTatca.Location = new Point(377, 32);
            btTatca.Name = "btTatca";
            btTatca.Size = new Size(308, 34);
            btTatca.TabIndex = 1;
            btTatca.Text = "Tất cả các bảng số";
            btTatca.UseVisualStyleBackColor = true;
            btTatca.Click += btTatca_Click;
            // 
            // btChinnut
            // 
            btChinnut.Location = new Point(377, 72);
            btChinnut.Name = "btChinnut";
            btChinnut.Size = new Size(308, 34);
            btChinnut.TabIndex = 2;
            btChinnut.Text = "Bảng số chín nút";
            btChinnut.UseVisualStyleBackColor = true;
            btChinnut.Click += btChinnut_Click;
            // 
            // btKhonggiam
            // 
            btKhonggiam.Location = new Point(377, 232);
            btKhonggiam.Name = "btKhonggiam";
            btKhonggiam.Size = new Size(308, 34);
            btKhonggiam.TabIndex = 3;
            btKhonggiam.Text = "Bảng số không giảm";
            btKhonggiam.UseVisualStyleBackColor = true;
            btKhonggiam.Click += btKhonggiam_Click;
            // 
            // btBasotang
            // 
            btBasotang.Location = new Point(377, 192);
            btBasotang.Name = "btBasotang";
            btBasotang.Size = new Size(308, 34);
            btBasotang.TabIndex = 4;
            btBasotang.Text = "Bảng số có 3 số tăng liên tiếp";
            btBasotang.UseVisualStyleBackColor = true;
            btBasotang.Click += btBasotang_Click;
            // 
            // btGanh
            // 
            btGanh.Location = new Point(377, 152);
            btGanh.Name = "btGanh";
            btGanh.Size = new Size(308, 34);
            btGanh.TabIndex = 5;
            btGanh.Text = "Bảng số gánh";
            btGanh.UseVisualStyleBackColor = true;
            btGanh.Click += btGanh_Click;
            // 
            // btDoixung
            // 
            btDoixung.Location = new Point(377, 112);
            btDoixung.Name = "btDoixung";
            btDoixung.Size = new Size(308, 34);
            btDoixung.TabIndex = 6;
            btDoixung.Text = "Bảng số đối xứng";
            btDoixung.UseVisualStyleBackColor = true;
            btDoixung.Click += btDoixung_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(377, 272);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(308, 34);
            btThoat.TabIndex = 7;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // lbdem
            // 
            lbdem.AutoSize = true;
            lbdem.Location = new Point(517, 350);
            lbdem.Name = "lbdem";
            lbdem.Size = new Size(0, 25);
            lbdem.TabIndex = 8;
            // 
            // cau3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbdem);
            Controls.Add(btThoat);
            Controls.Add(btDoixung);
            Controls.Add(btGanh);
            Controls.Add(btBasotang);
            Controls.Add(btKhonggiam);
            Controls.Add(btChinnut);
            Controls.Add(btTatca);
            Controls.Add(listBangso);
            Name = "cau3";
            Text = "cau3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBangso;
        private Button btTatca;
        private Button btChinnut;
        private Button btKhonggiam;
        private Button btBasotang;
        private Button btGanh;
        private Button btDoixung;
        private Button btThoat;
        private Label lbdem;
    }
}