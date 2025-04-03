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
    public partial class SubNumberOrder : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The country_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; private set; }
#nullable restore
#else
        public string CountryCode { get; private set; }
#endif
        /// <summary>An ISO 8901 datetime string denoting when the number order was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>A customer reference string for customer look ups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerReference { get; set; }
#nullable restore
#else
        public string CustomerReference { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; private set; }
        /// <summary>True if the sub number order is a block sub number order</summary>
        public bool? IsBlockSubNumberOrder { get; private set; }
        /// <summary>The order_request_id property</summary>
        public Guid? OrderRequestId { get; private set; }
        /// <summary>The count of phone numbers in the number order.</summary>
        public int? PhoneNumbersCount { get; private set; }
        /// <summary>The phone_number_type property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder_phone_number_type? PhoneNumberType { get; set; }
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The regulatory_requirements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderRegulatoryRequirement>? RegulatoryRequirements { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderRegulatoryRequirement> RegulatoryRequirements { get; set; }
#endif
        /// <summary>True if all requirements are met for every phone number, false otherwise.</summary>
        public bool? RequirementsMet { get; private set; }
        /// <summary>The status of the order.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder_status? Status { get; private set; }
        /// <summary>An ISO 8901 datetime string for when the number order was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; private set; }
#nullable restore
#else
        public string UpdatedAt { get; private set; }
#endif
        /// <summary>The user_id property</summary>
        public Guid? UserId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder"/> and sets the default values.
        /// </summary>
        public SubNumberOrder()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "customer_reference", n => { CustomerReference = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "is_block_sub_number_order", n => { IsBlockSubNumberOrder = n.GetBoolValue(); } },
                { "order_request_id", n => { OrderRequestId = n.GetGuidValue(); } },
                { "phone_number_type", n => { PhoneNumberType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder_phone_number_type>(); } },
                { "phone_numbers_count", n => { PhoneNumbersCount = n.GetIntValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "regulatory_requirements", n => { RegulatoryRequirements = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderRegulatoryRequirement>(global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderRegulatoryRequirement.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requirements_met", n => { RequirementsMet = n.GetBoolValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder_status>(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
                { "user_id", n => { UserId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customer_reference", CustomerReference);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrder_phone_number_type>("phone_number_type", PhoneNumberType);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderRegulatoryRequirement>("regulatory_requirements", RegulatoryRequirements);
            writer.WriteGuidValue("user_id", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
