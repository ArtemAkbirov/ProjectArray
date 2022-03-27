using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class FindIndexMinElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expectedIndex = 0;
            yield return new object[] { list, expectedList, expectedIndex };

            list = new ArrayList(new int[] { 7, 2, 7, 0, 5 });
            expectedList = new ArrayList(new int[] { 7, 2, 7, 0, 5 });
            expectedIndex = 3;
            yield return new object[] { list, expectedList, expectedIndex };

            list = new ArrayList(new int[] { 7, 7, 7, 7, 7 });
            expectedList = new ArrayList(new int[] { 7, 7, 7, 7, 7 });
            expectedIndex = 0;
            yield return new object[] { list, expectedList, expectedIndex };
        }
    }
}
