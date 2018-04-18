using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CY_Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentPage : ContentPage
	{
		public ContentPage ()
		{
			InitializeComponent ();
		}
	}
}