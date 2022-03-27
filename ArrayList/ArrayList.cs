using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectList
{
    public class ArrayList
    {
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }
        public ArrayList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
        }
        public int DeleteAllByValue(int value)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
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
            if (Length<n)
            {
                throw new Exception("imposible to delit last numbers");
            }
            if (n < 0)
            {
                throw new ArgumentException("imposible value");
            }
            for (int i = 0; i < n; i++)
            {
                Length--;
            }
        }
        public void DeleteStartNNumbers(int n,int index=0)
        {
            if (Length < n)
            {
                throw new Exception("imposible to delit last numbers");
            }
            if (n < 0)
            {
                throw new ArgumentException("imposible value");
            }
            for (int i = 0; i < n; i++)
            {
                MovieLeft(index);
                Length--;
            }
        }
        public void DeleteNElements(int n,int index)
        {
            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            if (n < 0 || n > _array.Length)
            {
                throw new ArgumentException("range");
            }
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
        public void Reverse()
        {
            int[] arr = new int[Length];
            int j = 0;
            for (int i=Length-1; i>=0; i--)
            {
                arr[j] = _array[i];
                j++;
            }
            _array=arr;
        }
        public int FindMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int max = _array[0];
            for (int i=0; i<Length; i++)
            {
                if (_array[i]>max)
                {
                    max= _array[i];
                }
            }
            return max;
        }
        public int FindMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int min = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }
        public int FindIndexMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] > _array[index])
                {
                    index=i;
                }
            }
            return index;
        }
        public int FindIndexMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] < _array[index])
                {
                    index = i;
                }
            }
            return index;
        }
        public void SortIncrease()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        int z = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = z;
                    }
                }
            }
        }
        public void SortDescending()
        {
            SortIncrease();
            Reverse();
        }
        public int DeleteFirstValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("ArrayList is empty");
            }
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i]==value)
                {
                    MovieLeft(i);
                    index = i;
                    Length--;
                    break;
                }
            }
            return index;
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
        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }

            return s;
        }
        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is ArrayList))
            {
                isEqual = false;
            }
            else
            {
                ArrayList list = (ArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
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