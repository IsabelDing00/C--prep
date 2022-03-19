using System;

namespace Assign04
{
	/*1.void Add (T element)2.T Remove (int index)
	 * 3.bool Contains (T element)4.void Clear ()5.void InsertAt (T element, int index)
	 * 6.void DeleteAt (int index)7.T  Find (int index)*/
	public class MyList<T>
	{
		MyList<T> list = new MyList<T>;
		public void Add(T element)
        {
			list.Add(element);
        }

		public T Remove(int index)
        {
			list.Remove(index);
			return list[index];
        }

		public bool Contains(T element)
        {
			if (list.Contains(element))
			{ 
				return true; 
			}
            return false;	
        }

		public void Clear()
        {
			list.Clear();
        }

		public void InsertAt(T element, int index)
		{
			list.InsertAt(index, element);
		}

		public void DeleteAt(int index)
        {
			list.Remove(index);
        }

		public T Find(int index)
        {
			return list[index];
        }
	}
}
