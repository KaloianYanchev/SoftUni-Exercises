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
        public string CollectGettersAndSetters(string classToInvestigate)
        {
            Type classType = Type.GetType(classToInvestigate);

            MethodInfo[] methodGetterInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            //sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
            //sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in methodGetterInfo.Where(m => m.Name.Contains("get")))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in methodGetterInfo.Where(m => m.Name.Contains("set")))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}