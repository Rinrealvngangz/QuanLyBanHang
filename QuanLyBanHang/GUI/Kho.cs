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
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        //Variable Global 
        KhoBLL _khoBLL = new KhoBLL();
        NhaCungCapBLL _nhaCC = new NhaCungCapBLL();
        List<KhoDTO> ListKho = new List<KhoDTO>();
        List<NhaCungCapDTO> listNCC = new List<NhaCungCapDTO>();
        string maspG, tenspG, maNCCG;
        int soluongG;
        int dongiaG;
        DateTime ntn;
        private void Kho_Load(object sender, EventArgs e)
        {
            LoadingKho();
        
        }

        // GUI --------------------------------------------
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            tranShowTTNCC.ShowSync(pnTTNCC);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            tranHideTTNCC.HideSync(pnTTNCC);
        }

        // connect BLL ------------------------------------------

        // hien Thi Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tenspG == null && maspG == null && dongiaG == 0 && soluongG == 0 && maNCCG ==null)
            {
                MessageBox.Show("Bạn chưa Chon Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                EditKhoHang frmKhoHang = new EditKhoHang();
          
                frmKhoHang.UpdateHandler += FrmKhoHang_UpdateHandler;
                frmKhoHang.show(tenspG,maspG,soluongG,dongiaG,maNCCG);
                      
                CheckFormIsOpen("EditKhoHang", frmKhoHang);

            }
          
           
        }         
        private void FrmKhoHang_UpdateHandler(object sender, EditKhoHang.updateData args)
        {         
            LoadingKho();
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

                  tranShowUpdate.ShowSync(frm);
              //  frm.Show();
                

        }

        // Delete SP
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if( maspG == null)
            {
                MessageBox.Show("Bạn chưa Chon Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            { 
               if(MessageBox.Show("Bạn có chắc muốn xóa sp !", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_khoBLL.DeleteSPKho(maspG))
                    {

                        LoadingKho();
                        MessageBox.Show("Delete Success");
                    }
                }
                return;
            }
          
        }
        
        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            string tensp = tbTimKiem.Text;
            List<KhoDTO> listKhoTK = new List<KhoDTO>();
            if (tbTimKiem.Text == null) return;
            listKhoTK = _khoBLL.TimKiemSP_Kho(tensp);
            gvKho.DataSource = listKhoTK;
            
                
        }
        // Fill Sort MaSP
        private void btnFill_Click(object sender, EventArgs e)
        {
            List<KhoDTO> listFill = new List<KhoDTO>();
            listFill = _khoBLL.FillSP_Kho();
            gvKho.DataSource = listFill;
        }

        // Fill SP Theo DateTime
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            List<KhoDTO> kho = new List<KhoDTO>();
            int ngay = _DateTimePicker.Value.Day;
            int thang = _DateTimePicker.Value.Month;
            int nam = _DateTimePicker.Value.Year;
            kho = _khoBLL.TimkiemSP_ngaynhap(ngay, thang, nam);
            gvKho.DataSource = kho;

        }
      
        public void LoadingKho()
        {
            ListKho = _khoBLL.LoadingKho();
            gvKho.DataSource = ListKho;
        }
        
        //Add SP Kho Hang
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            AddSPKhoHang frm = new AddSPKhoHang();
            frm.UpdateHandler += Frm_UpdateHandler;
            CheckFormIsOpen("AddSPKhoHang", frm);
        }

        private void Frm_UpdateHandler(object sender)
        {
            LoadingKho();
        }

        // Event Click gv

        private void gvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow Row = gvKho.Rows[e.RowIndex];

            tenspG = Row.Cells[0].Value.ToString();
            maspG = Row.Cells[1].Value.ToString();
            maNCCG = Row.Cells[2].Value.ToString();        
            dongiaG = int.Parse(Row.Cells[4].Value.ToString());
            soluongG = int.Parse(Row.Cells[3].Value.ToString());
            ntn = System.DateTime.Parse(Row.Cells[5].Value.ToString());
            LoadingNhaCC(maNCCG);
        }
        public void LoadingNhaCC(string maNCC)
        {
            listNCC = _nhaCC.LoadingNCC_Ma(maNCC);
            foreach(NhaCungCapDTO ncc in listNCC)
            {
                lbNCC.Text = ncc.TenNCC;
                lbHang.Text = ncc.Hang;
                lbSDT.Text = ncc.Sdt;
                lbDC.Text = ncc.DiaChi;
            }    
        }

    }
}
