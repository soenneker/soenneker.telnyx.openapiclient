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
    public partial class ChatCompletionSystemMessageParam : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content? Content { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content Content { get; set; }
#endif
        /// <summary>The role property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_role? Role { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam"/> and sets the default values.
        /// </summary>
        public ChatCompletionSystemMessageParam()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "content", n => { Content = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content>(global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content.CreateFromDiscriminatorValue); } },
                { "role", n => { Role = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_role>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content>("content", Content);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_role>("role", Role);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="string"/>, List&lt;global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChatCompletionSystemMessageParam_content : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type List&lt;global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1>? ChatCompletionSystemMessageParamContentMember1 { get; set; }
#nullable restore
#else
            public List<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1> ChatCompletionSystemMessageParamContentMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.ChatCompletionSystemMessageParam_content();
                if(parseNode.GetStringValue() is string stringValue)
                {
                    result.String = stringValue;
                }
                else if(parseNode.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1>(global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1.CreateFromDiscriminatorValue)?.AsList() is List<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1> chatCompletionSystemMessageParamContentMember1Value)
                {
                    result.ChatCompletionSystemMessageParamContentMember1 = chatCompletionSystemMessageParamContentMember1Value;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(String != null)
                {
                    writer.WriteStringValue(null, String);
                }
                else if(ChatCompletionSystemMessageParamContentMember1 != null)
                {
                    writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam_contentMember1>(null, ChatCompletionSystemMessageParamContentMember1);
                }
            }
        }
    }
}
#pragma warning restore CS0618
