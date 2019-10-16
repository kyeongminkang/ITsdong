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

        private void TxtNote_Focused(object sender, FocusEventArgs e)
        {
            // 높이가 반으로 줄어듦.
            // 아이폰만 설정해주면 됨 사실은
            // 안드로이드는 키보드 창이 나왔을 때 알아서 화면 조절이 가능하기 때문!
            if(Device.RuntimePlatform == Device.iOS)
            {
                AbsoluteLayout.SetLayoutBounds(txtNote, new Rectangle(0, 0, 1, 0.5));
            }
            
        }

        private void TxtNote_Unfocused(object sender, FocusEventArgs e)
        {
            if(Device.RuntimePlatform == Device.iOS)
            {
                AbsoluteLayout.SetLayoutBounds(txtNote, new Rectangle(0, 0, 1, 1));
            }
            
        }
    }
}
