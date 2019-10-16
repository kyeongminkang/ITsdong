using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ch09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            //InitializeComponent ();

            //img01.Source = ImageSource.FromUri(new Uri("https://developer.xamarin.com/demo/IMG_1415.JPG?width=100"));
            //Content = new Image()
            //{
            //    Source = ImageSource.FromUri(new Uri("https://developer.xamarin.com/demo/IMG_1415.JPG"))

            //};
        }
    }
}