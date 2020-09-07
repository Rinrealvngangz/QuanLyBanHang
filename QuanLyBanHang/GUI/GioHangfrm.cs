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
    public partial class GioHangfrm : Form
    {
        public GioHangfrm()
        {
            InitializeComponent();
        }
        KhachHangBLL _khBll = new KhachHangBLL();
        SanPhamBLL _spBll = new SanPhamBLL();
        ThongKeBLL _Thongke = new ThongKeBLL();
        HoaDonBLL _HoaDon = new HoaDonBLL();
        List<CartGioHang> listUser = new List<CartGioHang>();
        List<GioHang> ListGH = new List<GioHang>();
        int mahd;
        string tenSPG;
        private void GioHangfrm_Load(object sender, EventArgs e)
        {
            HienThi(listUser, ListGH);
        }
        public void HienThi(List<CartGioHang> listUser, List<GioHang> ListGH)
        {
            Loading(listUser, ListGH);
            Display(listUser);
        }


        public void Loading(List<CartGioHang> listUser, List<GioHang> ListGH)
        {

            ListGH = _spBll.Loading_Gio_SP();
            CreateUser(listUser, ListGH);
        }
        public void Display(List<CartGioHang> listUser)
        {
            flowpanelGioHang.Controls.Clear();
            for (int i = 0; i < listUser.Count; i++)
            {
                flowpanelGioHang.Controls.Add(listUser[i]);
            }

        }

        public void PoplistUser(List<CartGioHang> listUser)
        {
            string maHD , masp, tensp, size, color,soluong ,tennv, tenkh;
            int gia;
            if(tbNV.Text =="" || tbKH.Text =="")
            {
                MessageBox.Show("Tên nhân viên hoặc tên khách hàng không bỏ trống");
            }
            else
            {
                tennv = tbNV.Text;
                tenkh = tbKH.Text;
                maHD = mahd.ToString();
                for (int i = 0; i < listUser.Count; i++)
                {
                    masp = listUser[i].Masp;
                    tensp = listUser[i].Tensp;
                    size = listUser[i].Sizee;
                    color = listUser[i].Color;
                    soluong = listUser[i].Soluong;
                    gia = listUser[i].Gia;

                    ChiTietHoaDonDTO items = new ChiTietHoaDonDTO(maHD,masp,tensp,size,color,soluong,gia,tennv,tenkh);
                    _HoaDon.Them_ChitietHD(items);
                   
                }
         
            }
          
        }

        public void CreateUser(List<CartGioHang> listUser, List<GioHang> ListGH)
        {
            foreach (GioHang items in ListGH)
            {
                CartGioHang user = new CartGioHang();
                user.UpdateEventHandler += User_UpdateEventHandler;
                user.Masp = items.MaSP;
                user.Tensp = items.TenSP;
                user.Sizee = items.Size;
                user.Color = items.Color;
                user.Soluong = items.SoLuong;
                user.Gia = items.DonGia;
                listUser.Add(user);

            }
        }

        public void User_UpdateEventHandler(object sender)
        {
            List<CartGioHang> newlistUser = new List<CartGioHang>();
            List<GioHang> newListGH = new List<GioHang>();
            HienThi(newlistUser, newListGH);
        }

        public void AddKhachHang(string tenKH,string ngaymua)
        {
            string diachi;
            string max;
            string maKH;
            int kqMaKH,sdt;
            int demKH;
            demKH = _khBll.DemKhachHang();
            if(demKH >0)
            {
                max = _khBll.TimMaxKhachHang_ma();
                kqMaKH = int.Parse(max) + 1;
                maKH = kqMaKH.ToString();
            }    
           else
            {
                maKH = "0";
            }    
          
         
          
            sdt = int.Parse(tbSDT.Text);
            diachi = tbDiaChi.Text;
          
            KhachHangDTO KH = new KhachHangDTO(maKH, tenKH, diachi, sdt,ngaymua);
            _khBll.InsertKH(KH);
               
        }
        public void DeleteAllGioHang()
        {
            _spBll.DeleteAllGioHang();
            List<CartGioHang> newlistUser = new List<CartGioHang>();
            List<GioHang> newListGH = new List<GioHang>();
            HienThi(newlistUser, newListGH);

        }
        public void insertThongke(int price)
        {
            int valueMonth;
            int valYear;
            string date = DateTime.Now.ToString();
             valueMonth = 3;
                valYear = 2;
                  
            ThongKeDTO TK = new ThongKeDTO(price,valYear,date,valueMonth,tenSPG);
            _Thongke.ThemThongKe(TK);
        }
        public void DemGioHang()
        {
            tenSPG = _spBll.DemGioHang();
         
        }
        // tinh tien
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            string tenNV, tenKH;
            string ngayban;
            int tien;
            int maxHD;
            int countHD;
            if(tbTien.Text =="")
            {
                MessageBox.Show("Tổng tiền chưa tính");
            }
            else
            {
                tien = int.Parse(tbTien.Text);
                DemGioHang();                         
                insertThongke(tien);
                countHD = _spBll.CheckHoaDon();
                if(countHD >0)
                {
                    maxHD = _spBll.DemHoaDon_Ma();
                }else
                {
                    maxHD = 0;
                }    
                 
                 
                mahd = maxHD + 1;
                ngayban = DateTime.Now.ToString();
                tenKH = tbKH.Text;
                tenNV = tbNV.Text;
                HoaDonDTO hd = new HoaDonDTO(mahd, tenNV, tenKH, ngayban, tien);
                  AddKhachHang(tenKH,ngayban);
                if (_spBll.Them_HoaDon(hd))
                {
                    PoplistUser(listUser);
                    MessageBox.Show("Bán Thành Công , Kiểm Tra hóa đơn");
                    DeleteAllGioHang();

                }
                else
                {
                    MessageBox.Show("Bán thất Bại!");
                }
            }
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int tien;
            tien = _spBll.TinhTongTien();
            tbTien.Text = tien.ToString();
        }
        public void LayDataFormMain(string tenNV)
        {
            tbNV.Text = tenNV;
        }


   
    }
}
