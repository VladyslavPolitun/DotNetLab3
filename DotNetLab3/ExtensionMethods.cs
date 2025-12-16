using System;
using System.Collections.Generic;

namespace DotNetLab3
{
    public static class ExtensionMethods
    {
        public static string ReverseString(this string value)
        {
            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static int CountChar(this string value, char symbol)
        {
            int count = 0;
            foreach (char c in value)
            {
                if (c == symbol)
                    count++;
            }
            return count;
        }

        public static int CountOccurrences<T>(this T[] array, T value)
            where T : IEquatable<T>
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item.Equals(value))
                    count++;
            }
            return count;
        }

        public static T[] UniqueElements<T>(this T[] array)
            where T : IEquatable<T>
        {
            List<T> result = new List<T>();

            foreach (var item in array)
            {
                if (!result.Contains(item))
                    result.Add(item);
            }

            return result.ToArray();
        }
    }
}
