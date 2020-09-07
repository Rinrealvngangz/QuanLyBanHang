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
    public partial class ThongKe : Form
    {
        BindingSource listBinding = new BindingSource();
        public ThongKe()
        {
            InitializeComponent();
            gvThongke.DataSource = listBinding;
        }
        ThongKeBLL _thongkeBLL = new ThongKeBLL();
        List<ThongKeDTO> listThongKe = new List<ThongKeDTO>();
        int day, month, year;

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadingThongke();
            AddBinding();
         
        }
        public void LoadingThongke()
        {
           
            listThongKe = _thongkeBLL.LoadingThongKe();
            listBinding.DataSource = listThongKe;
       
        }
        public void AddBinding()
        {
           tbShoe.DataBindings.Add(new Binding("Text", gvThongke.DataSource, "TenSP"));

         
        }
        //Thống kê Price
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int priceMonth,priceYear,valMonth ,valYear;
            if( lbDay.Text == "" || lbMonth.Text == "" || lbYear.Text == "")
            {
                MessageBox.Show("Bạn Chưa Fill Day ,Month ,Year");
            }    
            else
            {
              
            
                if (gvThongke.Rows.Count > 0)
                {
                   priceMonth = _thongkeBLL.FillMonth(month, year);
                    tbPrice.Text = priceMonth.ToString();
                   priceYear = _thongkeBLL.FillPriceYear(year);
                   tbYearPrice.Text = priceYear.ToString();
                   valMonth = _thongkeBLL.FillValueMonth(month, year);
                   valYear = _thongkeBLL.FillValueYear(year);
                    valueMonth.Value = valMonth;
                    PerMonth.Text = valMonth.ToString();
                 ValueYear.Value = valYear;
                PerYear.Text = valYear.ToString();
                }
                else
                {
                  tbPrice.Text = "";
                    tbYearPrice.Text = "";
                   valueMonth.Value = 0;
                   ValueYear.Value = 0;
                    PerMonth.Text = "0";
                    PerYear.Text = "0";
               }
            }
           
            return;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }
       
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
            day = guna2DateTimePicker1.Value.Day;
            month = guna2DateTimePicker1.Value.Month;
            year = guna2DateTimePicker1.Value.Year;
            listThongKe = _thongkeBLL.FillDate(day,month,year);
            listBinding.DataSource = listThongKe;

            lbDay.Text = day.ToString();
            lbMonth.Text = month.ToString();
            lbYear.Text = year.ToString();
      
        }

     
    }
}
