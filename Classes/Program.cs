using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IpAddress ip = new IpAddress("186.21.21.21", 21);
            Console.WriteLine(ip.GetUserFriendlyBinaryAddress());
            Console.WriteLine();
        }
    }
}
