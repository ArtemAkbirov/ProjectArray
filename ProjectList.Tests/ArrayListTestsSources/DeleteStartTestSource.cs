using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class DeleteStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };

            list = new ArrayList(new int[] { 1, 2, 3, 4, 8 });
            expectedList = new ArrayList(new int[] { 2, 3, 4, 8 });
            yield return new object[] { list, expectedList };
        }
    }
}
