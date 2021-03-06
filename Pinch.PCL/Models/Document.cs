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
    public class Document : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int id;
        private string name;
        private string thumbUrl;
        private string url;

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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// If possible, a thumbnail of the document
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl 
        { 
            get 
            {
                return this.thumbUrl; 
            } 
            private set 
            {
                this.thumbUrl = value;
                onPropertyChanged("ThumbUrl");
            }
        }

        /// <summary>
        /// Where to retrieve the document
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            private set 
            {
                this.url = value;
                onPropertyChanged("Url");
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