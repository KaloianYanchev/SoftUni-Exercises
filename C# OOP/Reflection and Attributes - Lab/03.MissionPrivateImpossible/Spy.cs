using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string RevealPrivateMethods(string classToInvestigate)
        {
            Type classType = Type.GetType(classToInvestigate);

            MethodInfo[] methodGetterInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in methodGetterInfo)
            {
                sb.AppendLine($"{method.Name}");
            }

            return sb.ToString().Trim();
        }
    }
}