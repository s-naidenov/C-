using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    public class ReversedList<T> : IEnumerable, IEnumerator
    {
        private List<T> _list;
        private int _position = -1;

        public ReversedList(int capacity = 0)
        {
            _list = new List<T>(capacity);
        }

        public void Add(T elem)
        {
            _list.Add(elem);
            _position = _list.Count;
        }

        public object Current
        {
            get
            {
                if (_position > -1)
                { 
                    return _list[_position];
                }
                throw new InvalidOperationException();

            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_position > 0)
            {
                _position--;
                return true;
            
            }
            return false;

        }

        public void Reset()
        {
            _position = _list.Count;
            if (_position == 0)
            {
                _position = -1;
            }
        }
    }
}
