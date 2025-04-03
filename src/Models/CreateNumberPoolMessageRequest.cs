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
    public partial class CreateNumberPoolMessageRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Automatically detect if an SMS message is unusually long and exceeds a recommended limit of message parts.</summary>
        public bool? AutoDetect { get; set; }
        /// <summary>A list of media URLs. The total media size must be less than 1 MB.**Required for MMS**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MediaUrls { get; set; }
#nullable restore
#else
        public List<string> MediaUrls { get; set; }
#endif
        /// <summary>Unique identifier for a messaging profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessagingProfileId { get; set; }
#nullable restore
#else
        public string MessagingProfileId { get; set; }
#endif
        /// <summary>Subject of multimedia message</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>Message body (i.e., content) as a non-empty string.**Required for SMS**</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>Receiving address (+E.164 formatted phone number or short code).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>The protocol for sending the message, either SMS or MMS.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberPoolMessageRequest_type? Type { get; set; }
        /// <summary>If the profile this number is associated with has webhooks, use them for delivery notifications. If webhooks are also specified on the message itself, they will be attempted first, then those on the profile.</summary>
        public bool? UseProfileWebhooks { get; set; }
        /// <summary>The failover URL where webhooks related to this message will be sent if sending to the primary URL fails.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookFailoverUrl { get; set; }
#nullable restore
#else
        public string WebhookFailoverUrl { get; set; }
#endif
        /// <summary>The URL where webhooks related to this message will be sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookUrl { get; set; }
#nullable restore
#else
        public string WebhookUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberPoolMessageRequest"/> and sets the default values.
        /// </summary>
        public CreateNumberPoolMessageRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberPoolMessageRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberPoolMessageRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberPoolMessageRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auto_detect", n => { AutoDetect = n.GetBoolValue(); } },
                { "media_urls", n => { MediaUrls = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "messaging_profile_id", n => { MessagingProfileId = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "text", n => { Text = n.GetStringValue(); } },
                { "to", n => { To = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberPoolMessageRequest_type>(); } },
                { "use_profile_webhooks", n => { UseProfileWebhooks = n.GetBoolValue(); } },
                { "webhook_failover_url", n => { WebhookFailoverUrl = n.GetStringValue(); } },
                { "webhook_url", n => { WebhookUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("auto_detect", AutoDetect);
            writer.WriteCollectionOfPrimitiveValues<string>("media_urls", MediaUrls);
            writer.WriteStringValue("messaging_profile_id", MessagingProfileId);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("to", To);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberPoolMessageRequest_type>("type", Type);
            writer.WriteBoolValue("use_profile_webhooks", UseProfileWebhooks);
            writer.WriteStringValue("webhook_failover_url", WebhookFailoverUrl);
            writer.WriteStringValue("webhook_url", WebhookUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
