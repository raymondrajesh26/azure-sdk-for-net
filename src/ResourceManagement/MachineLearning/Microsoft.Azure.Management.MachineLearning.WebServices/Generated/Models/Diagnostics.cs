// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Diagnostics Settings
    /// </summary>
    public partial class Diagnostics
    {
        /// <summary>
        /// Initializes a new instance of the Diagnostics class.
        /// </summary>
        public Diagnostics() { }

        /// <summary>
        /// Initializes a new instance of the Diagnostics class.
        /// </summary>
        public Diagnostics(string level = default(string), string expiry = default(string))
        {
            Level = level;
            Expiry = expiry;
        }

        /// <summary>
        /// Trace Level: None, Error, All
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// [TODO] Expiry
        /// </summary>
        [JsonProperty(PropertyName = "expiry")]
        public string Expiry { get; set; }

    }
}
