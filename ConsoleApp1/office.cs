using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class office : ILog
    {
        public void login()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Hello World rada rada");
        }

        public void logoff()
        {
            throw new NotImplementedException();
        }
    }
   public static void main(string[] args)
    {
        office obj = new office();
        obj.login();
    }
}
