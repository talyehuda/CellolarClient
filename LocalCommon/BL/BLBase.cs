using LocalCommon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.BL
{
    public abstract class BLBase
    {
        protected WebAPIAccess apiAccess = null;

        /// <summary>
        /// performs a GET api operation and handles exceptions as needed
        /// </summary>
        protected void GetAPIData(string query)
        {
            try
            {
                apiAccess.GetData(query);
            }
            catch (APIConnectionError)
            {
                throw new BLConnectionError();
            }
            catch (APIServerError ex)
            {
                throw new BLServerError(ex.Message);
            }
            catch (APIUnhandledHttpStatusCodeException)
            {
               throw new BLServerUnhandledError();
            }
        }

        /// <summary>
        /// perfoms a GET api operation, returns a Model object and handles exceptions as needed
        /// </summary>
        protected Model GetAPIData<Model>(string query)
        {
            try
            {
                return apiAccess.GetData<Model>(query);
            }
            catch (APIConnectionError)
            {
                throw new BLConnectionError();
            }
            catch (APIServerError ex)
            {
                throw new BLServerError(ex.Message);
            }
            catch (APIUnhandledHttpStatusCodeException)
            {
                throw new BLServerUnhandledError();
            }
            
        }

        /// <summary>
        /// performs POST api operation to a Model object, returns Result object and handles exceptions
        /// as needed
        /// </summary>
        protected Result PostAPIData<Result, Model>(string query, Model model)
        {

            try
            {
                return apiAccess.PostData<Result, Model>(query, model);
            }
            catch (APIConnectionError)
            {
                throw new BLConnectionError();
            }
            catch (APIServerError ex)
            {
                throw new BLServerError(ex.Message);
            }
            catch (APIUnhandledHttpStatusCodeException)
            {
                throw new BLServerUnhandledError();
            }

        }

        /// <summary>
        /// performs POST api operation to a Model object and handles exceptions as needed
        /// </summary>
        protected void PostAPIData<Model>(string query, Model model)
        {

            try
            {
                apiAccess.PostData<Model>(query, model);
            }
            catch (APIConnectionError)
            {
                throw new BLConnectionError();
            }
            catch (APIServerError ex)
            {
                throw new BLServerError(ex.Message);
            }
            catch (APIUnhandledHttpStatusCodeException)
            {
                throw new BLServerUnhandledError();
            }

        }
    }
}
