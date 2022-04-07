using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListNegativeTestsSources
{
    public class FindIndexByFirstElementNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expected = 3;
            LinkedList actuallist = new LinkedList(new int[] { });
            int value = 4;

            yield return new object[] { actuallist, expected, value };
        }
    }
}
