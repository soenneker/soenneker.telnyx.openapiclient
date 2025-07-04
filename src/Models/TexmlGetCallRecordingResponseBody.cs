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
    public partial class TexmlGetCallRecordingResponseBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account_sid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountSid { get; set; }
#nullable restore
#else
        public string AccountSid { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The call_sid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallSid { get; set; }
#nullable restore
#else
        public string CallSid { get; set; }
#endif
        /// <summary>The channels property</summary>
        public int? Channels { get; set; }
        /// <summary>The conference_sid property</summary>
        public Guid? ConferenceSid { get; set; }
        /// <summary>The date_created property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateCreated { get; set; }
#nullable restore
#else
        public string DateCreated { get; set; }
#endif
        /// <summary>The date_updated property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateUpdated { get; set; }
#nullable restore
#else
        public string DateUpdated { get; set; }
#endif
        /// <summary>The duration of this recording, given in seconds.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Duration { get; set; }
#nullable restore
#else
        public string Duration { get; set; }
#endif
        /// <summary>The error_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode { get; set; }
#nullable restore
#else
        public string ErrorCode { get; set; }
#endif
        /// <summary>The media_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaUrl { get; set; }
#nullable restore
#else
        public string MediaUrl { get; set; }
#endif
        /// <summary>Identifier of a resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sid { get; set; }
#nullable restore
#else
        public string Sid { get; set; }
#endif
        /// <summary>Defines how the recording was created.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.RecordingSource? Source { get; set; }
        /// <summary>The start_time property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingStatus? Status { get; set; }
        /// <summary>Subresources details for a recording if available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingSubresourcesUris? SubresourcesUris { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingSubresourcesUris SubresourcesUris { get; set; }
#endif
        /// <summary>The relative URI for this recording resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TexmlGetCallRecordingResponseBody"/> and sets the default values.
        /// </summary>
        public TexmlGetCallRecordingResponseBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TexmlGetCallRecordingResponseBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.TexmlGetCallRecordingResponseBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.TexmlGetCallRecordingResponseBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_sid", n => { AccountSid = n.GetStringValue(); } },
                { "call_sid", n => { CallSid = n.GetStringValue(); } },
                { "channels", n => { Channels = n.GetIntValue(); } },
                { "conference_sid", n => { ConferenceSid = n.GetGuidValue(); } },
                { "date_created", n => { DateCreated = n.GetStringValue(); } },
                { "date_updated", n => { DateUpdated = n.GetStringValue(); } },
                { "duration", n => { Duration = n.GetStringValue(); } },
                { "error_code", n => { ErrorCode = n.GetStringValue(); } },
                { "media_url", n => { MediaUrl = n.GetStringValue(); } },
                { "sid", n => { Sid = n.GetStringValue(); } },
                { "source", n => { Source = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.RecordingSource>(); } },
                { "start_time", n => { StartTime = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingStatus>(); } },
                { "subresources_uris", n => { SubresourcesUris = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingSubresourcesUris>(global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingSubresourcesUris.CreateFromDiscriminatorValue); } },
                { "uri", n => { Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_sid", AccountSid);
            writer.WriteStringValue("call_sid", CallSid);
            writer.WriteIntValue("channels", Channels);
            writer.WriteGuidValue("conference_sid", ConferenceSid);
            writer.WriteStringValue("date_created", DateCreated);
            writer.WriteStringValue("date_updated", DateUpdated);
            writer.WriteStringValue("duration", Duration);
            writer.WriteStringValue("error_code", ErrorCode);
            writer.WriteStringValue("media_url", MediaUrl);
            writer.WriteStringValue("sid", Sid);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.RecordingSource>("source", Source);
            writer.WriteStringValue("start_time", StartTime);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingStatus>("status", Status);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TexmlRecordingSubresourcesUris>("subresources_uris", SubresourcesUris);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
