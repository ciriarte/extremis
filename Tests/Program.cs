using Extremis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    static
    class Program
    {
        static
        Int32 Main(String[] args)
        {
            var dictionary = new NullValueDictionary<String, String>() as INullValueDictionary<String, String>;
            Console.WriteLine("Hello {0}", dictionary["hello"] ?? "world");
            return 0;
        }
    }
}
