namespace Adapter.Models
{
    public class CajaEuros
    {
        private double _euros = 0;

        public CajaEuros()
        {
        }

        public double ObtenerSaldo()
        {
            return _euros;
        }

        public void DepositarEuros(double euros)
        {
            _euros += euros;
        }
        
        public bool RetirarEuros(double euros)
        {
            if (euros <= _euros)
            {
                _euros -= euros;
                return true;
            }

            return false;
        }
    }
}
