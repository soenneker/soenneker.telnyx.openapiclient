// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GlobalIpUsageMetric : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The global_ip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_global_ip? GlobalIp { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_global_ip GlobalIp { get; set; }
#endif
        /// <summary>The received property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_received? Received { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_received Received { get; set; }
#endif
        /// <summary>The timestamp of the metric.</summary>
        public DateTimeOffset? Timestamp { get; set; }
        /// <summary>The transmitted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_transmitted? Transmitted { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_transmitted Transmitted { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.GlobalIpUsageMetric"/> and sets the default values.
        /// </summary>
        public GlobalIpUsageMetric()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.GlobalIpUsageMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.GlobalIpUsageMetric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.GlobalIpUsageMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "global_ip", n => { GlobalIp = n.GetObjectValue<global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_global_ip>(global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_global_ip.CreateFromDiscriminatorValue); } },
                { "received", n => { Received = n.GetObjectValue<global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_received>(global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_received.CreateFromDiscriminatorValue); } },
                { "timestamp", n => { Timestamp = n.GetDateTimeOffsetValue(); } },
                { "transmitted", n => { Transmitted = n.GetObjectValue<global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_transmitted>(global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_transmitted.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_global_ip>("global_ip", GlobalIp);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_received>("received", Received);
            writer.WriteDateTimeOffsetValue("timestamp", Timestamp);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.GlobalIpUsageMetric_transmitted>("transmitted", Transmitted);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
