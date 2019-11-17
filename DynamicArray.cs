using System;
namespace DynamicArrayImplementation
{
    public class DynamicArray<T> : IEnumerable
	{
		private T[] staticArray;
		private int count = 0; //Amount of array space filled tracker.
		private int capacity = 0; //Actual array size.

        //Automatic capcity constructor.
		public DynamicArray()
		{
			//You can actually pass in parameters into the "this" keyword which will allocate them to the class properties in order.
			//So 16 will be passed into the staticArray property and initialises an internal static array of size 16.
			this(16);
		}

        //Constructor with specified capacity.
		public DynamicArray(int capacity)
		{
			if (capacity < 0) throw new IllegalArgumentException("Illegal capcity:" + capacity);
			this.capacity = capacity;
            //(T[]) we are casting into a static array type with generic element type.
			staticArray = (T[]) new Object[capacity];
		}

        public int Count()
		{
            for (int i = 0; i < capacity; i++)
			{
                if (staticArray[i] != null)
				{
					count += 1;
				}
			}

			return count;
		}

        public bool IsEmpty()
		{
			return Count() == 0;
		}

        public T Get(int index)
		{
			return staticArray[index];
		}

        public void Set(int index, T elementValue)
		{
			staticArray[index] = elementValue;
		}

        public void Clear()
		{
            for (int i = 0; i < capacity; i++)
			{
				staticArray[i] = null;
			}

			count = 0;
		}

        public void Add(T elementValue)
		{
            if (Count() + 1 >= capacity)
			{
				capacity *= 2;
                var newArray = (T[]) new Object[capacity];

                for (int i = 0; i < Count(); i++)
				{
					newArray[i] = staticArray[i];
				}

				staticArray = newArray;
			}

			staticArray[Count()++] = elementValue;
		}

        public T RemoveAt(int index)
		{
			if (index >= Count() || index < 0) return IndexOutOfRangeException();
			var removedElementByIndex = staticArray[index];
			staticArray[index] = null;

			return removedElementByIndex;
		}

        public bool RemoveByObject(Object elementValue)
		{
            for (int i = 0; i < capacity; i++)
			{
                if (staticArray[i] == elementValue)
				{
					RemoveAt(i);
					return true;
				}
			}

			return false;
		}

        public int IndexOf(Object elementValue)
		{
            for (int i = 0; i < capacity; i++)
			{
                if (staticArray[i] == elementValue)
				{
					return i;
				}
			}

			return -1;
		}

        public bool Contains(Object elementValue)
		{
			return IndexOf() != -1;
		}

    }
}
