using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Loading : Form
    {
        public Loading(string username,string pass)
        {
            InitializeComponent();
            this.username = username;
            this.pass = pass;
        }
        public string username {get;set;}
        public string pass { get; set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ProgressbarLoading.Value == 100)
            {
                timer1.Stop();
                this.Close();
                container(new Form1(username,pass));
            }
              ProgressbarLoading.Value += 1;
            guna2HtmlLabel2.Text = (Convert.ToInt32(guna2HtmlLabel2.Text) +1).ToString();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void container(object _from)
        {

            Form frm = _from as Form;
            frm.Show();

        }
    }
}
