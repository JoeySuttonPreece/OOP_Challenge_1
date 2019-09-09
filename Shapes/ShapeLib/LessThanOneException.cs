using System;

namespace ShapeLib
{
    public class LessThanOneException : Exception
    {
        public LessThanOneException() { }

        public LessThanOneException(string message) : base(message) { }

        public LessThanOneException(string message, Exception inner) : base(message, inner) { }
    }
}
