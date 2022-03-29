
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace ProjectList
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
