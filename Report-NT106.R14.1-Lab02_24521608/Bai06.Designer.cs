namespace Report_NT106.R14._1_Lab02_24521608
{
    partial class Bai06
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
            lblTitle = new Label();
            lblStatus = new Label();
            pnlLeft = new Panel();
            btnSeed = new Button();
            grpDish = new GroupBox();
            btnAddDish = new Button();
            btnBrowse = new Button();
            txtImagePath = new TextBox();
            label5 = new Label();
            cboContributor = new ComboBox();
            label4 = new Label();
            txtDishName = new TextBox();
            label3 = new Label();
            grpContributor = new GroupBox();
            btnAddContributor = new Button();
            cboRole = new ComboBox();
            label2 = new Label();
            txtContributorName = new TextBox();
            label1 = new Label();
            pnlRight = new Panel();
            grpResult = new GroupBox();
            lblContributor = new Label();
            lblDishName = new Label();
            pbDish = new PictureBox();
            btnRandom = new Button();
            grpList = new GroupBox();
            lvDishes = new ListView();
            pnlTitle.SuspendLayout();
            pnlLeft.SuspendLayout();
            grpDish.SuspendLayout();
            grpContributor.SuspendLayout();
            pnlRight.SuspendLayout();
            grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDish).BeginInit();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.LightSkyBlue;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1241, 60);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(399, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÀI 06 – HÔM NAY ĂN GÌ?";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Location = new Point(0, 693);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 28);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Sẵn sàng.";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(btnSeed);
            pnlLeft.Controls.Add(grpDish);
            pnlLeft.Controls.Add(grpContributor);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 60);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(340, 633);
            pnlLeft.TabIndex = 2;
            // 
            // btnSeed
            // 
            btnSeed.Location = new Point(12, 545);
            btnSeed.Name = "btnSeed";
            btnSeed.Size = new Size(320, 45);
            btnSeed.TabIndex = 2;
            btnSeed.Text = "NẠP DỮ LIỆU MẪU";
            btnSeed.UseVisualStyleBackColor = true;
            // 
            // grpDish
            // 
            grpDish.Controls.Add(btnAddDish);
            grpDish.Controls.Add(btnBrowse);
            grpDish.Controls.Add(txtImagePath);
            grpDish.Controls.Add(label5);
            grpDish.Controls.Add(cboContributor);
            grpDish.Controls.Add(label4);
            grpDish.Controls.Add(txtDishName);
            grpDish.Controls.Add(label3);
            grpDish.Location = new Point(10, 233);
            grpDish.Name = "grpDish";
            grpDish.Size = new Size(320, 306);
            grpDish.TabIndex = 1;
            grpDish.TabStop = false;
            grpDish.Text = "2. Món ăn";
            // 
            // btnAddDish
            // 
            btnAddDish.Location = new Point(20, 262);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new Size(280, 38);
            btnAddDish.TabIndex = 7;
            btnAddDish.Text = "Thêm món ăn";
            btnAddDish.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(226, 209);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(74, 36);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Chọn...";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(20, 210);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.ReadOnly = true;
            txtImagePath.Size = new Size(200, 34);
            txtImagePath.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 181);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 4;
            label5.Text = "Hình ảnh";
            // 
            // cboContributor
            // 
            cboContributor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContributor.FormattingEnabled = true;
            cboContributor.Location = new Point(20, 142);
            cboContributor.Name = "cboContributor";
            cboContributor.Size = new Size(280, 36);
            cboContributor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 111);
            label4.Name = "label4";
            label4.Size = new Size(161, 28);
            label4.TabIndex = 2;
            label4.Text = "Người đóng góp";
            label4.Click += label4_Click;
            // 
            // txtDishName
            // 
            txtDishName.Location = new Point(20, 73);
            txtDishName.Name = "txtDishName";
            txtDishName.Size = new Size(280, 34);
            txtDishName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 42);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 0;
            label3.Text = "Tên món ăn";
            // 
            // grpContributor
            // 
            grpContributor.Controls.Add(btnAddContributor);
            grpContributor.Controls.Add(cboRole);
            grpContributor.Controls.Add(label2);
            grpContributor.Controls.Add(txtContributorName);
            grpContributor.Controls.Add(label1);
            grpContributor.Location = new Point(10, 10);
            grpContributor.Name = "grpContributor";
            grpContributor.Size = new Size(320, 217);
            grpContributor.TabIndex = 0;
            grpContributor.TabStop = false;
            grpContributor.Text = "1. Người đóng góp";
            // 
            // btnAddContributor
            // 
            btnAddContributor.Location = new Point(14, 173);
            btnAddContributor.Name = "btnAddContributor";
            btnAddContributor.Size = new Size(112, 38);
            btnAddContributor.TabIndex = 4;
            btnAddContributor.Text = "Thêm người đóng góp";
            btnAddContributor.UseVisualStyleBackColor = true;
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(14, 131);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(182, 36);
            cboRole.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 98);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Quyền hạn";
            // 
            // txtContributorName
            // 
            txtContributorName.Location = new Point(14, 61);
            txtContributorName.Name = "txtContributorName";
            txtContributorName.Size = new Size(150, 34);
            txtContributorName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(grpResult);
            pnlRight.Controls.Add(grpList);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(340, 60);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(901, 633);
            pnlRight.TabIndex = 3;
            // 
            // grpResult
            // 
            grpResult.Controls.Add(lblContributor);
            grpResult.Controls.Add(lblDishName);
            grpResult.Controls.Add(pbDish);
            grpResult.Controls.Add(btnRandom);
            grpResult.Dock = DockStyle.Fill;
            grpResult.Location = new Point(460, 0);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(441, 633);
            grpResult.TabIndex = 1;
            grpResult.TabStop = false;
            grpResult.Text = "Kết quả";
            // 
            // lblContributor
            // 
            lblContributor.AutoSize = true;
            lblContributor.Location = new Point(20, 420);
            lblContributor.Name = "lblContributor";
            lblContributor.Size = new Size(0, 28);
            lblContributor.TabIndex = 3;
            // 
            // lblDishName
            // 
            lblDishName.AutoSize = true;
            lblDishName.Font = new Font("Segoe UI", 16F);
            lblDishName.Location = new Point(20, 375);
            lblDishName.Name = "lblDishName";
            lblDishName.Size = new Size(187, 45);
            lblDishName.TabIndex = 2;
            lblDishName.Text = "(chưa chọn)";
            // 
            // pbDish
            // 
            pbDish.BorderStyle = BorderStyle.FixedSingle;
            pbDish.Location = new Point(20, 100);
            pbDish.Name = "pbDish";
            pbDish.Size = new Size(320, 260);
            pbDish.SizeMode = PictureBoxSizeMode.Zoom;
            pbDish.TabIndex = 1;
            pbDish.TabStop = false;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(20, 30);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(300, 50);
            btnRandom.TabIndex = 0;
            btnRandom.Text = "HÔM NAY ĂN GÌ?";
            btnRandom.UseVisualStyleBackColor = true;
            // 
            // grpList
            // 
            grpList.Controls.Add(lvDishes);
            grpList.Dock = DockStyle.Left;
            grpList.Location = new Point(0, 0);
            grpList.Name = "grpList";
            grpList.Size = new Size(460, 633);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Danh sách món ăn (từ cơ sở dữ liệu)";
            // 
            // lvDishes
            // 
            lvDishes.Dock = DockStyle.Fill;
            lvDishes.Location = new Point(3, 30);
            lvDishes.Name = "lvDishes";
            lvDishes.Size = new Size(454, 600);
            lvDishes.TabIndex = 0;
            lvDishes.UseCompatibleStateImageBehavior = false;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 721);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(lblStatus);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F);
            Name = "Bai06";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 06 - Hôm nay ăn gì?";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlLeft.ResumeLayout(false);
            grpDish.ResumeLayout(false);
            grpDish.PerformLayout();
            grpContributor.ResumeLayout(false);
            grpContributor.PerformLayout();
            pnlRight.ResumeLayout(false);
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDish).EndInit();
            grpList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Label lblStatus;
        private Panel pnlLeft;
        private GroupBox grpDish;
        private GroupBox grpContributor;
        private Label label2;
        private TextBox txtContributorName;
        private Label label1;
        private Panel pnlRight;
        private ComboBox cboContributor;
        private Label label4;
        private TextBox txtDishName;
        private Label label3;
        private Button btnAddContributor;
        private ComboBox cboRole;
        private Button btnSeed;
        private Button btnAddDish;
        private Button btnBrowse;
        private TextBox txtImagePath;
        private Label label5;
        private GroupBox grpList;
        private GroupBox grpResult;
        private Label lblContributor;
        private Label lblDishName;
        private PictureBox pbDish;
        private Button btnRandom;
        private ListView lvDishes;
    }
}