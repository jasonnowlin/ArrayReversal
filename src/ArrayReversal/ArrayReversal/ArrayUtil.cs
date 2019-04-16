using System;

namespace ArrayReversal
{
    public static class ArrayUtil
    {
        public static int[] reverseLikeNoob(int[] arr)
        {
            for (var i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            return arr;
        }

        public static int[] reverseLikePro(int[] arr)
        {
            for (var i = 0; i < arr.Length / 2; i++)
            {
                arr[i] = arr[i] ^ arr[arr.Length - 1 - i] ^ (arr[arr.Length - 1 - i] = arr[i]);
            }
            return arr;
        }

        public static int[] reverseLikeZenMaster(int[] arr)
        {
            // Someone already solved this problem, next task please!
            Array.Reverse(arr);
            return arr;
        }
    }
}
