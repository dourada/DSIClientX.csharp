using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIClientX.csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dsi = new DSICLIENTXLib.DSICLientX();
                var response = dsi.ServerIPConfig("x1.mercurycert.net", 0);
                Console.WriteLine(response);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
