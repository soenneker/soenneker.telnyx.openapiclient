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
    public partial class MigrationSourceParams : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Bucket name to migrate the data from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BucketName { get; set; }
#nullable restore
#else
        public string BucketName { get; set; }
#endif
        /// <summary>Unique identifier for the data migration source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>Cloud provider from which to migrate data. Use &apos;telnyx&apos; if you want to migrate data from one Telnyx bucket to another.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider? Provider { get; set; }
        /// <summary>The provider_auth property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider_auth? ProviderAuth { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider_auth ProviderAuth { get; set; }
#endif
        /// <summary>For intra-Telnyx buckets migration, specify the source bucket region in this field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceRegion { get; set; }
#nullable restore
#else
        public string SourceRegion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams"/> and sets the default values.
        /// </summary>
        public MigrationSourceParams()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bucket_name", n => { BucketName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "provider", n => { Provider = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider>(); } },
                { "provider_auth", n => { ProviderAuth = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider_auth>(global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider_auth.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("bucket_name", BucketName);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider>("provider", Provider);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.MigrationSourceParams_provider_auth>("provider_auth", ProviderAuth);
            writer.WriteStringValue("source_region", SourceRegion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
