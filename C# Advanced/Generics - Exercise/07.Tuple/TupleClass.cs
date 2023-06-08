using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class TupleClass<T1, T2>
    {

        private T1 _item1;
        private T2 _item2;

        public TupleClass(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T1 Item1
        {
            get { return _item1; }
            set { _item1 = value; }
        }

        public T2 Item2
        {
            get { return _item2; }
            set { _item2 = value; }
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
