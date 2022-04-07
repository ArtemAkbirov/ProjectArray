using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListTestsSources
{
    public class ChangeElementByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 1, 3, 4, 5, 6 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 1;
            int value = 1;
            yield return new object[] { actuallist, expected, index, value };

            expected = new LinkedList(new int[] { 1, 2, 2, 4, 5, 6 });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 2;
            value = 2;

            yield return new object[] { actuallist, expected, index, value };
        }
    }
}
