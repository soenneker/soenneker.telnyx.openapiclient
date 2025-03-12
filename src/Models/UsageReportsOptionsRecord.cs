// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>
    /// An object following one of the schemas published in https://developers.telnyx.com/docs/api/v2/detail-records
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UsageReportsOptionsRecord : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Telnyx Product</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Product { get; set; }
#nullable restore
#else
        public string Product { get; set; }
#endif
        /// <summary>Telnyx Product Dimensions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProductDimensions { get; set; }
#nullable restore
#else
        public List<string> ProductDimensions { get; set; }
#endif
        /// <summary>Telnyx Product Metrics</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProductMetrics { get; set; }
#nullable restore
#else
        public List<string> ProductMetrics { get; set; }
#endif
        /// <summary>Subproducts if applicable</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.Models.RecordType?>? RecordTypes { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.Models.RecordType?> RecordTypes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.UsageReportsOptionsRecord"/> and sets the default values.
        /// </summary>
        public UsageReportsOptionsRecord()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.UsageReportsOptionsRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.UsageReportsOptionsRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.UsageReportsOptionsRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "product", n => { Product = n.GetStringValue(); } },
                { "product_dimensions", n => { ProductDimensions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "product_metrics", n => { ProductMetrics = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "record_types", n => { RecordTypes = n.GetCollectionOfEnumValues<global::Soenneker.Telnyx.Models.RecordType>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("product", Product);
            writer.WriteCollectionOfPrimitiveValues<string>("product_dimensions", ProductDimensions);
            writer.WriteCollectionOfPrimitiveValues<string>("product_metrics", ProductMetrics);
            writer.WriteCollectionOfEnumValues<global::Soenneker.Telnyx.Models.RecordType>("record_types", RecordTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
