﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
		private List<int> _stones;

        public Lake(List<int> stones)
        {
            Stones = stones;
        }

        public List<int> Stones
		{
			get { return _stones; }
            set { _stones = value; }
		}

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return Stones[i];
                }
            }

            for (int i = Stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return Stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();  
        }
    }
}
