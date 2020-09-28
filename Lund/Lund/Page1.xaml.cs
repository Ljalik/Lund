using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lund
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        BoxView pea, amber, keha, silmad;
        Button btn1, btn2, btn3, btn4;

        public Page1()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            //голова
            pea = new BoxView { Color = Color.LightBlue, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(pea, new Rectangle(0.3, 0.2, 200, 200));
            AbsoluteLayout.SetLayoutFlags(pea, AbsoluteLayoutFlags.All);
            abs.Children.Add(pea);
            // тело
            keha = new BoxView { Color = Color.Red, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(keha, new Rectangle(0.5, 0.5, 300, 300));
            AbsoluteLayout.SetLayoutFlags(keha, AbsoluteLayoutFlags.All);
            abs.Children.Add(keha);
            // ведро
            amber = new BoxView { Color = Color.DarkKhaki };
            AbsoluteLayout.SetLayoutBounds(amber, new Rectangle(0.2, 0.1, 100, 100));
            AbsoluteLayout.SetLayoutFlags(amber, AbsoluteLayoutFlags.All);
            abs.Children.Add(amber);
            btn1 = new Button { Text = "pea" };
            btn1.Clicked += Btn1_Clicked;
            AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.5, 0.8, 100, 100));
            AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.All);
            abs.Children.Add(btn1);
            // глаза
            silmad = new BoxView { Color = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(silmad, new Rectangle(0.1, 0.1, 50, 50));
            AbsoluteLayout.SetLayoutFlags(silmad, AbsoluteLayoutFlags.All);
            abs.Children.Add(silmad);
            Content = abs;
        }
        bool flag = true;
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            if (flag)
            {
                pea.Opacity = 0;
                flag = false;
            }
            else
            {
                pea.Opacity = 1;
                flag = true;
            }
        }
}