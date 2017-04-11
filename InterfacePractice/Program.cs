using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions
    {
        private string tCode { get; set; }
        private string date { get; set; }
        private double amount { get; set; }
        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
            Transaction t3 = new Transaction();
            t1.showTransaction();
            t2.showTransaction();
            t3.showTransaction();
            Console.ReadKey();
        }
    }
}
