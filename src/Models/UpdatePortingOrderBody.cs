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
    public partial class UpdatePortingOrderBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activation_settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_activation_settings? ActivationSettings { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_activation_settings ActivationSettings { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The customer_reference property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerReference { get; set; }
#nullable restore
#else
        public string CustomerReference { get; set; }
#endif
        /// <summary>Can be specified directly or via the `requirement_group_id` parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderDocuments? Documents { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderDocuments Documents { get; set; }
#endif
        /// <summary>The end_user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderEndUser? EndUser { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderEndUser EndUser { get; set; }
#endif
        /// <summary>The messaging property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_messaging? Messaging { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_messaging Messaging { get; set; }
#endif
        /// <summary>The misc property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc? Misc { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc Misc { get; set; }
#endif
        /// <summary>The phone_number_configuration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderPhoneNumberConfiguration? PhoneNumberConfiguration { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderPhoneNumberConfiguration PhoneNumberConfiguration { get; set; }
#endif
        /// <summary>If present, we will read the current values from the specified Requirement Group into the Documents and Requirements for this Porting Order. Note that any future changes in the Requirement Group would have no impact on this Porting Order. We will return an error if a specified Requirement Group conflicts with documents or requirements in the same request.</summary>
        public Guid? RequirementGroupId { get; set; }
        /// <summary>List of requirements for porting numbers. </summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderRequirement>? Requirements { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderRequirement> Requirements { get; set; }
#endif
        /// <summary>The user_feedback property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderUserFeedback? UserFeedback { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderUserFeedback UserFeedback { get; set; }
#endif
        /// <summary>The webhook_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookUrl { get; set; }
#nullable restore
#else
        public string WebhookUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody"/> and sets the default values.
        /// </summary>
        public UpdatePortingOrderBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activation_settings", n => { ActivationSettings = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_activation_settings>(global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_activation_settings.CreateFromDiscriminatorValue); } },
                { "customer_reference", n => { CustomerReference = n.GetStringValue(); } },
                { "documents", n => { Documents = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderDocuments>(global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderDocuments.CreateFromDiscriminatorValue); } },
                { "end_user", n => { EndUser = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderEndUser>(global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderEndUser.CreateFromDiscriminatorValue); } },
                { "messaging", n => { Messaging = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_messaging>(global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_messaging.CreateFromDiscriminatorValue); } },
                { "misc", n => { Misc = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc>(global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc.CreateFromDiscriminatorValue); } },
                { "phone_number_configuration", n => { PhoneNumberConfiguration = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderPhoneNumberConfiguration>(global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderPhoneNumberConfiguration.CreateFromDiscriminatorValue); } },
                { "requirement_group_id", n => { RequirementGroupId = n.GetGuidValue(); } },
                { "requirements", n => { Requirements = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderRequirement>(global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderRequirement.CreateFromDiscriminatorValue)?.AsList(); } },
                { "user_feedback", n => { UserFeedback = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderUserFeedback>(global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderUserFeedback.CreateFromDiscriminatorValue); } },
                { "webhook_url", n => { WebhookUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_activation_settings>("activation_settings", ActivationSettings);
            writer.WriteStringValue("customer_reference", CustomerReference);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderDocuments>("documents", Documents);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderEndUser>("end_user", EndUser);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderBody_messaging>("messaging", Messaging);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderMisc>("misc", Misc);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderPhoneNumberConfiguration>("phone_number_configuration", PhoneNumberConfiguration);
            writer.WriteGuidValue("requirement_group_id", RequirementGroupId);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.UpdatePortingOrderRequirement>("requirements", Requirements);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortingOrderUserFeedback>("user_feedback", UserFeedback);
            writer.WriteStringValue("webhook_url", WebhookUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
