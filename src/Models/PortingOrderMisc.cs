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
    public partial class PortingOrderMisc : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>New billing phone number for the remaining numbers. Used in case the current billing phone number is being ported to Telnyx. This will be set on your account with your current service provider and should be one of the numbers remaining on that account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewBillingPhoneNumber { get; set; }
#nullable restore
#else
        public string NewBillingPhoneNumber { get; set; }
#endif
        /// <summary>Remaining numbers can be either kept with their current service provider or disconnected. &apos;new_billing_telephone_number&apos; is required when &apos;remaining_numbers_action&apos; is &apos;keep&apos;.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc_remaining_numbers_action? RemainingNumbersAction { get; set; }
        /// <summary>A port can be either &apos;full&apos; or &apos;partial&apos;. When type is &apos;full&apos; the other attributes should be omitted.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc"/> and sets the default values.
        /// </summary>
        public PortingOrderMisc()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "new_billing_phone_number", n => { NewBillingPhoneNumber = n.GetStringValue(); } },
                { "remaining_numbers_action", n => { RemainingNumbersAction = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc_remaining_numbers_action>(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("new_billing_phone_number", NewBillingPhoneNumber);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc_remaining_numbers_action>("remaining_numbers_action", RemainingNumbersAction);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
