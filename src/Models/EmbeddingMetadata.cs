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
    public partial class EmbeddingMetadata : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The certainty property</summary>
        public double? Certainty { get; set; }
        /// <summary>The checksum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Checksum { get; set; }
#nullable restore
#else
        public string Checksum { get; set; }
#endif
        /// <summary>The embedding property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Embedding { get; set; }
#nullable restore
#else
        public string Embedding { get; set; }
#endif
        /// <summary>The filename property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filename { get; set; }
#nullable restore
#else
        public string Filename { get; set; }
#endif
        /// <summary>The loader_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata_loader_metadata? LoaderMetadata { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata_loader_metadata LoaderMetadata { get; set; }
#endif
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Source { get; set; }
#nullable restore
#else
        public string Source { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata"/> and sets the default values.
        /// </summary>
        public EmbeddingMetadata()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "certainty", n => { Certainty = n.GetDoubleValue(); } },
                { "checksum", n => { Checksum = n.GetStringValue(); } },
                { "embedding", n => { Embedding = n.GetStringValue(); } },
                { "filename", n => { Filename = n.GetStringValue(); } },
                { "loader_metadata", n => { LoaderMetadata = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata_loader_metadata>(global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata_loader_metadata.CreateFromDiscriminatorValue); } },
                { "source", n => { Source = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("certainty", Certainty);
            writer.WriteStringValue("checksum", Checksum);
            writer.WriteStringValue("embedding", Embedding);
            writer.WriteStringValue("filename", Filename);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.EmbeddingMetadata_loader_metadata>("loader_metadata", LoaderMetadata);
            writer.WriteStringValue("source", Source);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
