using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectList;

namespace ProjectList.Tests.LinkedListTestsSources
{
    public class AddStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 7;
            LinkedList expected = new LinkedList(new int[] { 7, 1, 2, 3, 4, 5, 6, });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            

            yield return new object[] { actuallist, expected, value };

            value = 0;
            expected = new LinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, });
            actuallist = new LinkedList(new int[] {  1, 2, 3, 4, 5, 6 });
            

            yield return new object[] { actuallist, expected, value };
        }
    }
}
