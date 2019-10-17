using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Text;
using Xamarin.Forms;

namespace Cha10_01
{
    public class ColorViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Color localColor;

        public double Red
        {
            get
            {
                return localColor.R;
            }
            set
            {
                if(MyRound(localColor.R) == MyRound(value))
                {
                    return;
                }
                //if(Setproperty(ref localColor.R, value)) { }
                LocalColor = Color.FromRgba(MyRound(value), localColor.G, localColor.B, localColor.A);
                OnPropertyChanged();
            }
        }

        public Color LocalColor
        {
            get
            {
                return localColor;

            }
            set
            {
                if (localColor == value)
                {
                    return;
                }

                localColor = value;
                OnPropertyChanged("LocalColor");

            }
        }

        //private void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        private double MyRound(double r)
        {
            return Math.Round(r, 3);
        }

        public double Green
        {
            get
            {
                return localColor.G;
            }
            set
            {
                if (MyRound(localColor.G) == MyRound(value))
                {
                    return;
                }

                LocalColor = Color.FromRgba(localColor.R, MyRound(value) ,localColor.B, localColor.A);
                OnPropertyChanged("Green");
            }
        }
        public double Blue
        {
            get
            {
                return localColor.B;
            }
            set
            {
                if (MyRound(localColor.B) == MyRound(value))
                {
                    return;
                }

                LocalColor = Color.FromRgba(localColor.R, localColor.G, MyRound(value), localColor.A);
                OnPropertyChanged("Blue");
            }

        }

        public double Alpha
        {
            get
            {
                return localColor.A;
            }
            set
            {
                if (MyRound(localColor.A) == MyRound(value))
                {
                    return;
                }

                LocalColor = Color.FromRgba(localColor.R, localColor.G, localColor.B, MyRound(value));
                OnPropertyChanged("Alpha");
            }

        }

    }
}
