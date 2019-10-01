namespace Adapter.Adapters
{
    public interface IConversor
    {
        void DepositarPesos(double pesos);
        bool RetirarPesos(double pesos);
        double SaldoPesos();
        double SaldoEuros();
    }
}
