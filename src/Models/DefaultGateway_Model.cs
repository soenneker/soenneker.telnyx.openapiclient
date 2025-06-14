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
    public partial class DefaultGateway_Model : global::Soenneker.Telnyx.OpenApiClient.Models.Record, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Network ID.</summary>
        public Guid? NetworkId { get; private set; }
        /// <summary>The current status of the interface deployment.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InterfaceStatus? Status { get; private set; }
        /// <summary>Wireguard peer ID.</summary>
        public Guid? WireguardPeerId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.DefaultGateway_Model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.OpenApiClient.Models.DefaultGateway_Model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.DefaultGateway_Model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "network_id", n => { NetworkId = n.GetGuidValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InterfaceStatus>(); } },
                { "wireguard_peer_id", n => { WireguardPeerId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteGuidValue("wireguard_peer_id", WireguardPeerId);
        }
    }
}
#pragma warning restore CS0618
