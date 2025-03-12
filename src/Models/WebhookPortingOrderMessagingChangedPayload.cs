// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>
    /// The webhook payload for the porting_order.messaging_changed event
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WebhookPortingOrderMessagingChangedPayload : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifies the customer reference associated with the porting order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerReference { get; set; }
#nullable restore
#else
        public string CustomerReference { get; set; }
#endif
        /// <summary>Identifies the porting order that was moved.</summary>
        public Guid? Id { get; set; }
        /// <summary>The messaging portability status of the porting order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging? Messaging { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging Messaging { get; set; }
#endif
        /// <summary>Identifies the support key associated with the porting order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportKey { get; set; }
#nullable restore
#else
        public string SupportKey { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload"/> and sets the default values.
        /// </summary>
        public WebhookPortingOrderMessagingChangedPayload()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "customer_reference", n => { CustomerReference = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "messaging", n => { Messaging = n.GetObjectValue<global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging>(global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging.CreateFromDiscriminatorValue); } },
                { "support_key", n => { SupportKey = n.GetStringValue(); } },
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
            writer.WriteGuidValue("id", Id);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging>("messaging", Messaging);
            writer.WriteStringValue("support_key", SupportKey);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
