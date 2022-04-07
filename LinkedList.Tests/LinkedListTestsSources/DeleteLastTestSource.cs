using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListTestsSources
{
    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });


            yield return new object[] { actuallist, expected };

            expected = new LinkedList(new int[] { 0, 1, 2, 3, 4 });
            actuallist = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5 });


            yield return new object[] { actuallist, expected };
        }
    }
}
