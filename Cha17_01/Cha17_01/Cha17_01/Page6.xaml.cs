using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha17_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page6 : ContentPage
	{
		public Page6 ()
		{
			InitializeComponent ();

            // 컬렉션 감시용 클래스 이벤트 처리까지!
            ObservableCollection<DateTime> list = new ObservableCollection<DateTime>();

            list.Add(DateTime.Now);

            lst01.ItemsSource = list;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Debug.WriteLine("===>27:" + DateTime.Now);
                list.Add(DateTime.Now);

                // list로 할 경우!
                //lst01.ItemsSource = null;
                //lst01.ItemsSource = list;
               
                return true;
            });
		}
	}
}