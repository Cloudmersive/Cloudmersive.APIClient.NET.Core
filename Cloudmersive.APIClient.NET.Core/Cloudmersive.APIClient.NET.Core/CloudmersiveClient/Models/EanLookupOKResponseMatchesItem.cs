﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Cloudmersive.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class EanLookupOKResponseMatchesItem
    {
        /// <summary>
        /// Initializes a new instance of the EanLookupOKResponseMatchesItem
        /// class.
        /// </summary>
        public EanLookupOKResponseMatchesItem() { }

        /// <summary>
        /// Initializes a new instance of the EanLookupOKResponseMatchesItem
        /// class.
        /// </summary>
        public EanLookupOKResponseMatchesItem(string eAN = default(string), string title = default(string))
        {
            EAN = eAN;
            Title = title;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EAN")]
        public string EAN { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

    }
}
