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
using BLL;
using DTO;
namespace GUI
{
    public partial class AddNhanVien : Form
    {
        public AddNhanVien()
        {
            InitializeComponent();
        }
        //Val global
        string img="",path;
        int ngay,thang,nam;
        bool kiemtraDay = false;
        bool kiemtraMonth = false;
        bool kiemtraYear = false;
        NhanVienBLL _addNV = new NhanVienBLL();
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            string ten, ma, sdt, diachi, gioiTinh;
            DateTime ngaysinh;
            ma = tbMa.Text;
            ten = tbTen.Text;
            sdt = tbPhone.Text;
            diachi = tbDiaChi.Text;
        
            if (tbNgay.Text == ""|| tbThang.Text =="" || tbNam.Text =="")
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
                   if(MessageBox.Show("Không Nhập Chữ","Thông báo",MessageBoxButtons.OK) ==DialogResult.OK)
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

                    ngaysinh = DateTime.Parse(ngay.ToString()+"/"+thang.ToString()+"/"+nam.ToString());
                    NhanVienDTO nv = new NhanVienDTO(ma, ten, gioiTinh, diachi, sdt, ngaysinh, img);

                    if (_addNV.ThemNV(nv))
                    {
                        MessageBox.Show("Thêm Nhân Viên success");
                        UpdateDataNV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Nhân Viên Fail,Xem Lại Mã NV","Thông Báo",MessageBoxButtons.OK);
                    }
                }
            
            }
        


        }
        // Event Delegate Img
        public delegate void UpdateHandler(object sender, UpdateData args);
        public event UpdateHandler UpdateHandlerEvent;
        public class UpdateData : EventArgs
        {
            public string data { get; set; }

        }
        public void UpdateDataNV()
        {
            UpdateData args = new UpdateData();
            UpdateHandlerEvent.Invoke(this, args);
        }
        private void AddAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Tap tin .png|*.png|.jpg|*.jpg|Tat ca |*.*";


            if (oFile.ShowDialog() == DialogResult.OK)
            {
                img = Path.GetFileName(oFile.FileName);
                path = oFile.FileName;
                File.Copy(path, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(path)), true);
                picAvaTar.Image = Image.FromFile(Application.StartupPath + "\\Images\\" + img);
               
          

            }
  

        }
    }
}
