using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankapp
{
    internal class Account
    {
        public string Name { get; set; }
        public string Acctno { get; set; }
        public float balance { get; set; }
        public void menu()
        {
            Console.WriteLine("welcome to the banking application");
            Console.WriteLine("select an option");
            Console.WriteLine("1 Create An Account");
            Console.WriteLine("2 Display Account information");
            Console.WriteLine("3 withdraw money");
            Console.WriteLine("4 Deposite Money");
            Console.WriteLine("5 Check Account Balance");
            Console.WriteLine("6. Exit Application");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.WriteLine();
                    createacct();
                    break;
                case 2:
                    displayacct();
                    Console.WriteLine();
                    
                    break;
                case 3:
                    withdraw();
                    Console.WriteLine();
                    
                    break;
                case 4:
                    deposite();
                    Console.WriteLine();
                    
                    break;
                case 5:
                    checkbalance();
                    Console.WriteLine();
                    
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine();
                    break;
            }
        }
            void createacct()
            {
                Console.WriteLine();
                Console.WriteLine("Enter the account name:");
                Name = Console.ReadLine();
                Acctno = Guid.NewGuid().ToString();
                Console.WriteLine("Enter the intial deposite:");
                balance = Convert.ToInt32(Console.ReadLine());

            }
            void displayacct()
            {
                Console.WriteLine();
                if (Acctno == null || Name == "" || balance == 0)
                {
                    throw new ArgumentException("Account", "Account has not been created or Account");
                }
                Console.WriteLine("Account information");
                Console.WriteLine("Account number:" + Acctno);
                Console.WriteLine("Account name" + Name);
                Console.WriteLine("Account balance: " + balance);
            }
            void withdraw()
            {
                Console.WriteLine();
                Console.WriteLine("Enter amont to withdraw");
                float debit = Convert.ToInt32(Console.ReadLine());
                if (debit > balance)
                {
                    throw new ArgumentException("amount,", "cannot be greater than balance");
                    balance -= debit;
                }
            }
                void deposite()
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter amount to Deposite");
                    float credit = Convert.ToInt32(Console.ReadLine());
                    balance += credit;
                }
                void checkbalance()
                {
                    Console.WriteLine();
                    Console.WriteLine("Account balance");
                    Console.WriteLine("Account balance:" +balance);
                }
            }
        }

    


