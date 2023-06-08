using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapMethodIntegers
{
    public class SwapClass<T>
    {
        private List<T> _list = new List<T>();

        public SwapClass()
        {

        }

        public List<T> List
        {
            get { return _list; }
            set { _list = value; }
        }

        public void AddItem(T item)
        {
            List.Add(item);
        }

        public List<T> Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex >= 0 && firstIndex < List.Count && secondIndex >= 0 && secondIndex < List.Count)
            {
                (List[firstIndex], List[secondIndex]) = (List[secondIndex], List[firstIndex]);
            }

            return List;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in List)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().Trim();
        }
    }
}