namespace MagicBoxLib
{
    public static class MagicBox
    {
        public static int Calculate(int[] input)
        {
            int deposit = 0;
            int balance = 0;
            for (int i = 0; i < input.Length; i++)
            {
                balance = balance * 2;
                balance += input[i];
            }
            return balance;
        }

    }
}

//1 1 4 8 20
