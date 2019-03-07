using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granici_cifrovih_tipov_danih
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sbyte {0} {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("sbyte {0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte {0} {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("sbyte {0} {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("sbyte {0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("sbyte {0} {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("sbyte {0} {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("sbyte {0} {1}", ulong.MinValue, ulong.MaxValue);
        }
    }
}
