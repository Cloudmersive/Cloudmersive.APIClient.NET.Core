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

    /// <summary>
    /// Result of a validation operation
    /// </summary>
    public partial class CheckOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckOKResponse class.
        /// </summary>
        public CheckOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the CheckOKResponse class.
        /// </summary>
        public CheckOKResponse(bool? validDomain = default(bool?))
        {
            ValidDomain = validDomain;
        }

        /// <summary>
        /// True if the domain name was valid, false if it is not
        /// </summary>
        [JsonProperty(PropertyName = "ValidDomain")]
        public bool? ValidDomain { get; set; }

    }
}
