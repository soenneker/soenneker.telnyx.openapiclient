// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ActiveCall : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier and token for controlling the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallControlId { get; set; }
#nullable restore
#else
        public string CallControlId { get; set; }
#endif
        /// <summary>Indicates the duration of the call in seconds</summary>
        public int? CallDuration { get; set; }
        /// <summary>ID that is unique to the call and can be used to correlate webhook events</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallLegId { get; set; }
#nullable restore
#else
        public string CallLegId { get; set; }
#endif
        /// <summary>ID that is unique to the call session and can be used to correlate webhook events. Call session is a group of related call legs that logically belong to the same phone call, e.g. an inbound and outbound leg of a transferred call</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallSessionId { get; set; }
#nullable restore
#else
        public string CallSessionId { get; set; }
#endif
        /// <summary>State received from a command.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientState { get; set; }
#nullable restore
#else
        public string ClientState { get; set; }
#endif
        /// <summary>The record_type property</summary>
        public global::Soenneker.Telnyx.Models.ActiveCall_record_type? RecordType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.ActiveCall"/> and sets the default values.
        /// </summary>
        public ActiveCall()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.ActiveCall"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.ActiveCall CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.ActiveCall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "call_control_id", n => { CallControlId = n.GetStringValue(); } },
                { "call_duration", n => { CallDuration = n.GetIntValue(); } },
                { "call_leg_id", n => { CallLegId = n.GetStringValue(); } },
                { "call_session_id", n => { CallSessionId = n.GetStringValue(); } },
                { "client_state", n => { ClientState = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetEnumValue<global::Soenneker.Telnyx.Models.ActiveCall_record_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("call_control_id", CallControlId);
            writer.WriteIntValue("call_duration", CallDuration);
            writer.WriteStringValue("call_leg_id", CallLegId);
            writer.WriteStringValue("call_session_id", CallSessionId);
            writer.WriteStringValue("client_state", ClientState);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.ActiveCall_record_type>("record_type", RecordType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
