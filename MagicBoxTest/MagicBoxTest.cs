using MagicBoxLib;

namespace MagicBoxTest
{
    public class MagicBoxTest
    {
        [Theory]
        [InlineData(new int[] { 1, -1, 2, 0, 4 }, 20)]
        public void Calculate(int[] param, int result) => Assert.Equal(result, MagicBox.Calculate(param));
    }
}
