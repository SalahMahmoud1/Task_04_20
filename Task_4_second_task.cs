namespace Second_Task
{
    
    class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.Name = name;
            this.Balance = balance;
        }
        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //============================Saving Class================================
    class SavingsAccount:Account 
    {
        public SavingsAccount(string name ,double balance,double interstRate):base(name,balance)
        {
            InterstRate = interstRate;
        }
        public double InterstRate { get; set; }
        public bool Deposit(double amount)
        {
            amount += InterstRate * amount/100;
            return base.Deposit(amount);
        }

    }
    //==========================Checking account ==================
    class CheckingAccount: Account 
    {
        public CheckingAccount(string name, double balance, double fee) : base(name, balance)
        {
            Fee = fee;
        }
        public double Fee { get; set; }
        public bool Withdraw(double amount)
        {
            amount += Fee;
            return base.Withdraw(amount);
        }
    }
    //==========================Trust account ==================
    class TrustAccount : Account
    {
          int checkCountWithdraw = 0;
          int year = 0;
        public TrustAccount(string name, double balance, double interstRate) : base(name, balance)
        {
            InterstRate = interstRate;
        }
        public double InterstRate { get; set; }
        public bool Deposit(double amount)
        {
            if(amount > 5000)
            {
                amount += InterstRate * amount / 100 + 50;
                
            }
            else
            {
                amount += InterstRate * amount / 100;
            }
            return base.Deposit(amount);
        }
        public bool Withdraw(double amount,int Year)
        {
            if (year == 0)
            {
                year = Year;
            }
            if (amount < (this.Balance * 0.2))
            {

            
                if(Year == year && checkCountWithdraw >= 3)
                {
                    Console.WriteLine("You have exceeded the maximum withdraw limit");
                    return false;
                }
                else if(Year != year && checkCountWithdraw >= 3)
                {
                    year = Year;
                    checkCountWithdraw = 1;
                    return base.Withdraw(amount);
                    // withdraw
                }
                else if(Year == year && checkCountWithdraw <3)
                {

                     //withdraw
                    checkCountWithdraw++;
                    return base.Withdraw(amount);
                }
                else
                {
                    return false;
                }
               
            }
            else
            {
                Console.WriteLine("The withdrawal limit is more than the accepted limit");
                return false;
            }
        }



        }
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sac1 = new SavingsAccount("salah",5000,2);
            sac1.Deposit(10000);//balance = 5000,Irate 2 % ,amount 1000 balance afterdeposit with insertrate=15200
            Console.WriteLine(sac1.Balance);
            CheckingAccount cac1 = new CheckingAccount ("mohamed", 5000, 2);
            cac1.Withdraw(2000);
            Console.WriteLine(cac1.Balance);

            TrustAccount tac1 = new TrustAccount("kemo", 50000, 2);
            TrustAccount tac2 = new TrustAccount("kemo2", 50000, 2);
            //tac1.Deposit(10000);//balance = 5000,Irate 2 % ,amount 1000 balance afterdeposit with insertrate=15200
            //Console.WriteLine(tac1.Balance);
            //tac1.Deposit(1000);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900,2025);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900, 2025);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900, 2025);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900, 2025);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900, 2026);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900, 2026);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900, 2026);
            Console.WriteLine(tac1.Balance);
            tac1.Withdraw(900, 2026);
            Console.WriteLine(tac1.Balance);
            tac2.Withdraw(900, 2026);
            Console.WriteLine(tac2.Balance);
            tac2.Withdraw(40000, 2026);
            Console.WriteLine(tac2.Balance);

        }
    }
}
