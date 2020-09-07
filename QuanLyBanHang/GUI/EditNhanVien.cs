using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;
using BLL;
namespace GUI
{
    public partial class EditNhanVien : Form
    {
        public EditNhanVien()
        {
            InitializeComponent();
        }
        //Val Global
        string MaNV;
        string img, path;
        NhanVienBLL _NVBLL = new NhanVienBLL();
        AccountBLL _accbll = new AccountBLL();
        List<DTO.Account> listAcc = new List<DTO.Account>();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
           Form frm  = this as Form;
            frm.Close();
        }


        //Event Delegate 
        public delegate void UpdateHandler(object sender, UpdateDataClass args);
        public event UpdateHandler UpdateHandlerEvent;
        public class UpdateDataClass : EventArgs
        {
            public string data { get; set; }
           
        }

        public void UpdateAndDel()
        {
            UpdateDataClass args = new UpdateDataClass();
            UpdateHandlerEvent.Invoke(this, args);
        }

        // Update NV
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ten = tbTen.Text;
            string sdt = tbPhone.Text;
            string Diachi = tbDiaChi.Text;
            string gioiTinh;
            DateTime ngaysinh = DateTime.Parse(tbNgaySinh.Text);
            if(radioNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }    
            NhanVienDTO nv = new NhanVienDTO(MaNV,ten,gioiTinh,Diachi,sdt,ngaysinh);

            if(_NVBLL.UpdateNV(nv))
            {
              
                UpdateAndDel();

            }
            else
            {
                MessageBox.Show("Update Fail!");
            }    
        }
        public void TranData(string maNV ,string ten , string sdt, string diachi , string gioitinh,DateTime ngaysinh)
        {
            MaNV = maNV;
            tbTen.Text = ten;
            tbPhone.Text = sdt;
            tbDiaChi.Text = diachi;
            tbNgaySinh.Text = ngaysinh.ToString();
             if(gioitinh.Contains("Na"))
            {
                
                radioNam.Checked=true;
            }
            else
            {
                radioNu.Checked = true;
               
            }
       
        }
        // upAccount
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string userName, pass;

            if (tbUser.Text.StartsWith(" ") || tbPass.Text.StartsWith(" "))
            {
                MessageBox.Show("Bạn Chưa Điền đủ thông tin");
            }
            else
            {
                userName = tbUser.Text;
                pass = tbPass.Text;
               
                if (_accbll.UpAcount(userName, pass,MaNV ))
                {
                    MessageBox.Show("Update Success");
                    tbUser.Text = userName;
                    tbPass.Text = pass;

                }
                else
                {
                    MessageBox.Show("Update Fail!");
                }
            }
        }

        public void loadingAcc()
        {

            listAcc = _accbll.LoadingAccCountUser(MaNV);
            foreach (DTO.Account acc in listAcc)
            {
                tbPass.Text = acc.PassWord;
                tbUser.Text = acc.UserName;
            }
        }

        private void EditNhanVien_Load(object sender, EventArgs e)
        {
            loadingAcc();
        
         }

        //Edit Image
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Tap tin .png|*.png|.jpg|*.jpg|Tat ca |*.*";


            if (oFile.ShowDialog() == DialogResult.OK)
            {
                img = Path.GetFileName(oFile.FileName);
                path = oFile.FileName;
                if (_NVBLL.UpdateAvatar_NV(MaNV, img))
                {
                    File.Copy(path, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(path)), true);
                    picImage.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + img);

                    UpdateAndDel();
                }
                else
                {
                    MessageBox.Show("Đã có tên Image trùng", "Thông Báo", MessageBoxButtons.OK);
                }
            }
          

        
        }
     
    }
}
