using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Cha10_01
{
    public class DateTimeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime dttm = DateTime.Now;

        // 계속 갱신해주는 아이
        public DateTimeViewModel()
        {
            Device.StartTimer(TimeSpan.FromSeconds(0.2), timer);
        }

        private bool timer()
        {
            Dttm = DateTime.Now;
            return true;
        }

        public DateTime Dttm
        {
            get
            {
                return dttm;
            }
            private set
            {
                if(dttm == value)
                {
                    return;
                }

                dttm = value;

                // 이벤트핸들러 감지하지 못할 수도 있으니까!
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Dttm"));
                }
                
            }
        }
    }
}
