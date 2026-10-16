using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class Bai03 : Form
    {
        private const string DuongDanInput = "input3.txt";
        private const string DuongDanOutput = "output3.txt";

        public Bai03()
        {
            InitializeComponent();

            btnDocFile.Click -= btnDocFile_Click;
            btnDocFile.Click += btnDocFile_Click;

            btnTinhVaGhi.Click -= btnTinhVaGhi_Click;
            btnTinhVaGhi.Click += btnTinhVaGhi_Click;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(DuongDanInput))
                {
                    rtbInput.Text = reader.ReadToEnd();
                }

                lblTrangThai.Text = "Đã đọc " + DuongDanInput + ". Bạn có thể sửa biểu thức trước khi tính.";
            }
            catch (FileNotFoundException)
            {
                string duongDanDayDu = Path.GetFullPath(DuongDanInput);
                lblTrangThai.Text = "Không tìm thấy file: " + duongDanDayDu;
                MessageBox.Show("Không tìm thấy file:\n" + duongDanDayDu);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private void btnTinhVaGhi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbInput.Text))
            {
                MessageBox.Show("Chưa có biểu thức nào. Hãy đọc file hoặc nhập vào khung bên trái.");
                return;
            }

            TinhBieuThuc boTinh = new TinhBieuThuc();
            rtbOutput.Clear();

            try
            {
                using (StreamWriter writer = new StreamWriter(DuongDanOutput))
                {
                    foreach (string dong in rtbInput.Lines)
                    {
                        if (string.IsNullOrWhiteSpace(dong))
                        {
                            continue;
                        }

                        string dongKetQua = TaoDongKetQua(boTinh, dong.Trim());
                        writer.WriteLine(dongKetQua);
                        rtbOutput.AppendText(dongKetQua + Environment.NewLine);
                    }
                }

                lblTrangThai.Text = "Đã ghi vào " + Path.GetFullPath(DuongDanOutput);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        private string TaoDongKetQua(TinhBieuThuc boTinh, string bieuThuc)
        {
            try
            {
                double ketQua = boTinh.Tinh(bieuThuc);
                return bieuThuc + " = " + ketQua.ToString("0.######", CultureInfo.InvariantCulture);
            }
            catch (Exception ex) when (ex is FormatException || ex is DivideByZeroException)
            {
                return bieuThuc + " = Lỗi: " + ex.Message;
            }
        }
    }

    public class TinhBieuThuc
    {
        private string chuoi;
        private int viTri;

        public double Tinh(string bieuThuc)
        {
            chuoi = ChuanHoa(bieuThuc);
            viTri = 0;

            double ketQua = TinhCongTru();

            if (viTri < chuoi.Length)
            {
                throw new FormatException("Ký tự không hợp lệ: '" + chuoi[viTri] + "'");
            }

            return ketQua;
        }

        private string ChuanHoa(string bieuThuc)
        {
            return bieuThuc
                .Replace(" ", "")
                .Replace("\t", "")
                .Replace('–', '-')
                .Replace('—', '-')
                .Replace('−', '-')
                .Replace('×', '*')
                .Replace('÷', '/');
        }

        private double TinhCongTru()
        {
            double ketQua = TinhNhanChia();

            while (viTri < chuoi.Length && (chuoi[viTri] == '+' || chuoi[viTri] == '-'))
            {
                char toanTu = chuoi[viTri];
                viTri++;

                double vePhai = TinhNhanChia();

                if (toanTu == '+')
                {
                    ketQua += vePhai;
                }
                else
                {
                    ketQua -= vePhai;
                }
            }

            return ketQua;
        }

        private double TinhNhanChia()
        {
            double ketQua = TinhThuaSo();

            while (viTri < chuoi.Length && (chuoi[viTri] == '*' || chuoi[viTri] == '/'))
            {
                char toanTu = chuoi[viTri];
                viTri++;

                double vePhai = TinhThuaSo();

                if (toanTu == '*')
                {
                    ketQua *= vePhai;
                }
                else
                {
                    if (vePhai == 0)
                    {
                        throw new DivideByZeroException("Chia cho 0.");
                    }

                    ketQua /= vePhai;
                }
            }

            return ketQua;
        }

        private double TinhThuaSo()
        {
            if (viTri >= chuoi.Length)
            {
                throw new FormatException("Biểu thức bị thiếu số ở cuối.");
            }

            char kyTu = chuoi[viTri];

            if (kyTu == '-')
            {
                viTri++;
                return -TinhThuaSo();
            }

            if (kyTu == '+')
            {
                viTri++;
                return TinhThuaSo();
            }

            if (kyTu == '(')
            {
                viTri++;
                double giaTri = TinhCongTru();

                if (viTri >= chuoi.Length || chuoi[viTri] != ')')
                {
                    throw new FormatException("Thiếu dấu ')'.");
                }

                viTri++;
                return giaTri;
            }

            return DocSo();
        }

        private double DocSo()
        {
            int batDau = viTri;

            while (viTri < chuoi.Length && (char.IsDigit(chuoi[viTri]) || chuoi[viTri] == '.'))
            {
                viTri++;
            }

            if (batDau == viTri)
            {
                throw new FormatException("Ký tự không hợp lệ: '" + chuoi[viTri] + "'");
            }

            string so = chuoi.Substring(batDau, viTri - batDau);
            return double.Parse(so, CultureInfo.InvariantCulture);
        }
    }
}