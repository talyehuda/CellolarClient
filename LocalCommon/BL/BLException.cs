using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.BL
{
    /// <summary>
    /// exception in the BL layer
    /// </summary>
    public class BLException : Exception
    {

        public BLException() : base()
        {
        }

        public BLException(string message) : base(message)
        {
        }
    }

    public class BLConnectionError : BLException
    {
        public BLConnectionError() : base()
        {
        }
    }

    /// <summary>
    /// error from the server, holds specific message
    /// </summary>
    public class BLServerError : BLException
    {

        public BLServerError() : base()
        {
        }

        public BLServerError(string message) : base(message)
        {
        }
    }


    /// <summary>
    /// unexpected error from the server
    /// </summary>
    public class BLServerUnhandledError : BLException
    {

        public BLServerUnhandledError() : base()
        {
        }
    }

}
