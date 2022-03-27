using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 5, 4, 3, 2, 1 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 1, 1, 1, 4, 1 });
            expectedList = new ArrayList(new int[] { 1, 4, 1, 1, 1 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 1, 1, 1, 1, 1 });
            expectedList = new ArrayList(new int[] { 1, 1, 1, 1, 1 });
            yield return new object[] { list, expectedList };
        }
    }
}
