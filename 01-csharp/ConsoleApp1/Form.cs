using System;
using System.Collections.Generic;

namespace BankAccountApp
{
    public partial class Form1
    {
        public Form1()
        {
            BankAccount account = new BankAccount("John Doe", Guid.NewGuid(), 250); // BankAccount sınıfından bir nesne oluştur
            //bankAccount.Owner = "John Doe";
            //bankAccount.AccountNumber = Guid.NewGuid(); // Benzersiz bir hesap numarası oluştur
            //bankAccount.Balance = 250;


            BankAccount account2 = new BankAccount("İrem x", Guid.NewGuid(), 500); // BankAccount sınıfından başka bir nesne oluştur
            //bankAccount2.Owner = "İrem x";
            //bankAccount2.AccountNumber = Guid.NewGuid();
            //bankAccount2.Balance = 500;

            BankAccount account3 = new BankAccount("Bob Smith", Guid.NewGuid(), 750); // BankAccount sınıfından üçüncü bir nesne oluştur

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(account);
            bankAccounts.Add(account2);
            bankAccounts.Add(account3); 

        }        
        
    }
}