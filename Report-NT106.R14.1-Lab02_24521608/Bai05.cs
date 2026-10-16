using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_NT106.R14._1_Lab02_24521608
{
    public partial class Bai05 : Form
    {
        private const string DuongDanInput = "input5.txt";
        private const string DuongDanOutput = "output5.txt";
        private const int SoDongMoiPhim = 5;

        private readonly BindingList<PhimChieu> danhSachPhim = new BindingList<PhimChieu>();

        public Bai05()
        {
            InitializeComponent();

            dgvMovies.DataSource = danhSachPhim;
            CauHinhBang();

            btnAdd.Click -= btnAdd_Click;
            btnAdd.Click += btnAdd_Click;

            btnWriteFile.Click -= btnWriteFile_Click;
            btnWriteFile.Click += btnWriteFile_Click;

            btnReadFile.Click -= btnReadFile_Click;
            btnReadFile.Click += btnReadFile_Click;

            btnExportStats.Click -= btnExportStats_Click;
            btnExportStats.Click += btnExportStats_Click;
        }

        private void CauHinhBang()
        {
            dgvMovies.ReadOnly = true;
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMovies.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvMovies.Columns["GiaVeChuan"].HeaderText = "Giá vé chuẩn";
            dgvMovies.Columns["PhongChieu"].HeaderText = "Phòng chiếu";
            dgvMovies.Columns["TongSoGhe"].HeaderText = "Tổng ghế";
            dgvMovies.Columns["SoVeDaBan"].HeaderText = "Vé đã bán";
            dgvMovies.Columns["SoVeTon"].HeaderText = "Vé tồn";
            dgvMovies.Columns["TiLeVeBan"].HeaderText = "Tỉ lệ bán (%)";
            dgvMovies.Columns["DoanhThu"].HeaderText = "Doanh thu";

            dgvMovies.Columns["GiaVeChuan"].DefaultCellStyle.Format = "N0";
            dgvMovies.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
            dgvMovies.Columns["TiLeVeBan"].DefaultCellStyle.Format = "0.##";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhimChieu phim;
            string thongBaoLoi;

            if (!TryLayPhimTuOnhap(out phim, out thongBaoLoi))
            {
                MessageBox.Show(thongBaoLoi);
                return;
            }

            danhSachPhim.Add(phim);
            XoaOnhap();
            lblStatus.Text = "Đã thêm phim: " + phim.TenPhim + " (" + danhSachPhim.Count + " phim).";
        }

        private bool TryLayPhimTuOnhap(out PhimChieu phim, out string thongBaoLoi)
        {
            phim = null;
            thongBaoLoi = "";

            string tenPhim = txtMovieName.Text.Trim();
            string phongChieu = txtRoom.Text.Trim();

            if (tenPhim == "")
            {
                thongBaoLoi = "Tên phim không được để trống.";
                return false;
            }

            if (phongChieu == "")
            {
                thongBaoLoi = "Phòng chiếu không được để trống.";
                return false;
            }

            decimal giaVe;
            if (!decimal.TryParse(txtTicketPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out giaVe) || giaVe <= 0)
            {
                thongBaoLoi = "Giá vé chuẩn phải là số dương, viết liền không có dấu chấm (ví dụ 90000).";
                return false;
            }

            int tongGhe;
            if (!int.TryParse(txtTotalSeats.Text.Trim(), out tongGhe) || tongGhe <= 0)
            {
                thongBaoLoi = "Tổng số ghế phải là số nguyên dương.";
                return false;
            }

            int soVeBan;
            if (!int.TryParse(txtSoldTickets.Text.Trim(), out soVeBan) || soVeBan < 0 || soVeBan > tongGhe)
            {
                thongBaoLoi = "Số vé đã bán phải là số nguyên từ 0 đến tổng số ghế (" + tongGhe + ").";
                return false;
            }

            phim = new PhimChieu
            {
                TenPhim = tenPhim,
                GiaVeChuan = giaVe,
                PhongChieu = phongChieu,
                TongSoGhe = tongGhe,
                SoVeDaBan = soVeBan
            };

            return true;
        }

        private void XoaOnhap()
        {
            txtMovieName.Clear();
            txtTicketPrice.Clear();
            txtRoom.Clear();
            txtTotalSeats.Clear();
            txtSoldTickets.Clear();
            txtMovieName.Focus();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            if (danhSachPhim.Count == 0)
            {
                MessageBox.Show("Danh sách phim đang trống, hãy thêm phim hoặc đọc file trước.");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(DuongDanInput))
                {
                    foreach (PhimChieu phim in danhSachPhim)
                    {
                        writer.WriteLine(phim.TenPhim);
                        writer.WriteLine(phim.GiaVeChuan.ToString(CultureInfo.InvariantCulture));
                        writer.WriteLine(phim.PhongChieu);
                        writer.WriteLine(phim.TongSoGhe);
                        writer.WriteLine(phim.SoVeDaBan);
                    }
                }

                lblStatus.Text = "Đã ghi " + danhSachPhim.Count + " phim vào " + Path.GetFullPath(DuongDanInput);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> cacDong = new List<string>();

                using (StreamReader reader = new StreamReader(DuongDanInput))
                {
                    string dong;
                    while ((dong = reader.ReadLine()) != null)
                    {
                        if (dong.Trim() != "")
                        {
                            cacDong.Add(dong.Trim());
                        }
                    }
                }

                if (cacDong.Count == 0 || cacDong.Count % SoDongMoiPhim != 0)
                {
                    MessageBox.Show("Mỗi phim phải có đúng " + SoDongMoiPhim + " dòng. File hiện có "
                        + cacDong.Count + " dòng (không chia hết cho " + SoDongMoiPhim + ").");
                    return;
                }

                List<PhimChieu> phimDocDuoc = new List<PhimChieu>();

                for (int viTriDau = 0; viTriDau < cacDong.Count; viTriDau += SoDongMoiPhim)
                {
                    phimDocDuoc.Add(ChuyenThanhPhim(cacDong, viTriDau));
                }

                danhSachPhim.Clear();
                foreach (PhimChieu phim in phimDocDuoc)
                {
                    danhSachPhim.Add(phim);
                }

                lblStatus.Text = "Đã đọc " + danhSachPhim.Count + " phim từ " + DuongDanInput;
            }
            catch (FileNotFoundException)
            {
                string duongDanDayDu = Path.GetFullPath(DuongDanInput);
                lblStatus.Text = "Không tìm thấy file: " + duongDanDayDu;
                MessageBox.Show("Không tìm thấy file:\n" + duongDanDayDu);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("File sai định dạng. " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private PhimChieu ChuyenThanhPhim(List<string> cacDong, int viTriDau)
        {
            int soThuTu = viTriDau / SoDongMoiPhim + 1;

            decimal giaVe;
            if (!decimal.TryParse(cacDong[viTriDau + 1], NumberStyles.Number, CultureInfo.InvariantCulture, out giaVe) || giaVe <= 0)
            {
                throw new FormatException("Phim thứ " + soThuTu + ": giá vé không hợp lệ.");
            }

            int tongGhe;
            if (!int.TryParse(cacDong[viTriDau + 3], out tongGhe) || tongGhe <= 0)
            {
                throw new FormatException("Phim thứ " + soThuTu + ": tổng số ghế không hợp lệ.");
            }

            int soVeBan;
            if (!int.TryParse(cacDong[viTriDau + 4], out soVeBan) || soVeBan < 0 || soVeBan > tongGhe)
            {
                throw new FormatException("Phim thứ " + soThuTu + ": số vé đã bán không hợp lệ.");
            }

            return new PhimChieu
            {
                TenPhim = cacDong[viTriDau],
                GiaVeChuan = giaVe,
                PhongChieu = cacDong[viTriDau + 2],
                TongSoGhe = tongGhe,
                SoVeDaBan = soVeBan
            };
        }

        private int TinhHangDoanhThu(PhimChieu phim)
        {
            int soPhimDoanhThuCaoHon = danhSachPhim.Count(p => p.DoanhThu > phim.DoanhThu);
            return soPhimDoanhThuCaoHon + 1;
        }

        private string TaoThongKeMotPhim(PhimChieu phim)
        {
            return
                "Tên phim: " + phim.TenPhim + Environment.NewLine +
                "Số lượng vé bán ra: " + phim.SoVeDaBan + Environment.NewLine +
                "Số lượng vé tồn: " + phim.SoVeTon + Environment.NewLine +
                "Tỉ lệ vé bán ra: " + phim.TiLeVeBan.ToString("0.##", CultureInfo.InvariantCulture) + "%" + Environment.NewLine +
                "Doanh thu: " + phim.DoanhThu.ToString("N0", CultureInfo.InvariantCulture) + Environment.NewLine +
                "Xếp hạng doanh thu: " + TinhHangDoanhThu(phim) + Environment.NewLine;
        }

        private async void btnExportStats_Click(object sender, EventArgs e)
        {
            if (danhSachPhim.Count == 0)
            {
                MessageBox.Show("Danh sách phim đang trống, hãy thêm phim hoặc đọc file trước.");
                return;
            }

            List<PhimChieu> phimTheoHang = danhSachPhim.OrderByDescending(p => p.DoanhThu).ToList();

            btnExportStats.Enabled = false;
            rtbStats.Clear();
            prgExport.Minimum = 0;
            prgExport.Maximum = phimTheoHang.Count;
            prgExport.Value = 0;

            try
            {
                using (StreamWriter writer = new StreamWriter(DuongDanOutput))
                {
                    foreach (PhimChieu phim in phimTheoHang)
                    {
                        string khoiThongKe = TaoThongKeMotPhim(phim);

                        writer.WriteLine(khoiThongKe);
                        rtbStats.AppendText(khoiThongKe + Environment.NewLine);

                        prgExport.Value++;
                        lblStatus.Text = "Đang xuất " + prgExport.Value + "/" + prgExport.Maximum + " phim...";

                        await Task.Delay(300);
                    }
                }

                lblStatus.Text = "Đã ghi thống kê vào " + Path.GetFullPath(DuongDanOutput);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
            }
            finally
            {
                btnExportStats.Enabled = true;
            }
        }
    }

    public class PhimChieu
    {
        public string TenPhim { get; set; }
        public decimal GiaVeChuan { get; set; }
        public string PhongChieu { get; set; }
        public int TongSoGhe { get; set; }
        public int SoVeDaBan { get; set; }

        public int SoVeTon
        {
            get { return TongSoGhe - SoVeDaBan; }
        }

        public double TiLeVeBan
        {
            get { return TongSoGhe == 0 ? 0 : (double)SoVeDaBan / TongSoGhe * 100; }
        }

        public decimal DoanhThu
        {
            get { return SoVeDaBan * GiaVeChuan; }
        }
    }
}