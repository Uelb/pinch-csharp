/*
 * Pinch.PCL
 *
 * This file was automatically generated for Pinch by APIMATIC v2.0 ( https://apimatic.io ) on 06/07/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using pinch;

namespace pinch.Models
{
    public class Message : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string body;
        private DateTime createdAt;
        private int id;
        private string messageType;
        private string rawHtml;
        private Person sender;
        private string subject;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("body")]
        public string Body 
        { 
            get 
            {
                return this.body; 
            } 
            private set 
            {
                this.body = value;
                onPropertyChanged("Body");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            private set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public int Id 
        { 
            get 
            {
                return this.id; 
            } 
            private set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// sms, email, or direct
        /// </summary>
        [JsonProperty("message_type")]
        public string MessageType 
        { 
            get 
            {
                return this.messageType; 
            } 
            private set 
            {
                this.messageType = value;
                onPropertyChanged("MessageType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("raw_html")]
        public string RawHtml 
        { 
            get 
            {
                return this.rawHtml; 
            } 
            private set 
            {
                this.rawHtml = value;
                onPropertyChanged("RawHtml");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("sender")]
        public Person Sender 
        { 
            get 
            {
                return this.sender; 
            } 
            private set 
            {
                this.sender = value;
                onPropertyChanged("Sender");
            }
        }

        /// <summary>
        /// The subject of the email if it's an email
        /// </summary>
        [JsonProperty("subject")]
        public string Subject 
        { 
            get 
            {
                return this.subject; 
            } 
            private set 
            {
                this.subject = value;
                onPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 