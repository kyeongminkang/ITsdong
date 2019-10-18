using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cha17_01
{
    public class Emp : ViewModelBase
    {
        int num;
        string tel, addr;
        double point;
        string imgUrl;

        public int Num
        {
            get
            {
                return this.num;

            }
            set
            {
                Setproperty(ref this.num, value);
            }
        }

        string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Setproperty(ref this.name, value);
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                Setproperty(ref this.tel, value);
            }
        }

        public string Addr
        {
            get
            {
                return this.addr;
            }
            set
            {
                Setproperty(ref this.addr, value);
            }
        }

        public double Point
        {
            get
            {
                return this.point;
            }
            set
            {
                Setproperty(ref this.point, value);
            }
        }

        public string ImgUrl
        {
            get
            {
                return this.imgUrl;

            }
            set
            {
                Setproperty(ref this.imgUrl, value);
            }
        }

        public ICommand ResetPointCommand { private set; get; }

        public ICommand MoveToTopCommand { private set; get; }
        public ICommand MoveToBottomCommand { private set; get; }

        public ICommand RemoveCommand { private set; get; }

        // 부모 프로퍼티 만듦
        public EmpGroup EmployeeGroup { get; set; }

        // 기본생성자 나중엔 맨 위에 만들어라!
        public Emp()
        {
            ResetPointCommand = new Command(() => { Point = 0.0; });
            MoveToTopCommand = new Command(() => { EmployeeGroup.MoveToTop(this); });
            MoveToBottomCommand = new Command(() => { EmployeeGroup.MoveToBottom(this); });
            RemoveCommand = new Command(() => { EmployeeGroup.Remove(this); });
        }

        // 생성자 다시 호출하기 위함
        public Emp(int num, string name, string tel, string addr, double point,
            string imgUrl = "https://cdn0.iconfinder.com/data/icons/buttery_png/128/pretty_smile.png") : this()
        {
            this.Num = num;
            this.Name = name;
            this.Tel = tel;
            this.Addr = addr;
            this.Point = point;
            this.ImgUrl = imgUrl;
        }
    }
}
