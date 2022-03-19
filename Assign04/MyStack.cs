using System;

namespace Assign04
{
    //Create a custom Stack class  MyStack<T> that can be used with any data type which 
    public class MyStack<T>
    {
        // has following methods: int Count(), T pop(), Void Push()
        List<T> list = new List<T>();
        public int Count()
        {
            return list.Count;
        }

        public T pop()
        {
            T value = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return value;
            
        }
        public void Push(T item)
        {
            list.Add(item);    
        }
    }

}
