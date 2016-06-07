/*
 * Pinch.PCL
 *
 * This file was automatically generated for Pinch by APIMATIC v2.0 ( https://apimatic.io ) on 06/07/2016
 */
using System;
using pinch.Controllers;
using pinch.Http.Client;

namespace pinch
{
    public partial class PinchClient
    {

        /// <summary>
        /// Singleton access to WebhookType controller
        /// </summary>
        public WebhookTypeController WebhookType
        {
            get
            {
                return WebhookTypeController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Webhook controller
        /// </summary>
        public WebhookController Webhook
        {
            get
            {
                return WebhookController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Ticket controller
        /// </summary>
        public TicketController Ticket
        {
            get
            {
                return TicketController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public PinchClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public PinchClient(string xAPITOKEN, string xAPIEMAIL)
        {
            Configuration.XAPITOKEN = xAPITOKEN;
            Configuration.XAPIEMAIL = xAPIEMAIL;
        }
    }
}