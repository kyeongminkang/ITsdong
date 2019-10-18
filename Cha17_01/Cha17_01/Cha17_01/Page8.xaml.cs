using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cha17_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page8 : ContentPage
	{
		public Page8 ()
		{
            // 객체 생성
            //DataTemplate dataTemplate = new DataTemplate(typeof(TextCell));
            int cnt = 1;
            DataTemplate dataTemplate = new DataTemplate(() =>
            {
                Debug.WriteLine("====>23 : " + cnt++);
                return new TextCell();
            });

            dataTemplate.SetBinding(TextCell.TextProperty, "Name");
            dataTemplate.SetValue(TextCell.TextColorProperty, "#000000");
            dataTemplate.SetBinding(TextCell.DetailProperty, "Tel");
            dataTemplate.SetValue(TextCell.DetailColorProperty, "#7f7f7f");

            //InitializeComponent ();
            Content = new ListView()
            {
                ItemsSource = CustViewModel.All,
                ItemTemplate = dataTemplate
            };
		}
	}
}