using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListNegativeTestsSources
{
    public class DeleteNElementsNegativeTestSource_WhenIndexLessThanZeroOrMoreThanLenght : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int n = 2;
            int index = 21;

            yield return new object[] { actuallist, n, index };

            actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            n = 2;
            index = 41;

            yield return new object[] { actuallist, n, index };
        }
    }
}
