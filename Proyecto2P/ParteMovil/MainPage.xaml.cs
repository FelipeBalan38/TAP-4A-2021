using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App7.Servicios;
using App7.Modelo;


namespace App7
{
    public partial class MainPage : ContentPage
    {
        APIServicio db;
        public MainPage()
        {
            InitializeComponent();
            db = new APIServicio();
            ListaPuntos();
        }
        private async void ListaPuntos()
        {

            var response = await APIServicio.ServiceClientInstance.GetPuntos();

            Puntaj.ItemsSource = response;

        }

        void Puntaj_sel(Object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var content = e.SelectedItem as Puntuaciones;
            Puntaj.SelectedItem = null;

        }
    }
}
