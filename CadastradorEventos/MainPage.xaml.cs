using CadastradorEventos.Models;
namespace CadastradorEventos
{
    public partial class MainPage : ContentPage
    {
        App Propriedades;

        public MainPage()
        {
            InitializeComponent();

            Propriedades = (App)Application.Current;

            pck_Locais.ItemsSource = Propriedades.lista_Locais;
        }
    }

}
