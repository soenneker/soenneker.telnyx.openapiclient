// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GatherRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Use this field to add state to every subsequent webhook. It must be a valid Base-64 encoded string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientState { get; set; }
#nullable restore
#else
        public string ClientState { get; set; }
#endif
        /// <summary>Use this field to avoid duplicate commands. Telnyx will ignore any command with the same `command_id` for the same `call_control_id`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommandId { get; set; }
#nullable restore
#else
        public string CommandId { get; set; }
#endif
        /// <summary>An id that will be sent back in the corresponding `call.gather.ended` webhook. Will be randomly generated if not specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GatherId { get; set; }
#nullable restore
#else
        public string GatherId { get; set; }
#endif
        /// <summary>The number of milliseconds to wait for the first DTMF.</summary>
        public int? InitialTimeoutMillis { get; set; }
        /// <summary>The number of milliseconds to wait for input between digits.</summary>
        public int? InterDigitTimeoutMillis { get; set; }
        /// <summary>The maximum number of digits to fetch. This parameter has a maximum value of 128.</summary>
        public int? MaximumDigits { get; set; }
        /// <summary>The minimum number of digits to fetch. This parameter has a minimum value of 1.</summary>
        public int? MinimumDigits { get; set; }
        /// <summary>The digit used to terminate input if fewer than `maximum_digits` digits have been gathered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TerminatingDigit { get; set; }
#nullable restore
#else
        public string TerminatingDigit { get; set; }
#endif
        /// <summary>The number of milliseconds to wait to complete the request.</summary>
        public int? TimeoutMillis { get; set; }
        /// <summary>A list of all digits accepted as valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValidDigits { get; set; }
#nullable restore
#else
        public string ValidDigits { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.GatherRequest"/> and sets the default values.
        /// </summary>
        public GatherRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            TerminatingDigit = "#";
            ValidDigits = "0123456789#*";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.GatherRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.GatherRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.GatherRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "client_state", n => { ClientState = n.GetStringValue(); } },
                { "command_id", n => { CommandId = n.GetStringValue(); } },
                { "gather_id", n => { GatherId = n.GetStringValue(); } },
                { "initial_timeout_millis", n => { InitialTimeoutMillis = n.GetIntValue(); } },
                { "inter_digit_timeout_millis", n => { InterDigitTimeoutMillis = n.GetIntValue(); } },
                { "maximum_digits", n => { MaximumDigits = n.GetIntValue(); } },
                { "minimum_digits", n => { MinimumDigits = n.GetIntValue(); } },
                { "terminating_digit", n => { TerminatingDigit = n.GetStringValue(); } },
                { "timeout_millis", n => { TimeoutMillis = n.GetIntValue(); } },
                { "valid_digits", n => { ValidDigits = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("client_state", ClientState);
            writer.WriteStringValue("command_id", CommandId);
            writer.WriteStringValue("gather_id", GatherId);
            writer.WriteIntValue("initial_timeout_millis", InitialTimeoutMillis);
            writer.WriteIntValue("inter_digit_timeout_millis", InterDigitTimeoutMillis);
            writer.WriteIntValue("maximum_digits", MaximumDigits);
            writer.WriteIntValue("minimum_digits", MinimumDigits);
            writer.WriteStringValue("terminating_digit", TerminatingDigit);
            writer.WriteIntValue("timeout_millis", TimeoutMillis);
            writer.WriteStringValue("valid_digits", ValidDigits);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
