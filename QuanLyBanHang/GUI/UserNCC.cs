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
    public partial class UserNCC : UserControl
    {
        public UserNCC()
        {
            InitializeComponent();
        }
        //val Global
        NhaCungCapBLL editNCC = new NhaCungCapBLL();
        private string _Ten;

        private string _Ma;

        private string _DiaChi;

        private string _Sdt;

        private string _Hang;

        private Image _img;

     

        public string Ten {
            get { return _Ten ; }
            set { _Ten = value; lbName.Text = value; } 
        
        }

        public string Ma
        {
            get { return _Ma; }
            set { _Ma = value; lbMa.Text = value; }

        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; lbDiaChi.Text = value; }

        }

        public string sdt
        {
            get { return _Sdt; }
            set { _Sdt = value; lbSdt.Text = value; }

        }

        public string Hang
        {
            get { return _Hang; }
            set { _Hang = value; lbHang.Text = value; }

        }

        public Image img
        {
            get { return _img; }
            set { _img = value; pictuteImage.Image = value; }

        }

       

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            trnShowEdit.ShowSync(pnshowEdit);
          
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
                tranShowNhaCC.ShowSync(frm);

        }

      
        // Open Form Edit
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            tranHideEdit.HideSync(pnshowEdit);
            EditNhaCC Ncc = new EditNhaCC();
            Ncc.LayData(Ten,DiaChi, sdt , Hang,Ma);
            Ncc.TranDataHandler += Ncc_TranDataHandler;
            Ncc.TranImageHandler += Ncc_TranImageHandler;
            CheckFormIsOpen("EditNhaCC", Ncc);
        }

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
        private void Ncc_TranImageHandler(object sender, EditNhaCC.TranImage args)
        {
            MessageBox.Show("Update Logo Success");
            UpdateAndDelete();
        }

        private void Ncc_TranDataHandler(object sender, EditNhaCC.TranDataClass args)
        {
            NhaCungCapDTO NCC = new NhaCungCapDTO(Ma,args.tenNCC,args.diaChi,args.sdt,args.hang);
            if(editNCC.UpdateNCC(NCC))
            {
                MessageBox.Show("Update Success");
                UpdateAndDelete();

            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }

     
       

        // Delete User
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa NCC ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (editNCC.DeleteNCC(Ma))
                {
                    MessageBox.Show("Delete Success");
                    UpdateAndDelete();
                }
                else
                {
                    MessageBox.Show("Delete Fail!");
                }
            }
            
                return;

        }

        
    }
}
