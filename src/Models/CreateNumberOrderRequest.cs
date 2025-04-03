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
    public partial class CreateNumberOrderRequest : IAdditionalDataHolder, IParsable
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
        /// <summary>Identifies the connection associated with this phone number.</summary>
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
        /// <summary>Identifies the messaging profile associated with the phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessagingProfileId { get; set; }
#nullable restore
#else
        public string MessagingProfileId { get; set; }
#endif
        /// <summary>The phone_numbers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest_phone_numbers>? PhoneNumbers { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest_phone_numbers> PhoneNumbers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest"/> and sets the default values.
        /// </summary>
        public CreateNumberOrderRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest();
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
                { "messaging_profile_id", n => { MessagingProfileId = n.GetStringValue(); } },
                { "phone_numbers", n => { PhoneNumbers = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest_phone_numbers>(global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest_phone_numbers.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("messaging_profile_id", MessagingProfileId);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.CreateNumberOrderRequest_phone_numbers>("phone_numbers", PhoneNumbers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
