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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        // Val Global
        NhaCungCapBLL _nhaCungCap = new NhaCungCapBLL();
        List<NhaCungCapDTO> ListNCC = new List<NhaCungCapDTO>();
        List<UserNCC> listUser = new List<UserNCC>();
        string count;
        // Loading Form
        private void NhaCungCap_Load(object sender, EventArgs e)
        {

            HienThi(listUser, ListNCC);
         
        }

        public void HienThi(List<UserNCC> listUser, List<NhaCungCapDTO> ListNCC)
        {
            Loading(listUser, ListNCC);
            Display(listUser);
        }
      
       
        public void Loading(List<UserNCC> listUser,List<NhaCungCapDTO> ListNCC)
        {         
                     
            ListNCC = _nhaCungCap.LoadingNCC();
            CreateUser(listUser,ListNCC);
        }
        //Tao User 
        public void CreateUser(List<UserNCC> listUser,List<NhaCungCapDTO> ListNCC)
        {
            foreach (NhaCungCapDTO items in ListNCC)
            {
                UserNCC user = new UserNCC();
                if (items.HinhAnh == "") items.HinhAnh = "Default_User_Logo.jpg";

                user.UpdateEventHandler += User_UpdateEventHandler;
                user.Ten = items.TenNCC;
                user.Ma = items.MaNCC;
                user.DiaChi = items.DiaChi;
                user.sdt = items.Sdt;
                user.Hang = items.Hang;
                user.img = System.Drawing.Image.FromFile(Application.StartupPath +"\\Images\\"+ items.HinhAnh);
                listUser.Add(user);

            }
        }

        // Event Delegate
        private void User_UpdateEventHandler(object sender, UserNCC.UpdateHandler args)
        {
      
            List<NhaCungCapDTO> NewListNCC = new List<NhaCungCapDTO>();
            NewListNCC = _nhaCungCap.LoadingNCC();
            List<UserNCC> listAfterUp = new List<UserNCC>();
            HienThi(listAfterUp, NewListNCC);


        }
        private void Frm_UpdateEvent(object sender, AddNhaCC.UpdateHandlerClass args)
        {
            HienThi(listUser, ListNCC);
        }

        public void Display(List<UserNCC> listUser)
        {
            flowPanelNCC.Controls.Clear();
            for(int i=0;i< listUser.Count;i++)
            {
                flowPanelNCC.Controls.Add(listUser[i]);
            }
            count = listUser.Count.ToString();
            lbCount.Text = count;
        }

        // Tim kiem NCC
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string tenNCC = tbTimKiem.Text;
            List<NhaCungCapDTO> ListTK = new List<NhaCungCapDTO>();
            List<UserNCC> listTKUser = new List<UserNCC>();
            ListTK = _nhaCungCap.TimkiemNCC(tenNCC);
            CreateUser(listTKUser, ListTK);
            Display(listTKUser);

        }
       
       
        // Thêm NCC
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            AddNhaCC frm = new AddNhaCC();
            frm.UpdateEvent += Frm_UpdateEvent;
            CheckFormIsOpen("AddNhaCC", frm);
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

        //Display Nike
        public void FillTheoHang(string hang)
        {
            List<NhaCungCapDTO> ListTK = new List<NhaCungCapDTO>();
            List<UserNCC> listTKUser = new List<UserNCC>();
            ListTK = _nhaCungCap.FillNCCTheo_Hang(hang);
            CreateUser(listTKUser, ListTK);
            Display(listTKUser);
        }
        private void btnNike_Click(object sender, EventArgs e)
        {
            FillTheoHang("Nike");
        }

        //Display Adidas
        private void btnAdidas_Click(object sender, EventArgs e)
        {
            FillTheoHang("Adidas");
        }

        //Displat Converse
        private void btnCV_Click(object sender, EventArgs e)
        {
            FillTheoHang("Converse");
        }

        // Show All
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Display(listUser);
        }

      
    }
}
