namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            var initialPhone = new Phone();
            initialPhone.InitialParameters();
            var secondPhone = new Phone(375448765674, "iPhone 7 32GB", 138);
            secondPhone.InitialParameters();
            var thirdPhone = new Phone(375252255438, "Apple iPhone 5c 16GB", 132);
            thirdPhone.InitialParameters();
            var call = new Phone();
            call.ReceiveCall("Александр");
            var number = new Phone();
            number.GetNumber(375332133242);
            var parameters3 = new Phone(375336785746, "Apple iPhone XR 128GB", 194);
            parameters3.Parameters();
            var callNumNumb = new Phone();
            callNumNumb.ReceiveCall("Алексей", 375292314323);
            var message = new Phone();
            message.sendMessage(375443546765);
            Console.ReadKey();



            //Задача 2
            Console.WriteLine("\n");
            var patient = new Patient(1);
            patient.SelectDoctor();
            Console.ReadKey();



            //Задача 3
            Console.WriteLine("\n");
            var creditCard = new CreditCard(4111111111100031, 175025);
            var creditCard2 = new CreditCard(5486732058864471, 19000);
            var creditCard3 = new CreditCard(1234561999999999, 789800);
            creditCard.Balance();
            creditCard.Replenishment();
            Console.WriteLine("--------------------------------");
            creditCard2.Balance();
            creditCard2.Replenishment();
            Console.WriteLine("--------------------------------");
            creditCard3.Balance();
            creditCard3.Withdrawal();
            Console.WriteLine("--------------------------------");
            creditCard.Balance();
            creditCard2.Balance();
            creditCard3.Balance();
            Console.ReadKey();
        }
    }
}