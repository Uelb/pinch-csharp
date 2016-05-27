/*
 * Pinch.PCL
 *
 * This file was automatically generated for Pinch by APIMATIC v2.0 ( https://apimatic.io ) on 05/27/2016
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pinch.Http.Request;
namespace pinch
{
    internal partial class AuthUtility
    {
        /// <summary>
        /// Appends the necessary Custom Authentication credentials for making this authorized call
        /// </summary>
        /// <param name="request">The out going request to access the resource</param>        
        internal static void AppendCustomAuthParams(HttpRequest request)
        {
            // TODO: Add your custom authentication here
			// The following properties are available to use
			//     Configuration.XAPITOKEN
			//     Configuration.XAPIEMAIL
			// 
			// ie. Add a header through:
			//     request.header("Key", "Value");
        }
    }
}
