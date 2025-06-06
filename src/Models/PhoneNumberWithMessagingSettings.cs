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
    public partial class PhoneNumberWithMessagingSettings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 3166-1 alpha-2 country code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; private set; }
#nullable restore
#else
        public string CountryCode { get; private set; }
#endif
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The messaging products that this number can be registered to use</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EligibleMessagingProducts { get; private set; }
#nullable restore
#else
        public List<string> EligibleMessagingProducts { get; private set; }
#endif
        /// <summary>The features property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_features? Features { get; private set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_features Features { get; private set; }
#endif
        /// <summary>High level health metrics about the number and it&apos;s messaging sending patterns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.NumberHealthMetrics? Health { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.NumberHealthMetrics Health { get; set; }
#endif
        /// <summary>Identifies the type of resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The messaging product that the number is registered to use</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessagingProduct { get; set; }
#nullable restore
#else
        public string MessagingProduct { get; set; }
#endif
        /// <summary>Unique identifier for a messaging profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessagingProfileId { get; set; }
#nullable restore
#else
        public string MessagingProfileId { get; set; }
#endif
        /// <summary>+E.164 formatted phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; private set; }
#nullable restore
#else
        public string PhoneNumber { get; private set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_record_type? RecordType { get; private set; }
        /// <summary>The messaging traffic or use case for which the number is currently configured.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrafficType { get; private set; }
#nullable restore
#else
        public string TrafficType { get; private set; }
#endif
        /// <summary>The type of the phone number</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_type? Type { get; private set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was updated.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings"/> and sets the default values.
        /// </summary>
        public PhoneNumberWithMessagingSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings();
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
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "eligible_messaging_products", n => { EligibleMessagingProducts = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "features", n => { Features = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_features>(global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_features.CreateFromDiscriminatorValue); } },
                { "health", n => { Health = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.NumberHealthMetrics>(global::Soenneker.Telnyx.OpenApiClient.Models.NumberHealthMetrics.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "messaging_product", n => { MessagingProduct = n.GetStringValue(); } },
                { "messaging_profile_id", n => { MessagingProfileId = n.GetStringValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_record_type>(); } },
                { "traffic_type", n => { TrafficType = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PhoneNumberWithMessagingSettings_type>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.NumberHealthMetrics>("health", Health);
            writer.WriteStringValue("messaging_product", MessagingProduct);
            writer.WriteStringValue("messaging_profile_id", MessagingProfileId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
