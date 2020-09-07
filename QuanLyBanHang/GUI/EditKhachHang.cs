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
    public partial class EditKhachHang : Form
    {
        public EditKhachHang()
        {
            InitializeComponent();
        }
        KhachHangBLL _EditKH = new KhachHangBLL();

        //Delegate

        public delegate void UpdateHandler(object sender, UpdateHandlerClass args);
        public event UpdateHandler UpdateHandlerEvent;

        public class UpdateHandlerClass: EventArgs
        {
            string data { get; set; }
        }

         public void UpdateData()
        {
            UpdateHandlerClass args = new UpdateHandlerClass();
            UpdateHandlerEvent.Invoke(this, args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ten, ma, diachi,ngaymua;
            int sdt;
            ten = tbTen.Text;
            ma = tbMa.Text;
            diachi = tbDiachi.Text;
            ngaymua = DateTime.Now.ToString();
            if(tbSDT.Text =="")
            {
                MessageBox.Show("Điền đầy đủ thông tin");
            }
            else
            {
                sdt = int.Parse(tbSDT.Text);
                KhachHangDTO KH = new KhachHangDTO(ma,ten,diachi,sdt,ngaymua);
                if (_EditKH.InsertKH(KH))
                  {
                    MessageBox.Show("Thêm Khách hàng Success");
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Thêm Khách hàng Fail");
                }

            }
         
        }
    }
}
