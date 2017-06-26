using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var x = new MyClass();
                while (true)
                {
                    Console.WriteLine(x.Prop1);
                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                var codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
