using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.BL
{
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

    public class BLServerError : BLException
    {

        public BLServerError() : base()
        {
        }

        public BLServerError(string message) : base(message)
        {
        }
    }

    public class BLServerUnhandledError : BLException
    {

        public BLServerUnhandledError() : base()
        {
        }
    }

}
