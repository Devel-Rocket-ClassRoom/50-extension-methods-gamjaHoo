using System;
using System.Collections.Generic;
using System.Text;

namespace Chunk
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int size)
        {
            if (size < 1)
                throw new ArgumentException("Chunk size must be greater than 0.");

            List<T> chunk = new List<T>(size);

            foreach (var item in source)
            {
                chunk.Add(item);

                if (chunk.Count == size)
                {
                    yield return chunk;
                    chunk = new List<T>(size);
                }
            }

            if (chunk.Count > 0)
                yield return chunk;
        }
    }
}
