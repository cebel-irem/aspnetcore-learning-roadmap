using System; 
using System.Collections.Generic; // BankAccount sınıfını kullanmak için gerekli olan namespace'i ekle
using System.Linq;  //liste içinde arama yapıp fitreleme işlemleri için 
using System.Text; 
using System.Threading.Tasks; //async/ await ve Task yapılarıyla asenkron programlama için gerekli yani program donmasın diye 


namespace BankAccountApp{
    public class BankAccount
    {
        public string Owner {get; set;}
        public Guid AccountNumber {get; set;}
        public decimal Balance {get; set;}

        public BankAccount(string owner, Guid accountNumber, decimal balance) // BankAccount sınıfının yapıcı metodu
        {
            Owner = owner;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        

    }
}