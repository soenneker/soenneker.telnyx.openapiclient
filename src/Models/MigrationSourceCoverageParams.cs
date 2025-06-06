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
    public partial class MigrationSourceCoverageParams : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Cloud provider from which to migrate data.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceCoverageParams_provider? Provider { get; set; }
        /// <summary>Provider region from which to migrate data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceRegion { get; set; }
#nullable restore
#else
        public string SourceRegion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceCoverageParams"/> and sets the default values.
        /// </summary>
        public MigrationSourceCoverageParams()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceCoverageParams"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceCoverageParams CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceCoverageParams();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "provider", n => { Provider = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceCoverageParams_provider>(); } },
                { "source_region", n => { SourceRegion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceCoverageParams_provider>("provider", Provider);
            writer.WriteStringValue("source_region", SourceRegion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
