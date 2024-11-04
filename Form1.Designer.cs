using System;
using System.Windows.Forms;
namespace kh
{

    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ListBox lbDichVuDaChon;
        private System.Windows.Forms.TextBox txtTongTien; 
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Button btnSuaKhachHang;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.Button btnChonDichVu;
        private System.Windows.Forms.Button btnTaoHoaDon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDichVuDaChon = new System.Windows.Forms.ListBox();
            this.txtTongTien = new System.Windows.Forms.TextBox(); 
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.btnSuaKhachHang = new System.Windows.Forms.Button();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.btnChonDichVu = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();

            // dgvCustomers
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(400, 150);
            this.dgvCustomers.TabIndex = 0;

            // dgvServices
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(12, 180);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.Size = new System.Drawing.Size(400, 150);
            this.dgvServices.TabIndex = 1;

            // txtTen
            this.txtTen.Location = new System.Drawing.Point(450, 12);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 23);
            this.txtTen.TabIndex = 2;
            this.txtTen.PlaceholderText = "Tên khách hàng";

            // txtSoDienThoai
            this.txtSoDienThoai.Location = new System.Drawing.Point(450, 41);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 23);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.PlaceholderText = "Số điện thoại";

            // txtDiaChi
            this.txtDiaChi.Location = new System.Drawing.Point(450, 70);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 23);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.PlaceholderText = "Địa chỉ";

            // lbDichVuDaChon
            this.lbDichVuDaChon.FormattingEnabled = true;
            this.lbDichVuDaChon.ItemHeight = 15;
            this.lbDichVuDaChon.Location = new System.Drawing.Point(450, 180);
            this.lbDichVuDaChon.Name = "lbDichVuDaChon";
            this.lbDichVuDaChon.Size = new System.Drawing.Size(200, 94);
            this.lbDichVuDaChon.TabIndex = 5;

            // txtTongTien
            this.txtTongTien.Location = new System.Drawing.Point(450, 280);
            this.txtTongTien.Name = "txtTongTien"; 
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(200, 23);
            this.txtTongTien.TabIndex = 6;
            this.txtTongTien.PlaceholderText = "Tổng tiền";

            // btnThemKhachHang
            this.btnThemKhachHang.Location = new System.Drawing.Point(670, 12);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(100, 23);
            this.btnThemKhachHang.TabIndex = 7;
            this.btnThemKhachHang.Text = "Thêm khách hàng";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnAddCustomer_Click);

            // btnSuaKhachHang
            this.btnSuaKhachHang.Location = new System.Drawing.Point(670, 41);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(100, 23);
            this.btnSuaKhachHang.TabIndex = 8;
            this.btnSuaKhachHang.Text = "Sửa khách hàng";
            this.btnSuaKhachHang.UseVisualStyleBackColor = true;
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnEditCustomer_Click);

            // btnXoaKhachHang
            this.btnXoaKhachHang.Location = new System.Drawing.Point(670, 70);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(100, 23);
            this.btnXoaKhachHang.TabIndex = 9;
            this.btnXoaKhachHang.Text = "Xóa khách hàng";
            this.btnXoaKhachHang.UseVisualStyleBackColor = true;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnDeleteCustomer_Click);

            // btnChonDichVu
            this.btnChonDichVu.Location = new System.Drawing.Point(450, 150);
            this.btnChonDichVu.Name = "btnChonDichVu";
            this.btnChonDichVu.Size = new System.Drawing.Size(100, 23);
            this.btnChonDichVu.TabIndex = 10;
            this.btnChonDichVu.Text = "Chọn dịch vụ";
            this.btnChonDichVu.UseVisualStyleBackColor = true;
            this.btnChonDichVu.Click += new System.EventHandler(this.btnSelectService_Click);

            // btnTaoHoaDon
            this.btnTaoHoaDon.Location = new System.Drawing.Point(670, 280);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(100, 23);
            this.btnTaoHoaDon.TabIndex = 11;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnCreateInvoice_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.btnChonDichVu);
            this.Controls.Add(this.btnXoaKhachHang);
            this.Controls.Add(this.btnSuaKhachHang);
            this.Controls.Add(this.btnThemKhachHang);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lbDichVuDaChon);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Quản Lý Khách Hàng và Hóa Đơn Dịch Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
