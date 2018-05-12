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
    /// A word in a sentence
    /// </summary>
    public partial class CheckSentenceJsonOKResponseWordsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckSentenceJsonOKResponseWordsItem class.
        /// </summary>
        public CheckSentenceJsonOKResponseWordsItem() { }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckSentenceJsonOKResponseWordsItem class.
        /// </summary>
        public CheckSentenceJsonOKResponseWordsItem(CheckSentenceJsonOKResponseWordsItemWord word = default(CheckSentenceJsonOKResponseWordsItemWord), bool? correct = default(bool?), IList<string> suggestions = default(IList<string>))
        {
            Word = word;
            Correct = correct;
            Suggestions = suggestions;
        }

        /// <summary>
        /// Position of the word
        /// </summary>
        [JsonProperty(PropertyName = "Word")]
        public CheckSentenceJsonOKResponseWordsItemWord Word { get; set; }

        /// <summary>
        /// True if the word is spelled correctly, false otherwise
        /// </summary>
        [JsonProperty(PropertyName = "Correct")]
        public bool? Correct { get; set; }

        /// <summary>
        /// Suggested spelling improvements
        /// </summary>
        [JsonProperty(PropertyName = "Suggestions")]
        public IList<string> Suggestions { get; set; }

    }
}