// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>
    /// The body parameters the webhook tool accepts, described as a JSON Schema object. These parameters will be passed to the webhook as the body of the request. See the [JSON Schema reference](https://json-schema.org/understanding-json-schema) for documentation about the format
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WebhookToolParams_body_parameters : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The properties of the body parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_properties? Properties { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_properties Properties { get; set; }
#endif
        /// <summary>The required properties of the body parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Required { get; set; }
#nullable restore
#else
        public List<string> Required { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters"/> and sets the default values.
        /// </summary>
        public WebhookToolParams_body_parameters()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "properties", n => { Properties = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_properties>(global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_properties.CreateFromDiscriminatorValue); } },
                { "required", n => { Required = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_properties>("properties", Properties);
            writer.WriteCollectionOfPrimitiveValues<string>("required", Required);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.WebhookToolParams_body_parameters_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
