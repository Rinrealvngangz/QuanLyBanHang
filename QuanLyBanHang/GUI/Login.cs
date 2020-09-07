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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AccountBLL AccountLogin = new AccountBLL();
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnUser);
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnPass);
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

            string userName = tbUserName.Text;
            string passWord = tbPassWord.Text;
            if (AccountLogin.LoadingAcount(userName, passWord))
            {
                Form frm = this as Form;
                frm.Hide();
                container(new Loading(userName,passWord));
            }
            else
                MessageBox.Show("Login Fail", "Thong Bao", MessageBoxButtons.OK);
        }

        private void container(object _from)
        {

            Form frm = _from as Form;
            frm.Show();

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            CheckFormIsOpen("SingUp", frm);
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
                transitionShow.ShowSync(frm);

        }
    }
}
