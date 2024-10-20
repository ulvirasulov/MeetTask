using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetTask
{
    public class User
    {
        private static int ID = 1;

        private int _id;
        private int _accountNumber;
        private string _customerName;
        private decimal _balance;

        public int Id
        {
            get { return _id; }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (value > 0)
                    _accountNumber = value;
                else
                {
                    Console.WriteLine("hesab nomresini daxil edin");
                }
            }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (value.Length > 0)
                    _customerName = value;
                else
                {
                    Console.WriteLine("Istifadeci adini daxil edin");
                }
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                {
                    Console.WriteLine("Balans 0-dan kicik ola bilmez");
                }
            }
        }

        public User(int accountNumber, string customerName, decimal balance)
        {
            _id = ID;
            ID++;
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
        }

    }
}

