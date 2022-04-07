using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListTestsSources
{
    public class DeleteNElementsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 3, 4, 5, 6 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 0;
            int value = 2;
            yield return new object[] { actuallist, expected, index, value };

            expected = new LinkedList(new int[] { 1, 2, 3 });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 3;
            value = 3;
            yield return new object[] { actuallist, expected, index, value };
        }
    }
}
