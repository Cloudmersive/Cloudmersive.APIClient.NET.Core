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
    /// Result of an NSFW classification
    /// </summary>
    public partial class ClassifyOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the ClassifyOKResponse class.
        /// </summary>
        public ClassifyOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the ClassifyOKResponse class.
        /// </summary>
        public ClassifyOKResponse(bool? successful = default(bool?), double? score = default(double?), string classificationOutcome = default(string))
        {
            Successful = successful;
            Score = score;
            ClassificationOutcome = classificationOutcome;
        }

        /// <summary>
        /// True if the classification was successfully run, false otherwise
        /// </summary>
        [JsonProperty(PropertyName = "Successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// Score between 0.0 and 1.0.  Scores of 0.0-0.2 represent high
        /// probability safe content, while scores 0.8-1.0 represent high
        /// probability unsafe content.  Content between 0.2 and 0.8 is of
        /// increasing raciness.
        /// </summary>
        [JsonProperty(PropertyName = "Score")]
        public double? Score { get; set; }

        /// <summary>
        /// Classification result into four categories:
        /// SafeContent_HighProbability, UnsafeContent_HighProbability,
        /// RacyContent, SafeContent_ModerateProbability
        /// </summary>
        [JsonProperty(PropertyName = "ClassificationOutcome")]
        public string ClassificationOutcome { get; set; }

    }
}