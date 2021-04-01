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
            throw new NotImplementedException();
        }

        public void Pack(T item)
        {
            throw new NotImplementedException();
        }

        public T Unpack(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
