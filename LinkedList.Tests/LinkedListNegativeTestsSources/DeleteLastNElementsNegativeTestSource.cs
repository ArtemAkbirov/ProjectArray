using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListNegativeTestsSources
{
    public class DeleteLastNElementsNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { });
            int value = 1;
            yield return new object[] { actuallist, value};

            actuallist = new LinkedList(new int[] { });
            value = 0;
            yield return new object[] { actuallist, value };

            actuallist = new LinkedList(new int[] { 1, 2, 3, 4});
            value = 5;
            yield return new object[] { actuallist, value };
        }
    }
}
