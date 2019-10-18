using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cha17_01
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //private string name;
        //public string FormatName = "";

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if(Setproperty(ref name, value))
        //        {
        //            FormatName = name + "님 환영합니다";
        //        }
        //    }
        //}

        protected bool Setproperty<T>(ref T var1, T value,
            [CallerMemberName]string propertyName = null)
        {
            if(Object.Equals(var1, value))
            {
                return false;
            }

            var1 = value;
            OnPropertyChanged(propertyName);
            return true;

        }


        // 위에 Name 프로퍼티가 자동으로 Name값을 받아옴
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
          
        }
    }
}
