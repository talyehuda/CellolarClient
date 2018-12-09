using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.DAL
{


    /// <summary>
    /// exception from the web API access layer
    /// </summary>
    public class APIException : Exception
    {
        public APIException() : base(null)
        {
        }
        public APIException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// connection error from the web api client to the server
    /// </summary>
    public class APIConnectionError : APIException
    {
        public APIConnectionError() : base(null)
        {
        }
    }

    /// <summary>
    /// error from the web API server, holds a message from the server
    /// </summary>
    public class APIServerError : APIException
    {
        public APIServerError() : base(null)
        {
        }
        public APIServerError(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// unhandled error status code from the web API server
    /// </summary>
    public class APIUnhandledHttpStatusCodeException : APIException
    {
        public readonly HttpStatusCode httpStatusCode;

        public APIUnhandledHttpStatusCodeException(HttpStatusCode httpStatusCode) : base(httpStatusCode.ToString())
        {
            this.httpStatusCode = httpStatusCode;
        }
    }
}
