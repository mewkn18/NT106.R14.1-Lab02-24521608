using System;
using System.IO;
using System.Windows.Forms;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();

            btnDocFile.Click -= btnDocFile_Click;
            btnDocFile.Click += btnDocFile_Click;

            btnThoat.Click -= btnThoat_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog hopThoaiChonFile = new OpenFileDialog();
            hopThoaiChonFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (hopThoaiChonFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                string noiDung;
                string tenFile = hopThoaiChonFile.SafeFileName;
                string duongDan;
                long kichThuocByte;

                using (FileStream luongFile = new FileStream(hopThoaiChonFile.FileName, FileMode.Open))
                using (StreamReader docFile = new StreamReader(luongFile))
                {
                    duongDan = luongFile.Name;
                    kichThuocByte = luongFile.Length;
                    noiDung = docFile.ReadToEnd();
                }

                txtTenFile.Text = tenFile;
                txtKichThuoc.Text = kichThuocByte + " bytes";
                txtDuongDan.Text = duongDan;
                txtSoDong.Text = DemSoDong(noiDung).ToString();
                txtSoTu.Text = DemSoTu(noiDung).ToString();
                txtSoKyTu.Text = noiDung.Length.ToString();

                rtbNoiDung.Text = noiDung;
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private int DemSoDong(string noiDung)
        {
            int soDong = 0;

            using (StringReader docChuoi = new StringReader(noiDung))
            {
                while (docChuoi.ReadLine() != null)
                {
                    soDong++;
                }
            }

            return soDong;
        }

        private int DemSoTu(string noiDung)
        {
            char[] kyTuNganCach = { ' ', '\t', '\r', '\n' };
            string[] cacTu = noiDung.Split(kyTuNganCach, StringSplitOptions.RemoveEmptyEntries);
            return cacTu.Length;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}