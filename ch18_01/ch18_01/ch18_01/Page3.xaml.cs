using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch18_01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
            // 코드로 사용할거니까!
            //InitializeComponent ();

            // 순수코드로 grid사용하기
            Grid grid = new Grid()
            {
                RowSpacing = 0, ColumnSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition()
                    {
                        Height = GridLength.Auto
                    },
                    new RowDefinition()
                    {
                        Height = new GridLength(100)
                    },
                    new RowDefinition()
                    {
                        Height = new GridLength(2, GridUnitType.Star)
                    },
                    new RowDefinition()
                    {
                        Height = new GridLength(1, GridUnitType.Star)
                    }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition()
                }
            };

            Button btn1 = new Button()
            {
                Text = "버튼1"
            };
            Button btn2 = new Button()
            {
                Text = "버튼2"
            };
            Button btn3 = new Button()
            {
                Text = "버튼3"
            };
            Button btn4 = new Button()
            {
                Text = "버튼4"
            };

            grid.Children.Add(btn1);
            grid.Children.Add(btn2);
            grid.Children.Add(btn3);
            grid.Children.Add(btn4);

            Grid.SetRow(btn1, 0);
            Grid.SetRow(btn2, 1);
            Grid.SetRow(btn3, 2);
            Grid.SetRow(btn4, 3);

            Button btn5 = new Button()
            {
                Text = "버튼5"
            };
            Button btn6 = new Button()
            {
                Text = "버튼6"
            };

            grid.Children.Add(btn5);
            grid.Children.Add(btn6);

            Grid.SetRow(btn5, 0);
            Grid.SetColumn(btn5, 1);
            Grid.SetRowSpan(btn5, 2);


            Grid.SetRow(btn6, 2);
            Grid.SetColumn(btn6, 1);
            Grid.SetRowSpan(btn6, 2);


            this.Content = grid;
            
        }
	}
}