using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListTestsSources
{
    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 7;
            int index = 6;
            yield return new object[] { actuallist, expected, value, index };

            expected = new LinkedList(new int[] { 7, 1, 2, 3, 4, 5, 6, });
            actuallist = new LinkedList(new int[] {  1, 2, 3, 4, 5, 6 });
            value = 7;
            index = 0;

            yield return new object[] { actuallist, expected, value, index };
        }
    }
}
