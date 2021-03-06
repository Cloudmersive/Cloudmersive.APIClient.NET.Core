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
    /// Position of the word
    /// </summary>
    public partial class CheckSentenceJsonOKResponseWordsItemWord
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckSentenceJsonOKResponseWordsItemWord class.
        /// </summary>
        public CheckSentenceJsonOKResponseWordsItemWord() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckSentenceJsonOKResponseWordsItemWord class.
        /// </summary>
        public CheckSentenceJsonOKResponseWordsItemWord(string word = default(string), int? wordIndex = default(int?), int? startPosition = default(int?), int? endPosition = default(int?))
        {
            Word = word;
            WordIndex = wordIndex;
            StartPosition = startPosition;
            EndPosition = endPosition;
        }

        /// <summary>
        /// Word as a string
        /// </summary>
        [JsonProperty(PropertyName = "Word")]
        public string Word { get; set; }

        /// <summary>
        /// Zero-based index of the word; first word has index 0, second word
        /// has index 1 and so on
        /// </summary>
        [JsonProperty(PropertyName = "WordIndex")]
        public int? WordIndex { get; set; }

        /// <summary>
        /// Zero-based character offset at which the word begins in the input
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "StartPosition")]
        public int? StartPosition { get; set; }

        /// <summary>
        /// Zero-based character offset at which the word ends in the input
        /// string
        /// </summary>
        [JsonProperty(PropertyName = "EndPosition")]
        public int? EndPosition { get; set; }

    }
}
