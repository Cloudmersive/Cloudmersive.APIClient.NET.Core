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
    /// Result of recognizing an image
    /// </summary>
    public partial class DescribeOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the DescribeOKResponse class.
        /// </summary>
        public DescribeOKResponse() { }

        /// <summary>
        /// Initializes a new instance of the DescribeOKResponse class.
        /// </summary>
        public DescribeOKResponse(bool? successful = default(bool?), bool? highconfidence = default(bool?), DescribeOKResponseBestOutcome bestOutcome = default(DescribeOKResponseBestOutcome), DescribeOKResponseRunnerUpOutcome runnerUpOutcome = default(DescribeOKResponseRunnerUpOutcome))
        {
            Successful = successful;
            Highconfidence = highconfidence;
            BestOutcome = bestOutcome;
            RunnerUpOutcome = runnerUpOutcome;
        }

        /// <summary>
        /// Was the image processed successfully?
        /// </summary>
        [JsonProperty(PropertyName = "Successful")]
        public bool? Successful { get; set; }

        /// <summary>
        /// Is the resulting best outcome recognition a high confidence
        /// outcome?
        /// </summary>
        [JsonProperty(PropertyName = "Highconfidence")]
        public bool? Highconfidence { get; set; }

        /// <summary>
        /// The best Machine Learning outcome
        /// </summary>
        [JsonProperty(PropertyName = "BestOutcome")]
        public DescribeOKResponseBestOutcome BestOutcome { get; set; }

        /// <summary>
        /// Best backup ("runner up") Machine Learning outcome
        /// </summary>
        [JsonProperty(PropertyName = "RunnerUpOutcome")]
        public DescribeOKResponseRunnerUpOutcome RunnerUpOutcome { get; set; }

    }
}
