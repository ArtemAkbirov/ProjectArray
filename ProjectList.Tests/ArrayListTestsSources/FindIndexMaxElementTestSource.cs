using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class FindIndexMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedIndex = 4;
            yield return new object[] { list, expectedList, expectedIndex };

            list = new ArrayList(new int[] { 1, 2, 7, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 7, 2, 5 });
            expectedIndex = 2;
            yield return new object[] { list, expectedList, expectedIndex };

            list = new ArrayList(new int[] { 7, 7, 7, 7, 7 });
            expectedList = new ArrayList(new int[] { 7, 7, 7, 7, 7 });
            expectedIndex = 0;
            yield return new object[] { list, expectedList, expectedIndex };
        }
    }
}
