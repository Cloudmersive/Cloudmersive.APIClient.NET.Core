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
    /// Result of spell checking a sentence
    /// </summary>
    public partial class CheckSentenceJsonOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckSentenceJsonOKResponse
        /// class.
        /// </summary>
        public CheckSentenceJsonOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the CheckSentenceJsonOKResponse
        /// class.
        /// </summary>
        public CheckSentenceJsonOKResponse(int? incorrectCount = default(int?), IList<CheckSentenceJsonOKResponseWordsItem> words = default(IList<CheckSentenceJsonOKResponseWordsItem>))
        {
            IncorrectCount = incorrectCount;
            Words = words;
        }

        /// <summary>
        /// Number of incorrect words
        /// </summary>
        [JsonProperty(PropertyName = "IncorrectCount")]
        public int? IncorrectCount { get; set; }

        /// <summary>
        /// Words in the sentence, both correct and incorrect
        /// </summary>
        [JsonProperty(PropertyName = "Words")]
        public IList<CheckSentenceJsonOKResponseWordsItem> Words { get; set; }

    }
}
