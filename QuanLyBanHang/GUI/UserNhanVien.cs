using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class UserNhanVien : UserControl
    {
        public UserNhanVien()
        {
            InitializeComponent();
        }

        NhanVienBLL editNV = new NhanVienBLL();

        private string _Ten;

        private string _Ma;

        private string _DiaChi;

        private string _GioiTinh;

        private string _Sdt;

        private DateTime _ngaysinh;

        private Image _img;



        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; lbTen.Text = value; }

        }

        public string Ma
        {
            get { return _Ma; }
            set { _Ma = value; lbMa.Text = value; }

        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; lbDiaChiNV.Text = value; }

        }

        public string sdt
        {
            get { return _Sdt; }
            set { _Sdt = value; lbsdtNV.Text = value; }

        }

      
        public Image img
        {
            get { return _img; }
            set { _img = value; pictuteImage.Image = value; }

        }

        public string GioiTinh { get { return _GioiTinh; } set { _GioiTinh = value; lbGioiTinh.Text = value; } }

        public DateTime Ngaysinh { get => _ngaysinh; set { _ngaysinh = value; lbNgaySinh.Text = value.ToString(); } }


        //Event deletegate
        public delegate void UpdateEvent(object sender, UpdateHandler args);
        public event UpdateEvent UpdateEventHandler;

        public class UpdateHandler : EventArgs
        {
            public string data { get; set; }
        }

        public void UpdateAndDelete()
        {
            UpdateHandler args = new UpdateHandler();
            UpdateEventHandler.Invoke(this, args);
        }
      

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditNhanVien frmNhanVien = new EditNhanVien();
            frmNhanVien.TranData(Ma ,Ten, sdt, DiaChi, GioiTinh,Ngaysinh);
            frmNhanVien.UpdateHandlerEvent += FrmNhanVien_UpdateHandlerEvent;
            CheckFormIsOpen("EditNhanVien", frmNhanVien);

        }

        private void FrmNhanVien_UpdateHandlerEvent(object sender, EditNhanVien.UpdateDataClass args)
        {
            MessageBox.Show("Update Success");
            UpdateAndDelete();
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
                tranShow.ShowSync(frm);

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {  
            if(MessageBox.Show("Bạn Có Muốn xóa ?","Thông Báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (editNV.DeleteNV(Ma))
                {
                    MessageBox.Show("Delete Success");
                    UpdateAndDelete();
                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }
            }
            return;

         
        }
    }
}
