using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DTO
{
    public class tinhToan : INotifyPropertyChanged
    {
      

        private string tongdongia;

        public string TongGia
        {
            get { return tongdongia; }
            set { tongdongia = value; OnPropertyChanged("TongGia");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string dongia)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(dongia));
            }
        }

    }
}
