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
    public partial class Form1 : Form
    {
      
        public Form1(string user,string pass)
        {
            InitializeComponent();
            username = user;
            passuser = pass;
            acc = _accBll.CheckAccCountUser(username, passuser);
        
        
            foreach (DTO.Account items in acc)
            {
                this.role = items.Role;
            }
        }
        AccountBLL _accBll = new AccountBLL();
     
        List<DTO.Account> acc = new List<DTO.Account>();
    
        public string role { get; set; }
        public string username { get; set; }
        public string passuser { get; set; }
        public string TenNV { get; set; }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            container(new sanPham(username,passuser));
        }
        private void container( object _from)
        {
            if (panelContainer.Controls.Count > 0) panelContainer.Controls.Clear();
            
                Form frm = _from as Form;
               frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(frm);
                frm.Show();       
            
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
          
            container(new Kho());
          
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            container(new NhaCungCap());
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

            if (this.role.StartsWith("Admin"))
            {
                container(new NhanVien());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập");
            }


        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            container(new KhachHang());
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            container(new ThongKe());
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            container(new HoaDon());
        }
       
        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
          
            if(this.role.StartsWith("Admin"))
            {
                container(new Account());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập");
            }
         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = this as Form;
            frm.Close();
            Login frmlogin = new Login();
            frmlogin.Show();
        }
    }
}
