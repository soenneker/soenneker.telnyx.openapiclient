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
    public partial class UpdateFqdnConnectionRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defaults to true</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>`Latency` directs Telnyx to route media through the site with the lowest round-trip time to the user&apos;s connection. Telnyx calculates this time using ICMP ping messages. This can be disabled by specifying a site to handle all media.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride? AnchorsiteOverride { get; set; }
        /// <summary>The uuid of the push credential for Android</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AndroidPushCredentialId { get; set; }
#nullable restore
#else
        public string AndroidPushCredentialId { get; set; }
#endif
        /// <summary>A user-assigned name to help manage the connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionName { get; set; }
#nullable restore
#else
        public string ConnectionName { get; set; }
#endif
        /// <summary>When enabled, Telnyx will generate comfort noise when you place the call on hold. If disabled, you will need to generate comfort noise or on hold music to avoid RTP timeout.</summary>
        public bool? DefaultOnHoldComfortNoiseEnabled { get; set; }
        /// <summary>Sets the type of DTMF digits sent from Telnyx to this Connection. Note that DTMF digits sent to Telnyx will be accepted in all formats.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType? DtmfType { get; set; }
        /// <summary>Encode the SIP contact header sent by Telnyx to avoid issues for NAT or ALG scenarios.</summary>
        public bool? EncodeContactHeaderEnabled { get; set; }
        /// <summary>Enable use of SRTP for encryption. Cannot be set if the transport_portocol is TLS.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.EncryptedMedia? EncryptedMedia { get; set; }
        /// <summary>The inbound property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.InboundFqdn? Inbound { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.InboundFqdn Inbound { get; set; }
#endif
        /// <summary>The uuid of the push credential for Ios</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IosPushCredentialId { get; set; }
#nullable restore
#else
        public string IosPushCredentialId { get; set; }
#endif
        /// <summary>Enable on-net T38 if you prefer that the sender and receiver negotiate T38 directly when both are on the Telnyx network. If this is disabled, Telnyx will be able to use T38 on just one leg of the call according to each leg&apos;s settings.</summary>
        public bool? OnnetT38PassthroughEnabled { get; set; }
        /// <summary>The outbound property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.OutboundFqdn? Outbound { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.OutboundFqdn Outbound { get; set; }
#endif
        /// <summary>The rtcp_settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.ConnectionRtcpSettings? RtcpSettings { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.ConnectionRtcpSettings RtcpSettings { get; set; }
#endif
        /// <summary>One of UDP, TLS, or TCP. Applies only to connections with IP authentication or FQDN authentication.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.FqdnConnectionTransportProtocol? TransportProtocol { get; set; }
        /// <summary>Determines which webhook format will be used, Telnyx API v1 or v2.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.WebhookApiVersion? WebhookApiVersion { get; set; }
        /// <summary>The failover URL where webhooks related to this connection will be sent if sending to the primary URL fails. Must include a scheme, such as &apos;https&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookEventFailoverUrl { get; set; }
#nullable restore
#else
        public string WebhookEventFailoverUrl { get; set; }
#endif
        /// <summary>The URL where webhooks related to this connection will be sent. Must include a scheme, such as &apos;https&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookEventUrl { get; set; }
#nullable restore
#else
        public string WebhookEventUrl { get; set; }
#endif
        /// <summary>Specifies how many seconds to wait before timing out a webhook.</summary>
        public int? WebhookTimeoutSecs { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdateFqdnConnectionRequest"/> and sets the default values.
        /// </summary>
        public UpdateFqdnConnectionRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            AnchorsiteOverride = global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride.Latency;
            DtmfType = global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType.RFC2833;
            TransportProtocol = global::Soenneker.Telnyx.OpenApiClient.Models.FqdnConnectionTransportProtocol.UDP;
            WebhookApiVersion = global::Soenneker.Telnyx.OpenApiClient.Models.WebhookApiVersion.One;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdateFqdnConnectionRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.UpdateFqdnConnectionRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.UpdateFqdnConnectionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "anchorsite_override", n => { AnchorsiteOverride = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride>(); } },
                { "android_push_credential_id", n => { AndroidPushCredentialId = n.GetStringValue(); } },
                { "connection_name", n => { ConnectionName = n.GetStringValue(); } },
                { "default_on_hold_comfort_noise_enabled", n => { DefaultOnHoldComfortNoiseEnabled = n.GetBoolValue(); } },
                { "dtmf_type", n => { DtmfType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType>(); } },
                { "encode_contact_header_enabled", n => { EncodeContactHeaderEnabled = n.GetBoolValue(); } },
                { "encrypted_media", n => { EncryptedMedia = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.EncryptedMedia>(); } },
                { "inbound", n => { Inbound = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.InboundFqdn>(global::Soenneker.Telnyx.OpenApiClient.Models.InboundFqdn.CreateFromDiscriminatorValue); } },
                { "ios_push_credential_id", n => { IosPushCredentialId = n.GetStringValue(); } },
                { "onnet_t38_passthrough_enabled", n => { OnnetT38PassthroughEnabled = n.GetBoolValue(); } },
                { "outbound", n => { Outbound = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.OutboundFqdn>(global::Soenneker.Telnyx.OpenApiClient.Models.OutboundFqdn.CreateFromDiscriminatorValue); } },
                { "rtcp_settings", n => { RtcpSettings = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConnectionRtcpSettings>(global::Soenneker.Telnyx.OpenApiClient.Models.ConnectionRtcpSettings.CreateFromDiscriminatorValue); } },
                { "transport_protocol", n => { TransportProtocol = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.FqdnConnectionTransportProtocol>(); } },
                { "webhook_api_version", n => { WebhookApiVersion = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.WebhookApiVersion>(); } },
                { "webhook_event_failover_url", n => { WebhookEventFailoverUrl = n.GetStringValue(); } },
                { "webhook_event_url", n => { WebhookEventUrl = n.GetStringValue(); } },
                { "webhook_timeout_secs", n => { WebhookTimeoutSecs = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride>("anchorsite_override", AnchorsiteOverride);
            writer.WriteStringValue("android_push_credential_id", AndroidPushCredentialId);
            writer.WriteStringValue("connection_name", ConnectionName);
            writer.WriteBoolValue("default_on_hold_comfort_noise_enabled", DefaultOnHoldComfortNoiseEnabled);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType>("dtmf_type", DtmfType);
            writer.WriteBoolValue("encode_contact_header_enabled", EncodeContactHeaderEnabled);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.EncryptedMedia>("encrypted_media", EncryptedMedia);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.InboundFqdn>("inbound", Inbound);
            writer.WriteStringValue("ios_push_credential_id", IosPushCredentialId);
            writer.WriteBoolValue("onnet_t38_passthrough_enabled", OnnetT38PassthroughEnabled);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.OutboundFqdn>("outbound", Outbound);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConnectionRtcpSettings>("rtcp_settings", RtcpSettings);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.FqdnConnectionTransportProtocol>("transport_protocol", TransportProtocol);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.WebhookApiVersion>("webhook_api_version", WebhookApiVersion);
            writer.WriteStringValue("webhook_event_failover_url", WebhookEventFailoverUrl);
            writer.WriteStringValue("webhook_event_url", WebhookEventUrl);
            writer.WriteIntValue("webhook_timeout_secs", WebhookTimeoutSecs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
