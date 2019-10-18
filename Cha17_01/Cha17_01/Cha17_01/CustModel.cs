using System;
using System.Collections.Generic;
using System.Text;

namespace Cha17_01
{
    public class CustModel
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Addr { get; set; }

        // 생성자
        public CustModel(int num, string name, string tel, string addr)
        {
            this.Num = num;
            this.Name = name;
            this.Tel = tel;
            this.Addr = addr;
        }

        public override string ToString()
        {
            return this.Num + "," + this.Name + "," + this.Tel + "," + this.Addr;
        }
    }
}
