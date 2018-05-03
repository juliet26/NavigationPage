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
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 ()
		{
			InitializeComponent ();
            this.lblOpcion.Text = string.Empty;
            BtnTres.Clicked += BtnTres_Clicked;
            BtnTest.Clicked += BtnTest_Clicked;
        }
        private async void BtnTres_Clicked(object sender, EventArgs e)
        {
            this.lblOpcion.Text = string.Empty;
            await Navigation.PushAsync(new Pagina3());
        }
        private async void BtnTest_Clicked(object sender, EventArgs e)
        {
            this.lblOpcion.Text = string.Empty;
            var respo = await DisplayAlert("Test", "Quiere realizar el test", "Si", "No");
            if (respo)
            {
                await DisplayAlert("Incio de Test", "Super bienvenido", "Aceptar");
                var opcion = await DisplayActionSheet("Opciones",
                    "Cancelar",
                    null, "Opcion 1", "Opcion 2", "Opcion 3");
                lblOpcion.Text = opcion.ToString();
            }
            else
            {
                await DisplayAlert("Test fallido", "En otra oportunidad", "Aceptar");

            }
        }
    }
}