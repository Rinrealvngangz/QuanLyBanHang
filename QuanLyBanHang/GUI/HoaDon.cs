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
    public partial class HoaDon : Form
    {
        BindingSource listHD = new BindingSource();
        public HoaDon()
        {
            InitializeComponent();
            gvHoaDon.DataSource = listHD;
        }
        List<HoaDonDTO> ListHoaDon = new List<HoaDonDTO>();
        HoaDonBLL dataHD = new HoaDonBLL();
        
        private void HoaDon_Load(object sender, EventArgs e)
        {

            LoadingHoaDon();
            AddBinding();
        }
        public void LoadingHoaDon()
        {
            ListHoaDon = dataHD.Loading_hoaDon();
            listHD.DataSource = ListHoaDon;
        }    

        public void AddBinding()
        {
            tbMa.DataBindings.Add(new Binding("Text", gvHoaDon.DataSource, "MaHD"));
            tbNV.DataBindings.Add(new Binding("Text", gvHoaDon.DataSource, "TenNV"));
            tbKH.DataBindings.Add(new Binding("Text", gvHoaDon.DataSource, "TenKH"));
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            int mahd;
            if (tbMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã Hóa Đơn");
            }
            else
            {
                mahd = int.Parse(tbMa.Text);
                ChiTietHoaDon frmChiTietHD = new ChiTietHoaDon(mahd);
                CheckFormIsOpen("ChiTietHoaDon", frmChiTietHD);
            }
       
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
        // Delete Hóa đơn
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if(tbMa.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập mã Hóa Đơn");
            }
          
            if (MessageBox.Show("Bạn Có Muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                              
                int mahd;
                string maChitietHD;
                    maChitietHD = tbMa.Text;
                    mahd = int.Parse(tbMa.Text);
                    if (dataHD.DeleteHoaDon(mahd))
                    {
                        dataHD.DeleteChiTietHoaDon(maChitietHD);
                        LoadingHoaDon();
                        MessageBox.Show("Delete Success");
                    }
                else
                {
                    MessageBox.Show("Delete Fail");
                }
            }
            return;
        }

        // Tìm Kiếm Hóa Đơn Theo Tên
        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            string tenKH = tbTimKiem.Text;
            listHD.DataSource = dataHD.TimKiem_hoaDon(tenKH);
        }

        // Show All
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            LoadingHoaDon();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                
                if (dataHD.DeleteAllHoaDon())
                {
                    dataHD.DeleteAllChiTietHoaDon();
                    LoadingHoaDon();
                          
                    MessageBox.Show("Delete Success");
                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }
            }
            return;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int day, month, year;
            day = guna2DateTimePicker1.Value.Day;
            month = guna2DateTimePicker1.Value.Month;
            year = guna2DateTimePicker1.Value.Year;
            gvHoaDon.DataSource = dataHD.FillChitietHD_date(day, month, year);
        }
    }
}
