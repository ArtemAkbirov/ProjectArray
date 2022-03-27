using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListNegativeTestsSources
{
    public class DeleteStartNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int index = -21;

            yield return new object[] { actuallist,  index };

            actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            index = 21;

            yield return new object[] { actuallist, index };
        }
    }
}
