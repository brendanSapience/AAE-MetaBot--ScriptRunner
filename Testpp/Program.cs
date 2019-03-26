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
            Class1 c1 = new Class1();
            CmdResponse res = new CmdResponse();

            String RESP = c1.run_cmd("C:\\Python27\\python.exe","C:\\Python27\\test.py", "");
            Console.WriteLine(RESP);
            //Console.WriteLine(res.RetCode);
            Console.ReadKey();

        }
    }
}
