namespace Report_NT106.R14._1_Lab02_24521608
{
    partial class Bai07
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
            panel1 = new Panel();
            lblTitle = new Label();
            lblStatus = new Label();
            grpTree = new GroupBox();
            tvFolders = new TreeView();
            grpContent = new GroupBox();
            pbContent = new PictureBox();
            rtbContent = new RichTextBox();
            panel1.SuspendLayout();
            grpTree.SuspendLayout();
            grpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbContent).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 60);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(392, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÀI 07 – DUYỆT THƯ MỤC";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Location = new Point(0, 637);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 28);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Sẵn sàng.";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpTree
            // 
            grpTree.Controls.Add(tvFolders);
            grpTree.Dock = DockStyle.Left;
            grpTree.Location = new Point(0, 60);
            grpTree.Name = "grpTree";
            grpTree.Size = new Size(380, 577);
            grpTree.TabIndex = 2;
            grpTree.TabStop = false;
            grpTree.Text = "Thư mục và file";
            // 
            // tvFolders
            // 
            tvFolders.Dock = DockStyle.Fill;
            tvFolders.HideSelection = false;
            tvFolders.Location = new Point(3, 30);
            tvFolders.Name = "tvFolders";
            tvFolders.Size = new Size(374, 544);
            tvFolders.TabIndex = 0;
            // 
            // grpContent
            // 
            grpContent.Controls.Add(pbContent);
            grpContent.Dock = DockStyle.Fill;
            grpContent.Location = new Point(380, 60);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(696, 577);
            grpContent.TabIndex = 3;
            grpContent.TabStop = false;
            grpContent.Text = "File Content";
            // 
            // pbContent
            // 
            pbContent.Dock = DockStyle.Fill;
            pbContent.Location = new Point(3, 30);
            pbContent.Name = "pbContent";
            pbContent.Size = new Size(690, 544);
            pbContent.TabIndex = 0;
            pbContent.TabStop = false;
            // 
            // rtbContent
            // 
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Font = new Font("Consolas", 10F);
            rtbContent.Location = new Point(380, 60);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(696, 577);
            rtbContent.TabIndex = 4;
            rtbContent.Text = "";
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 665);
            Controls.Add(rtbContent);
            Controls.Add(grpContent);
            Controls.Add(grpTree);
            Controls.Add(lblStatus);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "Bai07";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 07 - Duyệt thư mục";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpTree.ResumeLayout(false);
            grpContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label lblStatus;
        private GroupBox grpTree;
        private TreeView tvFolders;
        private GroupBox grpContent;
        private PictureBox pbContent;
        private RichTextBox rtbContent;
    }
}