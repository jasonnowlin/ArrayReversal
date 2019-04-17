using System;

namespace ArrayReversal
{
    public static class ArrayUtil
    {
        public static int[] reverseLikeNoob(int[] arr)
        {
            if (arr == null)
            {
                return null;
            }

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
            if (arr == null)
            {
                return null;
            }

            for (var i = 0; i < arr.Length / 2; i++)
            {
                arr[i] = arr[i] ^ arr[arr.Length - 1 - i] ^ (arr[arr.Length - 1 - i] = arr[i]);
            }

            return arr;
        }

        public static void reverseLikeZenMaster(int[] arr)
        {
            if (arr != null)
            {
                // Someone already solved this problem, next task please!
                Array.Reverse(arr);
            }
        }

        public static int[] reverseLikeMicrosoft(int[] arr)
        {
            if (arr == null)
            {
                return null;
            }

            var i = 0;
            var j = arr.Length - 1;
            while (i < j)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }

            return arr;
        }

        public static int[] copyAndReverse(int[] arr)
        {
            if (arr == null)
            {
                return null;
            }

            var copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);
            Array.Reverse(copy);

            return copy;
        }
    }
}
