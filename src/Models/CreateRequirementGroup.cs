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
    public partial class CreateRequirementGroup : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_action? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO alpha 2 country code</summary>
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
        /// <summary>The phone_number_type property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_phone_number_type? PhoneNumberType { get; set; }
        /// <summary>The regulatory_requirements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_regulatory_requirements>? RegulatoryRequirements { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_regulatory_requirements> RegulatoryRequirements { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup"/> and sets the default values.
        /// </summary>
        public CreateRequirementGroup()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_action>(); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "customer_reference", n => { CustomerReference = n.GetStringValue(); } },
                { "phone_number_type", n => { PhoneNumberType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_phone_number_type>(); } },
                { "regulatory_requirements", n => { RegulatoryRequirements = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_regulatory_requirements>(global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_regulatory_requirements.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_action>("action", Action);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteStringValue("customer_reference", CustomerReference);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_phone_number_type>("phone_number_type", PhoneNumberType);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.CreateRequirementGroup_regulatory_requirements>("regulatory_requirements", RegulatoryRequirements);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
