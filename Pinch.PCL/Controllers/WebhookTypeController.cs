/*
 * Pinch.PCL
 *
 * This file was automatically generated for Pinch by APIMATIC v2.0 ( https://apimatic.io ) on 05/27/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pinch;
using pinch.Http.Request;
using pinch.Http.Response;
using pinch.Http.Client;
using pinch.Models;

namespace pinch.Controllers
{
    public partial class WebhookTypeController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static WebhookTypeController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static WebhookTypeController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new WebhookTypeController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// List webhook types
        /// </summary>
        /// <return>Returns the List<WebhookType> response from the API call</return>
        public List<WebhookType> List()
        {
            Task<List<WebhookType>> t = ListAsync();
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List webhook types
        /// </summary>
        /// <return>Returns the List<WebhookType> response from the API call</return>
        public async Task<List<WebhookType>> ListAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/webhook_types");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("X-API-TOKEN", Configuration.XAPITOKEN);
            _headers.Add("X-API-EMAIL", Configuration.XAPIEMAIL);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //Custom Authentication to be added for authorization
            AuthUtility.AppendCustomAuthParams(_request);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //return null on 404
            if (_response.StatusCode == 404)
                 return null;

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<List<WebhookType>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 