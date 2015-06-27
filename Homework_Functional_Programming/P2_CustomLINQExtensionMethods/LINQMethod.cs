using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CustomLINQExtensionMethods
{
    static class LINQMethod
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {
            IEnumerable<T> result = collection.Where(predicate);
            return result;
        }
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) 
        {
            
            List<T> repeat = new List<T>();
            for (int i = 0; i < count; i++)
            {
                foreach(var item in collection)
                {
                    repeat.Add(item);
                }
            }
            IEnumerable<T> result = repeat;
            return result;
        }
        public static IEnumerable<string> WhereEndsWith<T>(this IEnumerable<string> collection, IEnumerable<string> suffixes) 
        {
            List<string> add = new List<string>();
            foreach (var suffix in suffixes)
	        {
		       var res = collection.Where(item =>
                {
                    return item.ToLower().EndsWith(suffix.ToLower());
                });
                foreach(var item in res)
                {
                    add.Add(item);
                }
	        }
            IEnumerable<string> result = add;
            return result;           
        }
    }
}
