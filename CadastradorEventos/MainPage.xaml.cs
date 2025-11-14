using CadastradorEventos.Models;
using CadastradorEventos.Views;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try 
            {
                //esses trechos das linhas 23 e 24, precisei do gemini, não estava conseguindo acessar as propriedades da model
                var LocalEscolhido = pck_Locais.SelectedItem;
                Locais Local = (Locais)LocalEscolhido;
                if (Local == null) { throw new Exception(message: "Por favor, escolha um local."); }
                Cadastrado cadastro = new Cadastrado
                {
                    descricao = Local.descricao,
                    MaximoPessoas = Local.maximoPessoas 
                };
                Navigation.PushAsync(new EventoCadastrado()
                {
                    BindingContext = cadastro,
                });
                
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }

}
