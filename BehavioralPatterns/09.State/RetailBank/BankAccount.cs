using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailBank
{
    public class BankAccount
    {
        public AccountState AccountState { get; set; }

        public decimal Balance { get { return AccountState.Balance; } }
        public BankAccount(decimal initialDeposite) 
        {            
            AccountState = new RegularAccountState(this, initialDeposite);
        }

        public void Deposite(decimal money)
        {
            AccountState.Deposite(money);
        }

        public void WithDraw(decimal money)
        {
            AccountState.Withdraw(money);
        }
    }

    public abstract class AccountState
    {
        public decimal Balance { get; protected set; }
        public abstract void Deposite(decimal amount);
        public abstract void Withdraw(decimal amount);

    }

    public class RegularAccountState : AccountState
    {
        private BankAccount bankAccount;
       

        public RegularAccountState(BankAccount bankAccount, decimal balance) 
        {
            this.bankAccount = bankAccount;
            this.Balance = balance;
        }
        public override void Deposite(decimal amount)
        {
            this.Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            
            this.Balance -= amount;

            if(this.Balance <= 0) 
            {
                this.bankAccount.AccountState = new OverDrawnAccountState(bankAccount, Balance);
                Console.WriteLine("Account stateis OverDrawn");
            }
        }
        
    }

    internal class OverDrawnAccountState : AccountState
    {
        private BankAccount bankAccount;
       

        public OverDrawnAccountState(BankAccount bankAccount, decimal balance)
        {
            this.bankAccount = bankAccount;
            this.Balance = balance;
        }

        public override void Deposite(decimal amount)
        {
            this.Balance += amount;
            if(Balance > 0)
            {
                this.bankAccount.AccountState = new RegularAccountState(bankAccount, Balance);
                Console.WriteLine("Welcome Bank, Account state is Regular now");
            }
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"Balance is less than 0 so no more money for you");
        }
    }
}
