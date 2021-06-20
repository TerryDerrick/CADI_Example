using System;
using System.Collections.Generic;
using System.Text;

namespace CADI_Example.Infrastructure
{
    public interface IDateTime
    {
        System.DateTime Now { get; }
        System.DateTime UtcNow { get; }
    }
}
