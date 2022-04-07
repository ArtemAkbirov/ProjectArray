using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListNegativeTestsSources
{
    public class DeleteByIndextNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { });
            int index = 2;
            yield return new object[] { actuallist, index };

            actuallist = new LinkedList(new int[] { 1, 2 ,3 ,4 });
            index = -2;
            yield return new object[] { actuallist, index };

            actuallist = new LinkedList(new int[] { 1, 2, 3, 4 });
            index = 6;
            yield return new object[] { actuallist, index };

        }
    }
}
