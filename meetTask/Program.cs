using System;

namespace meetTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bool stop = false;

            do
            {
                Console.WriteLine("\n1 - Yeni istifadeci elave etmek\r\n2 - Medaxil etmek\r\n3 - Mexaric etmek\r\n4 - Balansi yoxlamaq\r\n0 - Programi dayandir");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        Console.WriteLine("Yeni istifadeci elave edin:");
                        Console.Write("Hesab nomresi: ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Istifadeci adi: ");
                        string customerName = Console.ReadLine();
                        Console.Write("Balans: ");
                        decimal balance = Convert.ToDecimal(Console.ReadLine());
                        User newUser = new User(accountNumber, customerName, balance);
                        bank.AddUser(newUser);
                        Console.WriteLine("Yeni istifadeci elave olundu.");
                        break;

                    case "2":
                        Console.Write("Depozit ucun ID daxil edin: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Depozit meblegi: ");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        bank.Deposit(id, depositAmount);
                        break;

                    case "3":
                        Console.Write("Pul cixarmaq ucun ID daxil edin: ");
                        int withdrawId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Pul cixarmaq meblegi: ");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        bank.Withdraw(withdrawId, withdrawAmount);
                        break;

                    case "4":
                        Console.Write("Balansi yoxlamaq ucun ID daxil edin: ");
                        int checkId = Convert.ToInt32(Console.ReadLine());
                        bank.GetBalance(checkId);
                        break;

                    case "0":
                        Console.WriteLine("Proqram dayandirildi.");
                        stop = true;
                        break;

                    default:
                        Console.WriteLine("Duzgun reqem daxil edin.");
                        break;
                }
            } while (!stop);
        }
    }
}
