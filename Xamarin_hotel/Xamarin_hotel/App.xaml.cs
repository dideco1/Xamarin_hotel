using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using Xamarin_hotel.Model;
using Xamarin_hotel.View;

namespace Xamarin_hotel
{
    public partial class App : Application
    {
        internal List<Suite> Suites = new List<Suite>
        {
            new Suite()
            {
                Descricao = "Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Suite()
            {
                Descricao = "Executiva",
                ValorDiariaAdulto = 90.0,
                ValorDiariaCrianca = 45.0
            },
            new Suite()
            {
                Descricao = "Pobre",
                ValorDiariaAdulto = 45.0,
                ValorDiariaCrianca = 20.0
            }
        };
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            MainPage = new NavigationPage(new ContratacaoHospedagem());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
