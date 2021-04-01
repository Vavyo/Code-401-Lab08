using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses.Classes
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> contents = new List<T>();
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in contents)
            {
                yield return item;
            }
        }

        public void Pack(T item)
        {
            contents.Add(item);
        }

        public T Unpack(int index)
        {
            T item = contents[index];
            contents.RemoveAt(index);
            return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
