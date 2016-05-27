using System;
using System.Collections.Generic;

namespace pinch.Http.Response
{
    public class HttpStringResponse : HttpResponse
    {
        /// <summary>
        /// Raw string body of the http response
        /// </summary>
        public string Body { get; set; }
    }
}
