using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class Bai04 : Form
    {
        private const string DuongDanInput = "input4.txt";
        private const string DuongDanOutput = "output4.txt";

        private readonly JsonSerializerOptions cauHinhJson = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        private readonly List<SinhVien> danhSachNhap = new List<SinhVien>();
        private List<SinhVien> danhSachDoc = new List<SinhVien>();
        private int chiSoHienTai = 0;

        public Bai04()
        {
            InitializeComponent();

            btnThem.Click -= btnThem_Click;
            btnThem.Click += btnThem_Click;

            btnGhiFile.Click -= btnGhiFile_Click;
            btnGhiFile.Click += btnGhiFile_Click;

            btnDocFile.Click -= btnDocFile_Click;
            btnDocFile.Click += btnDocFile_Click;

            btnBack.Click -= btnBack_Click;
            btnBack.Click += btnBack_Click;

            btnNext.Click -= btnNext_Click;
            btnNext.Click += btnNext_Click;

            CapNhatNutDieuHuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien;
            string thongBaoLoi;

            if (!TryLaySinhVienTuOnhap(out sinhVien, out thongBaoLoi))
            {
                MessageBox.Show(thongBaoLoi);
                return;
            }

            if (danhSachNhap.Any(sv => sv.Mssv == sinhVien.Mssv))
            {
                MessageBox.Show("MSSV " + sinhVien.Mssv + " đã có trong danh sách.");
                return;
            }

            danhSachNhap.Add(sinhVien);
            lstNhap.Items.Add(sinhVien.ToString());
            XoaOnhap();
            lblTrangThai.Text = "Đã thêm " + sinhVien.HoTen + " (" + danhSachNhap.Count + " sinh viên).";
        }

        private bool TryLaySinhVienTuOnhap(out SinhVien sinhVien, out string thongBaoLoi)
        {
            sinhVien = null;
            thongBaoLoi = "";

            int mssv;
            if (!int.TryParse(txtMssv.Text.Trim(), out mssv))
            {
                thongBaoLoi = "MSSV phải là số nguyên.";
                return false;
            }

            float diem1, diem2, diem3;

            if (!TryDocSo(txtDiem1.Text, out diem1))
            {
                thongBaoLoi = "Điểm môn 1 phải là số.";
                return false;
            }

            if (!TryDocSo(txtDiem2.Text, out diem2))
            {
                thongBaoLoi = "Điểm môn 2 phải là số.";
                return false;
            }

            if (!TryDocSo(txtDiem3.Text, out diem3))
            {
                thongBaoLoi = "Điểm môn 3 phải là số.";
                return false;
            }

            sinhVien = new SinhVien
            {
                HoTen = txtHoTen.Text.Trim(),
                Mssv = mssv,
                DienThoai = txtDienThoai.Text.Trim(),
                Diem1 = diem1,
                Diem2 = diem2,
                Diem3 = diem3
            };

            thongBaoLoi = KiemTraHopLe(sinhVien);
            return thongBaoLoi == "";
        }

        private bool TryDocSo(string chu, out float so)
        {
            string chuChuanHoa = chu.Trim().Replace(',', '.');
            return float.TryParse(chuChuanHoa, NumberStyles.Float, CultureInfo.InvariantCulture, out so);
        }

        private string KiemTraHopLe(SinhVien sinhVien)
        {
            if (string.IsNullOrWhiteSpace(sinhVien.HoTen))
            {
                return "Họ và tên không được để trống.";
            }

            if (sinhVien.Mssv < 10000000 || sinhVien.Mssv > 99999999)
            {
                return "MSSV phải là số có đúng 8 chữ số (không bắt đầu bằng 0).";
            }

            if (sinhVien.DienThoai == null || !Regex.IsMatch(sinhVien.DienThoai, "^0[0-9]{9}$"))
            {
                return "Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0.";
            }

            if (!DiemHopLe(sinhVien.Diem1) || !DiemHopLe(sinhVien.Diem2) || !DiemHopLe(sinhVien.Diem3))
            {
                return "Điểm từng môn phải nằm trong khoảng từ 0 đến 10.";
            }

            return "";
        }

        private bool DiemHopLe(float diem)
        {
            return diem >= 0 && diem <= 10;
        }

        private void XoaOnhap()
        {
            txtHoTen.Clear();
            txtMssv.Clear();
            txtDienThoai.Clear();
            txtDiem1.Clear();
            txtDiem2.Clear();
            txtDiem3.Clear();
            txtHoTen.Focus();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (danhSachNhap.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống, hãy thêm ít nhất một sinh viên.");
                return;
            }

            try
            {
                string json = JsonSerializer.Serialize(danhSachNhap, cauHinhJson);
                File.WriteAllText(DuongDanInput, json);

                lblTrangThai.Text = "Đã ghi " + danhSachNhap.Count + " sinh viên vào " + Path.GetFullPath(DuongDanInput);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText(DuongDanInput);
                List<SinhVien> docDuoc = JsonSerializer.Deserialize<List<SinhVien>>(json);

                if (docDuoc == null || docDuoc.Count == 0)
                {
                    MessageBox.Show("File không có sinh viên nào.");
                    return;
                }

                for (int i = 0; i < docDuoc.Count; i++)
                {
                    string loi = KiemTraHopLe(docDuoc[i]);
                    if (loi != "")
                    {
                        MessageBox.Show("Sinh viên thứ " + (i + 1) + " trong file không hợp lệ: " + loi);
                        return;
                    }
                }

                foreach (SinhVien sinhVien in docDuoc)
                {
                    sinhVien.DiemTrungBinh = TinhDiemTrungBinh(sinhVien);
                }

                File.WriteAllText(DuongDanOutput, JsonSerializer.Serialize(docDuoc, cauHinhJson));

                danhSachDoc = docDuoc;
                chiSoHienTai = 0;
                HienThiSinhVienHienTai();

                lblTrangThai.Text = "Đã đọc " + docDuoc.Count + " sinh viên, ghi kết quả vào " + Path.GetFullPath(DuongDanOutput);
            }
            catch (FileNotFoundException)
            {
                string duongDanDayDu = Path.GetFullPath(DuongDanInput);
                lblTrangThai.Text = "Không tìm thấy file: " + duongDanDayDu;
                MessageBox.Show("Không tìm thấy file:\n" + duongDanDayDu);
            }
            catch (JsonException)
            {
                MessageBox.Show("File " + DuongDanInput + " không đúng định dạng JSON của danh sách sinh viên.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private float TinhDiemTrungBinh(SinhVien sinhVien)
        {
            double tong = sinhVien.Diem1 + sinhVien.Diem2 + sinhVien.Diem3;
            return (float)Math.Round(tong / 3.0, 2);
        }

        private void HienThiSinhVienHienTai()
        {
            SinhVien sinhVien = danhSachDoc[chiSoHienTai];

            txtXemHoTen.Text = sinhVien.HoTen;
            txtXemMssv.Text = sinhVien.Mssv.ToString();
            txtXemDienThoai.Text = sinhVien.DienThoai;
            txtXemDiem1.Text = sinhVien.Diem1.ToString("0.##", CultureInfo.InvariantCulture);
            txtXemDiem2.Text = sinhVien.Diem2.ToString("0.##", CultureInfo.InvariantCulture);
            txtXemDiem3.Text = sinhVien.Diem3.ToString("0.##", CultureInfo.InvariantCulture);
            txtXemDiemTb.Text = sinhVien.DiemTrungBinh.ToString("0.##", CultureInfo.InvariantCulture);

            lblTrang.Text = (chiSoHienTai + 1) + " / " + danhSachDoc.Count;
            CapNhatNutDieuHuong();
        }

        private void CapNhatNutDieuHuong()
        {
            btnBack.Enabled = chiSoHienTai > 0;
            btnNext.Enabled = chiSoHienTai < danhSachDoc.Count - 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            chiSoHienTai--;
            HienThiSinhVienHienTai();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            chiSoHienTai++;
            HienThiSinhVienHienTai();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class SinhVien
    {
        public string HoTen { get; set; }
        public int Mssv { get; set; }
        public string DienThoai { get; set; }
        public float Diem1 { get; set; }
        public float Diem2 { get; set; }
        public float Diem3 { get; set; }
        public float DiemTrungBinh { get; set; }

        public override string ToString()
        {
            return HoTen + " | " + Mssv + " | " + DienThoai + " | " +
                   Diem1.ToString("0.##", CultureInfo.InvariantCulture) + ", " +
                   Diem2.ToString("0.##", CultureInfo.InvariantCulture) + ", " +
                   Diem3.ToString("0.##", CultureInfo.InvariantCulture);
        }
    }
}