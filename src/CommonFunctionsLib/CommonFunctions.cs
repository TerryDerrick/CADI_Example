namespace CommonFunctionsLib
{
    using System;

    /// <inheritdoc/>
    public class CommonFunctions : ICommonFunctions
    {
        /// <inheritdoc/>
        public int Addition(int a, int b)
        {
            return a + b;
        }

        /// <inheritdoc/>
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
