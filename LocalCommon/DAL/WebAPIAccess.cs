using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace LocalCommon.DAL
{
    
    public class WebAPIAccess
    {

        //key in app.config that holds api server address
        private string apiServerAddress_Key = null;
        private Uri apiServerUrl = null;


        public WebAPIAccess(string controller)
        {
            apiServerAddress_Key = "apiServerAddress";
            apiServerUrl = new Uri(ConfigurationManager.AppSettings[apiServerAddress_Key] + $"api/{controller}/");

        }
        /// <summary>
        ///performs http get request and discards returned content 
        ///unless an error is returned, then an exception is thrown
        /// with the content saved in error's message
        /// </summary>
        public void GetData(string query)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = apiServerUrl;

                var responseTask = client.GetAsync(query);
                try
                {
                    responseTask.Wait();
                }
                catch (Exception)
                {
                    throw new APIConnectionError();
                }

                var result = responseTask.Result;
                switch (result.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        return;
                    case System.Net.HttpStatusCode.MethodNotAllowed:
                        var task = result.Content.ReadAsStringAsync();
                        task.Wait();
                        string resultContent = task.Result;
                        throw new APIServerError(resultContent);
                    default:
                        throw new APIUnhandledHttpStatusCodeException(result.StatusCode);
                }

            }
        }

        /// <summary>
        ///performs http get request and returns content as a Model object
        ///unless an error is returned, then an exception is thrown
        /// with the content saved in error's message
        /// </summary>
        public Model GetData<Model>(string query)
        {


            using (var client = new HttpClient())
            {
                client.BaseAddress = apiServerUrl;

                var responseTask = client.GetAsync(query);
                try
                {
                    responseTask.Wait();
                }
                catch (Exception)
                {
                    throw new APIConnectionError();
                }

                var result = responseTask.Result;
                switch (result.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        var data = readTask.Result;
                        JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                        Model model = JSserializer.Deserialize<Model>(data);
                        return model;

                    case System.Net.HttpStatusCode.MethodNotAllowed:
                        var task = result.Content.ReadAsStringAsync();
                        task.Wait();
                        string resultContent = task.Result;
                        throw new APIServerError(resultContent);

                    default:
                        var task2 = result.Content.ReadAsStringAsync();
                        task2.Wait();
                        string resultContent2 = task2.Result;
                        Console.WriteLine("error from server: (code: " + result.StatusCode.ToString()+")");
                        Console.WriteLine(resultContent2);
                        throw new APIUnhandledHttpStatusCodeException(result.StatusCode);
                }

            }
        }

        /// <summary>
        ///performs http post request on a Model object and returns content as a Repons object
        ///unless an error is returned, then an exception is thrown
        /// with the content saved in error's message
        /// </summary>
        public Response PostData<Response, Model>(string query, Model model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = apiServerUrl;

                var jsonContent = new StringContent((new JavaScriptSerializer()).Serialize(model), Encoding.UTF8, "application/json");

                var postTask = client.PostAsync(query, jsonContent);
                try
                {
                    postTask.Wait();
                }
                catch (Exception)
                {
                    throw new APIConnectionError();
                }

                var result = postTask.Result;

                switch (result.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();

                        var data = readTask.Result;

                        JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                        Response response = JSserializer.Deserialize<Response>(data);

                        return response;

                    case System.Net.HttpStatusCode.MethodNotAllowed:
                        var task = result.Content.ReadAsStringAsync();
                        task.Wait();
                        string resultContent = task.Result;
                        throw new APIServerError(resultContent);

                    default:
                        {
                            throw new APIUnhandledHttpStatusCodeException(result.StatusCode);
                        }
                }


            }

        }

        /// <summary>
        ///performs http post request on a Model object and discards response content
        ///unless an error is returned, then an exception is thrown
        /// with the content saved in error's message
        /// </summary>
        public void PostData<Model>(string query, Model model)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = apiServerUrl;

                var jsonContent = new StringContent(new JavaScriptSerializer().Serialize(model), Encoding.UTF8, "application/json");

                var postTask = client.PostAsync(query, jsonContent);
                try
                {
                    postTask.Wait();
                }
                catch (Exception)
                {
                    throw new APIConnectionError();
                }

                var result = postTask.Result;

                switch (result.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        return;

                    case System.Net.HttpStatusCode.NoContent:
                        return;

                    case System.Net.HttpStatusCode.MethodNotAllowed:
                        var task = result.Content.ReadAsStringAsync();
                        task.Wait();
                        string resultContent = task.Result;
                        throw new APIServerError(resultContent);

                    default:
                        var task1 = result.Content.ReadAsStringAsync();
                        task1.Wait();
                        string resultContent1 = task1.Result;
                        Console.WriteLine(resultContent1);
                        throw new APIUnhandledHttpStatusCodeException(result.StatusCode);
                }
            }
        }
    }
}
