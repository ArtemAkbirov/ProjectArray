using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList.Tests.ArrayListNegativeTestsSources
{
    public class AddIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 8;
            int index = -21;

            yield return new object[] { actuallist, value, index };


            actuallist = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            value = 8;
            index = 8;

            yield return new object[] { actuallist, value, index };
        }
    }
}
