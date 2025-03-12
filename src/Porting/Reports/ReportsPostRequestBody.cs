// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Soenneker.Telnyx.Models;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Porting.Reports
{
    /// <summary>
    /// The parameters for generating a new porting related report.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReportsPostRequestBody : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The params property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.ExportPortingOrdersCSVReport? Params { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.ExportPortingOrdersCSVReport Params { get; set; }
#endif
        /// <summary>Identifies the type of report</summary>
        public global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody_report_type? ReportType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody"/> and sets the default values.
        /// </summary>
        public ReportsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "params", n => { Params = n.GetObjectValue<global::Soenneker.Telnyx.Models.ExportPortingOrdersCSVReport>(global::Soenneker.Telnyx.Models.ExportPortingOrdersCSVReport.CreateFromDiscriminatorValue); } },
                { "report_type", n => { ReportType = n.GetEnumValue<global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody_report_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.ExportPortingOrdersCSVReport>("params", Params);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Porting.Reports.ReportsPostRequestBody_report_type>("report_type", ReportType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
