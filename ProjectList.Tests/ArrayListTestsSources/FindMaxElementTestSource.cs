using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class FindMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedNumber = 5;
            yield return new object[] {  list, expectedList, expectedNumber };
            
            list = new ArrayList(new int[] { 1, 2, 7, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 7, 2, 5 });
            expectedNumber = 7;
            yield return new object[] { list, expectedList, expectedNumber };

            list = new ArrayList(new int[] { 7, 7, 7, 7, 7 });
            expectedList = new ArrayList(new int[] { 7, 7, 7, 7, 7 });
            expectedNumber = 7;
            yield return new object[] { list, expectedList, expectedNumber };
        }
    }
}
