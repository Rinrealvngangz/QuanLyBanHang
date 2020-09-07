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
    public partial class sanPham : Form
    {
     
        public sanPham(string user,string pass)
        {
            InitializeComponent();

            
            
            username = user;
            passuser = pass;
            acc = _accBll.CheckAccCountUser(username,passuser);

            foreach (DTO.Account items in acc)
            {
                this.role = items.Role;
            }
         
            if (this.role.StartsWith("Admin"))
            {
                TenNV = "Admin";
                Hinhanh = "Default_User_Logo.jpg";
                lbNV.Text = TenNV;
                avatarNV.Image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Images\\" + Hinhanh);
            }else
            {
                nv = _nvBll.FillNameAndImage(user);

                foreach (NhanVienDTO items in nv)
                {

                    if (items.HinhAnh == "")
                        items.HinhAnh = "Default_User_Logo.jpg";

                    TenNV = items.TenNV;
                    Hinhanh = items.HinhAnh;
                }
                lbNV.Text = TenNV;
                avatarNV.Image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Images\\" + Hinhanh);

            }


        }
        List<NhanVienDTO> nv = new List<NhanVienDTO>();
        NhanVienBLL _nvBll = new NhanVienBLL();
        List<DTO.Account> acc = new List<DTO.Account>();
        AccountBLL _accBll = new AccountBLL();
        public string username { get; set; }
        public string passuser { get; set; }
        public string TenNV { get; set; }
        public string role { get; set; }
        public string Hinhanh { get; set; }
        //Val Global
        GioHangfrm frm = null;
        SanPhamBLL DataSanPham = new SanPhamBLL();// Data San Pham    
        List<SanPham> Listsp = new List<SanPham>(); // List San Pham
        List<SanPham> ListFill = new List<SanPham>(); // List San Pham Fill theo Hang
        List<Hang> ListTenHang = new List<Hang>();
        List<ThongTinSPDTO> listInfoSize = new List<ThongTinSPDTO>();
        string dongiaG;
        string maspG, soluongG, tenspG;
        string sizeG,colorG;

        // Loading Data
     
  
        // GUI -------------------------------------------

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if( tenspG ==null && maspG==null && dongiaG==null && soluongG==null)
            {
                MessageBox.Show("Bạn chưa Chon Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK);
            }

            else
            {
                EditSanPham frm = new EditSanPham();
                frm.UpdateDataGvHandler += Frm_UpdateDataGvHandler;
                frm.setData(tenspG, maspG, dongiaG, soluongG);
                CheckFormIsOpen("EditSanPham", frm);        
                
            }
         

        }

        private void Frm_UpdateDataGvHandler(object sender, EditSanPham.UpdateDataGv args)
        {                    
           gvSanPham.Rows.Clear();
            LoadingSanPham(Listsp);
            tbTen.Text = args.tensp;
            tbSoLuong.Text = args.soLuong;
            tbPrice.Text = args.gia;
            
            
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
                transitionShow.ShowSync(frm);

        }
   
        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            if (tenspG == null && maspG == null && dongiaG == null && soluongG == null)
            {
                MessageBox.Show("Bạn chưa Chon Sản Phẩm!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                transitionShow.ShowSync(panelSize_Color);
            }    
        

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            transitionHide.HideSync(panelSize_Color);
        }
        //-----------------------------------------------------------------------------////

        // connect BLL ----------------------------------------
        private void sanPham_Load(object sender, EventArgs e)
        {
           
            LoadingSanPham(Listsp);     
             addBinding();
          
        }
       
        public void DisplayGUI(List<SanPham> ListSP)          
        {

            int i = 0;//Val Count 
           gvSanPham.Rows.Clear();
             foreach (SanPham items in ListSP)
             {

                 gvSanPham.Rows.Add();
                 if (items.Img == "")
                     items.Img = "Default_User_Logo.jpg";

                 gvSanPham.Rows[i].Cells[0].Value = System.Drawing.Image.FromFile(Application.StartupPath + "\\Images\\" + items.Img);
                 gvSanPham.Rows[i].Cells[1].Value = items.MaSP;
                 gvSanPham.Rows[i].Cells[2].Value = items.TenSP;
                 gvSanPham.Rows[i].Cells[3].Value = items.DonGia;
                 gvSanPham.Rows[i].Cells[4].Value = items.SoLuong;
                 //       gvSanPham.Rows[i].Cells[5].Value = items.MaHang;
                 i++;
             }
          
        }
        // Loading SanPham
        public void LoadingSanPham(List<SanPham> ListSP)
        {
          
           ListSP = DataSanPham.LoadingSanPham();
            DisplayGUI(ListSP);
        }
      

      
        //Loading Size
        public void LoadingSize_CB()
        {

            listInfoSize = DataSanPham.LoadingSizeTheoMa(maspG);

            cbListSize.DataSource = listInfoSize;
            cbListSize.DisplayMember = "Size";
        }
        // Sự Kiện Khi click gv

        private void gvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = gvSanPham.Rows[e.RowIndex];

            tenspG = row.Cells[2].Value + "";
            maspG = row.Cells[1].Value.ToString();
            dongiaG = row.Cells[3].Value.ToString();
            soluongG = row.Cells[4].Value.ToString();
         
          
            //hien thi len cbSize
            LoadingSize_CB();

            //hien thi so luong,gia
            tbTen.Text = tenspG;
            tbSoLuong.Text = soluongG;
            tbPrice.Text = dongiaG;

        }

    
        private void AddSoLuong_Click(object sender, EventArgs e)
        {
            int soluong=0;
               
            if(tbSoLuong.Text =="")
            {
                MessageBox.Show("Chưa Chọn Sản Phẩm");
            }
            else
            {
                soluong = int.Parse(tbSoLuong.Text);
                int t = int.Parse(soluongG);
                while (soluong < t)
                {
                    soluong += 1;
                    break;
                }
                tbSoLuong.Text = soluong.ToString();

            }

        }

        private void minusSoLuong_Click(object sender, EventArgs e)
        {
            int soluong =0 ;

            if (tbSoLuong.Text == "")
            {
                MessageBox.Show("Chưa Chọn Sản Phẩm");
            }
            else
            {
                soluong = int.Parse(tbSoLuong.Text);
                while (soluong > 0)
                {
                    soluong -= 1;
                    break;
                }
                tbSoLuong.Text = soluong.ToString();
            }
          

        }

   
        // Lấy Color Theo Size
        private void cbListSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbListSize.SelectedValue != null)
            {
                ThongTinSPDTO items = cbListSize.SelectedValue as ThongTinSPDTO;
                List<ThongTinSPDTO> listColor;
                listColor = LoadingColorTheoMa(items);
                cbListColor.DataSource = listColor;
                cbListColor.DisplayMember = "Color";
               
            }
        }

        public List<ThongTinSPDTO> LoadingColorTheoMa(ThongTinSPDTO items)
        {
            string  Size;
            Size = items.Size;
            sizeG = Size;
          return   DataSanPham.LoadingColorTheoMa(maspG,Size);

        }
    

     

        // reloading Data San Pham
        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            gvSanPham.Rows.Clear();
             LoadingSanPham(Listsp);       
        }

        public void  DisplayDateTime()
        {
            DateTime date = DateTime.Now;
            label1.Text = date.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayDateTime();
        }

        // Tìm Kiếm Sản Phẩm
        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            List<SanPham> listTimkiem =new List<SanPham>();
            if(tbTimKiem.Text =="")
            {
                MessageBox.Show("Nhập tên cần tìm!");
            }else
            {
                string tensp = tbTimKiem.Text;
                listTimkiem = DataSanPham.TimKiemSP(tensp);
                tbTimKiem.Text = "";
                DisplayGUI(listTimkiem);
            }    
        }

        // Tinh gia San Pham voi so Luong
        tinhToan tinhGia = new tinhToan();


        // Lay Value Colo
        private void cbListColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListColor.SelectedItem != null)
            {
                ThongTinSPDTO ttsp = cbListColor.SelectedValue as ThongTinSPDTO;
                colorG = ttsp.Color;
            }

        }
        // delegate
        public delegate void UpdateHandler(object sender, UpdateHandlerClass args);
        public event UpdateHandler UpdateHandlerEvent;

        public class  UpdateHandlerClass
        {
            public string data { get; set; }
        }
        public void UpdateGioHangHadler()
        {
            UpdateHandlerClass args = new UpdateHandlerClass();
            UpdateHandlerEvent.Invoke(this, args);
        }
        // Open Form Gio Hang
     
  
        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            frm = new GioHangfrm();
            frm.LayDataFormMain(lbNV.Text);
           
            CheckFormIsOpen("GioHangfrm", frm);
        }

        //add Shoping Cart

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            int PriceG;
            string sL, tensp, masp, colorsp, sizesp;

            if (tbPrice.Text == "" || tbTen.Text.StartsWith(" ") ||colorG ==null ||sizeG ==null)
            {
                MessageBox.Show("Điền đầy đủ Thông tin");
            }
            else
            {  if(cbListColor.Items.Count >0 && cbListSize.Items.Count >0)
                {
                    List<CartGioHang> newlistUser = new List<CartGioHang>();
                    List<GioHang> newListGH = new List<GioHang>();
                    PriceG = int.Parse(tbPrice.Text);
                    sL = tbSoLuong.Text;
                    tensp = tbTen.Text;
                    masp = maspG;
                    colorsp = colorG;
                    sizesp = sizeG;
                    GioHang sp = new GioHang(masp, tensp, PriceG, sL, colorsp, sizesp);
                    newListGH.Add(sp);

                    if (DataSanPham.Them_GioHang(sp))
                    {

                        MessageBox.Show("Thêm Success,Kiểm tra Giỏ hàng");
                        if (frm == null)
                        {
                            frm = new GioHangfrm();

                        }
                        frm.HienThi(newlistUser, newListGH);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Size và Color chưa có ");
                }
             
            }
          
        }
        // hiển thị kho
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            HienThiKho frmKho = new HienThiKho();
            frmKho.UpdateHandlerEvent += FrmKho_UpdateHandlerEvent;
            CheckFormIsOpen("HienThiKho", frmKho);
        }

        private void FrmKho_UpdateHandlerEvent(object sender)
        {
            LoadingSanPham(Listsp);
        }

        public void addBinding()
        {
            Binding dataBindings = new Binding("Text", tinhGia, "TongGia", true, DataSourceUpdateMode.OnPropertyChanged);
            tbPrice.DataBindings.Add(dataBindings);
         
        }
        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            int sl, totalPrice,Price;

            if (tbSoLuong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = int.Parse(tbSoLuong.Text);
               
            }
            Price = int.Parse(dongiaG);
            totalPrice = sl * Price;
            tinhGia.TongGia = totalPrice.ToString();
        }

        // Thêm Color Size Cho Sản Phẩm
        private void iconAdd_Click(object sender, EventArgs e)
        {
            string Masp, size, color;
            int dem,soluong;
               size  =  tbSize.Text;
               color =  tbColor.Text;
               Masp = maspG;      
            dem = DataSanPham.DemSLTTSP(Masp);
            soluong = int.Parse(soluongG);

                if (dem >= soluong)
                {
                    MessageBox.Show("Đã Vượt quá số Lượng Sản Phẩm!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {

                    ThongTinSPDTO listinfo = new ThongTinSPDTO(Masp, color, size);
                    if (DataSanPham.ThemSize_Color(listinfo))
                    {

                        MessageBox.Show("Update Success");
                        LoadingSize_CB();
                    }
                    else
                        MessageBox.Show("Update Fail");
                    ;
                }

            }



        }
    }


