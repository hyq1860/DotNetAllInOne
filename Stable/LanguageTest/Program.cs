using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageTest
{
    class Program
    {
        public static int aaa()
        {
            int x = 1;

            try
            {
                Console.WriteLine("try");
                Console.WriteLine(x);
                return ++x;
            }
            catch (Exception e)
            {

            }
            finally
            {
                Console.WriteLine("finanlly before:" + x.ToString());
                ++x;
                Console.WriteLine("finanlly after:" + x.ToString());
            }
            return x;
        }
        public static void Main()
        {
            var a = aaa();
            Console.Write(a);
            Console.ReadLine();
        }

    }
}
