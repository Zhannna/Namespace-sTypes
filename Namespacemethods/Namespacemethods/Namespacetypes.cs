using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Namespacemethods
{
    static class Namespacetypes
    {
        public static  Type[] GetTypes(Assembly assembly, string namespac)
        {
            return assembly.GetTypes().Where(t => namespac.Equals(t.Namespace)).ToArray();


        }


        public static MethodInfo[] GetMethods(Assembly assembly, string namespac)
        {
            List<MethodInfo> m = new List<MethodInfo>();
            foreach (Type item in GetTypes(assembly, namespac))
            {
                foreach (MethodInfo method in item.GetMethods())
                {
                    m.Add(method);
                    
                }
            }
            return m.ToArray();
        }


        }


}

