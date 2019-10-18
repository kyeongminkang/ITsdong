using System;
using System.Collections.Generic;
using System.Text;

namespace Cha17_01
{
    public class CustViewModel
    {
        public static List<CustModel> All { private set; get; }

        private CustViewModel() { } // 외부에서 생성자 호출 못하도록! 

        // 무조건 1번은 실행
        static CustViewModel()
        {
            // 내부변수
            List<CustModel> all = new List<CustModel>();
            Random rnd = new Random();

            for (int i = 1; i <= 100; i++)
            {
                all.Add(new CustModel(i, "홍길동" + i, "010-1111-" + (1000 + rnd.Next(1000)), "서울" + rnd.Next(1000)));
            }

            All = all;

        }
    }
}
