namespace Report_NT106.R14._1_Lab02_24521608
{
    partial class Bai03
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
            btnTinhVaGhi = new Button();
            btnDocFile = new Button();
            grpInput = new GroupBox();
            rtbInput = new RichTextBox();
            grpOutput = new GroupBox();
            rtbOutput = new RichTextBox();
            pnlTieuDe.SuspendLayout();
            pnlNut.SuspendLayout();
            grpInput.SuspendLayout();
            grpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.BackColor = Color.DodgerBlue;
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(966, 60);
            pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 16F);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(569, 45);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "BÀI 03 – ĐỌC, GHI FILE VÀ TÍNH TOÁN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Dock = DockStyle.Bottom;
            lblTrangThai.Location = new Point(0, 536);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(90, 28);
            lblTrangThai.TabIndex = 0;
            lblTrangThai.Text = "Sẵn sàng";
            lblTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlNut
            // 
            pnlNut.Controls.Add(btnTinhVaGhi);
            pnlNut.Controls.Add(btnDocFile);
            pnlNut.Dock = DockStyle.Top;
            pnlNut.Location = new Point(0, 60);
            pnlNut.Name = "pnlNut";
            pnlNut.Size = new Size(966, 70);
            pnlNut.TabIndex = 1;
            // 
            // btnTinhVaGhi
            // 
            btnTinhVaGhi.BackColor = Color.Khaki;
            btnTinhVaGhi.Location = new Point(260, 12);
            btnTinhVaGhi.Name = "btnTinhVaGhi";
            btnTinhVaGhi.Size = new Size(280, 46);
            btnTinhVaGhi.TabIndex = 1;
            btnTinhVaGhi.Text = "TÍNH VÀ GHI output3.txt";
            btnTinhVaGhi.UseVisualStyleBackColor = false;
            // 
            // btnDocFile
            // 
            btnDocFile.BackColor = Color.Khaki;
            btnDocFile.Location = new Point(20, 12);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(220, 46);
            btnDocFile.TabIndex = 0;
            btnDocFile.Text = "ĐỌC input3.txt";
            btnDocFile.UseVisualStyleBackColor = false;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(rtbInput);
            grpInput.Dock = DockStyle.Left;
            grpInput.Location = new Point(0, 130);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(430, 406);
            grpInput.TabIndex = 2;
            grpInput.TabStop = false;
            grpInput.Text = "Biểu thức (input3.txt)";
            // 
            // rtbInput
            // 
            rtbInput.Dock = DockStyle.Fill;
            rtbInput.Font = new Font("Consolas", 11F);
            rtbInput.Location = new Point(3, 30);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(424, 373);
            rtbInput.TabIndex = 0;
            rtbInput.Text = "";
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(rtbOutput);
            grpOutput.Dock = DockStyle.Fill;
            grpOutput.Location = new Point(430, 130);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new Size(536, 406);
            grpOutput.TabIndex = 3;
            grpOutput.TabStop = false;
            grpOutput.Text = "Kết quả (output3.txt)";
            // 
            // rtbOutput
            // 
            rtbOutput.Dock = DockStyle.Fill;
            rtbOutput.Font = new Font("Consolas", 11F);
            rtbOutput.Location = new Point(3, 30);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(530, 373);
            rtbOutput.TabIndex = 0;
            rtbOutput.Text = "";
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 564);
            Controls.Add(grpOutput);
            Controls.Add(grpInput);
            Controls.Add(pnlNut);
            Controls.Add(lblTrangThai);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            Name = "Bai03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 03 - Đọc, ghi file và tính toán";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            pnlNut.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            grpOutput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblTrangThai;
        private Panel pnlNut;
        private Button btnTinhVaGhi;
        private Button btnDocFile;
        private GroupBox grpInput;
        private RichTextBox rtbInput;
        private GroupBox grpOutput;
        private RichTextBox rtbOutput;
    }
}