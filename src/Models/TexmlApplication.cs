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
    public partial class TexmlApplication : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies whether the connection can be used.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>`Latency` directs Telnyx to route media through the site with the lowest round-trip time to the user&apos;s connection. Telnyx calculates this time using ICMP ping messages. This can be disabled by specifying a site to handle all media.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride? AnchorsiteOverride { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>Sets the type of DTMF digits sent from Telnyx to this Connection. Note that DTMF digits sent to Telnyx will be accepted in all formats.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType? DtmfType { get; set; }
        /// <summary>Specifies whether calls to phone numbers associated with this connection should hangup after timing out.</summary>
        public bool? FirstCommandTimeout { get; set; }
        /// <summary>Specifies how many seconds to wait before timing out a dial command.</summary>
        public int? FirstCommandTimeoutSecs { get; set; }
        /// <summary>A user-assigned name to help manage the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FriendlyName { get; set; }
#nullable restore
#else
        public string FriendlyName { get; set; }
#endif
        /// <summary>Uniquely identifies the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The inbound property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_inbound? Inbound { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_inbound Inbound { get; set; }
#endif
        /// <summary>The outbound property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_outbound? Outbound { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_outbound Outbound { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>URL for Telnyx to send requests to containing information about call progress events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusCallback { get; set; }
#nullable restore
#else
        public string StatusCallback { get; set; }
#endif
        /// <summary>HTTP request method Telnyx should use when requesting the status_callback URL.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_status_callback_method? StatusCallbackMethod { get; set; }
        /// <summary>Tags associated with the Texml Application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>ISO 8601 formatted date-time indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; private set; }
#nullable restore
#else
        public string UpdatedAt { get; private set; }
#endif
        /// <summary>URL to which Telnyx will deliver your XML Translator webhooks if we get an error response from your voice_url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VoiceFallbackUrl { get; set; }
#nullable restore
#else
        public string VoiceFallbackUrl { get; set; }
#endif
        /// <summary>HTTP request method Telnyx will use to interact with your XML Translator webhooks. Either &apos;get&apos; or &apos;post&apos;.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_voice_method? VoiceMethod { get; set; }
        /// <summary>URL to which Telnyx will deliver your XML Translator webhooks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VoiceUrl { get; set; }
#nullable restore
#else
        public string VoiceUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication"/> and sets the default values.
        /// </summary>
        public TexmlApplication()
        {
            AdditionalData = new Dictionary<string, object>();
            AnchorsiteOverride = global::Soenneker.Telnyx.OpenApiClient.Models.AnchorsiteOverride.Latency;
            DtmfType = global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType.RFC2833;
            StatusCallbackMethod = global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_status_callback_method.Post;
            VoiceMethod = global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_voice_method.Post;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication();
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
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "dtmf_type", n => { DtmfType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType>(); } },
                { "first_command_timeout", n => { FirstCommandTimeout = n.GetBoolValue(); } },
                { "first_command_timeout_secs", n => { FirstCommandTimeoutSecs = n.GetIntValue(); } },
                { "friendly_name", n => { FriendlyName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "inbound", n => { Inbound = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_inbound>(global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_inbound.CreateFromDiscriminatorValue); } },
                { "outbound", n => { Outbound = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_outbound>(global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_outbound.CreateFromDiscriminatorValue); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "status_callback", n => { StatusCallback = n.GetStringValue(); } },
                { "status_callback_method", n => { StatusCallbackMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_status_callback_method>(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
                { "voice_fallback_url", n => { VoiceFallbackUrl = n.GetStringValue(); } },
                { "voice_method", n => { VoiceMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_voice_method>(); } },
                { "voice_url", n => { VoiceUrl = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.DtmfType>("dtmf_type", DtmfType);
            writer.WriteBoolValue("first_command_timeout", FirstCommandTimeout);
            writer.WriteIntValue("first_command_timeout_secs", FirstCommandTimeoutSecs);
            writer.WriteStringValue("friendly_name", FriendlyName);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_inbound>("inbound", Inbound);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_outbound>("outbound", Outbound);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteStringValue("status_callback", StatusCallback);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_status_callback_method>("status_callback_method", StatusCallbackMethod);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("voice_fallback_url", VoiceFallbackUrl);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlApplication_voice_method>("voice_method", VoiceMethod);
            writer.WriteStringValue("voice_url", VoiceUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
