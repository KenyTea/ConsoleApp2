using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка
{
    class Program
    {
        class Money
        {
            public Money(decimal amount, string unit)
            {
                Amount = amount;
                Unit = unit; 
            }

            public decimal Amount { get; set; }
            public string Unit { get; set; }

            public static Money operator +(Money a, Money b)
            {
                if(a.Unit != b.Unit)
                    throw new InvalidOperationException
                    ("Нельзя суммировать деньги в разных валютах");
                    return new Money(a.Amount + b.Amount, a.Unit);
                
            }

        }
        static void Main(string[] args)
        {
            
            Money usd = new Money(100, "USD");
            Money kzt = new Money(3000, "KZT");
            Money usd2 = new Money(500, "USD");

           // var result = usd + kzt;
            var result2 = usd + usd2;

            //Console.WriteLine(result);
            Console.WriteLine( result2);
        }
    }
}
