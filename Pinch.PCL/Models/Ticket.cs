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
    public class Ticket : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string access;
        private string agency;
        private Building building;
        private List<Person> contacts;
        private string description;
        private List<Document> documents;
        private string id;
        private string manager;
        private string name;
        private string status;
        private Unit unit;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("access")]
        public string Access 
        { 
            get 
            {
                return this.access; 
            } 
            private set 
            {
                this.access = value;
                onPropertyChanged("Access");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("agency")]
        public string Agency 
        { 
            get 
            {
                return this.agency; 
            } 
            private set 
            {
                this.agency = value;
                onPropertyChanged("Agency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("building")]
        public Building Building 
        { 
            get 
            {
                return this.building; 
            } 
            private set 
            {
                this.building = value;
                onPropertyChanged("Building");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("contacts")]
        public List<Person> Contacts 
        { 
            get 
            {
                return this.contacts; 
            } 
            private set 
            {
                this.contacts = value;
                onPropertyChanged("Contacts");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            private set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("documents")]
        public List<Document> Documents 
        { 
            get 
            {
                return this.documents; 
            } 
            set 
            {
                this.documents = value;
                onPropertyChanged("Documents");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
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
        [JsonProperty("manager")]
        public string Manager 
        { 
            get 
            {
                return this.manager; 
            } 
            private set 
            {
                this.manager = value;
                onPropertyChanged("Manager");
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
            private set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            private set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("unit")]
        public Unit Unit 
        { 
            get 
            {
                return this.unit; 
            } 
            private set 
            {
                this.unit = value;
                onPropertyChanged("Unit");
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