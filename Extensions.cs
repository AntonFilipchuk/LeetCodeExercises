using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Extensions
    {
        public static string ValuesAsString(this Array array)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    sb.Append(array.GetValue(i) == null ? "null" : array.GetValue(i)!.ToString());
                    continue;
                }
                sb.Append(array.GetValue(i) == null ? "null" : array.GetValue(i)!.ToString());
                sb.Append(", ");
            }

            return $"[{sb.ToString()}]";
        }

        public static string ValuesAsString<T>(this List<T> list)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    sb.Append(list[i] == null ? "null" : list[i]!.ToString());
                    continue;
                }
                sb.Append(list[i] == null ? "null" : list[i]!.ToString());
                sb.Append(", ");
            }

            return $"[{sb.ToString()}]";
        }
    }
}
