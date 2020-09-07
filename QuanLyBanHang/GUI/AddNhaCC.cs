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
    public partial class AddNhaCC : Form
    {
        public AddNhaCC()
        {
            InitializeComponent();
        }
        //Val Global
        NhaCungCapBLL _addNCC = new NhaCungCapBLL();
       
        //Event delegate
        public delegate void UpdateHandler(object sender , UpdateHandlerClass args);
        public event UpdateHandler UpdateEvent;
        public class UpdateHandlerClass:EventArgs
        {
            string data { get; set; }
        }
        public void Update()
        {
            UpdateHandlerClass args = new UpdateHandlerClass();
            UpdateEvent.Invoke(this, args);
        }
        // add NCC
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string ten, ma, diachi, sdt, hinhanh, hang;
            ten = tbAddTEn.Text;
            ma = tbMaNCC.Text;
            diachi = tbDiachi.Text;
            sdt = tbSdt.Text;
            hang = tbHang.Text;
            if(hang =="Adidas")
            {
                hinhanh = "adidas-3-la.jpg";
            }else if(hang =="Nike")
            {
                hinhanh = "icons8-nike-50.png";
            }else
            {
                hinhanh = "logo_converse.png";
            }
            NhaCungCapDTO NCC = new NhaCungCapDTO(ma,ten,diachi,sdt,hang,hinhanh);
             if(_addNCC.insertNCC(NCC))
            {
                MessageBox.Show("Insert Success");
                Update();
            }
            else
            {
                MessageBox.Show("Insert Fail!");
            }

        }

      
        //private void picAddImg_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog oFile = new OpenFileDialog();
        //    oFile.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
        //    if(oFile.ShowDialog() == DialogResult.OK)
        //    {
        //        img = System.IO.Path.GetFileName(oFile.FileName);           
        //        path = oFile.FileName;
        //        File.Copy(path, Path.Combine(@"C:\Users\tuann\OneDrive\Desktop\BanHang-1\GUI\Images\", Path.GetFileName(path)), true);
        //    }    

        //}
    }
    
}
