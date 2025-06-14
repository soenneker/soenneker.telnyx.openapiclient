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
    public partial class SIMCardOrderPreview_Model : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount of SIM cards requested in the SIM card order.</summary>
        public int? Quantity { get; set; }
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The shipping_cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_shipping_cost? ShippingCost { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_shipping_cost ShippingCost { get; set; }
#endif
        /// <summary>The sim_cards_cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_sim_cards_cost? SimCardsCost { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_sim_cards_cost SimCardsCost { get; set; }
#endif
        /// <summary>The total_cost property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_total_cost? TotalCost { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_total_cost TotalCost { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model"/> and sets the default values.
        /// </summary>
        public SIMCardOrderPreview_Model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "quantity", n => { Quantity = n.GetIntValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "shipping_cost", n => { ShippingCost = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_shipping_cost>(global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_shipping_cost.CreateFromDiscriminatorValue); } },
                { "sim_cards_cost", n => { SimCardsCost = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_sim_cards_cost>(global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_sim_cards_cost.CreateFromDiscriminatorValue); } },
                { "total_cost", n => { TotalCost = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_total_cost>(global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_total_cost.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("quantity", Quantity);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_shipping_cost>("shipping_cost", ShippingCost);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_sim_cards_cost>("sim_cards_cost", SimCardsCost);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SIMCardOrderPreview_Model_total_cost>("total_cost", TotalCost);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
