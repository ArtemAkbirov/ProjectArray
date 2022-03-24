using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class AddIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int Index = 3;
            int value = 1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 1, 4, 5 });
            yield return new object[] { value, Index, list, expectedList };
            
            Index = 1;
            value = 3;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 3, 2, 3, 4, 5 });
            yield return new object[] { value, Index, list, expectedList };

            Index = 0;
            value = 10;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 10, 1, 2, 3, 4, 5 });
            yield return new object[] { value, Index, list, expectedList };
        }
    }
}
