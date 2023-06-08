using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T _leftItem;
        private T _rightItem;

        public T LeftItem
        {
            get { return _leftItem; }
            set { _leftItem = value; }
        }

        public T RightItem
        {
            get { return _rightItem; }
            set { _rightItem = value; }
        }

        public EqualityScale(T leftItem, T rightItem)
        {
            LeftItem = leftItem;
            RightItem = rightItem;
        }

        public bool AreEqual()
        {
            return LeftItem.Equals(RightItem);
        }
    }
}
