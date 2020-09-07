using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  BLL;
using DTO;
namespace GUI
{
    public partial class ChiTietHoaDon : Form
    {
        BindingSource listBinding = new BindingSource();
        public ChiTietHoaDon(int maHD)
        {
          
            InitializeComponent();
            gvChiTietHD.DataSource = listBinding;
            _mahdG = maHD;
        }
      
        HoaDonBLL _dataHD = new HoaDonBLL();
        List<ChiTietHoaDonDTO> listHD = new List<ChiTietHoaDonDTO>();
        private int _mahdG;

        public int MahdG { get => _mahdG; set => _mahdG = value; }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadingChiTiet_HD();
            AddBinding();
        }
        public void LoadingChiTiet_HD()
        {
            listHD = _dataHD.loadingChitietHD_Ma(MahdG);
            gvChiTietHD.DataSource = listHD;
        }

        public void AddBinding()
        {
            lbKH.DataBindings.Add(new Binding("Text", gvChiTietHD.DataSource, "TenKH"));
            lbNV.DataBindings.Add(new Binding("Text", gvChiTietHD.DataSource, "TenNV"));
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = this as Form;
            frm.Close();
        }

      
    }
}
