using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListNegativeTestsSources
{
    public class ChangeElementByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = -1;
            int value = 1;
            yield return new object[] { actuallist, index, value };

            
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 12;
            value = 2;

            yield return new object[] { actuallist, index, value };
        }
    }
}
