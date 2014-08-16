using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremis
{
    // Credit to http://stackoverflow.com/users/1467858/horgh
    // from http://stackoverflow.com/questions/14150508/how-to-get-null-instead-of-the-keynotfoundexception-accessing-dictionary-value-b
    // I just made it work.

    public interface INullValueDictionary<T, U>
        where U : class
    {
        U this[T key] { get; }
    }

    public class NullValueDictionary<T, U> : Dictionary<T, U>, INullValueDictionary<T, U>
        where U : class
    {
        U INullValueDictionary<T, U>.this[T key]
        {
            get
            {
                U val;
                TryGetValue(key, out val);
                return val;
            }
        }
    }
}
