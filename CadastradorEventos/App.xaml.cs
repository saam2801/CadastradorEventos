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
                
            },
            new Locais()
            {
                descricao = "Salão de Festas Premium",
                
            },
            new Locais()
            { 
                descricao = "Salão de Festas normal",
                
            },
            new Locais()
            { 
                descricao = "Salão de Festas Econômico",
                
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
