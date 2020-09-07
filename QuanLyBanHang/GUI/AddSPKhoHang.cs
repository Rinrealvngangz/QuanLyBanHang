using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class AddSPKhoHang : Form
    {
        public AddSPKhoHang()
        {
            InitializeComponent();
        }
        KhoBLL editKho = new KhoBLL();
        public delegate void UpdateSanPham(object sender);
        public event UpdateSanPham UpdateHandler;

       
        public void CRUD()
        {
          
            UpdateHandler.Invoke(this);
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string tensp, masp, maNCC;
            int soluong, dongia;
            DateTime ntn = DateTime.Now;
            tensp = tbTen.Text;
            masp = tbMaSP.Text;
            maNCC = tbMaNCC.Text;
            if (tbSoLuong.Text == "" || tbGia.Text == "" || tbMaNCC.Text =="" || tbTen.Text =="" || tbMaSP.Text =="")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                soluong = int.Parse(tbSoLuong.Text);
                dongia = int.Parse(tbGia.Text);
                KhoDTO kho = new KhoDTO(masp, tensp, maNCC, soluong, dongia, ntn);
                if (editKho.AddSPKho(kho))
                {
                    MessageBox.Show("Thêm Sản Phẩm Success!");
                    CRUD();
                    tbTen.Text = "";
                    tbMaNCC.Text = "";
                    tbMaSP.Text = "";
                    tbSoLuong.Text = "";
                    tbGia.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi Mã SP đã có hoặc mã nhà cung cấp không tồn tại , ", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
