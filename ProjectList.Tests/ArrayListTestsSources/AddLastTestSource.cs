using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 3 });
            yield return new object[] { value, list, expectedList};

            value = 1;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 1 });
            yield return new object[] { value, list, expectedList };

            value = 0;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 0 });
            yield return new object[] { value, list, expectedList };
        }
    }
}
