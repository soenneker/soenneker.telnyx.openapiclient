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
    public partial class SubNumberOrderPhoneNumber : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bundle_id property</summary>
        public Guid? BundleId { get; set; }
        /// <summary>The country_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The phone_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The phone_number_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumberType { get; set; }
#nullable restore
#else
        public string PhoneNumberType { get; set; }
#endif
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>The regulatory_requirements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber_regulatory_requirements>? RegulatoryRequirements { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber_regulatory_requirements> RegulatoryRequirements { get; set; }
#endif
        /// <summary>The requirements_met property</summary>
        public bool? RequirementsMet { get; set; }
        /// <summary>The requirements_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequirementsStatus { get; set; }
#nullable restore
#else
        public string RequirementsStatus { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber"/> and sets the default values.
        /// </summary>
        public SubNumberOrderPhoneNumber()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber();
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
                { "id", n => { Id = n.GetGuidValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "phone_number_type", n => { PhoneNumberType = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "regulatory_requirements", n => { RegulatoryRequirements = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber_regulatory_requirements>(global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber_regulatory_requirements.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requirements_met", n => { RequirementsMet = n.GetBoolValue(); } },
                { "requirements_status", n => { RequirementsStatus = n.GetStringValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("bundle_id", BundleId);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteStringValue("phone_number_type", PhoneNumberType);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.SubNumberOrderPhoneNumber_regulatory_requirements>("regulatory_requirements", RegulatoryRequirements);
            writer.WriteBoolValue("requirements_met", RequirementsMet);
            writer.WriteStringValue("requirements_status", RequirementsStatus);
            writer.WriteStringValue("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
