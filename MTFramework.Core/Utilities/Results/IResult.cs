using System;
using System.Collections.Generic;
using System.Text;

namespace MTFramework.Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        String Message { get; }
    }
}
