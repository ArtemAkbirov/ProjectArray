using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class DeleteNElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int n = 2;
            int index = 1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 4, 5 });
            yield return new object[] { n, index, list, expectedList };

            n = 2;
            index = 2;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 8 });
            expectedList = new ArrayList(new int[] { 1, 2, 8 });
            yield return new object[] { n, index, list, expectedList };
        }
    }
}
