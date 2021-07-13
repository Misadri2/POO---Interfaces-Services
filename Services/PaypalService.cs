namespace Interfaces.Services
{
    public class PaypalService : IOnlinePaymentService
    {

        // colocar o valor das taxas e calcular de acordo com os meses informados
        private const double FeePercentage = 0.05;
        private const double MonthlyInterest = 0.10;

        public double Interest(double amount, int months)
        {
             return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
           return amount * FeePercentage;
        }
    }
}