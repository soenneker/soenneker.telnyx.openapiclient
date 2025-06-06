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
    public partial class PhoneNumbersJobUpdatePhoneNumbersRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifies the billing group associated with the phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillingGroupId { get; set; }
#nullable restore
#else
        public string BillingGroupId { get; set; }
#endif
        /// <summary>Identifies the connection associated with the phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionId { get; set; }
#nullable restore
#else
        public string ConnectionId { get; set; }
#endif
        /// <summary>A customer reference string for customer look ups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerReference { get; set; }
#nullable restore
#else
        public string CustomerReference { get; set; }
#endif
        /// <summary>If someone attempts to port your phone number away from Telnyx and your phone number has an external PIN set, we will attempt to verify that you provided the correct external PIN to the winning carrier. Note that not all carriers cooperate with this security mechanism.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalPin { get; set; }
#nullable restore
#else
        public string ExternalPin { get; set; }
#endif
        /// <summary>Indicates whether to enable or disable HD Voice on each phone number. HD Voice is a paid feature and may not be available for all phone numbers, more details about it can be found in the Telnyx support documentation.</summary>
        public bool? HdVoiceEnabled { get; set; }
        /// <summary>Array of phone number ids and/or phone numbers in E164 format to update. This parameter is required if no filter parameters are provided. If you want to update specific numbers rather than all numbers matching a filter, you must use this parameter. Each item must be either a valid phone number ID or a phone number in E164 format (e.g., &apos;+13127367254&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PhoneNumbers { get; set; }
#nullable restore
#else
        public List<string> PhoneNumbers { get; set; }
#endif
        /// <summary>A list of user-assigned tags to help organize phone numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>The voice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePhoneNumberVoiceSettingsRequest? Voice { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePhoneNumberVoiceSettingsRequest Voice { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumbersJobUpdatePhoneNumbersRequest"/> and sets the default values.
        /// </summary>
        public PhoneNumbersJobUpdatePhoneNumbersRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumbersJobUpdatePhoneNumbersRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumbersJobUpdatePhoneNumbersRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumbersJobUpdatePhoneNumbersRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "billing_group_id", n => { BillingGroupId = n.GetStringValue(); } },
                { "connection_id", n => { ConnectionId = n.GetStringValue(); } },
                { "customer_reference", n => { CustomerReference = n.GetStringValue(); } },
                { "external_pin", n => { ExternalPin = n.GetStringValue(); } },
                { "hd_voice_enabled", n => { HdVoiceEnabled = n.GetBoolValue(); } },
                { "phone_numbers", n => { PhoneNumbers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "voice", n => { Voice = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePhoneNumberVoiceSettingsRequest>(global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePhoneNumberVoiceSettingsRequest.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("billing_group_id", BillingGroupId);
            writer.WriteStringValue("connection_id", ConnectionId);
            writer.WriteStringValue("customer_reference", CustomerReference);
            writer.WriteStringValue("external_pin", ExternalPin);
            writer.WriteBoolValue("hd_voice_enabled", HdVoiceEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("phone_numbers", PhoneNumbers);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePhoneNumberVoiceSettingsRequest>("voice", Voice);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
