// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>
    /// The call forwarding settings for a phone number.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CallForwarding : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if call forwarding will be enabled for this number if forwards_to and forwarding_type are filled in. Defaults to true for backwards compatibility with APIV1 use of numbers endpoints.</summary>
        public bool? CallForwardingEnabled { get; set; }
        /// <summary>Call forwarding type. &apos;forwards_to&apos; must be set for this to have an effect.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.CallForwarding_forwarding_type? ForwardingType { get; set; }
        /// <summary>The phone number to which inbound calls to this number are forwarded. Inbound calls will not be forwarded if this field is left blank. If set, must be a +E.164-formatted phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ForwardsTo { get; set; }
#nullable restore
#else
        public string ForwardsTo { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CallForwarding"/> and sets the default values.
        /// </summary>
        public CallForwarding()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CallForwarding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CallForwarding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CallForwarding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "call_forwarding_enabled", n => { CallForwardingEnabled = n.GetBoolValue(); } },
                { "forwarding_type", n => { ForwardingType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CallForwarding_forwarding_type>(); } },
                { "forwards_to", n => { ForwardsTo = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("call_forwarding_enabled", CallForwardingEnabled);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CallForwarding_forwarding_type>("forwarding_type", ForwardingType);
            writer.WriteStringValue("forwards_to", ForwardsTo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
