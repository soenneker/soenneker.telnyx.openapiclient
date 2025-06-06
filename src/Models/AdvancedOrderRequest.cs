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
    public partial class AdvancedOrderRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The area_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AreaCode { get; set; }
#nullable restore
#else
        public string AreaCode { get; set; }
#endif
        /// <summary>The comments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comments { get; set; }
#nullable restore
#else
        public string Comments { get; set; }
#endif
        /// <summary>The country_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The customer_reference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerReference { get; set; }
#nullable restore
#else
        public string CustomerReference { get; set; }
#endif
        /// <summary>The features property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_features?>? Features { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_features?> Features { get; set; }
#endif
        /// <summary>The phone_number_type property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_phone_number_type? PhoneNumberType { get; set; }
        /// <summary>The quantity property</summary>
        public int? Quantity { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest"/> and sets the default values.
        /// </summary>
        public AdvancedOrderRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            CountryCode = "US";
            PhoneNumberType = global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_phone_number_type.Local;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "area_code", n => { AreaCode = n.GetStringValue(); } },
                { "comments", n => { Comments = n.GetStringValue(); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "customer_reference", n => { CustomerReference = n.GetStringValue(); } },
                { "features", n => { Features = n.GetCollectionOfEnumValues<global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_features>()?.AsList(); } },
                { "phone_number_type", n => { PhoneNumberType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_phone_number_type>(); } },
                { "quantity", n => { Quantity = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("area_code", AreaCode);
            writer.WriteStringValue("comments", Comments);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteStringValue("customer_reference", CustomerReference);
            writer.WriteCollectionOfEnumValues<global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_features>("features", Features);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.AdvancedOrderRequest_phone_number_type>("phone_number_type", PhoneNumberType);
            writer.WriteIntValue("quantity", Quantity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
