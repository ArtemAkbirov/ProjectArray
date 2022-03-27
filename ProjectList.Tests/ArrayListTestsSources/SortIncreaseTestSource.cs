using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class SortIncreaseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 4, 2, 3, 1, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 1, 1, 1, 4, 1 });
            expectedList = new ArrayList(new int[] { 1, 1, 1, 1, 4 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 1, 1, 1, 1, 1 });
            expectedList = new ArrayList(new int[] { 1, 1, 1, 1, 1 });
            yield return new object[] { list, expectedList };
        }
    }
}
