using System;

namespace DSA.Lab01
{
    public static class SearchAlgorithms
    {
        public static int LinearSearch(int[] values, int target)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            for (int i = 0; i < values.Length; ++i)
            {
                if (values[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] sortedValues, int target)
        {
            if (sortedValues == null)
            {
                throw new ArgumentNullException(nameof(sortedValues));
            }

            // TODO: Implement binary search.
            // The input to this method is guaranteed to be sorted in ascending order.
            //
            // Suggested plan:
            // 1. Keep track of a low and high index.
            // 2. Inspect the middle value.
            // 3. Return the index if it matches.
            // 4. Otherwise discard either the lower or upper half.
            // 5. Repeat while there is still a valid search range.

            int start = 0;
            int end = sortedValues.Length;

            while (start <= end)
            {
                int calcMid = start + (end - start)/2;


                if (sortedValues[calcMid] == target) return calcMid;
                else
                {
                    if(sortedValues[calcMid] > target) end = calcMid - 1;
                    else if (sortedValues[calcMid] < target) start = calcMid + 1;
                }
            }

            return -1;
        }
    }
}
