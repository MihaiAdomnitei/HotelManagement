using System;

namespace Lab1.exceptions
{
    public class ExistentEntityException : Exception
    {
        public ExistentEntityException() { }

        public ExistentEntityException(string message) : base(message) { }

        public ExistentEntityException(string message, Exception cause) : base(message, cause) { }

        public ExistentEntityException(Exception cause) : base(cause.ToString()) { }

        public ExistentEntityException(string message, Exception cause, bool enableSuppression, bool writableStackTrace) : base(message, cause)
        {
            // Custom implementation if needed
        }
    }
}