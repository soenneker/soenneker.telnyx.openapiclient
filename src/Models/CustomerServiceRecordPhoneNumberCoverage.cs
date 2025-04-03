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
    public partial class CustomerServiceRecordPhoneNumberCoverage : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional data required to perform CSR for the phone number. Only returned if `has_csr_coverage` is true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage_additional_data_required?>? AdditionalDataRequired { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage_additional_data_required?> AdditionalDataRequired { get; set; }
#endif
        /// <summary>Indicates whether the phone number is covered or not.</summary>
        public bool? HasCsrCoverage { get; set; }
        /// <summary>The phone number that is being verified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The reason why the phone number is not covered. Only returned if `has_csr_coverage` is false.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage"/> and sets the default values.
        /// </summary>
        public CustomerServiceRecordPhoneNumberCoverage()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additional_data_required", n => { AdditionalDataRequired = n.GetCollectionOfEnumValues<global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage_additional_data_required>()?.AsList(); } },
                { "has_csr_coverage", n => { HasCsrCoverage = n.GetBoolValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::Soenneker.Telnyx.OpenApiClient.Models.CustomerServiceRecordPhoneNumberCoverage_additional_data_required>("additional_data_required", AdditionalDataRequired);
            writer.WriteBoolValue("has_csr_coverage", HasCsrCoverage);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
