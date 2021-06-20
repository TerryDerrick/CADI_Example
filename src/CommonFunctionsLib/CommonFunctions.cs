namespace CommonFunctionsLib
{
    using System;

    /// <inheritdoc/>
    public class CommonFunctions : ICommonFunctions
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
