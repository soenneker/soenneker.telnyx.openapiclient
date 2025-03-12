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
    /// High level health metrics about the number and it&apos;s messaging sending patterns.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class NumberHealthMetrics : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ratio of messages received to the number of messages sent.</summary>
        public float? InboundOutboundRatio { get; set; }
        /// <summary>The number of messages analyzed for the health metrics.</summary>
        public int? MessageCount { get; set; }
        /// <summary>The ratio of messages blocked for spam to the number of messages attempted.</summary>
        public float? SpamRatio { get; set; }
        /// <summary>The ratio of messages sucessfully delivered to the number of messages attempted.</summary>
        public float? SuccessRatio { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.NumberHealthMetrics"/> and sets the default values.
        /// </summary>
        public NumberHealthMetrics()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.NumberHealthMetrics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.NumberHealthMetrics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.NumberHealthMetrics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "inbound_outbound_ratio", n => { InboundOutboundRatio = n.GetFloatValue(); } },
                { "message_count", n => { MessageCount = n.GetIntValue(); } },
                { "spam_ratio", n => { SpamRatio = n.GetFloatValue(); } },
                { "success_ratio", n => { SuccessRatio = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("inbound_outbound_ratio", InboundOutboundRatio);
            writer.WriteIntValue("message_count", MessageCount);
            writer.WriteFloatValue("spam_ratio", SpamRatio);
            writer.WriteFloatValue("success_ratio", SuccessRatio);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
