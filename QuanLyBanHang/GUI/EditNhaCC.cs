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
namespace GUI
{
    public partial class EditNhaCC : Form
    {
        public EditNhaCC()
        {
            InitializeComponent();
        }
        // Val Global
        NhaCungCapBLL _editNCC = new NhaCungCapBLL();
        string _MaNCC;
        string img, path;
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "Tap tin .png|*.png|.jpg|*.jpg|Tat ca |*.*";
          

            if (oFile.ShowDialog() == DialogResult.OK)
            {
                img = Path.GetFileName(oFile.FileName);
                path = oFile.FileName;
            }
            if(_editNCC.UpdateLogo(img,_MaNCC))
            {
                File.Copy(path, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(path)), true);
               UpdateImage();
            }
            
        }

        // Update NCC
        //Event Delegate 
        public delegate void TranData(object sender, TranDataClass args);
        public event TranData TranDataHandler;
        public class TranDataClass : EventArgs
        {
           public string tenNCC { get; set; }
           public string diaChi { get; set; }
            public string sdt { get; set; }
            public string hang { get; set;  }
        }
        // Event Delegate Img
        public delegate void TranDataIMG(object sender, TranImage args);
        public event TranDataIMG TranImageHandler;
        public class TranImage : EventArgs
        {
            public string data { get; set; }
         
        }
        public void UpdateImage()
        {
            TranImage args = new TranImage();
            TranImageHandler.Invoke(this, args);
        }
        public void TruyenDataTextBox()
        {
            TranDataClass args = new TranDataClass();
            args.tenNCC = lbEditTenNCC.Text;
            args.diaChi = lbEditDiaChiNCC.Text;
            args.sdt = lbSdtNCC.Text;
            args.hang = lbEditHang.Text;
            TranDataHandler.Invoke(this, args);
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (lbEditTenNCC.Text == "" || lbEditDiaChiNCC.Text == "" || lbEditHang.Text == "" || lbSdtNCC.Text == "")
            {
                MessageBox.Show("Không được để trống các trường!");
            }
            else
            {

                TruyenDataTextBox();
            
            }

        }
        // hien Thi TextBox
        public void LayData(string ten ,string diachi ,string sdt ,string hang ,string maNCC)
        {
            lbEditTenNCC.Text = ten;
            lbEditDiaChiNCC.Text = diachi;
            lbSdtNCC.Text = sdt;
            lbEditHang.Text = hang;
            _MaNCC = maNCC;
        }
    }
}
