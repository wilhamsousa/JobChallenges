namespace MagicBoxLib
{
    /// <summary>
    /// Para cada moeda colocada em uma caixa é criada uma moeda adicional no dia seguinte.
    /// Para cada moeda retirada da caixa, uma moeda desaparece da caixa imediatamente
    /// Ex: { 1, 2, -1 } Dia 0 entra uma moeda, dia 1 entra 2, dia 3 sai 1
    /// </summary>
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
