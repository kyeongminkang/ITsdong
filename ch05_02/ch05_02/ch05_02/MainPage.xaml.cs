using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ch05_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("note_data"))
            {
                txtNote.Text = (string)Application.Current.Properties["note_data"];
            }
        }

        public void SaveData()
        {
            Application.Current.Properties["note_data"] = txtNote.Text; 
        }
    }
}
