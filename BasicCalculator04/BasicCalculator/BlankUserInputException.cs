using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BasicCalculator
{
    [Serializable]
    public class BlankUserInputException : Exception
    {

        public BlankUserInputException()
        { 
        }

        public BlankUserInputException(string message):base(message)
        { 
        }

        public BlankUserInputException(string message, Exception innerException):base(message, innerException)
        { 
        }

        public BlankUserInputException(SerializationInfo info, StreamingContext context):base(info,context)
        { 
        
        }
    }
}
