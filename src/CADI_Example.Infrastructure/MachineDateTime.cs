using System;
using System.Collections.Generic;
using System.Text;

namespace CADI_Example.Infrastructure
{
    /// <summary>
    /// Localised Machine Implementation of DateTime.
    /// </summary>
    public class MachineDateTime : IDateTime
    {
        /// <inheritdoc/>
        public DateTime Now => DateTime.Now;

        /// <inheritdoc/>
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
