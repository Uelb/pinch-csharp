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
    public class Person : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string firstname;
        private string homePhoneNumber;
        private string lastname;
        private string mobilePhoneNumber;
        private string role;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstname")]
        public string Firstname 
        { 
            get 
            {
                return this.firstname; 
            } 
            private set 
            {
                this.firstname = value;
                onPropertyChanged("Firstname");
            }
        }

        /// <summary>
        /// The landline phone number of the resident or manager
        /// </summary>
        [JsonProperty("home_phone_number")]
        public string HomePhoneNumber 
        { 
            get 
            {
                return this.homePhoneNumber; 
            } 
            private set 
            {
                this.homePhoneNumber = value;
                onPropertyChanged("HomePhoneNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lastname")]
        public string Lastname 
        { 
            get 
            {
                return this.lastname; 
            } 
            private set 
            {
                this.lastname = value;
                onPropertyChanged("Lastname");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("mobile_phone_number")]
        public string MobilePhoneNumber 
        { 
            get 
            {
                return this.mobilePhoneNumber; 
            } 
            private set 
            {
                this.mobilePhoneNumber = value;
                onPropertyChanged("MobilePhoneNumber");
            }
        }

        /// <summary>
        /// Caretaker, Resident, Manager, ThirdParty
        /// </summary>
        [JsonProperty("role")]
        public string Role 
        { 
            get 
            {
                return this.role; 
            } 
            private set 
            {
                this.role = value;
                onPropertyChanged("Role");
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