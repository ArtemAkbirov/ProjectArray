using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectList
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public void AddLast(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }
        public void AddStart(int value, int index=0) 
        {
            if (Length+1>=_array.Length)
            {
                UpSize();
            }
            MovieRight(index);
            _array[0] = value;
            Length++;
        }
        public void AddIndex(int index, int value)
        {
            if (Length + 1 >= _array.Length)
            {
                UpSize();
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            MovieRight(index);
            _array[index] = value;
            Length++;
        }

        public void DeleteLast()
        {
            Length--;
        }
        public void DeleteStart(int index=0)
        {
            if (Length + 1 >= _array.Length)
            {
                UpSize();
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            MovieLeft(index);
            Length--;
        }
        public void DeleteIndex(int index)
        {
            if (Length + 1 >= _array.Length)
            {
                UpSize();
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            MovieLeft(index);
            Length--;
        }
        public void DeleteLastNNumbers(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Length--;
            }
        }
        public void DeleteStartNNumbers(int n,int index=0)
        {
            for (int i = 0; i < n; i++)
            {
                MovieLeft(index);
                Length--;
            }
        }
        public void DeleteNElements(int n,int index)
        {
            int[] arr = new int[Length - n];
            for (int i = 0; i < index; i++)
            {
                arr[i] = _array[i];
            }
            for (int i = index; i < arr.Length; i++)
            {
                arr[i] = _array[i + n];
            }
            _array = arr;
        }
        public int GetLength()
        {
            return Length;
        }
        public int GetIndexValue(int index)
        {
            return _array[index];
        }
        public int FindFirstIndexValue(int value)
        {
            int count = -1;
            for(int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count=i;
                    break;
                }
            }
            return count;
        }
        public void ChangeIndex(int index, int value)
        {
            if (Length == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            if (index > Length)
            {
                throw new Exception("The index does not exist");
            }
            if (index < 0)
            {
                throw new Exception("The index does not exist");
            }
            _array[index] = value;
        }
        public void Write()
        {
            Console.Write($"L={Length} RL={_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        private void MovieRight(int index)
        {
            int[] arr = new int[Length + 1];
            for (int i = 0; i < index; i++)
            {
                arr[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                arr[i+1] = _array[i];
            }
            _array = arr;
        }
        private void MovieLeft(int index)
        {
            int[] arr = new int[Length-1];
            for (int i = 0; i < index; i++)
            {
                arr[i] = _array[i];
            }
            for (int i = index; i < Length - 1; i++)
            {
                arr[i] = _array[i+1];
            }
            _array = arr;
        }
        private void DeleteN(int count, int index)
        {
            int[] arr = new int[Length-count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = _array[i];
            }
            for (int i = index; i < arr.Length; i++)
            {
                arr[i]=_array[i+count];
            }
            _array = arr;
        }

    }
}