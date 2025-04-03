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
    public partial class SendFaxRequest : IAdditionalDataHolder, IParsable
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
        /// <summary>The connection ID to send the fax with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionId { get; set; }
#nullable restore
#else
        public string ConnectionId { get; set; }
#endif
        /// <summary>The phone number, in E.164 format, the fax will be sent from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? From { get; set; }
#nullable restore
#else
        public string From { get; set; }
#endif
        /// <summary>The `from_display_name` string to be used as the caller id name (SIP From Display Name) presented to the destination (`to` number). The string should have a maximum of 128 characters, containing only letters, numbers, spaces, and -_~!.+ special characters. If ommited, the display name will be the same as the number in the `from` field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromDisplayName { get; set; }
#nullable restore
#else
        public string FromDisplayName { get; set; }
#endif
        /// <summary>The media_name used for the fax&apos;s media. Must point to a file previously uploaded to api.telnyx.com/v2/media by the same user/organization. media_name and media_url/contents can&apos;t be submitted together.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaName { get; set; }
#nullable restore
#else
        public string MediaName { get; set; }
#endif
        /// <summary>The URL (or list of URLs) to the PDF used for the fax&apos;s media. media_url and media_name/contents can&apos;t be submitted together.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaUrl { get; set; }
#nullable restore
#else
        public string MediaUrl { get; set; }
#endif
        /// <summary>The flag to enable monochrome, true black and white fax results.</summary>
        public bool? Monochrome { get; set; }
        /// <summary>The format for the preview file in case the `store_preview` is `true`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest_preview_format? PreviewFormat { get; set; }
        /// <summary>The quality of the fax. The `ultra` settings provides the highest quality available, but also present longer fax processing times. `ultra_light` is best suited for images, wihle `ultra_dark` is best suited for text.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.Quality? Quality { get; set; }
        /// <summary>Should fax media be stored on temporary URL. It does not support media_name, they can&apos;t be submitted together.</summary>
        public bool? StoreMedia { get; set; }
        /// <summary>Should fax preview be stored on temporary URL.</summary>
        public bool? StorePreview { get; set; }
        /// <summary>The flag to disable the T.38 protocol.</summary>
        public bool? T38Enabled { get; set; }
        /// <summary>The phone number, in E.164 format, the fax will be sent to or SIP URI</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>Use this field to override the URL to which Telnyx will send subsequent webhooks for this fax.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookUrl { get; set; }
#nullable restore
#else
        public string WebhookUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest"/> and sets the default values.
        /// </summary>
        public SendFaxRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            PreviewFormat = global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest_preview_format.Tiff;
            Quality = global::Soenneker.Telnyx.OpenApiClient.Models.Quality.High;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest();
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
                { "connection_id", n => { ConnectionId = n.GetStringValue(); } },
                { "from", n => { From = n.GetStringValue(); } },
                { "from_display_name", n => { FromDisplayName = n.GetStringValue(); } },
                { "media_name", n => { MediaName = n.GetStringValue(); } },
                { "media_url", n => { MediaUrl = n.GetStringValue(); } },
                { "monochrome", n => { Monochrome = n.GetBoolValue(); } },
                { "preview_format", n => { PreviewFormat = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest_preview_format>(); } },
                { "quality", n => { Quality = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.Quality>(); } },
                { "store_media", n => { StoreMedia = n.GetBoolValue(); } },
                { "store_preview", n => { StorePreview = n.GetBoolValue(); } },
                { "t38_enabled", n => { T38Enabled = n.GetBoolValue(); } },
                { "to", n => { To = n.GetStringValue(); } },
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
            writer.WriteStringValue("client_state", ClientState);
            writer.WriteStringValue("connection_id", ConnectionId);
            writer.WriteStringValue("from", From);
            writer.WriteStringValue("from_display_name", FromDisplayName);
            writer.WriteStringValue("media_name", MediaName);
            writer.WriteStringValue("media_url", MediaUrl);
            writer.WriteBoolValue("monochrome", Monochrome);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SendFaxRequest_preview_format>("preview_format", PreviewFormat);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.Quality>("quality", Quality);
            writer.WriteBoolValue("store_media", StoreMedia);
            writer.WriteBoolValue("store_preview", StorePreview);
            writer.WriteBoolValue("t38_enabled", T38Enabled);
            writer.WriteStringValue("to", To);
            writer.WriteStringValue("webhook_url", WebhookUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
