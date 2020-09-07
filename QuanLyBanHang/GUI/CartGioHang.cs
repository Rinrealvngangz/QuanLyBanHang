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

namespace GUI
{
    public partial class CartGioHang : UserControl
    {
        public CartGioHang()
        {
            InitializeComponent();
        }
        SanPhamBLL _spBll = new SanPhamBLL();
        private string _masp;
        private string _tensp;
        private string _size;
        private string _color;
        private string _soluong;
        private int _gia;

        public string Masp { get => _masp; set { _masp = value; lbeMa.Text = value; } }
        public string Tensp { get => _tensp; set {_tensp = value; lbeten.Text = value; }
    }
        public string Sizee { get => _size; set { _size = value; lbesize.Text = value; }
}
        public string Color { get => _color; set { _color = value; lbecolor.Text = value; }}
        public string Soluong { get => _soluong; set { _soluong = value;  lbesoluong.Text = value; } }
        public int Gia { get => _gia; set { _gia = value; lbegia.Text = value.ToString(); }}

        public delegate void UpdateEvent(object sender);
        public event UpdateEvent UpdateEventHandler;

        public class UpdateHandler : EventArgs
        {
            public string data { get; set; }
        }

        public void UpdateAndDelete()
        {
            UpdateHandler args = new UpdateHandler();
            UpdateEventHandler.Invoke(this);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc xóa Sản Phẩm trong giỏ hàng ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (_spBll.DeleteGiohang(Masp ,Sizee,Color,Soluong))
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
