using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****/n");

            //No need to assign initial value to local variables used as output parameters, provided the first time you use them is as output arguments.
            // C# 7 allows for out parameters to be declared in the method call.
            Add(90, 90, out int ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            Console.ReadLine();
        }
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
    }
}
