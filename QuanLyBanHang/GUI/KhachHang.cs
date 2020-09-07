using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class KhachHang : Form
    {
        BindingSource KHListBinding = new BindingSource();
        public KhachHang()
        {
            InitializeComponent();
        }
        //var Global
        KhachHangBLL _KhachHangBLL = new KhachHangBLL();
        List<KhachHangDTO> ListKH = new List<KhachHangDTO>();
       
        private void KhachHang_Load(object sender, EventArgs e)
        {
            gvKhachHang.DataSource = KHListBinding;
            LoadingKhachHang();
            AddBinding();
           // gvKhachHang.FirstDisplayedScrollingRowIndex = gvKhachHang.RowCount - 1;
           
        }

        public void LoadingKhachHang()
        {
            ListKH = _KhachHangBLL.LoadingKhachHang();
            KHListBinding.DataSource = ListKH;
        }
      

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            EditKhachHang frmKh = new EditKhachHang();
            frmKh.UpdateHandlerEvent += FrmKh_UpdateHandlerEvent;
            CheckFormIsOpen("EditKhachHang", frmKh);
        }

        private void FrmKh_UpdateHandlerEvent(object sender, EditKhachHang.UpdateHandlerClass args)
        {
            LoadingKhachHang();
        }

        private void CheckFormIsOpen(string name, Form frm)
        {

            if ((Application.OpenForms[name] as Form) != null)
            {
                //Form is already open   
                MessageBox.Show("Form is already open", "Thông Báo", MessageBoxButtons.OK);

            }
            else
                // Form is not open
                tranShow.ShowSync(frm);

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        // Update
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string ten, ma, diachi;
            int sdt;
            ten = tbTen.Text;
            ma = tbMa.Text;      
            diachi = tbDiachi.Text;
                 
            if(tbSDT.Text ==null)
            {
                MessageBox.Show("Điền đầy đủ Thông Tin");
            }
            else
            {
                sdt = int.Parse(tbSDT.Text);
                KhachHangDTO KH = new KhachHangDTO(ma, ten, diachi, sdt);

                if (_KhachHangBLL.UpdateKH(KH))
                {
                    MessageBox.Show("Update Success");
                    LoadingKhachHang();
                }
                else
                {
                    MessageBox.Show("Update Fail");
                }    
            }  

            
        }
         void AddBinding()
        {
            tbMa.DataBindings.Add(new Binding("Text", gvKhachHang.DataSource, "MaKH"));
            tbTen.DataBindings.Add(new Binding("Text", gvKhachHang.DataSource, "TenKH"));
            tbSDT.DataBindings.Add(new Binding("Text", gvKhachHang.DataSource, "SDT"));
            tbDiachi.DataBindings.Add(new Binding("Text", gvKhachHang.DataSource, "DiaChi"));
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string MaKH = tbMa.Text;
         
            if (MessageBox.Show("Bạn Có Muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_KhachHangBLL.DeleteKH(MaKH))
                {
                    MessageBox.Show("Delete Success");
                    //tbMa.Text = "";
                    //tbDiachi.Text = "";
                    //tbSDT.Text = "";
                    //tbTen.Text = "";
                    LoadingKhachHang();
                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }
            }
            return;
        }

        // Fill Theo tên
        private void btnFill_Click(object sender, EventArgs e)
        {
            ListKH = _KhachHangBLL.FillKhachhang_Ten();
            KHListBinding.DataSource = ListKH;
        }
        // Fill _ ngayMua
        private void _DateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            int day, month, year;
            day = _DateTimePicker.Value.Day;
            month = _DateTimePicker.Value.Month;
            year = _DateTimePicker.Value.Year;
            ListKH = _KhachHangBLL.Fill_NgayMua(day, month, year);
            KHListBinding.DataSource = ListKH;

        }

        // show ALL
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            LoadingKhachHang();
        }

        // TimKiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string ten = tbTimKiem.Text;
            ListKH = _KhachHangBLL.TimKiemKhachhang_Ten(ten);
            KHListBinding.DataSource = ListKH;
        }

     
    }
}
