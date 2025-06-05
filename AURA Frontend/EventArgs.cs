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

        public static implicit operator EventArgs<T>(T value)
        {
            return new EventArgs<T>(value);
        }

        public static explicit operator T(EventArgs<T> e)
        {
            return e.Value;
        }
    }
}
