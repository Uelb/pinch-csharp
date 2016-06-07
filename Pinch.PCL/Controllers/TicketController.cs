/*
 * Pinch.PCL
 *
 * This file was automatically generated for Pinch by APIMATIC v2.0 ( https://apimatic.io ) on 06/07/2016
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
    public partial class TicketController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TicketController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TicketController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TicketController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// List all the opened tickets of every clients you are working for
        /// </summary>
        /// <return>Returns the List<Ticket> response from the API call</return>
        public List<Ticket> List()
        {
            Task<List<Ticket>> t = ListAsync();
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// List all the opened tickets of every clients you are working for
        /// </summary>
        /// <return>Returns the List<Ticket> response from the API call</return>
        public async Task<List<Ticket>> ListAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets");


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
                return APIHelper.JsonDeserialize<List<Ticket>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This method returns no result but the status code tells you if the operation succedded
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket AcceptIntervention(string ticketId)
        {
            Task<Ticket> t = AcceptInterventionAsync(ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// This method returns no result but the status code tells you if the operation succedded
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> AcceptInterventionAsync(string ticketId)
        {
            //validating required parameters
            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/accept");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null);

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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="interventionDate">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket SetInterventionDate(DateTime interventionDate, string ticketId)
        {
            Task<Ticket> t = SetInterventionDateAsync(interventionDate, ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="interventionDate">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> SetInterventionDateAsync(DateTime interventionDate, string ticketId)
        {
            //validating required parameters
            if (null == interventionDate)
                throw new ArgumentNullException("interventionDate", "The parameter \"interventionDate\" is a required parameter and cannot be null.");

            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/set_intervention_date");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "intervention_date", interventionDate }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket UploadQuote(FileStreamInfo file, string ticketId)
        {
            Task<Ticket> t = UploadQuoteAsync(file, ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> UploadQuoteAsync(FileStreamInfo file, string ticketId)
        {
            //validating required parameters
            if (null == file)
                throw new ArgumentNullException("file", "The parameter \"file\" is a required parameter and cannot be null.");

            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/quote_upload");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "file", file }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket SendMessage(string body, string ticketId)
        {
            Task<Ticket> t = SendMessageAsync(body, ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> SendMessageAsync(string body, string ticketId)
        {
            //validating required parameters
            if (null == body)
                throw new ArgumentNullException("body", "The parameter \"body\" is a required parameter and cannot be null.");

            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/message");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "body", body }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <param name="interventionDate">Optional parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket DeclareInterventionDone(string ticketId, DateTime? interventionDate = null)
        {
            Task<Ticket> t = DeclareInterventionDoneAsync(ticketId, interventionDate);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <param name="interventionDate">Optional parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> DeclareInterventionDoneAsync(string ticketId, DateTime? interventionDate = null)
        {
            //validating required parameters
            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/intervention_done");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "intervention_date", interventionDate }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// The document should not be an invoice nor a quote
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket UploadDocument(FileStreamInfo file, string ticketId)
        {
            Task<Ticket> t = UploadDocumentAsync(file, ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// The document should not be an invoice nor a quote
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> UploadDocumentAsync(FileStreamInfo file, string ticketId)
        {
            //validating required parameters
            if (null == file)
                throw new ArgumentNullException("file", "The parameter \"file\" is a required parameter and cannot be null.");

            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/document_upload");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "file", file }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket UploadPicture(FileStreamInfo file, string ticketId)
        {
            Task<Ticket> t = UploadPictureAsync(file, ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> UploadPictureAsync(FileStreamInfo file, string ticketId)
        {
            //validating required parameters
            if (null == file)
                throw new ArgumentNullException("file", "The parameter \"file\" is a required parameter and cannot be null.");

            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/picture_upload");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "file", file }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public Ticket Get(string ticketId)
        {
            Task<Ticket> t = GetAsync(ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the Ticket response from the API call</return>
        public async Task<Ticket> GetAsync(string ticketId)
        {
            //validating required parameters
            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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
                return APIHelper.JsonDeserialize<Ticket>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UploadInvoice(FileStreamInfo file, string ticketId)
        {
            Task<string> t = UploadInvoiceAsync(file, ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="file">Required parameter: Example: </param>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UploadInvoiceAsync(FileStreamInfo file, string ticketId)
        {
            //validating required parameters
            if (null == file)
                throw new ArgumentNullException("file", "The parameter \"file\" is a required parameter and cannot be null.");

            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/invoice_upload");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("X-API-TOKEN", Configuration.XAPITOKEN);
            _headers.Add("X-API-EMAIL", Configuration.XAPIEMAIL);

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "file", file }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

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
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get the documents of a ticket related to the intervention (No invoice, no quote)
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the List<Document> response from the API call</return>
        public List<Document> Documents(string ticketId)
        {
            Task<List<Document>> t = DocumentsAsync(ticketId);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get the documents of a ticket related to the intervention (No invoice, no quote)
        /// </summary>
        /// <param name="ticketId">Required parameter: Example: </param>
        /// <return>Returns the List<Document> response from the API call</return>
        public async Task<List<Document>> DocumentsAsync(string ticketId)
        {
            //validating required parameters
            if (null == ticketId)
                throw new ArgumentNullException("ticketId", "The parameter \"ticketId\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{ticket_id}/documents");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "ticket_id", ticketId }
            });


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
                return APIHelper.JsonDeserialize<List<Document>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the List<Message> response from the API call</return>
        public List<Message> Messages(string id)
        {
            Task<List<Message>> t = MessagesAsync(id);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <return>Returns the List<Message> response from the API call</return>
        public async Task<List<Message>> MessagesAsync(string id)
        {
            //validating required parameters
            if (null == id)
                throw new ArgumentNullException("id", "The parameter \"id\" is a required parameter and cannot be null.");

            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/tickets/{id}/messages");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


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
                return APIHelper.JsonDeserialize<List<Message>>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 