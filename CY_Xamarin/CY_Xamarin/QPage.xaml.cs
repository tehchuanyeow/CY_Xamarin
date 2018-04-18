using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CY_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QPage : ContentPage
    {
        int pos = 0;
        List<string> Quotes = new List<string>()
            {
                "Make hay while sunshines",
                "Waterhouse",
                "James",
                "Baird",
                "Jeff",
                "Nguyen",
            };
        public QPage()
        {
            InitializeComponent();
            LabelQuotes.Text = Quotes[pos];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            pos++;
            if (pos >= Quotes.Count) pos = 0;

            LabelQuotes.Text = Quotes[pos];
        }
    }
}
