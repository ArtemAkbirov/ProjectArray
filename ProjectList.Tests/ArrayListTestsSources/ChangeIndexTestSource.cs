using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class ChangeIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            int index = 2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 2, 4, 5 });
            yield return new object[] { value, index, list, expectedList };

            value = 2;
            index = 0;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 2, 2, 3, 4, 5 });
            yield return new object[] { value, index, list, expectedList };

            value = 0;
            index = 3;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 3, 0, 5 });
            yield return new object[] { value, index, list, expectedList };

           
        }
    }
}
