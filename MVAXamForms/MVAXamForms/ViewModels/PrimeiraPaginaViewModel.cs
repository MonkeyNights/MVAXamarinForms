using System.Collections.ObjectModel;
using MVAXamForms.Models;
using Xamarin.Forms;

namespace MVAXamForms.ViewModels
{
    public class PrimeiraPaginaViewModel : BaseViewModel
    {
        private int _primeiroNumero;
        private int _segundoNumero;
        private int _resultado;

        public int PrimeiroNumero
        {
            get
            {
                return _primeiroNumero;
            }
            set
            {
                _primeiroNumero = value;
                OnPropertyChanged();
                SomarCommand.ChangeCanExecute();
            }
        }

        public int SegundoNumero
        {
            get
            {
                return _segundoNumero;
            }
            set
            {
                _segundoNumero = value;
                OnPropertyChanged();
                SomarCommand.ChangeCanExecute();
            }
        }

        public int Resultado
        {
            get
            {
                return _resultado;
            }
            private set
            {
                _resultado = value;
                OnPropertyChanged();
            }
        }

        public Command SomarCommand { get; private set; }

        public PrimeiraPaginaViewModel()
        {
            SomarCommand = new Command(ExecuteSomarCommand,
                CanExecuteSomarCommand);
            Historico = new ObservableCollection<ItemDeHistorico>();
        }

        private bool CanExecuteSomarCommand() =>
                        PrimeiroNumero >= 1 &&
                        SegundoNumero >= 1;

        private void ExecuteSomarCommand()
        {
            Resultado = PrimeiroNumero + SegundoNumero;
            Historico.Add(new ItemDeHistorico(
                PrimeiroNumero, SegundoNumero, Resultado));
        }

        public ObservableCollection<ItemDeHistorico> Historico { get; private set; }
    }
}
