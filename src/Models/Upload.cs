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
    public partial class Upload : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The available_usages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.Models.Upload_available_usages?>? AvailableUsages { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.Models.Upload_available_usages?> AvailableUsages { get; set; }
#endif
        /// <summary>A code returned by Microsoft Teams if there is an error with the upload process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode { get; set; }
#nullable restore
#else
        public string ErrorCode { get; set; }
#endif
        /// <summary>A message set if there is an error with the upload process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMessage { get; set; }
#nullable restore
#else
        public string ErrorMessage { get; set; }
#endif
        /// <summary>The location_id property</summary>
        public Guid? LocationId { get; set; }
        /// <summary>Represents the status of the upload on Microsoft Teams.</summary>
        public global::Soenneker.Telnyx.Models.Upload_status? Status { get; set; }
        /// <summary>The tenant_id property</summary>
        public Guid? TenantId { get; set; }
        /// <summary>Uniquely identifies the resource.</summary>
        public Guid? TicketId { get; set; }
        /// <summary>The tn_upload_entries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.Models.TnUploadEntry>? TnUploadEntries { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.Models.TnUploadEntry> TnUploadEntries { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.Upload"/> and sets the default values.
        /// </summary>
        public Upload()
        {
            AdditionalData = new Dictionary<string, object>();
            Status = global::Soenneker.Telnyx.Models.Upload_status.Pending_upload;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.Upload"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.Upload CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.Upload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "available_usages", n => { AvailableUsages = n.GetCollectionOfEnumValues<global::Soenneker.Telnyx.Models.Upload_available_usages>()?.AsList(); } },
                { "error_code", n => { ErrorCode = n.GetStringValue(); } },
                { "error_message", n => { ErrorMessage = n.GetStringValue(); } },
                { "location_id", n => { LocationId = n.GetGuidValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.Upload_status>(); } },
                { "tenant_id", n => { TenantId = n.GetGuidValue(); } },
                { "ticket_id", n => { TicketId = n.GetGuidValue(); } },
                { "tn_upload_entries", n => { TnUploadEntries = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.Models.TnUploadEntry>(global::Soenneker.Telnyx.Models.TnUploadEntry.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::Soenneker.Telnyx.Models.Upload_available_usages>("available_usages", AvailableUsages);
            writer.WriteStringValue("error_code", ErrorCode);
            writer.WriteStringValue("error_message", ErrorMessage);
            writer.WriteGuidValue("location_id", LocationId);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.Upload_status>("status", Status);
            writer.WriteGuidValue("tenant_id", TenantId);
            writer.WriteGuidValue("ticket_id", TicketId);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.Models.TnUploadEntry>("tn_upload_entries", TnUploadEntries);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
