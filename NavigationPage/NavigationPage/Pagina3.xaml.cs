using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina3 : ContentPage
	{
		public Pagina3 ()
		{
			InitializeComponent ();
            this.btnInicio.Clicked += BtnInicio_Clicked;
            this.btnSiguiente.Clicked += BtnSiguiente_Clicked;
            this.btnAnterior.Clicked += BtnAnterior_Clicked;
        }
        private async void BtnInicio_Clicked(object sender, EventArgs e)
        {
            await NavigationPage.PopToRootAsync();
        }
        private async void BtnSiguiente_Clicked(object sender, EventArgs e)
        {
            await NavigationPage.PushModalAsync(new Pagina4());
        }
        private async void BtnAnterior_Clicked(object sender, EventArgs e)
        {
            await NavigationPage.PopAsync();
        }
    }
}