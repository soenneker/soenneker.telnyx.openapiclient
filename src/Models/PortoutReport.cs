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
    public partial class PortoutReport : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Identifies the document that was uploaded when report was generated. This field is only populated when the report is under completed status.</summary>
        public Guid? DocumentId { get; set; }
        /// <summary>Uniquely identifies the report.</summary>
        public Guid? Id { get; set; }
        /// <summary>The params property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.ExportPortoutsCSVReport? Params { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.ExportPortoutsCSVReport Params { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>Identifies the type of report</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport_report_type? ReportType { get; set; }
        /// <summary>The current status of the report generation.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport_status? Status { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was updated.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport"/> and sets the default values.
        /// </summary>
        public PortoutReport()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "document_id", n => { DocumentId = n.GetGuidValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "params", n => { Params = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ExportPortoutsCSVReport>(global::Soenneker.Telnyx.OpenApiClient.Models.ExportPortoutsCSVReport.CreateFromDiscriminatorValue); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "report_type", n => { ReportType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport_report_type>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport_status>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteGuidValue("document_id", DocumentId);
            writer.WriteGuidValue("id", Id);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ExportPortoutsCSVReport>("params", Params);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport_report_type>("report_type", ReportType);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortoutReport_status>("status", Status);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
