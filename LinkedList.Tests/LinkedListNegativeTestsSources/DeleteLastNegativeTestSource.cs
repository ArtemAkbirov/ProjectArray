using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.LinkedListNegativeTestsSources
{
    public class DeleteLastNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList actuallist = new LinkedList(new int[] {});
          
            yield return new object[] { actuallist };
        }
    }
}
