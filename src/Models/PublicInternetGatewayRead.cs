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
    public partial class PublicInternetGatewayRead : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>Identifies the resource.</summary>
        public Guid? Id { get; private set; }
        /// <summary>A user specified name for the interface.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The id of the network associated with the interface.</summary>
        public Guid? NetworkId { get; set; }
        /// <summary>The publically accessible ip for this interface.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicIp { get; private set; }
#nullable restore
#else
        public string PublicIp { get; private set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The region property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.PublicInternetGatewayRead_region? Region { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.PublicInternetGatewayRead_region Region { get; set; }
#endif
        /// <summary>The region interface is deployed to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegionCode { get; set; }
#nullable restore
#else
        public string RegionCode { get; set; }
#endif
        /// <summary>The current status of the interface deployment.</summary>
        public global::Soenneker.Telnyx.Models.InterfaceStatus? Status { get; private set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; private set; }
#nullable restore
#else
        public string UpdatedAt { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.PublicInternetGatewayRead"/> and sets the default values.
        /// </summary>
        public PublicInternetGatewayRead()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.PublicInternetGatewayRead"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.PublicInternetGatewayRead CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.PublicInternetGatewayRead();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "network_id", n => { NetworkId = n.GetGuidValue(); } },
                { "public_ip", n => { PublicIp = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "region", n => { Region = n.GetObjectValue<global::Soenneker.Telnyx.Models.PublicInternetGatewayRead_region>(global::Soenneker.Telnyx.Models.PublicInternetGatewayRead_region.CreateFromDiscriminatorValue); } },
                { "region_code", n => { RegionCode = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.InterfaceStatus>(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteGuidValue("network_id", NetworkId);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.PublicInternetGatewayRead_region>("region", Region);
            writer.WriteStringValue("region_code", RegionCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
