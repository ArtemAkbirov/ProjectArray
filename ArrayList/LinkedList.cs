using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectList
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {

            }
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }
            private set
            {
            }
        }

        public LinkedList()
        {
            _root = null;

            _tail = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }
        public LinkedList(int[] values)
        {
            if (values.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    AddLast(values[i]);
                }
            }
        }
        

        public void AddLast(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                //Node crnt = _root;

                //while (crnt.Next != null)
                //{
                //    crnt = crnt.Next;
                //}

                //crnt.Next = new Node(value);

                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }
        public void AddStart(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }
        public void AddByIndex(int value, int index)
        {
            if (index < 0 || index >= Length + 1)
            {
                throw new ArgumentException("This index doesn't exist");
            }
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                if (index==0)
                {
                    AddStart(value);
                }
                else
                {
                    Node prevNode = GetNode(index-1);
                    Node nextNode = GetNode(index);
                    Node newNode = new Node(value);
                    prevNode.Next= newNode;
                    newNode.Next = nextNode;
                }
            }
        }
        public void DeleteLast()
        {
            if (Length<1)
            {
                throw new Exception("Nothing to delete");
            }
            if (Length==1)
            {
                _root = null;
                _tail= null;
            }
            else
            {
                Node lastNode = GetNode(Length-2);
                lastNode.Next = null;
                _tail = lastNode;
            }
        }
        public void DeleteStart()
        {
            if (Length < 1)
            {
                throw new Exception("Nothing to delete");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = _root.Next;
            }
        }
        public void DeleteByIndex(int index)
        {
            
            if (index < 0 || index >= Length)
            {
                throw new ArgumentException("This index doesn'n exist");
            }
            else if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node prevNode = GetNode(index - 1);
                Node nextNode = GetNode(index + 1);
                if (index == Length - 1)
                {
                    _tail = nextNode;
                }
                prevNode.Next = nextNode;
            }
        }
        public void DeleteLastNElements(int value)
        {
            if (Length < 1)
            {
                throw new Exception("Nothing to delete");
            }
            if (value >= Length)
            {
                throw new ArgumentException("Can't remove more than there is");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node lastNode = GetNode(Length - 1 - value);
                lastNode.Next = null;
                _tail = lastNode;
            }
        }
        public void DeleteStartNElements(int value)
        {
            
            if (value >= Length)
            {
                throw new ArgumentException("Can't remove more than there is");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node firstNode = GetNode(value);
                _root = firstNode;
            }
        }
        public void DeleteNElementsByIndex(int index, int value)
        {
            if (Length <= 0)
            {
                throw new Exception("Nothing to delete");
            }
            if (index < 0 || index >= Length || value >Length)
            {
                throw new ArgumentException("This index doesn'n exist");
            }
                Node prevNode = GetNode(index - 1);
                Node nextNode = GetNode(index + value);
                if (index == 0)
                {
                    _root = nextNode;
                }
                else
                {
                    prevNode.Next = nextNode;
                }
        }
        public int FindIndexByFirstElement(int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int index = -1;
            Node crnt = _root;
            for (int i = 0; crnt != null; i++)
            {
                if (crnt.Value == value)
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }
        public void ChangeElementByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            Node changeNode = GetNode(index);
            changeNode.Value = value;
        }
        public void Reverse()
        {
            if (_tail is null)
            {
                throw new Exception();
            }
            Node crnt = _root;
            Node next;
            while (crnt.Next != null)
            {
                next = crnt.Next;
                crnt.Next = next.Next;
                next.Next = _root;
                _root = next;
            }
            _tail = crnt;
        }

        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return s;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }

        private Node GetNode(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }
            return crnt;
        }
    }
}
