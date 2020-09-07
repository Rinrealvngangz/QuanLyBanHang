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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        int ngay, thang, nam;
        bool kiemtraDay = false;
        bool kiemtraMonth = false;
        bool kiemtraYear = false;
        NhanVienBLL _addNV = new NhanVienBLL();
        AccountBLL _accBll = new AccountBLL();
       
        private void SignUp_Load(object sender, EventArgs e)
        {

        }
     
        public void FillAccount()
        {
            string userName, pass, manv, role;

            if (tbMaNV.Text.StartsWith(" ") || tbPassWord.Text.StartsWith(" ") || tbUsser.Text.StartsWith(" "))
            {
                MessageBox.Show("Bạn Chưa Điền đủ thông tin");
            }
            else
            {
                userName = tbUsser.Text;
                pass = tbPassWord.Text;
                manv = tbMaNV.Text;
                role = "User";
                DTO.Account acc = new DTO.Account(userName, pass, role, manv);
                _accBll.AddUser(acc);
          
            }
        }
        public void AddNhanVien()
        {
            string ten, ma, sdt, diachi, gioiTinh;
            DateTime ngaysinh;
            ma = tbMaNV.Text;
            ten = tbFullName.Text;
            sdt = tbSDT.Text;
            diachi = tbDiachi.Text;

            if (tbNgay.Text == "" || tbThang.Text == "" || tbNam.Text == "")
            {
                MessageBox.Show("Điên Đây Đủ Thông tin");
            }
            else
            {
                kiemtraDay = Int32.TryParse(tbNgay.Text, out ngay);
                kiemtraMonth = Int32.TryParse(tbThang.Text, out thang);
                kiemtraYear = Int32.TryParse(tbNam.Text, out nam);

                if (!kiemtraDay || !kiemtraMonth || !kiemtraYear)
                {
                    if (MessageBox.Show("Không Nhập Chữ", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        MessageBox.Show("Nhập lại Ngày sinh");
                    }
                }
                else
                {
                    if (radioNam.Checked)
                    {
                        gioiTinh = "Nam";
                    }
                    else
                    {
                        gioiTinh = "Nữ";
                    }

                    ngaysinh = DateTime.Parse(ngay.ToString() + "/" + thang.ToString() + "/" + nam.ToString());
                    NhanVienDTO nv = new NhanVienDTO(ma, ten, gioiTinh, diachi, sdt, ngaysinh);

                    if (_addNV.ThemNVNoImage(nv))
                    {
                        FillAccount();
                        MessageBox.Show("Tạo Tài Khoản Thành công success");
                        Form frm = this as Form;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Nhân Viên Fail,Xem Lại Mã NV", "Thông Báo", MessageBoxButtons.OK);
                    }
                }

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AddNhanVien();
          

        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnName);
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnUser);
        }

        private void tbPassWord_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnPass);
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnMaNV);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnDiachi);
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pnSDT);
        }

        private void tbNgay_TextChanged(object sender, EventArgs e)
        {
            tranShow.ShowSync(pndate);
        }
    }
}
