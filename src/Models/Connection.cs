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
    public partial class Connection : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defaults to true</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>`Latency` directs Telnyx to route media through the site with the lowest round-trip time to the user&apos;s connection. Telnyx calculates this time using ICMP ping messages. This can be disabled by specifying a site to handle all media.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride? AnchorsiteOverride { get; set; }
        /// <summary>The connection_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionName { get; set; }
#nullable restore
#else
        public string ConnectionName { get; set; }
#endif
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>Identifies the specific resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Identifies the associated outbound voice profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutboundVoiceProfileId { get; set; }
#nullable restore
#else
        public string OutboundVoiceProfileId { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>ISO 8601 formatted date indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>Determines which webhook format will be used, Telnyx API v1 or v2.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.Connection_webhook_api_version? WebhookApiVersion { get; set; }
        /// <summary>The failover URL where webhooks related to this connection will be sent if sending to the primary URL fails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookEventFailoverUrl { get; set; }
#nullable restore
#else
        public string WebhookEventFailoverUrl { get; set; }
#endif
        /// <summary>The URL where webhooks related to this connection will be sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookEventUrl { get; set; }
#nullable restore
#else
        public string WebhookEventUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.Connection"/> and sets the default values.
        /// </summary>
        public Connection()
        {
            AdditionalData = new Dictionary<string, object>();
            AnchorsiteOverride = global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride.Latency;
            WebhookApiVersion = global::Soenneker.Telnyx.OpenApiClient.Models.Connection_webhook_api_version.One;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.Connection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.Connection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.Connection();
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
                { "connection_name", n => { ConnectionName = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "outbound_voice_profile_id", n => { OutboundVoiceProfileId = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
                { "webhook_api_version", n => { WebhookApiVersion = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.Connection_webhook_api_version>(); } },
                { "webhook_event_failover_url", n => { WebhookEventFailoverUrl = n.GetStringValue(); } },
                { "webhook_event_url", n => { WebhookEventUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("connection_name", ConnectionName);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("outbound_voice_profile_id", OutboundVoiceProfileId);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.Connection_webhook_api_version>("webhook_api_version", WebhookApiVersion);
            writer.WriteStringValue("webhook_event_failover_url", WebhookEventFailoverUrl);
            writer.WriteStringValue("webhook_event_url", WebhookEventUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
