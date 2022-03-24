using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class DeleteIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int Index = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 5 });
            yield return new object[] { Index, list, expectedList };

            Index = 1;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1,  3, 4, 5 });
            yield return new object[] { Index, list, expectedList };
        }
    }
}
