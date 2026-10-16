using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class Bai07 : Form
    {
        private const string TenNutGiaMa = "__nut_gia_ma__";
        private const int GioiHanKyTu = 200000;

        private static readonly string[] DuoiVanBan =
        {
            ".txt", ".cs", ".md", ".json", ".xml", ".csv", ".log",
            ".html", ".css", ".js", ".ini", ".config", ".py", ".c", ".cpp", ".h", ".sql"
        };

        private static readonly string[] DuoiAnh = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

        public Bai07()
        {
            InitializeComponent();

            tvFolders.BeforeExpand -= tvFolders_BeforeExpand;
            tvFolders.BeforeExpand += tvFolders_BeforeExpand;

            tvFolders.AfterSelect -= tvFolders_AfterSelect;
            tvFolders.AfterSelect += tvFolders_AfterSelect;

            rtbContent.ReadOnly = true;
            pbContent.SizeMode = PictureBoxSizeMode.Zoom;
            HienThiChe(false);

            NapCacODia();
        }

        private TreeNode TaoNutGiaMa()
        {
            TreeNode nutGiaMa = new TreeNode("...");
            nutGiaMa.Name = TenNutGiaMa;
            return nutGiaMa;
        }

        private bool ChiCoNutGiaMa(TreeNode nut)
        {
            return nut.Nodes.Count == 1 && nut.Nodes[0].Name == TenNutGiaMa;
        }

        private void NapCacODia()
        {
            tvFolders.Nodes.Clear();

            foreach (DriveInfo oDia in DriveInfo.GetDrives())
            {
                string tenHienThi = oDia.Name;

                if (oDia.IsReady)
                {
                    if (oDia.VolumeLabel != "")
                    {
                        tenHienThi = oDia.VolumeLabel + " (" + oDia.Name + ")";
                    }
                }
                else
                {
                    tenHienThi = oDia.Name + " [chưa sẵn sàng]";
                }

                TreeNode nutODia = new TreeNode(tenHienThi);
                nutODia.Tag = oDia.Name;

                if (oDia.IsReady)
                {
                    nutODia.Nodes.Add(TaoNutGiaMa());
                }

                tvFolders.Nodes.Add(nutODia);
            }
        }

        private void tvFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode nut = e.Node;

            if (ChiCoNutGiaMa(nut))
            {
                nut.Nodes.Clear();
                NapNutCon(nut);
            }
        }

        private void NapNutCon(TreeNode nutCha)
        {
            string duongDan = (string)nutCha.Tag;

            try
            {
                DirectoryInfo thuMuc = new DirectoryInfo(duongDan);

                foreach (DirectoryInfo thuMucCon in thuMuc.GetDirectories().OrderBy(d => d.Name))
                {
                    TreeNode nutThuMuc = new TreeNode(thuMucCon.Name);
                    nutThuMuc.Tag = thuMucCon.FullName;
                    nutThuMuc.Nodes.Add(TaoNutGiaMa());
                    nutCha.Nodes.Add(nutThuMuc);
                }

                foreach (FileInfo tep in thuMuc.GetFiles().OrderBy(f => f.Name))
                {
                    TreeNode nutTep = new TreeNode(tep.Name);
                    nutTep.Tag = tep.FullName;
                    nutTep.ForeColor = Color.SteelBlue;
                    nutCha.Nodes.Add(nutTep);
                }
            }
            catch (UnauthorizedAccessException)
            {
                lblStatus.Text = "Không có quyền truy cập: " + duongDan;
            }
            catch (IOException ex)
            {
                lblStatus.Text = "Không đọc được thư mục: " + ex.Message;
            }
        }

        private void tvFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string duongDan = e.Node.Tag as string;

            if (duongDan == null)
            {
                return;
            }

            lblStatus.Text = duongDan;

            if (Directory.Exists(duongDan))
            {
                XoaNoiDung();
                return;
            }

            HienThiTep(duongDan);
        }

        private void HienThiTep(string duongDan)
        {
            string duoiFile = Path.GetExtension(duongDan).ToLowerInvariant();

            try
            {
                if (DuoiAnh.Contains(duoiFile))
                {
                    HienThiAnh(duongDan);
                }
                else if (DuoiVanBan.Contains(duoiFile))
                {
                    HienThiVanBan(duongDan);
                }
                else
                {
                    XoaNoiDung();
                    rtbContent.Text = "Không hỗ trợ xem định dạng '" + duoiFile + "'.";
                }
            }
            catch (Exception ex) when (ex is IOException
                || ex is UnauthorizedAccessException
                || ex is ArgumentException
                || ex is OutOfMemoryException)
            {
                XoaNoiDung();
                rtbContent.Text = "Không mở được file: " + ex.Message;
            }
        }

        private void HienThiVanBan(string duongDan)
        {
            string noiDung;
            bool biCat;

            using (StreamReader docFile = new StreamReader(duongDan))
            {
                char[] boDem = new char[GioiHanKyTu];
                int soKyTuDoc = docFile.Read(boDem, 0, boDem.Length);
                noiDung = new string(boDem, 0, soKyTuDoc);
                biCat = docFile.Peek() != -1;
            }

            XoaNoiDung();
            HienThiChe(false);
            rtbContent.Text = noiDung;

            if (biCat)
            {
                lblStatus.Text = duongDan + "  (file dài, chỉ hiển thị " + GioiHanKyTu + " ký tự đầu)";
            }
        }

        private void HienThiAnh(string duongDan)
        {
            XoaNoiDung();

            using (FileStream luongFile = new FileStream(duongDan, FileMode.Open, FileAccess.Read))
            using (Image anhGoc = Image.FromStream(luongFile))
            {
                pbContent.Image = new Bitmap(anhGoc);
            }

            HienThiChe(true);
        }

        private void XoaNoiDung()
        {
            rtbContent.Clear();

            if (pbContent.Image != null)
            {
                pbContent.Image.Dispose();
                pbContent.Image = null;
            }

            HienThiChe(false);
        }

        private void HienThiChe(bool laAnh)
        {
            pbContent.Visible = laAnh;
            rtbContent.Visible = !laAnh;
        }
    }
}