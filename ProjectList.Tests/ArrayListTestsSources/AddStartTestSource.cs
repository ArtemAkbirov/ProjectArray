using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class AddStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 3, 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };

            value = 1;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };

            value = 0;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] {0, 1, 2, 3, 4, 5 });
            yield return new object[] { value, list, expectedList };
        }
    }
}
