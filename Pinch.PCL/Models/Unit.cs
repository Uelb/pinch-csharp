/*
 * Pinch.PCL
 *
 * This file was automatically generated for Pinch by APIMATIC v2.0 ( https://apimatic.io ) on 06/01/2016
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
    public class Unit : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string floorNumber;
        private string frenchFloorNumber;
        private string kind;
        private string reference;
        private string tenantName;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("floor_number")]
        public string FloorNumber 
        { 
            get 
            {
                return this.floorNumber; 
            } 
            private set 
            {
                this.floorNumber = value;
                onPropertyChanged("FloorNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("french_floor_number")]
        public string FrenchFloorNumber 
        { 
            get 
            {
                return this.frenchFloorNumber; 
            } 
            private set 
            {
                this.frenchFloorNumber = value;
                onPropertyChanged("FrenchFloorNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("kind")]
        public string Kind 
        { 
            get 
            {
                return this.kind; 
            } 
            private set 
            {
                this.kind = value;
                onPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("reference")]
        public string Reference 
        { 
            get 
            {
                return this.reference; 
            } 
            private set 
            {
                this.reference = value;
                onPropertyChanged("Reference");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tenant_name")]
        public string TenantName 
        { 
            get 
            {
                return this.tenantName; 
            } 
            private set 
            {
                this.tenantName = value;
                onPropertyChanged("TenantName");
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