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
    public partial class EditKhoHang : Form
    {
        // Val global
        KhoBLL editKho = new KhoBLL();


        // Event Delegate

        public delegate void showText(string tensp, string masp, int soluong, int gia, string maNCC);

        public delegate void UpdateSanPham(object sender, updateData args);
        public event UpdateSanPham UpdateHandler;

        public class updateData : EventArgs
        {
            string data { get; set; }
        }

        public EditKhoHang()
        {
            InitializeComponent();
            showText text = new showText(show);
        }
        private void EditKhoHang_Load(object sender, EventArgs e)
        {


        }
        // Display info textbox
        public void show(string tensp,string masp,int soluong ,int gia,string maNCC)
        {
            tbTen.Text = tensp;
            tbGia.Text = gia.ToString();
            tbMaNCC.Text = maNCC;
            tbSoLuong.Text =  soluong.ToString();
            tbMaSP.Text = masp;
        }
       
     // add SP
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string tensp, masp, maNCC;
            int soluong, dongia;
            DateTime ntn = DateTime.Now;
            tensp = tbTen.Text;
            masp = tbMaSP.Text;
            maNCC = tbMaNCC.Text;
            if(tbSoLuong.Text =="" || tbGia.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                soluong = int.Parse(tbSoLuong.Text);
                dongia = int.Parse(tbGia.Text);
                KhoDTO kho = new KhoDTO(masp, tensp, maNCC, soluong, dongia, ntn);
                if(editKho.AddSPKho(kho))
                {
                    MessageBox.Show("Thêm Sản Phẩm Success!");
                    CRUD();
                }
                else
                {
                    MessageBox.Show("Lỗi Mã SP Hoặc Chưa điền đủ thông tin !","Thông Báo",MessageBoxButtons.OK);
                }
            }
         

        }
         
        public void CRUD()
        {
            updateData args = new updateData();
            UpdateHandler.Invoke(this, args);
        }
        // Update SanPham Kho
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string tensp,masp,maNCC;
            int soluong, dongia;
         
            if (tbSoLuong.Text == "" || tbGia.Text == "" || tbTen.Text =="" || tbMaNCC.Text =="" || tbMaSP.Text =="")
            {

                MessageBox.Show("Phải điền Đầy đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                tensp = tbTen.Text;
                masp = tbMaSP.Text;
                maNCC = tbMaNCC.Text;
                soluong = int.Parse(tbSoLuong.Text);
                dongia = int.Parse(tbGia.Text);
                KhoDTO kho = new KhoDTO(masp, tensp, maNCC, soluong, dongia);
                if (editKho.UpdateSPKho(kho))
                {
                    MessageBox.Show("Update Success");
                    CRUD();
                }
                else
                {
                    MessageBox.Show("Update Fail,Xem Lại Mã Sản Phẩm!");
                }
            }
          
        }
    }
}
