namespace IsEqualWithInvertLib
{
    /// <summary>
    /// Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.
    /// </summary>
    public static class IsEqualWithInvert
    {
        public static bool Solution(int[] a, int[] b)
        {
            bool inverted = false;
            for (int x = 0; x < a.Length; x++)
                if (a[x] != b[x])
                {
                    if (x < (a.Length - 1) && !inverted)
                        Invert(a, b, x, a[x]);

                    inverted = true;

                    if (a[x] != b[x])
                        return false;
                }

            return true;
        }

        private static void Invert(int[] a, int[] b, int positionStart, int value)
        {
            for (int x = positionStart + 1; x < b.Length; x++)
                if (b[x] == value && a[x] != b[x])
                {
                    int backup = b[positionStart];
                    b[positionStart] = b[x];
                    b[x] = backup;
                    return;
                }
        }
    }
}
