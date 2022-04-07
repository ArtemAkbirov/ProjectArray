using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListNegativeTestsSources
{
    public class DeleteNElementsByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] { });
            int index = -2;
            int value = 1;
            yield return new object[] { actuallist, index, value };

            actuallist = new LinkedList(new int[] { });
            index = 8;
            value = 0;
            yield return new object[] { actuallist, index, value };

            actuallist = new LinkedList(new int[] { 1, 2, 3, 4 });
            index = 2;
            value = 5;
            yield return new object[] { actuallist, index ,value };
        }
    }
}
