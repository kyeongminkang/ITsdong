using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cha10_01
{
    public class PowerViewModel : ViewModelBase
    {
        double op1, op2, result;

        // op1 ^ op2 = result

        public ICommand IncreaseCommand { private set; get; }
        public ICommand DecreaseCommand { private set; get; }

        public PowerViewModel(double v)
        {
            Op1 = v;
            Op2 = 0;

            IncreaseCommand = new Command(IncreaseFn);
            DecreaseCommand = new Command(DecreaseFn);
        }

        //프로퍼티 만들기
        public double Op1
        {
            get
            {
                return op1;
            }
            private set
            {
                if(Setproperty(ref op1, value))
                {
                    Result = Math.Pow(op1, op2);
                }
            }
        }

        private void DecreaseFn(object obj)
        {
            Op2 -= 1;
        }

        private void IncreaseFn(object obj)
        {
            Op2 += 1;
        }

        public double Op2
        {
            get
            {
                return op2;
            }
            set
            {
                if(Setproperty(ref op2, value))
                {
                    Result = Math.Pow(op1, op2);
                }
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
                Setproperty(ref result, value);
            }
        }
    }
}
