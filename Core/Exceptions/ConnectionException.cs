using System;

namespace Core.Exceptions
{
    public class ConnectionException : Exception
    {
        public ConnectionException(string message):base(message)
        {
            
        }
    }
}