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
    public partial class TexmlCreateSiprecSessionRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the connector to use for the SIPREC session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorName { get; set; }
#nullable restore
#else
        public string ConnectorName { get; set; }
#endif
        /// <summary>When set, custom parameters will be added as metadata (recording.session.ExtensionParameters). Otherwise, they’ll be added to sip headers.</summary>
        public bool? IncludeMetadataCustomHeaders { get; set; }
        /// <summary>Name of the SIPREC session. May be used to stop the SIPREC session from TeXML instruction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Controls whether to encrypt media sent to your SRS using SRTP and TLS. When set you need to configure SRS port in your connector to 5061.</summary>
        public bool? Secure { get; set; }
        /// <summary>Sets `Session-Expires` header to the INVITE. A reinvite is sent every half the value set. Usefull for session keep alive. Minimum value is 90, set to 0 to disable.</summary>
        public int? SessionTimeoutSecs { get; set; }
        /// <summary>Specifies SIP transport protocol.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_SipTransport? SipTransport { get; set; }
        /// <summary>URL destination for Telnyx to send status callback events to for the siprec session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusCallback { get; set; }
#nullable restore
#else
        public string StatusCallback { get; set; }
#endif
        /// <summary>HTTP request type used for `StatusCallback`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_StatusCallbackMethod? StatusCallbackMethod { get; set; }
        /// <summary>The track to be used for siprec session. Can be `both_tracks`, `inbound_track` or `outbound_track`. Defaults to `both_tracks`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_Track? Track { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody"/> and sets the default values.
        /// </summary>
        public TexmlCreateSiprecSessionRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            SipTransport = global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_SipTransport.Udp;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ConnectorName", n => { ConnectorName = n.GetStringValue(); } },
                { "IncludeMetadataCustomHeaders", n => { IncludeMetadataCustomHeaders = n.GetBoolValue(); } },
                { "Name", n => { Name = n.GetStringValue(); } },
                { "Secure", n => { Secure = n.GetBoolValue(); } },
                { "SessionTimeoutSecs", n => { SessionTimeoutSecs = n.GetIntValue(); } },
                { "SipTransport", n => { SipTransport = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_SipTransport>(); } },
                { "StatusCallback", n => { StatusCallback = n.GetStringValue(); } },
                { "StatusCallbackMethod", n => { StatusCallbackMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_StatusCallbackMethod>(); } },
                { "Track", n => { Track = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_Track>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ConnectorName", ConnectorName);
            writer.WriteBoolValue("IncludeMetadataCustomHeaders", IncludeMetadataCustomHeaders);
            writer.WriteStringValue("Name", Name);
            writer.WriteBoolValue("Secure", Secure);
            writer.WriteIntValue("SessionTimeoutSecs", SessionTimeoutSecs);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_SipTransport>("SipTransport", SipTransport);
            writer.WriteStringValue("StatusCallback", StatusCallback);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_StatusCallbackMethod>("StatusCallbackMethod", StatusCallbackMethod);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlCreateSiprecSessionRequestBody_Track>("Track", Track);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
