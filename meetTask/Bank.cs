using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetTask
{
    public class Bank
    {
        User[] users = new User[0];

        public void AddUser(User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[^1] = user;
        }

        public void Deposit(int id, decimal money) // medaxil
        {
            if (id > 0 && money > 0)
            {
                foreach (var user in users)
                {
                    if (user.Id == id)
                    {
                        user.Balance += money;
                        Console.WriteLine($"id {id} olan istifadeciye {money} qeder medaxil olundu.");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("id ve ya mebleg duzgun qeyd olunmayib");
            }
        }

        public void Withdraw(int id, decimal money) // pul cixarmaq
        {
            if (id > 0 && money > 0)
            {
                foreach (var user in users)
                {
                    if (user.Id == id)
                    {
                        if (user.Balance >= money)
                        {
                            user.Balance -= money;
                            Console.WriteLine($"id {id} olan istifadeciye {money} qeder mexaric olundu.");
                        }
                        else
                        {
                            Console.WriteLine("Balansiniz kifayet qeder deyil!");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("id ve ya mebleg duzgun qeyd olunmayib");
            }
        }

        public void GetBalance(int id)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    Console.WriteLine($"id {id} olan istifadecinin balansi: {user.Balance}");
                    return;
                }
            }
        }
    }
}
