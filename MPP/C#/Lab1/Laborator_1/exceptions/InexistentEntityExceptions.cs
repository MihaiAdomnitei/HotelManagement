using System;

namespace Lab1.exceptions
{
    public class InexistentEntityException : Exception
    {
        public InexistentEntityException() { }

        public InexistentEntityException(string message) : base(message) { }

        public InexistentEntityException(string message, Exception cause) : base(message, cause) { }

        public InexistentEntityException(Exception cause) : base(cause.ToString()) { }

        public InexistentEntityException(string message, Exception cause, bool enableSuppression, bool writableStackTrace) : base(message, cause)
        {
            // Custom implementation if needed
        }
    }
}