using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListNegativeTestsSources
{
    public class DeleteNElementsNegativeTestSource_WhenNLessThanZeroOrMoreThanLength : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int n = 21;
            int index = 2;

            yield return new object[] { actuallist, n, index };

            actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            n = 23;
            index = 3;

            yield return new object[] { actuallist, n, index };
        }
    }
}
