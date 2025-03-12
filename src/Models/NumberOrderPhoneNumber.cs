// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class NumberOrderPhoneNumber : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bundle_id property</summary>
        public Guid? BundleId { get; private set; }
        /// <summary>The country_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The deadline property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Deadline { get; set; }
#nullable restore
#else
        public string Deadline { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; private set; }
        /// <summary>The is_block_number property</summary>
        public bool? IsBlockNumber { get; set; }
        /// <summary>The locality property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locality { get; set; }
#nullable restore
#else
        public string Locality { get; set; }
#endif
        /// <summary>The order_request_id property</summary>
        public Guid? OrderRequestId { get; set; }
        /// <summary>The phone_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The phone_number_type property</summary>
        public global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber_phone_number_type? PhoneNumberType { get; set; }
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
        public List<global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue>? RegulatoryRequirements { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue> RegulatoryRequirements { get; set; }
#endif
        /// <summary>True if all requirements are met for a phone number, false otherwise.</summary>
        public bool? RequirementsMet { get; private set; }
        /// <summary>Status of requirements (if applicable)</summary>
        public global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber_requirements_status? RequirementsStatus { get; private set; }
        /// <summary>The status of the phone number in the order.</summary>
        public global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber_status? Status { get; private set; }
        /// <summary>The sub_number_order_id property</summary>
        public Guid? SubNumberOrderId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber"/> and sets the default values.
        /// </summary>
        public NumberOrderPhoneNumber()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bundle_id", n => { BundleId = n.GetGuidValue(); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "deadline", n => { Deadline = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "is_block_number", n => { IsBlockNumber = n.GetBoolValue(); } },
                { "locality", n => { Locality = n.GetStringValue(); } },
                { "order_request_id", n => { OrderRequestId = n.GetGuidValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "phone_number_type", n => { PhoneNumberType = n.GetEnumValue<global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber_phone_number_type>(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "regulatory_requirements", n => { RegulatoryRequirements = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue>(global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requirements_met", n => { RequirementsMet = n.GetBoolValue(); } },
                { "requirements_status", n => { RequirementsStatus = n.GetEnumValue<global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber_requirements_status>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber_status>(); } },
                { "sub_number_order_id", n => { SubNumberOrderId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteStringValue("deadline", Deadline);
            writer.WriteBoolValue("is_block_number", IsBlockNumber);
            writer.WriteStringValue("locality", Locality);
            writer.WriteGuidValue("order_request_id", OrderRequestId);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.NumberOrderPhoneNumber_phone_number_type>("phone_number_type", PhoneNumberType);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue>("regulatory_requirements", RegulatoryRequirements);
            writer.WriteGuidValue("sub_number_order_id", SubNumberOrderId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
