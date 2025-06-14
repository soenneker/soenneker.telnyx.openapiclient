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
    /// Composed type wrapper for classes <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.EnumObjectResponse"/>, <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.EnumPaginatedResponse"/>, List&lt;global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1&gt;
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GetEnumEndpoint_200 : IComposedTypeWrapper, IParsable
    {
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.EnumObjectResponse"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.EnumObjectResponse? EnumObjectResponse { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.EnumObjectResponse EnumObjectResponse { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.EnumPaginatedResponse"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.EnumPaginatedResponse? EnumPaginatedResponse { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.EnumPaginatedResponse EnumPaginatedResponse { get; set; }
#endif
        /// <summary>Composed type representation for type List&lt;global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1>? GetEnumEndpoint200Member1 { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1> GetEnumEndpoint200Member1 { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            var result = new global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200();
            if("EnumObjectResponse".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.EnumObjectResponse = new global::Soenneker.Telnyx.OpenApiClient.Models.EnumObjectResponse();
            }
            else if("EnumPaginatedResponse".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
            {
                result.EnumPaginatedResponse = new global::Soenneker.Telnyx.OpenApiClient.Models.EnumPaginatedResponse();
            }
            else if(parseNode.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1>(global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1.CreateFromDiscriminatorValue)?.AsList() is List<global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1> getEnumEndpoint200Member1Value)
            {
                result.GetEnumEndpoint200Member1 = getEnumEndpoint200Member1Value;
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            if(EnumObjectResponse != null)
            {
                return EnumObjectResponse.GetFieldDeserializers();
            }
            else if(EnumPaginatedResponse != null)
            {
                return EnumPaginatedResponse.GetFieldDeserializers();
            }
            return new Dictionary<string, Action<IParseNode>>();
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            if(EnumObjectResponse != null)
            {
                writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.EnumObjectResponse>(null, EnumObjectResponse);
            }
            else if(EnumPaginatedResponse != null)
            {
                writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.EnumPaginatedResponse>(null, EnumPaginatedResponse);
            }
            else if(GetEnumEndpoint200Member1 != null)
            {
                writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.GetEnumEndpoint_200Member1>(null, GetEnumEndpoint200Member1);
            }
        }
    }
}
#pragma warning restore CS0618
