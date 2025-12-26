namespace Task_04_20
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.Name = name;
            this.Balance = balance;
        }
        public Account()
        {
            
        }
        public Account(string name = "Unnamed Account")
        {
            this.Name = name;
       
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
    //========================================================================
    public static class AccountUtil
    {
        // Utility helper functions for Account class
        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
    }
//=======================================================================================================================================
class SavingsAccount:Account
    {
       
        public SavingsAccount(string Name, double Balance,double fee): base(Name, Balance)
        {
           
        }
        public SavingsAccount(string Name):base(Name) 
        {

        }

        public SavingsAccount(string Name, double Balance) : base(Name, Balance)
        {

        }

        public SavingsAccount()
        {

        }
    }
    class CheckingAccount:Account
    {
        public CheckingAccount(string Name,double Balance) : base(Name,Balance)
        {

        }
        public CheckingAccount(string Name) : base(Name)
        {

        }
        public CheckingAccount()
        {

        }

    }
    class TrustAccount : Account
    {
        public TrustAccount(string Name, double Balance, double fee) : base(Name, Balance)
        {

        }
        public TrustAccount(string Name) : base(Name)
        {

        }

        public TrustAccount(string Name, double Balance) : base(Name, Balance)
        {

        }

        public TrustAccount()
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<Account>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman",0,0));
            savAccounts.Add(new SavingsAccount("Batman", 2000,0));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Account>();
            checAccounts.Add(new CheckingAccount("",0));
            checAccounts.Add(new CheckingAccount("Larry2",0));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new TrustAccount("",0,0));
            trustAccounts.Add(new TrustAccount("Superman2",0,0));
            trustAccounts.Add(new TrustAccount("Batman2", 2000,0));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            Console.WriteLine();

        }
    }
}
