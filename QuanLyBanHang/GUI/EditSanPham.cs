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
    public partial class EditSanPham : Form
    {
        public EditSanPham()
        {
            InitializeComponent();
        }
        // Valribel global
        SanPhamBLL spbll = new SanPhamBLL();
        string img;
        string PathImg;
        string MaspG;
      

        private void EditSanPham_Load(object sender, EventArgs e)
        {
            
        }
       
        // Update Image Form File
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {

            OpenFileDialog oFile = new OpenFileDialog();
            openFileImage.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            
            if (oFile.ShowDialog() == DialogResult.OK)
            {
              
                img = System.IO.Path.GetFileName("@"+oFile.FileName);
              
                PathImg = oFile.FileName;           
            }

            if (spbll.UpdateHinhAnh(img, MaspG))
            {
                MessageBox.Show("Update Image success");

                File.Copy(PathImg, Path.Combine(Application.StartupPath + "\\Images\\", Path.GetFileName(PathImg)), true);
                Update();
            }
            else
                MessageBox.Show("Update Image fail");

        }
          
        // Event delegate 
        public delegate void ReloadingGV(object sender , UpdateDataGv args);

        public event ReloadingGV UpdateDataGvHandler;

        public class UpdateDataGv : EventArgs
        {
            public string tensp { get; set; }
            public string soLuong { get; set; }
            public string gia { get; set; }
         

        }
        
        // auto refesh after UPdate and Delele
        public void Update()
        {
            
            UpdateDataGv args = new UpdateDataGv();
            args.tensp = tbTen.Text;
            args.gia = tbGia.Text;
            args.soLuong = tbSoLuong.Text;
            UpdateDataGvHandler.Invoke(this, args);

        }
        public void Delete()
        {

            UpdateDataGv args = new UpdateDataGv();
            string ten = ""; tbTen.Text = "";
            string gia = ""; tbGia.Text = "";
            string soluong = ""; tbSoLuong.Text = "";
            args.tensp = ten;
            args.gia = gia;
            args.soLuong = soluong;
            UpdateDataGvHandler.Invoke(this, args);

        }

        // Update San Pham
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            string masp, tensp;
            int soluong, dongia;
            masp = MaspG;
            tensp = tbTen.Text;
            if(tbSoLuong.Text ==""|| tbGia.Text == "")
              {

                MessageBox.Show("Phải điền Đầy đủ Thông Tin","Thông Báo",MessageBoxButtons.OK);
               
            }else
            {
                soluong = int.Parse(tbSoLuong.Text);
                dongia = int.Parse(tbGia.Text);

                SanPham sp = new SanPham(masp, tensp, dongia, soluong);
                if (spbll.UpdateSanPham(sp))
                {
                    MessageBox.Show("Update Sucess");
                    Update();
                }
                else
                    MessageBox.Show("Update Fail");
            }    
         
           
        }
       
        public void setData(string tensp,string masp, string dongia,string soluong)
        {
            
            MaspG = masp;
            tbTen.Text = tensp;
            tbGia.Text = dongia;
            tbSoLuong.Text = soluong;
          
        }
        
        // delete SanPham
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try {
                spbll.DeleteSanPham(MaspG);
                MessageBox.Show("Delete Success");
             
                Delete();
                 tbTen.Text = "";
                 tbGia.Text = "";
                tbSoLuong.Text = "";

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    
}
