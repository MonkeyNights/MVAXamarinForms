using System;

namespace MVAXamForms.Models
{
    public class ItemDeHistorico
    {
        public DateTime Data { get; }
        public int PrimeiroNumero { get; }
        public int SegundoNumero { get; }
        public int Resultado { get; }

        public ItemDeHistorico(int primeiroNumero, 
            int segundoNumero,
            int resultado)
        {
            Data = DateTime.Now;
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
            Resultado = resultado;
        }
    }
}
