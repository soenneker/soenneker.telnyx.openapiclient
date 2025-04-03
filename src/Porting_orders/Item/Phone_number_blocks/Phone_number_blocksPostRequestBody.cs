// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Phone_number_blocksPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the activation ranges for this porting phone number block. The activation range must be within the block range and should not overlap with other activation ranges.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_activation_ranges>? ActivationRanges { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_activation_ranges> ActivationRanges { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The phone_number_range property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_phone_number_range? PhoneNumberRange { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_phone_number_range PhoneNumberRange { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody"/> and sets the default values.
        /// </summary>
        public Phone_number_blocksPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activation_ranges", n => { ActivationRanges = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_activation_ranges>(global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_activation_ranges.CreateFromDiscriminatorValue)?.AsList(); } },
                { "phone_number_range", n => { PhoneNumberRange = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_phone_number_range>(global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_phone_number_range.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_activation_ranges>("activation_ranges", ActivationRanges);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Phone_number_blocks.Phone_number_blocksPostRequestBody_phone_number_range>("phone_number_range", PhoneNumberRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
