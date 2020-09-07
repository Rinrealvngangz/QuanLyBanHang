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
    public partial class Account : Form
    {
        BindingSource listBin = new BindingSource();

        public Account()
        {
            InitializeComponent();
            gvAcc.DataSource = listBin;
        }
        AccountBLL _accBll = new AccountBLL();
        List<DTO.Account> listacc = new List<DTO.Account>();
        private void Account_Load(object sender, EventArgs e)
        {
            LoadingAcc();
            AddBinding();
        }
        public void LoadingAcc()
        {
            listacc = _accBll.LoadingAccCount();
            listBin.DataSource = listacc;
        }
        public void AddBinding()
        {
            tbTen.DataBindings.Add(new Binding("Text", gvAcc.DataSource, "UserName"));
            tbMa.DataBindings.Add(new Binding("Text", gvAcc.DataSource, "MaUser"));
            tbPass.DataBindings.Add(new Binding("Text", gvAcc.DataSource, "PassWord"));

            tbRole.DataBindings.Add(new Binding("Text", gvAcc.DataSource, "Role"));


        }
        //Del
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string maNV = tbMa.Text;
            if (tbMa.Text == "")
            {
                MessageBox.Show("Bạn Chưa Điền Mã NV");

            }
            else
            {
                if (MessageBox.Show("Bạn có chắc xóa NCC ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (_accBll.DelAcount(maNV))
                    {
                        MessageBox.Show("Delete Success");
                        LoadingAcc();
                        tbMa.Text = "";
                        tbPass.Text = "";
                        tbRole.Text = "";
                        tbTen.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail!");
                    }
                }
            }


            return;
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string userName, pass, manv;

            if (tbMa.Text.StartsWith(" ") || tbPass.Text.StartsWith(" ") || tbTen.Text.StartsWith(" "))
            {
                MessageBox.Show("Bạn Chưa Điền đủ thông tin");
            }
            else
            {
                userName = tbTen.Text;
                pass = tbPass.Text;
                manv = tbMa.Text;
                if (_accBll.UpAcount(userName, pass, manv))
                {
                    MessageBox.Show("Update Success");
                    LoadingAcc();

                }
                else
                {
                    MessageBox.Show("Update Fail!");
                }
            }
        }

      

        // Timkiem acc
        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            string username = tbTimKiem.Text;
            List<DTO.Account> newlistAcc = new List<DTO.Account>();
            newlistAcc = _accBll.TimKiemAccCountUser(username);
            listBin.DataSource = newlistAcc;
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            string MaAcc;
            if (tbMa.Text.StartsWith(" "))
            {
                MessageBox.Show("Điền Mã muốn Xóa");
            }
            else
            {
                MaAcc = tbMa.Text;
                if (MessageBox.Show("Bạn Có Muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_accBll.DelAcount(MaAcc))
                    {
                        MessageBox.Show("Delete Success");
                        LoadingAcc();
                    }
                    else
                    {
                        MessageBox.Show("Delete Fail");
                    }
                }
            }

            return;
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            string userName, pass, manv;

            if (tbMa.Text.StartsWith(" ") || tbPass.Text.StartsWith(" ") || tbTen.Text.StartsWith(" "))
            {
                MessageBox.Show("Bạn Chưa Điền đủ thông tin");
            }
            else
            {
                userName = tbTen.Text;
                pass = tbPass.Text;
                manv = tbMa.Text;

                if (_accBll.UpAcount(userName, pass, manv))
                {
                    MessageBox.Show("Thêm  Success");
                    LoadingAcc();

                }
                else
                {
                    MessageBox.Show("Thêm Fail!");
                }
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            string userName, pass, manv, role;

            if (tbMa.Text.StartsWith(" ") || tbPass.Text.StartsWith(" ") || tbTen.Text.StartsWith(" ") || tbRole.Text.StartsWith(" "))
            {
                MessageBox.Show("Bạn Chưa Điền đủ thông tin");
            }
            else
            {
                userName = tbTen.Text;
                pass = tbPass.Text;
                manv = tbMa.Text;
                role = tbRole.Text;
                DTO.Account acc = new DTO.Account(userName, pass, role, manv);
                if (_accBll.AddUser(acc))
                {
                    MessageBox.Show("Thêm  Success");
                    LoadingAcc();

                }
                else
                {
                    MessageBox.Show("Thêm Fail!");
                }
            }
        }
    }
}
