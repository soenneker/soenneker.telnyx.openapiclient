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
    public partial class ConferenceResource : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The id of the account the resource belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountSid { get; set; }
#nullable restore
#else
        public string AccountSid { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The version of the API that was used to make the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApiVersion { get; set; }
#nullable restore
#else
        public string ApiVersion { get; set; }
#endif
        /// <summary>Caller ID, if present.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallSidEndingConference { get; set; }
#nullable restore
#else
        public string CallSidEndingConference { get; set; }
#endif
        /// <summary>The timestamp of when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateCreated { get; set; }
#nullable restore
#else
        public string DateCreated { get; set; }
#endif
        /// <summary>The timestamp of when the resource was last updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateUpdated { get; set; }
#nullable restore
#else
        public string DateUpdated { get; set; }
#endif
        /// <summary>A string that you assigned to describe this conference room.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FriendlyName { get; set; }
#nullable restore
#else
        public string FriendlyName { get; set; }
#endif
        /// <summary>The reason why a conference ended. When a conference is in progress, will be null.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_reason_conference_ended? ReasonConferenceEnded { get; set; }
        /// <summary>A string representing the region where the conference is hosted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>The unique identifier of the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sid { get; set; }
#nullable restore
#else
        public string Sid { get; set; }
#endif
        /// <summary>The status of this conference.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_status? Status { get; set; }
        /// <summary>A list of related resources identified by their relative URIs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_subresource_uris? SubresourceUris { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_subresource_uris SubresourceUris { get; set; }
#endif
        /// <summary>The relative URI for this conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource"/> and sets the default values.
        /// </summary>
        public ConferenceResource()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource();
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
                { "api_version", n => { ApiVersion = n.GetStringValue(); } },
                { "call_sid_ending_conference", n => { CallSidEndingConference = n.GetStringValue(); } },
                { "date_created", n => { DateCreated = n.GetStringValue(); } },
                { "date_updated", n => { DateUpdated = n.GetStringValue(); } },
                { "friendly_name", n => { FriendlyName = n.GetStringValue(); } },
                { "reason_conference_ended", n => { ReasonConferenceEnded = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_reason_conference_ended>(); } },
                { "region", n => { Region = n.GetStringValue(); } },
                { "sid", n => { Sid = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_status>(); } },
                { "subresource_uris", n => { SubresourceUris = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_subresource_uris>(global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_subresource_uris.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("api_version", ApiVersion);
            writer.WriteStringValue("call_sid_ending_conference", CallSidEndingConference);
            writer.WriteStringValue("date_created", DateCreated);
            writer.WriteStringValue("date_updated", DateUpdated);
            writer.WriteStringValue("friendly_name", FriendlyName);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_reason_conference_ended>("reason_conference_ended", ReasonConferenceEnded);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("sid", Sid);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_status>("status", Status);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource_subresource_uris>("subresource_uris", SubresourceUris);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
