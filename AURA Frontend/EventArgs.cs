using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public class EventArgs<T> : EventArgs
    {
        public T Value { get; }

        public EventArgs(T value)
        {
            Value = value;
        }
    }
}
