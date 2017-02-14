using System;
using System.Runtime.Serialization;

namespace MainContainer.Exception
{
    [Serializable]
    internal class OverBurdendException : System.Exception
    {
        public OverBurdendException()
        {
        }

        public OverBurdendException(string message) : base(message)
        {
        }

        public OverBurdendException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected OverBurdendException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}