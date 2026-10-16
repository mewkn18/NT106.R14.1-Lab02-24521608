namespace Report_NT106.R14._1_Lab02_24521608
{
    partial class Bai05
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
            pnlTitle = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            lblStatus = new Label();
            grpInput = new GroupBox();
            btnAdd = new Button();
            txtSoldTickets = new TextBox();
            txtTotalSeats = new TextBox();
            txtRoom = new TextBox();
            txtTicketPrice = new TextBox();
            txtMovieName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlRight = new Panel();
            grpStats = new GroupBox();
            rtbStats = new RichTextBox();
            grpList = new GroupBox();
            dgvMovies = new DataGridView();
            prgExport = new ProgressBar();
            pnlFileButtons = new Panel();
            btnExportStats = new Button();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            pnlTitle.SuspendLayout();
            grpInput.SuspendLayout();
            pnlRight.SuspendLayout();
            grpStats.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            pnlFileButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.SkyBlue;
            pnlTitle.Controls.Add(label1);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1186, 60);
            pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(651, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(441, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÀI 05 – QUẢN LÝ PHÒNG VÉ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Location = new Point(0, 671);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 28);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Sẵn sàng";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnAdd);
            grpInput.Controls.Add(txtSoldTickets);
            grpInput.Controls.Add(txtTotalSeats);
            grpInput.Controls.Add(txtRoom);
            grpInput.Controls.Add(txtTicketPrice);
            grpInput.Controls.Add(txtMovieName);
            grpInput.Controls.Add(label6);
            grpInput.Controls.Add(label5);
            grpInput.Controls.Add(label4);
            grpInput.Controls.Add(label3);
            grpInput.Controls.Add(label2);
            grpInput.Dock = DockStyle.Left;
            grpInput.Location = new Point(0, 60);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(300, 611);
            grpInput.TabIndex = 2;
            grpInput.TabStop = false;
            grpInput.Text = "Nhập thông tin phim";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 345);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 45);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm phim";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtSoldTickets
            // 
            txtSoldTickets.Location = new Point(20, 295);
            txtSoldTickets.Name = "txtSoldTickets";
            txtSoldTickets.Size = new Size(150, 34);
            txtSoldTickets.TabIndex = 9;
            // 
            // txtTotalSeats
            // 
            txtTotalSeats.Location = new Point(20, 235);
            txtTotalSeats.Name = "txtTotalSeats";
            txtTotalSeats.Size = new Size(150, 34);
            txtTotalSeats.TabIndex = 8;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(20, 175);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(150, 34);
            txtRoom.TabIndex = 7;
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.Location = new Point(20, 115);
            txtTicketPrice.Name = "txtTicketPrice";
            txtTicketPrice.Size = new Size(150, 34);
            txtTicketPrice.TabIndex = 6;
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(20, 55);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(150, 34);
            txtMovieName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 270);
            label6.Name = "label6";
            label6.Size = new Size(125, 28);
            label6.TabIndex = 4;
            label6.Text = "Số vé đã bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 210);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 3;
            label5.Text = "Tổng số ghế";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 150);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 2;
            label4.Text = "Phòng chiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 1;
            label3.Text = "Giá vé chuẩn (VNĐ)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên phim";
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(grpStats);
            pnlRight.Controls.Add(grpList);
            pnlRight.Controls.Add(prgExport);
            pnlRight.Controls.Add(pnlFileButtons);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(300, 60);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(886, 611);
            pnlRight.TabIndex = 0;
            // 
            // grpStats
            // 
            grpStats.Controls.Add(rtbStats);
            grpStats.Dock = DockStyle.Fill;
            grpStats.Location = new Point(0, 300);
            grpStats.Name = "grpStats";
            grpStats.Size = new Size(886, 289);
            grpStats.TabIndex = 3;
            grpStats.TabStop = false;
            grpStats.Text = "Thống kê (output5.txt)";
            // 
            // rtbStats
            // 
            rtbStats.Dock = DockStyle.Fill;
            rtbStats.Font = new Font("Consolas", 10F);
            rtbStats.Location = new Point(3, 30);
            rtbStats.Name = "rtbStats";
            rtbStats.ReadOnly = true;
            rtbStats.Size = new Size(880, 256);
            rtbStats.TabIndex = 0;
            rtbStats.Text = "";
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvMovies);
            grpList.Dock = DockStyle.Top;
            grpList.Location = new Point(0, 70);
            grpList.Name = "grpList";
            grpList.Size = new Size(886, 230);
            grpList.TabIndex = 2;
            grpList.TabStop = false;
            grpList.Text = "Danh sách phim";
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Dock = DockStyle.Fill;
            dgvMovies.Location = new Point(3, 30);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 62;
            dgvMovies.Size = new Size(880, 197);
            dgvMovies.TabIndex = 0;
            // 
            // prgExport
            // 
            prgExport.Dock = DockStyle.Bottom;
            prgExport.Location = new Point(0, 589);
            prgExport.Name = "prgExport";
            prgExport.Size = new Size(886, 22);
            prgExport.TabIndex = 1;
            // 
            // pnlFileButtons
            // 
            pnlFileButtons.Controls.Add(btnExportStats);
            pnlFileButtons.Controls.Add(btnWriteFile);
            pnlFileButtons.Controls.Add(btnReadFile);
            pnlFileButtons.Dock = DockStyle.Top;
            pnlFileButtons.Location = new Point(0, 0);
            pnlFileButtons.Name = "pnlFileButtons";
            pnlFileButtons.Size = new Size(886, 70);
            pnlFileButtons.TabIndex = 0;
            // 
            // btnExportStats
            // 
            btnExportStats.Location = new Point(425, 12);
            btnExportStats.Name = "btnExportStats";
            btnExportStats.Size = new Size(220, 46);
            btnExportStats.TabIndex = 3;
            btnExportStats.Text = "XUẤT THỐNG KÊ";
            btnExportStats.UseVisualStyleBackColor = true;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(220, 12);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(190, 46);
            btnWriteFile.TabIndex = 2;
            btnWriteFile.Text = "GHI input5.txt";
            btnWriteFile.UseVisualStyleBackColor = true;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(15, 12);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(190, 46);
            btnReadFile.TabIndex = 1;
            btnReadFile.Text = "ĐỌC input5.txt";
            btnReadFile.UseVisualStyleBackColor = true;
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 699);
            Controls.Add(pnlRight);
            Controls.Add(grpInput);
            Controls.Add(lblStatus);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F);
            Name = "Bai05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 05 - Quản lý phòng vé";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            pnlRight.ResumeLayout(false);
            grpStats.ResumeLayout(false);
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            pnlFileButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Label label1;
        private Label lblStatus;
        private GroupBox grpInput;
        private TextBox txtSoldTickets;
        private TextBox txtTotalSeats;
        private TextBox txtRoom;
        private TextBox txtTicketPrice;
        private TextBox txtMovieName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnlRight;
        private Button btnAdd;
        private GroupBox grpList;
        private DataGridView dgvMovies;
        private ProgressBar prgExport;
        private Panel pnlFileButtons;
        private Button btnExportStats;
        private Button btnWriteFile;
        private Button btnReadFile;
        private GroupBox grpStats;
        private RichTextBox rtbStats;
    }
}