﻿using System;

namespace Core.Exceptions
{
    public class DbException : Exception
    {
        public DbException(string message):base(message)
        {
            
        }
    }
}