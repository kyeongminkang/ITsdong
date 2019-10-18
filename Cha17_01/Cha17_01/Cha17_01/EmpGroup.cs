using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Cha17_01
{
    public class EmpGroup : ViewModelBase
    {
        // emp그룹의 이름 즉, 회사명
        string corpName;

        // employee 전체 목록 잡기 위함. 이벤트 바로 잡기 위해 observablecollection 사용
        ObservableCollection<Emp> emps = new ObservableCollection<Emp>();

        public string CorpName
        {
            get
            {
                return this.corpName;
            }
            set
            {
                Setproperty(ref this.corpName, value);
            }
        }

        public ObservableCollection<Emp> Emps
        {
            get
            {
                return this.emps;
            }
            set
            {
                Setproperty(ref this.emps, value);
            }
        }

        public void MoveToTop(Emp emp)
        {
            Emps.Move(Emps.IndexOf(emp), 0);
        }

        public void MoveToBottom(Emp emp)
        {
            Emps.Move(Emps.IndexOf(emp), Emps.Count - 1);
        }

        public void Remove(Emp emp)
        {
            Emps.Remove(emp);
        }
    }
}
