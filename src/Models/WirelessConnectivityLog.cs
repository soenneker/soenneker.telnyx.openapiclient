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
    /// This object represents a wireless connectivity session log that happened through a SIM card. It aids in finding out potential problems when the SIM is not able to attach properly.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WirelessConnectivityLog : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Access Point Name (APN) identifies the packet data network that a mobile data user wants to communicate with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Apn { get; private set; }
#nullable restore
#else
        public string Apn { get; private set; }
#endif
        /// <summary>The cell ID to which the SIM connected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CellId { get; private set; }
#nullable restore
#else
        public string CellId { get; private set; }
#endif
        /// <summary>ISO 8601 formatted date-time indicating when the record was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>Uniquely identifies the session.</summary>
        public int? Id { get; private set; }
        /// <summary>The International Mobile Equipment Identity (or IMEI) is a number, usually unique, that identifies the device currently being used connect to the network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Imei { get; private set; }
#nullable restore
#else
        public string Imei { get; private set; }
#endif
        /// <summary>SIM cards are identified on their individual network operators by a unique International Mobile Subscriber Identity (IMSI). &lt;br/&gt;Mobile network operators connect mobile phone calls and communicate with their market SIM cards using their IMSIs. The IMSI is stored in the Subscriber  Identity Module (SIM) inside the device and is sent by the device to the appropriate network. It is used to acquire the details of the device in the Home  Location Register (HLR) or the Visitor Location Register (VLR).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Imsi { get; private set; }
#nullable restore
#else
        public string Imsi { get; private set; }
#endif
        /// <summary>The SIM&apos;s address in the currently connected network. This IPv4 address is usually obtained dynamically, so it may vary according to the location or new connections.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ipv4 { get; private set; }
#nullable restore
#else
        public string Ipv4 { get; private set; }
#endif
        /// <summary>The SIM&apos;s address in the currently connected network. This IPv6 address is usually obtained dynamically, so it may vary according to the location or new connections.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ipv6 { get; private set; }
#nullable restore
#else
        public string Ipv6 { get; private set; }
#endif
        /// <summary>ISO 8601 formatted date-time indicating when the last heartbeat to the device was successfully recorded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastSeen { get; private set; }
#nullable restore
#else
        public string LastSeen { get; private set; }
#endif
        /// <summary>The type of the session, &apos;registration&apos; being the initial authentication session and &apos;data&apos; the actual data transfer sessions.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.WirelessConnectivityLog_log_type? LogType { get; private set; }
        /// <summary>It&apos;s a three decimal digit that identifies a country.&lt;br/&gt;&lt;br/&gt;This code is commonly seen joined with a Mobile Network Code (MNC) in a tuple that allows identifying a carrier known as PLMN (Public Land Mobile Network) code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobileCountryCode { get; private set; }
#nullable restore
#else
        public string MobileCountryCode { get; private set; }
#endif
        /// <summary>It&apos;s a two to three decimal digits that identify a network.&lt;br/&gt;&lt;br/&gt; This code is commonly seen joined with a Mobile Country Code (MCC) in a tuple that allows identifying a carrier known as PLMN (Public Land Mobile Network) code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MobileNetworkCode { get; private set; }
#nullable restore
#else
        public string MobileNetworkCode { get; private set; }
#endif
        /// <summary>The radio technology the SIM card used during the session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RadioAccessTechnology { get; private set; }
#nullable restore
#else
        public string RadioAccessTechnology { get; private set; }
#endif
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The identification UUID of the related SIM card resource.</summary>
        public Guid? SimCardId { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the session started.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; private set; }
#nullable restore
#else
        public string StartTime { get; private set; }
#endif
        /// <summary>The state of the SIM card after when the session happened.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; private set; }
#nullable restore
#else
        public string State { get; private set; }
#endif
        /// <summary>ISO 8601 formatted date-time indicating when the session ended.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StopTime { get; private set; }
#nullable restore
#else
        public string StopTime { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.WirelessConnectivityLog"/> and sets the default values.
        /// </summary>
        public WirelessConnectivityLog()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.WirelessConnectivityLog"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.WirelessConnectivityLog CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.WirelessConnectivityLog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "apn", n => { Apn = n.GetStringValue(); } },
                { "cell_id", n => { CellId = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "imei", n => { Imei = n.GetStringValue(); } },
                { "imsi", n => { Imsi = n.GetStringValue(); } },
                { "ipv4", n => { Ipv4 = n.GetStringValue(); } },
                { "ipv6", n => { Ipv6 = n.GetStringValue(); } },
                { "last_seen", n => { LastSeen = n.GetStringValue(); } },
                { "log_type", n => { LogType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.WirelessConnectivityLog_log_type>(); } },
                { "mobile_country_code", n => { MobileCountryCode = n.GetStringValue(); } },
                { "mobile_network_code", n => { MobileNetworkCode = n.GetStringValue(); } },
                { "radio_access_technology", n => { RadioAccessTechnology = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "sim_card_id", n => { SimCardId = n.GetGuidValue(); } },
                { "start_time", n => { StartTime = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "stop_time", n => { StopTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("sim_card_id", SimCardId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
