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
    public partial class WdrReport : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>ISO 8601 formatted date-time indicating the end time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndTime { get; set; }
#nullable restore
#else
        public string EndTime { get; set; }
#endif
        /// <summary>Identifies the resource.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The URL where the report content, when generated, will be published to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReportUrl { get; set; }
#nullable restore
#else
        public string ReportUrl { get; set; }
#endif
        /// <summary>ISO 8601 formatted date-time indicating the start time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>Indicates the status of the report, which is updated asynchronously.</summary>
        public global::Soenneker.Telnyx.Models.WdrReport_status? Status { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; private set; }
#nullable restore
#else
        public string UpdatedAt { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.WdrReport"/> and sets the default values.
        /// </summary>
        public WdrReport()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.WdrReport"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.WdrReport CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.WdrReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "end_time", n => { EndTime = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "report_url", n => { ReportUrl = n.GetStringValue(); } },
                { "start_time", n => { StartTime = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.WdrReport_status>(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("end_time", EndTime);
            writer.WriteStringValue("report_url", ReportUrl);
            writer.WriteStringValue("start_time", StartTime);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.WdrReport_status>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
