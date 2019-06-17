// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EdifactDecimalIndicator.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EdifactDecimalIndicator
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "Comma")]
        Comma,
        [EnumMember(Value = "Decimal")]
        Decimal
    }
    internal static class EdifactDecimalIndicatorEnumExtension
    {
        internal static string ToSerializedValue(this EdifactDecimalIndicator? value)
        {
            return value == null ? null : ((EdifactDecimalIndicator)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EdifactDecimalIndicator value)
        {
            switch( value )
            {
                case EdifactDecimalIndicator.NotSpecified:
                    return "NotSpecified";
                case EdifactDecimalIndicator.Comma:
                    return "Comma";
                case EdifactDecimalIndicator.Decimal:
                    return "Decimal";
            }
            return null;
        }

        internal static EdifactDecimalIndicator? ParseEdifactDecimalIndicator(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return EdifactDecimalIndicator.NotSpecified;
                case "Comma":
                    return EdifactDecimalIndicator.Comma;
                case "Decimal":
                    return EdifactDecimalIndicator.Decimal;
            }
            return null;
        }
    }
}