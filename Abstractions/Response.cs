using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Abstractions
{
    public class Response<T>
    {
        private int errorCode;
        public Response()
        {
            Timestamp = DateTime.Now;
            Errors = new List<String>();
        }

        public DateTime Timestamp { get; private set; }
        public List<String> Errors { get; set; }
        public Boolean Succeed => !Errors.Any();

        [JsonIgnore]
        public int ErrorCode
        {
            get { return errorCode; }
            set
            {
                if (value <= errorCode) return;
                errorCode = value;
            }
        }
    }
}
