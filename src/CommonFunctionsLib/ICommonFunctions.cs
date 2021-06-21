namespace CommonFunctionsLib
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Common Functions Interface.
    /// </summary>
    public interface ICommonFunctions
    {
        /// <summary>
        /// Addition.
        /// </summary>
        /// <param name="a">value 1.</param>
        /// <param name="b">value 2.</param>
        /// <returns>int result.</returns>
        int Subtract(int a, int b);

        /// <summary>
        /// Subtraction.
        /// </summary>
        /// <param name="a">value 1.</param>
        /// <param name="b">value 2.</param>
        /// <returns>int result.</returns>
        int Addition(int a, int b);
    }
}
