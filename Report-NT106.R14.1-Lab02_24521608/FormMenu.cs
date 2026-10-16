using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class FormMenu : Form
    {
        private readonly List<(string TenBai, Func<Form> TaoForm)> danhSachBai =
            new List<(string, Func<Form>)>
            {
                ("Bài 01 – Ghi và Đọc file", () => new Bai01()),
                ("Bài 02 – Đọc thông tin một file .txt", () => new Bai02()),
                ("Bài 03 – Đọc, ghi file và tính toán", () => new Bai03()),
                ("Bài 04 – Đọc và Ghi file (JsonSerializer)", () => new Bai04()),
                ("Bài 05 – Quản lý phòng vé (phiên bản 2)", () => new Bai05()),
                ("Bài 06 – Hôm nay ăn gì? (phiên bản 2)", () => new Bai06()),
                ("Bài 07 – Duyệt thư mục", () => new Bai07()),
            };

        public FormMenu()
        {
            InitializeComponent();
            ApDungGiaoDien();
            TaoNutChoTungBai();
        }

        private void ApDungGiaoDien()
        {
            BackColor = Color.FromArgb(245, 247, 250);

            pnlTieuDe.BackColor = Color.FromArgb(31, 58, 95);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Font = new Font("Segoe UI", 16, FontStyle.Bold);
        }

        private void TaoNutChoTungBai()
        {
            foreach (var bai in danhSachBai)
            {
                Button nut = new Button();
                nut.Text = bai.TenBai;
                nut.Size = new Size(460, 50);
                nut.Margin = new Padding(0, 0, 0, 14);

                nut.FlatStyle = FlatStyle.Flat;
                nut.FlatAppearance.BorderSize = 0;
                nut.BackColor = Color.FromArgb(52, 120, 246);
                nut.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 95, 220);
                nut.ForeColor = Color.White;
                nut.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                nut.Cursor = Cursors.Hand;

                nut.Click += (sender, e) => MoBai(bai.TaoForm);

                flpBai.Controls.Add(nut);
            }
        }

        private void MoBai(Func<Form> taoForm)
        {
            using (Form formBai = taoForm())
            {
                formBai.ShowDialog();
            }
        }
    }
}