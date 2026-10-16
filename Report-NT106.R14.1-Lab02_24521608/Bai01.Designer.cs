namespace Report_NT106.R14._1_Lab02_24521608
{
    partial class Bai01
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
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            lblTrangThai = new Label();
            pnlNut = new Panel();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            grpNoiDung = new GroupBox();
            rtbNoiDung = new RichTextBox();
            pnlTieuDe.SuspendLayout();
            pnlNut.SuspendLayout();
            grpNoiDung.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(878, 60);
            pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(235, 28);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀI 01 – GHI VÀ ĐỌC FILE";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Dock = DockStyle.Bottom;
            lblTrangThai.Location = new Point(0, 492);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(94, 28);
            lblTrangThai.TabIndex = 1;
            lblTrangThai.Text = "Sẵn sàng.";
            lblTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlNut
            // 
            pnlNut.Controls.Add(btnDocFile);
            pnlNut.Controls.Add(btnGhiFile);
            pnlNut.Dock = DockStyle.Left;
            pnlNut.Location = new Point(0, 60);
            pnlNut.Name = "pnlNut";
            pnlNut.Size = new Size(220, 432);
            pnlNut.TabIndex = 2;
            // 
            // btnDocFile
            // 
            btnDocFile.Location = new Point(20, 30);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(180, 50);
            btnDocFile.TabIndex = 1;
            btnDocFile.Text = "ĐỌC FILE";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Location = new Point(20, 100);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(180, 50);
            btnGhiFile.TabIndex = 0;
            btnGhiFile.Text = "GHI FILE";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // grpNoiDung
            // 
            grpNoiDung.Controls.Add(rtbNoiDung);
            grpNoiDung.Dock = DockStyle.Fill;
            grpNoiDung.Location = new Point(220, 60);
            grpNoiDung.Name = "grpNoiDung";
            grpNoiDung.Size = new Size(658, 432);
            grpNoiDung.TabIndex = 3;
            grpNoiDung.TabStop = false;
            grpNoiDung.Text = "Nội dung file";
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Dock = DockStyle.Fill;
            rtbNoiDung.Location = new Point(3, 30);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.Size = new Size(652, 399);
            rtbNoiDung.TabIndex = 0;
            rtbNoiDung.Text = "";
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 520);
            Controls.Add(grpNoiDung);
            Controls.Add(pnlNut);
            Controls.Add(lblTrangThai);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            Name = "Bai01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 01 - Ghi và Đọc file";
            Click += btnDocFile_Click;
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlNut.ResumeLayout(false);
            grpNoiDung.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblTrangThai;
        private Panel pnlNut;
        private Button btnGhiFile;
        private GroupBox grpNoiDung;
        private RichTextBox rtbNoiDung;
        private Button btnDocFile;
    }
}