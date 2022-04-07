using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListTestsSources
{
    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 5, 6});
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = 3;
            yield return new object[] { actuallist, expected, index };

            expected = new LinkedList(new int[] { 2, 3, 4, 5, 6, });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 0;
            yield return new object[] { actuallist, expected, index };
        }
    }
}
