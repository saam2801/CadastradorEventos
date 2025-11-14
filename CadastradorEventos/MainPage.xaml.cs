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
                //eu definitivamente não gostei dessa solução, mas foi oque eu consegui pensar por hora
                //para o professor:
                //se puder me sugerir uma solução mais elegante, porque isso aqui está horrivel, mas não conheço muito da linguagem para poder desenvolver uma solução melhor
                //obrigado
                if(NomeEvnt.Text == null || Local == null || QtdCnvd.Text == null || PreçoEntrada.Text == null || dtpck_Fim == null || dtpck_Inicio == null) 
                { throw new Exception(message: "Por favor, preencha os dados corretamente."); }
                Cadastrado cadastro = new Cadastrado
                {
                    descricao = Local.descricao,
                    NomeEvento = NomeEvnt.Text,
                    qtd_Convidados = int.Parse(QtdCnvd.Text),
                    entradaPreco = int.Parse(PreçoEntrada.Text),
                    comecoFesta = dtpck_Inicio.Date,
                    fimFesta = dtpck_Fim.Date,
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

        private void dtpck_Inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker objeto = (DatePicker)sender;

            DateTime selecionada = objeto.Date;

            dtpck_Fim.MinimumDate = selecionada; //a festa pode acabar no mesmo dia
            dtpck_Fim.MaximumDate = selecionada.AddDays(7); //a festa acaba em uma semana no máximo
        }
    }

}
