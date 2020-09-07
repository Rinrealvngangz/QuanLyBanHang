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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        // Val Global
        List<NhanVienDTO> ListNV = new List<NhanVienDTO>();
        List<UserNhanVien> listUser = new List<UserNhanVien>();
        NhanVienBLL _nhanvien = new NhanVienBLL();


        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThi(listUser, ListNV);
        }

        
        public void HienThi(List<UserNhanVien> listUser, List<NhanVienDTO> ListNV)
        {
            Loading(listUser, ListNV);
            Display(listUser);
        }


        public void Loading(List<UserNhanVien> listUser, List<NhanVienDTO> ListNV)
        {

            ListNV = _nhanvien.LoadingNhanVien();
            CreateUser(listUser, ListNV);
        }
        public void Display(List<UserNhanVien> listUser)
        {
            flowPanelNV.Controls.Clear();
            for (int i = 0; i < listUser.Count; i++)
            {
                flowPanelNV.Controls.Add(listUser[i]);
            }
            
        }
        public void CreateUser(List<UserNhanVien> listUser, List<NhanVienDTO> ListNV)
        {
            foreach (NhanVienDTO items in ListNV)
            {
                UserNhanVien user = new UserNhanVien();
                if (items.HinhAnh == "") items.HinhAnh = "Default_User_Logo.jpg";
                user.UpdateEventHandler += User_UpdateEventHandler;
                user.Ten = items.TenNV;
                user.Ma = items.MaNV;
                user.DiaChi = items.DiaChi;
                user.sdt = items.Sdt;
                user.Ngaysinh = items.NgaySinh;
                user.GioiTinh = items.GioiTinh;
                user.img = System.Drawing.Image.FromFile(Application.StartupPath + "\\Images\\" + items.HinhAnh);
                listUser.Add(user);

            }
        }
        //Update infoNV
        private void User_UpdateEventHandler(object sender, UserNhanVien.UpdateHandler args)
        {

            List<NhanVienDTO> newListNV = new List<NhanVienDTO>();
            newListNV = _nhanvien.LoadingNhanVien();
            List<UserNhanVien> listAfterUp = new List<UserNhanVien>();
            HienThi(listAfterUp, newListNV);
        }

        // tim kiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenNV;
            tenNV = tbTimKiem.Text;
            List<NhanVienDTO> ListNV = new List<NhanVienDTO>();
            List<UserNhanVien> NV = new List<UserNhanVien>();
            ListNV =   _nhanvien.TimKiemNV(tenNV);
            CreateUser(NV, ListNV);
            Display(NV);
                     
        }

        // show all
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Display(listUser);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            List<UserNhanVien> NV = new List<UserNhanVien>();
            List<NhanVienDTO> ListNV = new List<NhanVienDTO>();
            ListNV = _nhanvien.FillNhanVien_Ten();
            FillNewList(NV, ListNV);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            List<UserNhanVien> NV = new List<UserNhanVien>();
            List<NhanVienDTO> ListNV = new List<NhanVienDTO>();
            ListNV = _nhanvien.FillNhanVien_GioiTinh("Nam");
            FillNewList(NV, ListNV);
        }
        public void FillNewList(List<UserNhanVien> NV, List<NhanVienDTO> ListNV)
        {
           
            CreateUser(NV, ListNV);
            Display(NV);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            List<UserNhanVien> NV = new List<UserNhanVien>();
            List<NhanVienDTO> ListNV = new List<NhanVienDTO>();
            ListNV = _nhanvien.FillNhanVien_GioiTinh("Nữ");
            FillNewList(NV, ListNV);
        }

        // open Form Add
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            AddNhanVien frm = new AddNhanVien();
            frm.UpdateHandlerEvent += Frm_UpdateHandlerEvent;
            CheckFormIsOpen("AddNhanVien",frm);
        }

        private void Frm_UpdateHandlerEvent(object sender, AddNhanVien.UpdateData args)
        {

            List<NhanVienDTO> newListNV = new List<NhanVienDTO>();
            newListNV = _nhanvien.LoadingNhanVien();
            List<UserNhanVien> listAfterUp = new List<UserNhanVien>();
            HienThi(listAfterUp, newListNV);
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

    
    }
}
