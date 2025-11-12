using CadastradorEventos.Models;
namespace CadastradorEventos
{
    public partial class App : Application
    {
        public List<Locais> lista_Locais = new List<Locais>
        {
            new Locais()
            { 
                descricao = "Salão de Festas Elite",
                maximoPessoas = 1000,
            },
            new Locais()
            {
                descricao = "Salão de Festas Premium",
                maximoPessoas = 700,
            },
            new Locais()
            { 
                descricao = "Salão de Festas normal",
                maximoPessoas = 500,
            },
            new Locais()
            { 
                descricao = "Salão de Festas Econômico",
                maximoPessoas = 250,
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
#if WINDOWS
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.MinimumHeight = 800;
            window.MinimumWidth = 400;
            window.MaximumHeight = 800;
            window.MaximumWidth = 400;

            return window;
        }
#endif
    }
    
}
