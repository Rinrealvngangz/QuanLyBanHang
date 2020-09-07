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
    public partial class HienThiKho : Form
    {
        BindingSource listBinding = new BindingSource();
        SanPhamBLL _spBll = new SanPhamBLL();
        KhoBLL _kho = new KhoBLL();
        int soluongKhoG;
        public HienThiKho()
        {
            InitializeComponent();
           gvKhoSpNhap.DataSource =  listBinding;
        }
        KhoBLL _khoHang = new KhoBLL();
        List<KhoDTO> listKho = new List<KhoDTO>();
        private void HienThiKho_Load(object sender, EventArgs e)
        {

            LoadingKhohang();
            AddBinding();
        }
        public void AddBinding()
        {
            tbTen.DataBindings.Add(new Binding("Text", gvKhoSpNhap.DataSource, "TenSP"));
            lbSoluongKho.DataBindings.Add(new Binding("Text", gvKhoSpNhap.DataSource, "Soluong"));
            tbGia.DataBindings.Add(new Binding("Text", gvKhoSpNhap.DataSource, "DonGia"));
            tbMa.DataBindings.Add(new Binding("Text", gvKhoSpNhap.DataSource, "MaSP"));
           
        }
        public void LoadingKhohang()
        {
            listKho = _khoHang.LoadingKho();
            listBinding.DataSource = listKho;
        }
        //Deletegate
        public delegate void UpdateHandler(object sender);
        public event UpdateHandler UpdateHandlerEvent;

        public void UpdateDelegate()
        {
            UpdateHandlerEvent.Invoke(this);
        }

       
        //Add San pham
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string masp, tensp, maHang;
            int soluongban, gia;
            int soluongAfter,slkho;

            if (tbGia.Text == "" || tbSoLuong.Text =="")
            {
                MessageBox.Show("Điền đầy đủ thong tin");
            }
            else
            {
                                                                                                                                                                         
                masp = tbMa.Text;
                if(masp.Contains("NK"))
                {
                    maHang = "NK";
                } else if(masp.Contains("AD"))
                {
                    maHang = "AD";
                }    else
                {
                    maHang = "CV";
                }    
                tensp = tbTen.Text;
                soluongban = int.Parse(tbSoLuong.Text);
                slkho = int.Parse(lbSoluongKho.Text);
                soluongAfter = slkho - soluongban;
                gia = int.Parse(tbGia.Text);
                if(soluongban == slkho )
                {
                    _kho.DeleteSPKho(masp);
                }    
                SanPham sp = new SanPham(masp, tensp, gia, soluongban, maHang);
               if(_spBll.ThemSP_Kho(sp))
                {
                    MessageBox.Show("Thêm Sản Phẩm Thành Công");
                    UpdateDelegate();
                    _kho.UpdateSoluongKho(soluongAfter, masp);
                    LoadingKhohang();
                    tbGia.Text = "";
                    tbMa.Text = "";
                    tbSoLuong.Text = "";
                    tbTen.Text = "";
                }    else
                {
                    MessageBox.Show("Thêm Sản Phẩm Thất Bại");
                }    
            }

        }

     
    }
}
