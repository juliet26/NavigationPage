using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationPage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

        }
        public async void SiguienteButton_Clicked(Object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Pagina2());
        }
	}
}
