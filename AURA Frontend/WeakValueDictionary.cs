using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AURA_Frontend
{
    public class WeakValueDictionary<TKey, TValue> where TKey : class where TValue : class
    {
        private readonly Dictionary<TKey, WeakReference<TValue>> r_Dictionary = new();
        private readonly ConditionalWeakTable<TValue, ScreenFinalizer> r_TrackerTable = new();

        public TValue this[TKey key]
        {
            get
            {
                TryGetValue(key, out TValue value);
                return value;
            }
            set => addOrUpdate(key, value);
        }

        private void addOrUpdate(TKey key, TValue value)
        {
            r_Dictionary[key] = new WeakReference<TValue>(value);
            r_TrackerTable.Add(value, new ScreenFinalizer(() => Remove(key)));
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = null;

            if (r_Dictionary.TryGetValue(key, out var weakRef))
            {
                if (weakRef.TryGetTarget(out value))
                {
                    return true;
                }
                else
                {
                    // Value has been collected, remove the stale entry
                    r_Dictionary.Remove(key);
                }
            }

            return false;
        }

        public void Remove(TKey key)
        {
            r_Dictionary.Remove(key);
        }

        public void CleanDeadEntries()
        {
            var deadKeys = r_Dictionary
                .Where(kvp => !kvp.Value.TryGetTarget(out _))
                .Select(kvp => kvp.Key)
                .ToList();

            foreach (var key in deadKeys)
            {
                r_Dictionary.Remove(key);
            }
        }

        public int Count => r_Dictionary.Count;
        public IEnumerable<TKey> Keys => r_Dictionary.Keys;


        private class ScreenFinalizer
        {
            private event Action Destroyed;

            public ScreenFinalizer(Action destroyed)
            {
                Destroyed = destroyed;
            }

            ~ScreenFinalizer()
            {
                Destroyed?.Invoke();
            }
        }
    }
}
