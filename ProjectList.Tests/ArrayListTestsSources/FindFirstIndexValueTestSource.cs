using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListTestsSources
{
    public class FindFirstIndexValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            int expected = 1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, expected, list };

            value = 4;
            expected = 3;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, expected, list };

            value = 6;
            expected = -1;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, expected, list };
        }
    }
}
