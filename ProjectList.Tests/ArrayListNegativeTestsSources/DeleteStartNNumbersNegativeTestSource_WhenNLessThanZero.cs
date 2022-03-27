﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListNegativeTestsSources
{
    public class DeleteStartNNumbersNegativeTestSource_WhenNLessThanZero : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int n = -7;

            yield return new object[] { actuallist, n };
        }
    }
}
