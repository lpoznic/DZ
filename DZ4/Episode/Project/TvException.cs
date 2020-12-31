using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TVUtilities
{
    [Serializable]
    public class TvException : Exception
    {

        public object Title { get; private set; }


        public TvException() { }
        public TvException(string message, string title) : base(message) {

            Title = title;
        }
        public TvException(string message, Exception innerException) : base(message, innerException) { }
        protected TvException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        
    }
}
