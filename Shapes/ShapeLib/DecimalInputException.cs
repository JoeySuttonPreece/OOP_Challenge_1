using System;

namespace ShapeLib
{
    public class DecimalInputException : Exception
    {
        public DecimalInputException() { }

        public DecimalInputException(string message) : base(message) { }

        public DecimalInputException(string message, Exception inner) : base(message, inner) { }
    }
}