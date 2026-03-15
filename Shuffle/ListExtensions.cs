using System;
using System.Collections.Generic;
using System.Text;

namespace Shuffle
{
    public static class ListExtensions
    {
        private static readonly Random _random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }
    }
}
