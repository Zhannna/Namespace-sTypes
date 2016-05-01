using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Namespacemethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Namespacemethods";
        Type[] t = Namespacetypes.GetTypes(Assembly.GetExecutingAssembly(), str);
           
        foreach (Type item in t)
        {
            Console.WriteLine(item.Name);
            
        }

        foreach (MethodInfo item in Namespacetypes.GetMethods(Assembly.GetExecutingAssembly(), str))
        {
            Console.WriteLine(item.Name);
        }
            
        }
    }
}
