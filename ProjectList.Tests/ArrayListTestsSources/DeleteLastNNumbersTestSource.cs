using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class DeleteLastNNumbersTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3});
            yield return new object[] { value, list, expectedList };

            value = 1;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 3, 4});
            yield return new object[] { value, list, expectedList };
        }
    }
}
