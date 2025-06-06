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
    public partial class VerifyDetailRecord : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>Telnyx account currency used to describe monetary values, including billing costs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>The delivery_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryStatus { get; set; }
#nullable restore
#else
        public string DeliveryStatus { get; set; }
#endif
        /// <summary>E.164 formatted phone number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationPhoneNumber { get; set; }
#nullable restore
#else
        public string DestinationPhoneNumber { get; set; }
#endif
        /// <summary>Unique ID of the verification</summary>
        public Guid? Id { get; set; }
        /// <summary>Currency amount per billing unit used to calculate the Telnyx billing costs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rate { get; set; }
#nullable restore
#else
        public string Rate { get; set; }
#endif
        /// <summary>Billing unit used to calculate the Telnyx billing costs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RateMeasuredIn { get; set; }
#nullable restore
#else
        public string RateMeasuredIn { get; set; }
#endif
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>The updated_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>The verification_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationStatus { get; set; }
#nullable restore
#else
        public string VerificationStatus { get; set; }
#endif
        /// <summary>The verify_channel_id property</summary>
        public Guid? VerifyChannelId { get; set; }
        /// <summary>Depending on the type of verification, the `verify_channel_id`points to one of the following channel ids;---verify_channel_type | verify_channel_id------------------- | -----------------sms, psd2           | messaging_idcall, flashcall     | call_control_id---</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.VerifyDetailRecord_verify_channel_type? VerifyChannelType { get; set; }
        /// <summary>The verify_profile_id property</summary>
        public Guid? VerifyProfileId { get; set; }
        /// <summary>Currency amount for Verify Usage Fee</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerifyUsageFee { get; set; }
#nullable restore
#else
        public string VerifyUsageFee { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.VerifyDetailRecord"/> and sets the default values.
        /// </summary>
        public VerifyDetailRecord()
        {
            AdditionalData = new Dictionary<string, object>();
            RecordType = "verification_detail_record";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.VerifyDetailRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.VerifyDetailRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.VerifyDetailRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "delivery_status", n => { DeliveryStatus = n.GetStringValue(); } },
                { "destination_phone_number", n => { DestinationPhoneNumber = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "rate", n => { Rate = n.GetStringValue(); } },
                { "rate_measured_in", n => { RateMeasuredIn = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
                { "verification_status", n => { VerificationStatus = n.GetStringValue(); } },
                { "verify_channel_id", n => { VerifyChannelId = n.GetGuidValue(); } },
                { "verify_channel_type", n => { VerifyChannelType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.VerifyDetailRecord_verify_channel_type>(); } },
                { "verify_profile_id", n => { VerifyProfileId = n.GetGuidValue(); } },
                { "verify_usage_fee", n => { VerifyUsageFee = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("currency", Currency);
            writer.WriteStringValue("delivery_status", DeliveryStatus);
            writer.WriteStringValue("destination_phone_number", DestinationPhoneNumber);
            writer.WriteGuidValue("id", Id);
            writer.WriteStringValue("rate", Rate);
            writer.WriteStringValue("rate_measured_in", RateMeasuredIn);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteStringValue("verification_status", VerificationStatus);
            writer.WriteGuidValue("verify_channel_id", VerifyChannelId);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.VerifyDetailRecord_verify_channel_type>("verify_channel_type", VerifyChannelType);
            writer.WriteGuidValue("verify_profile_id", VerifyProfileId);
            writer.WriteStringValue("verify_usage_fee", VerifyUsageFee);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
