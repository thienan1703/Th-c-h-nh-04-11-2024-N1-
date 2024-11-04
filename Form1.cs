using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;


namespace kh
{
    public class KhachHang
    {
        public int MaKhachHang { get; set; }
        public string Ten { get; set; } = string.Empty; 
        public string SoDienThoai { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
    }

    public class DichVu
    {
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; } = string.Empty;
        public decimal GiaTien { get; set; }
    }

    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public KhachHang KhachHang { get; set; } = new KhachHang();
        public List<DichVu> DichVus { get; set; } = new List<DichVu>();

        public decimal TongTien => DichVus.Sum(d => d.GiaTien);
    }

    public partial class Form1 : Form
    {
        private List<KhachHang> khachHangs = new List<KhachHang>();
        private List<DichVu> dichVus = new List<DichVu>();
        private List<DichVu> dichVuDaChon = new List<DichVu>();
        private int maKhachHang = 1;
        private int maDichVu = 1;
        private int maHoaDon = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            dichVus.Add(new DichVu { MaDichVu = maDichVu++, TenDichVu = "Dịch vụ A", GiaTien = 100000 });
            dichVus.Add(new DichVu { MaDichVu = maDichVu++, TenDichVu = "Dịch vụ B", GiaTien = 200000 });
            dichVus.Add(new DichVu { MaDichVu = maDichVu++, TenDichVu = "Dịch vụ C", GiaTien = 150000 });

            dgvServices.DataSource = new BindingList<DichVu>(dichVus);
            dgvServices.Columns["MaDichVu"].HeaderText = "Mã Dịch Vụ";
            dgvServices.Columns["TenDichVu"].HeaderText = "Tên Dịch Vụ";
            dgvServices.Columns["GiaTien"].HeaderText = "Giá Tiền";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var khachHang = new KhachHang
            {
                MaKhachHang = maKhachHang++,

                Ten = txtTen.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text
            };
            khachHangs.Add(khachHang);
            dgvCustomers.DataSource = new BindingList<KhachHang>(khachHangs);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is KhachHang khachHang)
            {
                khachHang.Ten = txtTen.Text;
                khachHang.SoDienThoai = txtSoDienThoai.Text;
                khachHang.DiaChi = txtDiaChi.Text;
                dgvCustomers.Refresh();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is KhachHang khachHang)
            {
                khachHangs.Remove(khachHang);
                dgvCustomers.DataSource = new BindingList<KhachHang>(khachHangs);
            }
        }

        private void btnSelectService_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow?.DataBoundItem is DichVu dichVu)
            {
                dichVuDaChon.Add(dichVu);
                lbDichVuDaChon.Items.Add(dichVu.TenDichVu);
                txtTongTien.Text = dichVuDaChon.Sum(d => d.GiaTien).ToString();
            }
        }


        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow?.DataBoundItem is KhachHang khachHang)
            {
                var hoaDon = new HoaDon
                {
                    MaHoaDon = maHoaDon++,
                    KhachHang = khachHang,
                    DichVus = new List<DichVu>(dichVuDaChon)
                };

                // Tạo chuỗi hiển thị chi tiết hóa đơn
                var hoaDonDetails = $"Mã hóa đơn: {hoaDon.MaHoaDon}\n" +
                                    $"Mã khách hàng: {khachHang.MaKhachHang}\n" +
                                    $"Tên khách hàng: {khachHang.Ten}\n" +
                                    $"Số điện thoại: {khachHang.SoDienThoai}\n" +
                                    $"Địa chỉ: {khachHang.DiaChi}\n\n" +
                                    "Danh sách dịch vụ:\n";

                // Thêm thông tin từng dịch vụ vào chuỗi hiển thị
                foreach (var dichVu in hoaDon.DichVus)
                {
                    hoaDonDetails += $"- {dichVu.TenDichVu}: {dichVu.GiaTien} VND\n";
                }

                // Thêm tổng tiền vào chuỗi hiển thị
                hoaDonDetails += $"\nTổng tiền: {hoaDon.TongTien} VND";

                // Hiển thị hóa đơn trong MessageBox
                MessageBox.Show(hoaDonDetails, "Hóa Đơn Tạm Thời");

                // Xóa danh sách dịch vụ đã chọn và đặt lại tổng tiền
                lbDichVuDaChon.Items.Clear();
                dichVuDaChon.Clear();
                txtTongTien.Text = "0";
            }
        }

    }
}


