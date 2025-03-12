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
    public partial class GlobalIpAssignmentUsageMetric_global_ip_assignment : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Global IP assignment ID.</summary>
        public Guid? Id { get; set; }
        /// <summary>The wireguard_peer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment_wireguard_peer? WireguardPeer { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment_wireguard_peer WireguardPeer { get; set; }
#endif
        /// <summary>Wireguard peer ID.</summary>
        public Guid? WireguardPeerId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment"/> and sets the default values.
        /// </summary>
        public GlobalIpAssignmentUsageMetric_global_ip_assignment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "id", n => { Id = n.GetGuidValue(); } },
                { "wireguard_peer", n => { WireguardPeer = n.GetObjectValue<global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment_wireguard_peer>(global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment_wireguard_peer.CreateFromDiscriminatorValue); } },
                { "wireguard_peer_id", n => { WireguardPeerId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("id", Id);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.GlobalIpAssignmentUsageMetric_global_ip_assignment_wireguard_peer>("wireguard_peer", WireguardPeer);
            writer.WriteGuidValue("wireguard_peer_id", WireguardPeerId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
