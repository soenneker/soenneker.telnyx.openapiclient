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
    public partial class UpdateTexmlApplicationRequest_inbound : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>When set, this will limit the total number of inbound calls to phone numbers associated with this connection.</summary>
        public int? ChannelLimit { get; set; }
        /// <summary>When enabled Telnyx will include Shaken/Stir data in the Webhook for new inbound calls.</summary>
        public bool? ShakenStirEnabled { get; set; }
        /// <summary>Specifies a subdomain that can be used to receive Inbound calls to a Connection, in the same way a phone number is used, from a SIP endpoint. Example: the subdomain &quot;example.sip.telnyx.com&quot; can be called from any SIP endpoint by using the SIP URI &quot;sip:@example.sip.telnyx.com&quot; where the user part can be any alphanumeric value. Please note TLS encrypted calls are not allowed for subdomain calls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SipSubdomain { get; set; }
#nullable restore
#else
        public string SipSubdomain { get; set; }
#endif
        /// <summary>This option can be enabled to receive calls from: &quot;Anyone&quot; (any SIP endpoint in the public Internet) or &quot;Only my connections&quot; (any connection assigned to the same Telnyx user).</summary>
        public global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound_sip_subdomain_receive_settings? SipSubdomainReceiveSettings { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound"/> and sets the default values.
        /// </summary>
        public UpdateTexmlApplicationRequest_inbound()
        {
            AdditionalData = new Dictionary<string, object>();
            SipSubdomainReceiveSettings = global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound_sip_subdomain_receive_settings.From_anyone;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "channel_limit", n => { ChannelLimit = n.GetIntValue(); } },
                { "shaken_stir_enabled", n => { ShakenStirEnabled = n.GetBoolValue(); } },
                { "sip_subdomain", n => { SipSubdomain = n.GetStringValue(); } },
                { "sip_subdomain_receive_settings", n => { SipSubdomainReceiveSettings = n.GetEnumValue<global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound_sip_subdomain_receive_settings>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("channel_limit", ChannelLimit);
            writer.WriteBoolValue("shaken_stir_enabled", ShakenStirEnabled);
            writer.WriteStringValue("sip_subdomain", SipSubdomain);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.UpdateTexmlApplicationRequest_inbound_sip_subdomain_receive_settings>("sip_subdomain_receive_settings", SipSubdomainReceiveSettings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
