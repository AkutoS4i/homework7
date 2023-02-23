namespace Homework7
{
    public class CreditCard
    {
        public long cardNumber;
        public decimal balance;
        public CreditCard(long cardNumber, decimal balance)
        {
            this.cardNumber = cardNumber;
            this.balance = balance;
        }
        public void Replenishment()
        {
            Console.Write("Введите сумму для пополнения: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            balance += +sum;
        }
        public void Withdrawal()
        {
            Console.Write("Введите сумму для вывода: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            balance -= sum;
        }
        public decimal Balance()
        {
            Console.WriteLine($"Баланс карты {cardNumber}: " + balance);
            return balance;
        }
    }
}
