using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cha17_01
{

    //    empgroup과 emp는 모델
    //empgroup은 테이블, emp는 레코드라고 보면 됨.

    //실제 데이터를 세팅해주는 viewmodel 작성



    public class CorpViewModel : ViewModelBase
    {
        EmpGroup employeeGroup;

        public EmpGroup EmployeeGroup
        {
            get
            {
                return this.employeeGroup;
            }
            set
            {
                Setproperty(ref this.employeeGroup, value);
            }
        }

        // 실제 데이터 만들어주기
        // 생성자

        public CorpViewModel() : this(null)
        {

        }

        // 나중에 save용 프로퍼티 만들기 위함
        public CorpViewModel(IDictionary<string, object> properties)
        {

            Random rnd = new Random();
            EmployeeGroup = new EmpGroup();
            EmployeeGroup.CorpName = "(주)대한민국";
            IsRefreshing = true;

            for (int i = 1; i <= 15; i++)
            {
                string name = "이순신";
                employeeGroup.Emps.Add(new Emp(i, name, "010-1111-" + i, "서울" + i, rnd.NextDouble() * 100));

            }

            foreach (Emp emp in EmployeeGroup.Emps)
            {
                emp.EmployeeGroup = this.EmployeeGroup;
            }

            IsRefreshing = false;
            RefreshCommand = new Command(
                execute: () =>
            {
                LoadData();
            },
            canExecute: () =>
            {
                return !isRefreshing;
            }
            );

        }

        private void LoadData()
        {
            IsRefreshing = true;

            EmployeeGroup.Emps.Insert(0,
                new Emp(EmployeeGroup.Emps.Count + 1, "홍길동"
                + EmployeeGroup.Emps.Count + 1, "010-2222-2222", "경기", (new Random()).NextDouble() * 100));

            Thread.Sleep(500);
            IsRefreshing = false;
        }

        public ICommand RefreshCommand { private set; get; }
        bool isRefreshing = true;

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { Setproperty(ref isRefreshing, value); }
        }
    }
}
