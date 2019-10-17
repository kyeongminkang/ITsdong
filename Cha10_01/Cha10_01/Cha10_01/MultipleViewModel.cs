using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cha10_01
{
    public class MultipleViewModel : INotifyPropertyChanged
    {



        private double op1, op2, result;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Op1
        {
            get
            {
                return op1;
            }
            set
            {
                if (op1 == value)
                {
                    return;
                }
                op1 = value;
                OnPropertyChanged("Op1");

                Calc();
            }
        }

        public double Op2
        {
            get
            {
                return op2;
            }
            set
            {
                if (op2 == value)
                {
                    return;
                }
                op2 = value;
                OnPropertyChanged("Op2");
                Calc();
            }
        }

        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                if(result == value)
                {
                    return;
                }
                result = value;
                OnPropertyChanged("Result");
            }
        }

        private void Calc()
        {
            Result = op1 * op2;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
