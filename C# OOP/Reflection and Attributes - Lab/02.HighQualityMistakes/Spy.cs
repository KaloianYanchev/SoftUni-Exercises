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
        public string AnalyseAccessModifiers(string classToInvestigate)
        {
            Type classType = Type.GetType(classToInvestigate);

            FieldInfo[] fieldInfos = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] methodSetterInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] methodGetterInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            //Object classInstance = Activator.CreateInstance(classType, new object[] { });

            //sb.AppendLine($"Class under investigation: {classToInvestigate}");

            foreach (FieldInfo field in fieldInfos)
            {
                Console.WriteLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in methodSetterInfo.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }
            foreach (MethodInfo method in methodGetterInfo.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            return sb.ToString().Trim();
        }
    }
}