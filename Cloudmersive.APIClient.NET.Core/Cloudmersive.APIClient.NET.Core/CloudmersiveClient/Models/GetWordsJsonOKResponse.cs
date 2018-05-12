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
    /// Words in input string
    /// </summary>
    public partial class GetWordsJsonOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetWordsJsonOKResponse class.
        /// </summary>
        public GetWordsJsonOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the GetWordsJsonOKResponse class.
        /// </summary>
        public GetWordsJsonOKResponse(IList<GetWordsJsonOKResponseWordsItem> words = default(IList<GetWordsJsonOKResponseWordsItem>))
        {
            Words = words;
        }

        /// <summary>
        /// Array of words
        /// </summary>
        [JsonProperty(PropertyName = "Words")]
        public IList<GetWordsJsonOKResponseWordsItem> Words { get; set; }

    }
}
