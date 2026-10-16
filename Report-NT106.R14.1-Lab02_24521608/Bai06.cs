using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class Bai06 : Form
    {
        private readonly string duongDanDb = Path.Combine(AppContext.BaseDirectory, "monan.db");
        private readonly string thuMucAnh = Path.Combine(AppContext.BaseDirectory, "images");

        public Bai06()
        {
            InitializeComponent();

            lvDishes.View = View.Details;
            lvDishes.FullRowSelect = true;
            lvDishes.GridLines = true;
            lvDishes.Columns.Add("IDMA", 60);
            lvDishes.Columns.Add("Tên món ăn", 200);
            lvDishes.Columns.Add("Người đóng góp", 160);

            cboRole.Items.AddRange(new object[] { "Admin", "User" });
            cboRole.SelectedIndex = 1;

            btnAddContributor.Click -= btnAddContributor_Click;
            btnAddContributor.Click += btnAddContributor_Click;

            btnBrowse.Click -= btnBrowse_Click;
            btnBrowse.Click += btnBrowse_Click;

            btnAddDish.Click -= btnAddDish_Click;
            btnAddDish.Click += btnAddDish_Click;

            btnSeed.Click -= btnSeed_Click;
            btnSeed.Click += btnSeed_Click;

            btnRandom.Click -= btnRandom_Click;
            btnRandom.Click += btnRandom_Click;

            try
            {
                KhoiTaoCoSoDuLieu();
                NapDanhSachNguoiDung();
                NapDanhSachMonAn();
                lblStatus.Text = "Cơ sở dữ liệu: " + duongDanDb;
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        private SqliteConnection MoKetNoi()
        {
            SqliteConnection ketNoi = new SqliteConnection("Data Source=" + duongDanDb + ";Foreign Keys=True");
            ketNoi.Open();
            return ketNoi;
        }

        private void KhoiTaoCoSoDuLieu()
        {
            using (SqliteConnection ketNoi = MoKetNoi())
            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.CommandText =
                    "CREATE TABLE IF NOT EXISTS NguoiDung (" +
                    "  IDNCC INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "  HoVaTen TEXT NOT NULL," +
                    "  QuyenHan TEXT NOT NULL);" +
                    "CREATE TABLE IF NOT EXISTS MonAn (" +
                    "  IDMA INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "  TenMonAn TEXT NOT NULL," +
                    "  HinhAnh TEXT," +
                    "  IDNCC INTEGER NOT NULL," +
                    "  FOREIGN KEY (IDNCC) REFERENCES NguoiDung (IDNCC));";
                lenh.ExecuteNonQuery();
            }
        }

        private long ThemNguoiDung(SqliteConnection ketNoi, SqliteTransaction giaoDich, string hoVaTen, string quyenHan)
        {
            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.Transaction = giaoDich;
                lenh.CommandText = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES ($hoVaTen, $quyenHan)";
                lenh.Parameters.AddWithValue("$hoVaTen", hoVaTen);
                lenh.Parameters.AddWithValue("$quyenHan", quyenHan);
                lenh.ExecuteNonQuery();

                lenh.Parameters.Clear();
                lenh.CommandText = "SELECT last_insert_rowid()";
                return (long)lenh.ExecuteScalar();
            }
        }

        private void ThemMonAn(SqliteConnection ketNoi, SqliteTransaction giaoDich, string tenMonAn, string hinhAnh, long idncc)
        {
            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.Transaction = giaoDich;
                lenh.CommandText = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ($tenMonAn, $hinhAnh, $idncc)";
                lenh.Parameters.AddWithValue("$tenMonAn", tenMonAn);
                lenh.Parameters.AddWithValue("$hinhAnh", (object)hinhAnh ?? DBNull.Value);
                lenh.Parameters.AddWithValue("$idncc", idncc);
                lenh.ExecuteNonQuery();
            }
        }

        private void NapDanhSachNguoiDung()
        {
            cboContributor.Items.Clear();

            using (SqliteConnection ketNoi = MoKetNoi())
            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.CommandText = "SELECT IDNCC, HoVaTen, QuyenHan FROM NguoiDung ORDER BY HoVaTen";

                using (SqliteDataReader docDuLieu = lenh.ExecuteReader())
                {
                    while (docDuLieu.Read())
                    {
                        cboContributor.Items.Add(new NguoiDongGop
                        {
                            Idncc = docDuLieu.GetInt64(0),
                            HoVaTen = docDuLieu.GetString(1),
                            QuyenHan = docDuLieu.GetString(2)
                        });
                    }
                }
            }

            if (cboContributor.Items.Count > 0 && cboContributor.SelectedIndex < 0)
            {
                cboContributor.SelectedIndex = 0;
            }
        }

        private void NapDanhSachMonAn()
        {
            lvDishes.Items.Clear();

            using (SqliteConnection ketNoi = MoKetNoi())
            using (SqliteCommand lenh = ketNoi.CreateCommand())
            {
                lenh.CommandText =
                    "SELECT m.IDMA, m.TenMonAn, n.HoVaTen " +
                    "FROM MonAn m JOIN NguoiDung n ON m.IDNCC = n.IDNCC " +
                    "ORDER BY m.IDMA";

                using (SqliteDataReader docDuLieu = lenh.ExecuteReader())
                {
                    while (docDuLieu.Read())
                    {
                        ListViewItem dong = new ListViewItem(docDuLieu.GetInt64(0).ToString());
                        dong.SubItems.Add(docDuLieu.GetString(1));
                        dong.SubItems.Add(docDuLieu.GetString(2));
                        lvDishes.Items.Add(dong);
                    }
                }
            }
        }

        private void btnAddContributor_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtContributorName.Text.Trim();

            if (hoVaTen == "")
            {
                MessageBox.Show("Họ và tên không được để trống.");
                return;
            }

            try
            {
                using (SqliteConnection ketNoi = MoKetNoi())
                {
                    ThemNguoiDung(ketNoi, null, hoVaTen, cboRole.SelectedItem.ToString());
                }

                txtContributorName.Clear();
                NapDanhSachNguoiDung();
                lblStatus.Text = "Đã thêm người đóng góp: " + hoVaTen;
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog hopThoaiChonAnh = new OpenFileDialog();
            hopThoaiChonAnh.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (hopThoaiChonAnh.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = hopThoaiChonAnh.FileName;
            }
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            string tenMonAn = txtDishName.Text.Trim();
            NguoiDongGop nguoiDongGop = cboContributor.SelectedItem as NguoiDongGop;

            if (tenMonAn == "")
            {
                MessageBox.Show("Tên món ăn không được để trống.");
                return;
            }

            if (nguoiDongGop == null)
            {
                MessageBox.Show("Hãy thêm người đóng góp trước, rồi chọn người đóng góp cho món ăn.");
                return;
            }

            try
            {
                string tenFileAnh = null;

                if (txtImagePath.Text != "")
                {
                    Directory.CreateDirectory(thuMucAnh);
                    tenFileAnh = Guid.NewGuid().ToString("N") + Path.GetExtension(txtImagePath.Text);
                    File.Copy(txtImagePath.Text, Path.Combine(thuMucAnh, tenFileAnh));
                }

                using (SqliteConnection ketNoi = MoKetNoi())
                {
                    ThemMonAn(ketNoi, null, tenMonAn, tenFileAnh, nguoiDongGop.Idncc);
                }

                txtDishName.Clear();
                txtImagePath.Clear();
                NapDanhSachMonAn();
                lblStatus.Text = "Đã thêm món ăn: " + tenMonAn;
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi chép file ảnh: " + ex.Message);
            }
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqliteConnection ketNoi = MoKetNoi())
                using (SqliteTransaction giaoDich = ketNoi.BeginTransaction())
                {
                    long idNguyenVanA = ThemNguoiDung(ketNoi, giaoDich, "Nguyễn Văn A", "Admin");
                    long idTranThiB = ThemNguoiDung(ketNoi, giaoDich, "Trần Thị B", "User");
                    long idLeVanC = ThemNguoiDung(ketNoi, giaoDich, "Lê Văn C", "User");

                    ThemMonAn(ketNoi, giaoDich, "Phở bò", null, idNguyenVanA);
                    ThemMonAn(ketNoi, giaoDich, "Bún chả", null, idNguyenVanA);
                    ThemMonAn(ketNoi, giaoDich, "Cơm tấm", null, idTranThiB);
                    ThemMonAn(ketNoi, giaoDich, "Bánh mì", null, idTranThiB);
                    ThemMonAn(ketNoi, giaoDich, "Mì Quảng", null, idLeVanC);
                    ThemMonAn(ketNoi, giaoDich, "Hủ tiếu", null, idLeVanC);
                    ThemMonAn(ketNoi, giaoDich, "Bún bò Huế", null, idTranThiB);
                    ThemMonAn(ketNoi, giaoDich, "Gỏi cuốn", null, idNguyenVanA);

                    giaoDich.Commit();
                }

                NapDanhSachNguoiDung();
                NapDanhSachMonAn();
                lblStatus.Text = "Đã nạp dữ liệu mẫu (3 người, 8 món).";
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                string tenMonAn = null;
                string tenFileAnh = null;
                string tenNguoiDongGop = null;

                using (SqliteConnection ketNoi = MoKetNoi())
                using (SqliteCommand lenh = ketNoi.CreateCommand())
                {
                    lenh.CommandText =
                        "SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen " +
                        "FROM MonAn m JOIN NguoiDung n ON m.IDNCC = n.IDNCC " +
                        "ORDER BY RANDOM() LIMIT 1";

                    using (SqliteDataReader docDuLieu = lenh.ExecuteReader())
                    {
                        if (docDuLieu.Read())
                        {
                            tenMonAn = docDuLieu.GetString(0);
                            tenFileAnh = docDuLieu.IsDBNull(1) ? null : docDuLieu.GetString(1);
                            tenNguoiDongGop = docDuLieu.GetString(2);
                        }
                    }
                }

                if (tenMonAn == null)
                {
                    MessageBox.Show("Chưa có món ăn nào. Hãy thêm món hoặc bấm NẠP DỮ LIỆU MẪU.");
                    return;
                }

                lblDishName.Text = tenMonAn;
                lblContributor.Text = "Người đóng góp: " + tenNguoiDongGop;
                HienThiAnh(tenFileAnh);
                lblStatus.Text = "Hôm nay ăn: " + tenMonAn;
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void HienThiAnh(string tenFileAnh)
        {
            if (pbDish.Image != null)
            {
                pbDish.Image.Dispose();
                pbDish.Image = null;
            }

            if (string.IsNullOrEmpty(tenFileAnh))
            {
                return;
            }

            string duongDanAnh = Path.Combine(thuMucAnh, tenFileAnh);

            if (!File.Exists(duongDanAnh))
            {
                return;
            }

            using (FileStream luongFile = new FileStream(duongDanAnh, FileMode.Open, FileAccess.Read))
            using (Image anhGoc = Image.FromStream(luongFile))
            {
                pbDish.Image = new Bitmap(anhGoc);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    public class NguoiDongGop
    {
        public long Idncc { get; set; }
        public string HoVaTen { get; set; }
        public string QuyenHan { get; set; }

        public override string ToString()
        {
            return HoVaTen + " (" + QuyenHan + ")";
        }
    }
}