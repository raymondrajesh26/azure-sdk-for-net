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
    /// [TODO] The link in Graph Paramter
    /// </summary>
    public partial class GraphParameterLink
    {
        /// <summary>
        /// Initializes a new instance of the GraphParameterLink class.
        /// </summary>
        public GraphParameterLink() { }

        /// <summary>
        /// Initializes a new instance of the GraphParameterLink class.
        /// </summary>
        public GraphParameterLink(string nodeId = default(string), string parameterId = default(string))
        {
            NodeId = nodeId;
            ParameterId = parameterId;
        }

        /// <summary>
        /// [TODO] The node ID
        /// </summary>
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// [TODO] The parameter ID
        /// </summary>
        [JsonProperty(PropertyName = "parameterId")]
        public string ParameterId { get; set; }

    }
}
