// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>
    /// The set of features available for a specific messaging use case (SMS or MMS). Featurescan vary depending on the characteristics the phone number, as well as its currentproduct configuration.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MessagingFeatureSet : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Send messages to and receive messages from numbers in the same country.</summary>
        public bool? DomesticTwoWay { get; set; }
        /// <summary>Receive messages from numbers in other countries.</summary>
        public bool? InternationalInbound { get; set; }
        /// <summary>Send messages to numbers in other countries.</summary>
        public bool? InternationalOutbound { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.MessagingFeatureSet"/> and sets the default values.
        /// </summary>
        public MessagingFeatureSet()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.MessagingFeatureSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.MessagingFeatureSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.MessagingFeatureSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "domestic_two_way", n => { DomesticTwoWay = n.GetBoolValue(); } },
                { "international_inbound", n => { InternationalInbound = n.GetBoolValue(); } },
                { "international_outbound", n => { InternationalOutbound = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("domestic_two_way", DomesticTwoWay);
            writer.WriteBoolValue("international_inbound", InternationalInbound);
            writer.WriteBoolValue("international_outbound", InternationalOutbound);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
