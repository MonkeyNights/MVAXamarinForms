using MVAXamForms.ViewModels;

namespace MVAXamForms
{
    public partial class PrimeiraPagina
    {
        public PrimeiraPagina()
        {
            InitializeComponent();
            BindingContext = new PrimeiraPaginaViewModel();
        }
    }
}
