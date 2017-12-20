using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {

            ComicsManager manager = new ComicsManager();
            List<Comics> lstComicses = manager.Select(null);

            foreach (Comics comics in lstComicses)
            {
                Console.WriteLine(comics.ToString());
            }

            Console.ReadLine();
        }
    }
}
