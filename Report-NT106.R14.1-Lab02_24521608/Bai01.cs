using System;
using System.IO;
using System.Windows.Forms;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class Bai01 : Form
    {
        private const string DuongDanInput = "input1.txt";
        private const string DuongDanOutput = "output1.txt";

        public Bai01()
        {
            InitializeComponent();

            btnDocFile.Click -= btnDocFile_Click;
            btnDocFile.Click += btnDocFile_Click;

            btnGhiFile.Click -= btnGhiFile_Click;
            btnGhiFile.Click += btnGhiFile_Click;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(DuongDanInput))
                {
                    rtbNoiDung.Text = reader.ReadToEnd();
                }

                lblTrangThai.Text = "Đã đọc " + DuongDanInput + ". Bạn có thể sửa nội dung trước khi ghi.";
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

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (rtbNoiDung.Text.Length == 0)
            {
                MessageBox.Show("Khung nội dung đang trống, hãy đọc file hoặc nhập chữ vào.");
                return;
            }

            try
            {
                string noiDungInHoa = rtbNoiDung.Text.ToUpperInvariant();

                using (StreamWriter writer = new StreamWriter(DuongDanOutput))
                {
                    writer.Write(noiDungInHoa.Replace("\n", Environment.NewLine));
                }

                lblTrangThai.Text = "Đã ghi vào " + Path.GetFullPath(DuongDanOutput);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }
    }
}