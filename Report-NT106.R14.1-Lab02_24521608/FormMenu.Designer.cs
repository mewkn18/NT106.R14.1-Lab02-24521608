namespace Report_NT106.R14._1_Lab02_24521608
{
    partial class FormMenu
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
            pnlTieuDe = new Panel();
            lblTieuDe = new Label();
            flpBai = new FlowLayoutPanel();
            pnlTieuDe.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTieuDe
            // 
            pnlTieuDe.Controls.Add(lblTieuDe);
            pnlTieuDe.Dock = DockStyle.Top;
            pnlTieuDe.Location = new Point(0, 0);
            pnlTieuDe.Name = "pnlTieuDe";
            pnlTieuDe.Size = new Size(558, 70);
            pnlTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(268, 28);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "LAB 02 – FILE VÀ I/O STREAM";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpBai
            // 
            flpBai.AutoScroll = true;
            flpBai.Dock = DockStyle.Fill;
            flpBai.FlowDirection = FlowDirection.TopDown;
            flpBai.Location = new Point(0, 70);
            flpBai.Name = "flpBai";
            flpBai.Padding = new Padding(40, 20, 40, 20);
            flpBai.Size = new Size(558, 514);
            flpBai.TabIndex = 1;
            flpBai.WrapContents = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 584);
            Controls.Add(flpBai);
            Controls.Add(pnlTieuDe);
            Font = new Font("Segoe UI", 10F);
            Name = "FormMenu";
            Text = "Lab 02 - File và I/O Stream";
            pnlTieuDe.ResumeLayout(false);
            pnlTieuDe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private FlowLayoutPanel flpBai;
    }
}
