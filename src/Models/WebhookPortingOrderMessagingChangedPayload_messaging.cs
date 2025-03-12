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
    /// The messaging portability status of the porting order.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WebhookPortingOrderMessagingChangedPayload_messaging : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether Telnyx will port messaging capabilities from the losing carrier. If false, any messaging capabilities will stay with their current provider.</summary>
        public bool? EnableMessaging { get; set; }
        /// <summary>Indicates whether the porting order is messaging capable.</summary>
        public bool? MessagingCapable { get; set; }
        /// <summary>Indicates whether the messaging port is completed.</summary>
        public bool? MessagingPortCompleted { get; set; }
        /// <summary>Indicates the messaging port status of the porting order.</summary>
        public global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging_messaging_port_status? MessagingPortStatus { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging"/> and sets the default values.
        /// </summary>
        public WebhookPortingOrderMessagingChangedPayload_messaging()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enable_messaging", n => { EnableMessaging = n.GetBoolValue(); } },
                { "messaging_capable", n => { MessagingCapable = n.GetBoolValue(); } },
                { "messaging_port_completed", n => { MessagingPortCompleted = n.GetBoolValue(); } },
                { "messaging_port_status", n => { MessagingPortStatus = n.GetEnumValue<global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging_messaging_port_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enable_messaging", EnableMessaging);
            writer.WriteBoolValue("messaging_capable", MessagingCapable);
            writer.WriteBoolValue("messaging_port_completed", MessagingPortCompleted);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.WebhookPortingOrderMessagingChangedPayload_messaging_messaging_port_status>("messaging_port_status", MessagingPortStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
