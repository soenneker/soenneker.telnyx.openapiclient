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
    public partial class VirtualCrossConnectCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The desired throughput in Megabits per Second (Mbps) for your Virtual Cross Connect.&lt;br /&gt;&lt;br /&gt;The available bandwidths can be found using the /virtual_cross_connect_regions endpoint.</summary>
        public double? BandwidthMbps { get; set; }
        /// <summary>The Border Gateway Protocol (BGP) Autonomous System Number (ASN). If null, value will be assigned by Telnyx.</summary>
        public double? BgpAsn { get; set; }
        /// <summary>The Virtual Private Cloud with which you would like to establish a cross connect.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.VirtualCrossConnectCreate_cloud_provider? CloudProvider { get; set; }
        /// <summary>The region where your Virtual Private Cloud hosts are located.&lt;br /&gt;&lt;br /&gt;The available regions can be found using the /virtual_cross_connect_regions endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudProviderRegion { get; set; }
#nullable restore
#else
        public string CloudProviderRegion { get; set; }
#endif
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
        /// <summary>The authentication key for BGP peer configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryBgpKey { get; set; }
#nullable restore
#else
        public string PrimaryBgpKey { get; set; }
#endif
        /// <summary>The identifier for your Virtual Private Cloud. The number will be different based upon your Cloud provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryCloudAccountId { get; set; }
#nullable restore
#else
        public string PrimaryCloudAccountId { get; set; }
#endif
        /// <summary>The IP address assigned for your side of the Virtual Cross Connect.&lt;br /&gt;&lt;br /&gt;If none is provided, one will be generated for you.&lt;br /&gt;&lt;br /&gt;This value should be null for GCE as Google will only inform you of your assigned IP once the connection has been accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryCloudIp { get; set; }
#nullable restore
#else
        public string PrimaryCloudIp { get; set; }
#endif
        /// <summary>Indicates whether the primary circuit is enabled. Setting this to `false` will disable the circuit.</summary>
        public bool? PrimaryEnabled { get; private set; }
        /// <summary>The IP address assigned to the Telnyx side of the Virtual Cross Connect.&lt;br /&gt;&lt;br /&gt;If none is provided, one will be generated for you.&lt;br /&gt;&lt;br /&gt;This value should be null for GCE as Google will only inform you of your assigned IP once the connection has been accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryTelnyxIp { get; set; }
#nullable restore
#else
        public string PrimaryTelnyxIp { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The region the interface should be deployed to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegionCode { get; set; }
#nullable restore
#else
        public string RegionCode { get; set; }
#endif
        /// <summary>The authentication key for BGP peer configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryBgpKey { get; set; }
#nullable restore
#else
        public string SecondaryBgpKey { get; set; }
#endif
        /// <summary>The identifier for your Virtual Private Cloud. The number will be different based upon your Cloud provider.&lt;br /&gt;&lt;br /&gt;This attribute is only necessary for GCE.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryCloudAccountId { get; set; }
#nullable restore
#else
        public string SecondaryCloudAccountId { get; set; }
#endif
        /// <summary>The IP address assigned for your side of the Virtual Cross Connect.&lt;br /&gt;&lt;br /&gt;If none is provided, one will be generated for you.&lt;br /&gt;&lt;br /&gt;This value should be null for GCE as Google will only inform you of your assigned IP once the connection has been accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryCloudIp { get; set; }
#nullable restore
#else
        public string SecondaryCloudIp { get; set; }
#endif
        /// <summary>Indicates whether the secondary circuit is enabled. Setting this to `false` will disable the circuit.</summary>
        public bool? SecondaryEnabled { get; private set; }
        /// <summary>The IP address assigned to the Telnyx side of the Virtual Cross Connect.&lt;br /&gt;&lt;br /&gt;If none is provided, one will be generated for you.&lt;br /&gt;&lt;br /&gt;This value should be null for GCE as Google will only inform you of your assigned IP once the connection has been accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryTelnyxIp { get; set; }
#nullable restore
#else
        public string SecondaryTelnyxIp { get; set; }
#endif
        /// <summary>The current status of the interface deployment.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InterfaceStatus? Status { get; private set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; private set; }
#nullable restore
#else
        public string UpdatedAt { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.VirtualCrossConnectCreate"/> and sets the default values.
        /// </summary>
        public VirtualCrossConnectCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.VirtualCrossConnectCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.VirtualCrossConnectCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.VirtualCrossConnectCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bandwidth_mbps", n => { BandwidthMbps = n.GetDoubleValue(); } },
                { "bgp_asn", n => { BgpAsn = n.GetDoubleValue(); } },
                { "cloud_provider", n => { CloudProvider = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.VirtualCrossConnectCreate_cloud_provider>(); } },
                { "cloud_provider_region", n => { CloudProviderRegion = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "network_id", n => { NetworkId = n.GetGuidValue(); } },
                { "primary_bgp_key", n => { PrimaryBgpKey = n.GetStringValue(); } },
                { "primary_cloud_account_id", n => { PrimaryCloudAccountId = n.GetStringValue(); } },
                { "primary_cloud_ip", n => { PrimaryCloudIp = n.GetStringValue(); } },
                { "primary_enabled", n => { PrimaryEnabled = n.GetBoolValue(); } },
                { "primary_telnyx_ip", n => { PrimaryTelnyxIp = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "region_code", n => { RegionCode = n.GetStringValue(); } },
                { "secondary_bgp_key", n => { SecondaryBgpKey = n.GetStringValue(); } },
                { "secondary_cloud_account_id", n => { SecondaryCloudAccountId = n.GetStringValue(); } },
                { "secondary_cloud_ip", n => { SecondaryCloudIp = n.GetStringValue(); } },
                { "secondary_enabled", n => { SecondaryEnabled = n.GetBoolValue(); } },
                { "secondary_telnyx_ip", n => { SecondaryTelnyxIp = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InterfaceStatus>(); } },
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
            writer.WriteDoubleValue("bandwidth_mbps", BandwidthMbps);
            writer.WriteDoubleValue("bgp_asn", BgpAsn);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.VirtualCrossConnectCreate_cloud_provider>("cloud_provider", CloudProvider);
            writer.WriteStringValue("cloud_provider_region", CloudProviderRegion);
            writer.WriteStringValue("name", Name);
            writer.WriteGuidValue("network_id", NetworkId);
            writer.WriteStringValue("primary_bgp_key", PrimaryBgpKey);
            writer.WriteStringValue("primary_cloud_account_id", PrimaryCloudAccountId);
            writer.WriteStringValue("primary_cloud_ip", PrimaryCloudIp);
            writer.WriteStringValue("primary_telnyx_ip", PrimaryTelnyxIp);
            writer.WriteStringValue("region_code", RegionCode);
            writer.WriteStringValue("secondary_bgp_key", SecondaryBgpKey);
            writer.WriteStringValue("secondary_cloud_account_id", SecondaryCloudAccountId);
            writer.WriteStringValue("secondary_cloud_ip", SecondaryCloudIp);
            writer.WriteStringValue("secondary_telnyx_ip", SecondaryTelnyxIp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
