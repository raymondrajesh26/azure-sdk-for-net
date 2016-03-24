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
    /// </summary>
    public partial class CheckNameResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameResult class.
        /// </summary>
        public CheckNameResult() { }

        /// <summary>
        /// Initializes a new instance of the CheckNameResult class.
        /// </summary>
        public CheckNameResult(bool? nameAvaliable = default(bool?), string reason = default(string), string message = default(string))
        {
            NameAvaliable = nameAvaliable;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// True, if the name is available; False, otherwise
        /// </summary>
        [JsonProperty(PropertyName = "nameAvaliable")]
        public bool? NameAvaliable { get; set; }

        /// <summary>
        /// The reason why if it is not available. Possible values include:
        /// 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// : The message from the server
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
