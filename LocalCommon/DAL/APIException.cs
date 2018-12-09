using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.DAL
{

    public class APIException : Exception
    {
        public APIException() : base(null)
        {
        }
        public APIException(string message) : base(message)
        {
        }
    }

    public class APIConnectionError : APIException
    {
        public APIConnectionError() : base(null)
        {
        }
    }
    public class APIServerError : APIException
    {
        public APIServerError() : base(null)
        {
        }
        public APIServerError(string message) : base(message)
        {
        }
    }
    public class APIUnhandledHttpStatusCodeException : APIException
    {
        public readonly HttpStatusCode httpStatusCode;

        public APIUnhandledHttpStatusCodeException(HttpStatusCode httpStatusCode) : base(httpStatusCode.ToString())
        {
            this.httpStatusCode = httpStatusCode;
        }
    }
}
