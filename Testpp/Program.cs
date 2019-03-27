using shellLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testpp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCommand c1 = new RunCommand();
            CmdResponse res = new CmdResponse();

            // Return Code | Std Output | Std Error
            //String RESP = c1.run_cmd("C:\\Python27\\python.exe", "C:\\Python27\\test.py", "123 345", "|");
            //Console.WriteLine(RESP);

             String RESP1 = c1.run_os_cmd("ipconfig", "/all","|");
           Console.WriteLine(RESP1);
            Console.WriteLine(res.RetCode);
            Console.ReadKey();

        }
    }
}
