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
    /// Response model for webhook tool test results
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TestWebhookToolResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>The request property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse_request? Request { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse_request Request { get; set; }
#endif
        /// <summary>The response property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Response { get; set; }
#nullable restore
#else
        public string Response { get; set; }
#endif
        /// <summary>The status_code property</summary>
        public int? StatusCode { get; set; }
        /// <summary>The success property</summary>
        public bool? Success { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse"/> and sets the default values.
        /// </summary>
        public TestWebhookToolResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "content_type", n => { ContentType = n.GetStringValue(); } },
                { "request", n => { Request = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse_request>(global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse_request.CreateFromDiscriminatorValue); } },
                { "response", n => { Response = n.GetStringValue(); } },
                { "status_code", n => { StatusCode = n.GetIntValue(); } },
                { "success", n => { Success = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("content_type", ContentType);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TestWebhookToolResponse_request>("request", Request);
            writer.WriteStringValue("response", Response);
            writer.WriteIntValue("status_code", StatusCode);
            writer.WriteBoolValue("success", Success);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
