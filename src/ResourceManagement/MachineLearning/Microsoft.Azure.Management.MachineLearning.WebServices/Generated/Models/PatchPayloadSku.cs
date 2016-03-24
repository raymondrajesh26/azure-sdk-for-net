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
    /// [TODO] SKU
    /// </summary>
    public partial class PatchPayloadSku
    {
        /// <summary>
        /// Initializes a new instance of the PatchPayloadSku class.
        /// </summary>
        public PatchPayloadSku() { }

        /// <summary>
        /// Initializes a new instance of the PatchPayloadSku class.
        /// </summary>
        public PatchPayloadSku(string name = default(string), string tier = default(string))
        {
            Name = name;
            Tier = tier;
        }

        /// <summary>
        /// [TODO] Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// [TODO] Tier
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
