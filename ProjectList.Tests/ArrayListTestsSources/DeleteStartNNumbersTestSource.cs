using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class DeleteStartNNumbersTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 3, 4, 5 });
            yield return new object[] { value, list, expectedList };

            value = 3;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 8 });
            expectedList = new ArrayList(new int[] { 4, 8 });
            yield return new object[] { value,list, expectedList };
        }
    }
}
