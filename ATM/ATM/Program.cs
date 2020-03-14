using System;

namespace ATM
{

    class UserAccount
    {
        protected float balance;
        protected string firstname, surname;
        
        
        public UserAccount(string inputFirstname, string inputSurname)
        {
            balance = 0f;
            firstname = inputFirstname;
            surname = inputSurname;
        }
        public float GetBalance()
        {
            return balance;
        }
        public void SetBalance(float newBalance)
        {
            balance = newBalance;
        }

        public bool WithDraw(float withdrawAmount)
        {
            if (GetBalance() >= withdrawAmount)
            {

            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
