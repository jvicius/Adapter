using Adapter.Models;

namespace Adapter.Adapters
{
    public class ConversorPesos : IConversor
    {
        private const double Rate = 0.046;
        private readonly CajaEuros _cajaEuros;

        public ConversorPesos()
        {
            _cajaEuros = new CajaEuros();
        }

        public ConversorPesos(CajaEuros caja)
        {
            _cajaEuros = caja;
        }

        public void DepositarPesos(double pesos)
        {
            _cajaEuros.DepositarEuros(pesos*Rate);
        }

        public bool RetirarPesos(double pesos)
        {
            return _cajaEuros.RetirarEuros(pesos * Rate);
        }

        public double SaldoPesos()
        {
            return _cajaEuros.ObtenerSaldo() * Rate;
        }

        public double SaldoEuros()
        {
            return _cajaEuros.ObtenerSaldo();
        }
    }
}
