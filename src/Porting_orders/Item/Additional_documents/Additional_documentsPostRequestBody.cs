// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Additional_documentsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additional_documents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody_additional_documents>? AdditionalDocuments { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody_additional_documents> AdditionalDocuments { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody"/> and sets the default values.
        /// </summary>
        public Additional_documentsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additional_documents", n => { AdditionalDocuments = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody_additional_documents>(global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody_additional_documents.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Additional_documents.Additional_documentsPostRequestBody_additional_documents>("additional_documents", AdditionalDocuments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
