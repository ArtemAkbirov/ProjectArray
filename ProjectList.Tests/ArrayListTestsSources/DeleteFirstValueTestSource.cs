using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class DeleteFirstValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 3, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 5 });
            int expectedNumber = 2;
            yield return new object[] { value, list, expectedList, expectedNumber };


            value = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 2, 5 });
            expectedNumber = 1;
            yield return new object[] { value, list, expectedList, expectedNumber };

        }
    }
}
