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
    public partial class OutboundVoiceProfile : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the billing group associated with the outbound proflile. Defaults to null (for no group assigned).</summary>
        public Guid? BillingGroupId { get; set; }
        /// <summary>The call_recording property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.OutboundCallRecording? CallRecording { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.OutboundCallRecording CallRecording { get; set; }
#endif
        /// <summary>Must be no more than your global concurrent call limit. Null means no limit.</summary>
        public int? ConcurrentCallLimit { get; set; }
        /// <summary>Amount of connections associated with this outbound voice profile.</summary>
        public int? ConnectionsCount { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The maximum amount of usage charges, in USD, you want Telnyx to allow on this outbound voice profile in a day before disallowing new calls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DailySpendLimit { get; set; }
#nullable restore
#else
        public string DailySpendLimit { get; set; }
#endif
        /// <summary>Specifies whether to enforce the daily_spend_limit on this outbound voice profile.</summary>
        public bool? DailySpendLimitEnabled { get; set; }
        /// <summary>Specifies whether the outbound voice profile can be used. Disabled profiles will result in outbound calls being blocked for the associated Connections.</summary>
        public bool? Enabled { get; set; }
        /// <summary>Identifies the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Maximum rate (price per minute) for a Destination to be allowed when making outbound calls.</summary>
        public double? MaxDestinationRate { get; set; }
        /// <summary>A user-supplied name to help with organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>Indicates the coverage of the termination regions.</summary>
        public global::Soenneker.Telnyx.Models.ServicePlan? ServicePlan { get; set; }
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>Specifies the type of traffic allowed in this profile.</summary>
        public global::Soenneker.Telnyx.Models.TrafficType? TrafficType { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>Setting for how costs for outbound profile are calculated.</summary>
        public global::Soenneker.Telnyx.Models.UsagePaymentMethod? UsagePaymentMethod { get; set; }
        /// <summary>The list of destinations you want to be able to call using this outbound voice profile formatted in alpha2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WhitelistedDestinations { get; set; }
#nullable restore
#else
        public List<string> WhitelistedDestinations { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.OutboundVoiceProfile"/> and sets the default values.
        /// </summary>
        public OutboundVoiceProfile()
        {
            AdditionalData = new Dictionary<string, object>();
            ServicePlan = global::Soenneker.Telnyx.Models.ServicePlan.Global;
            TrafficType = global::Soenneker.Telnyx.Models.TrafficType.Conversational;
            UsagePaymentMethod = global::Soenneker.Telnyx.Models.UsagePaymentMethod.RateDeck;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.OutboundVoiceProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.OutboundVoiceProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.OutboundVoiceProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "billing_group_id", n => { BillingGroupId = n.GetGuidValue(); } },
                { "call_recording", n => { CallRecording = n.GetObjectValue<global::Soenneker.Telnyx.Models.OutboundCallRecording>(global::Soenneker.Telnyx.Models.OutboundCallRecording.CreateFromDiscriminatorValue); } },
                { "concurrent_call_limit", n => { ConcurrentCallLimit = n.GetIntValue(); } },
                { "connections_count", n => { ConnectionsCount = n.GetIntValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "daily_spend_limit", n => { DailySpendLimit = n.GetStringValue(); } },
                { "daily_spend_limit_enabled", n => { DailySpendLimitEnabled = n.GetBoolValue(); } },
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "max_destination_rate", n => { MaxDestinationRate = n.GetDoubleValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "service_plan", n => { ServicePlan = n.GetEnumValue<global::Soenneker.Telnyx.Models.ServicePlan>(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "traffic_type", n => { TrafficType = n.GetEnumValue<global::Soenneker.Telnyx.Models.TrafficType>(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
                { "usage_payment_method", n => { UsagePaymentMethod = n.GetEnumValue<global::Soenneker.Telnyx.Models.UsagePaymentMethod>(); } },
                { "whitelisted_destinations", n => { WhitelistedDestinations = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("billing_group_id", BillingGroupId);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.OutboundCallRecording>("call_recording", CallRecording);
            writer.WriteIntValue("concurrent_call_limit", ConcurrentCallLimit);
            writer.WriteIntValue("connections_count", ConnectionsCount);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("daily_spend_limit", DailySpendLimit);
            writer.WriteBoolValue("daily_spend_limit_enabled", DailySpendLimitEnabled);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("id", Id);
            writer.WriteDoubleValue("max_destination_rate", MaxDestinationRate);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.ServicePlan>("service_plan", ServicePlan);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.TrafficType>("traffic_type", TrafficType);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.UsagePaymentMethod>("usage_payment_method", UsagePaymentMethod);
            writer.WriteCollectionOfPrimitiveValues<string>("whitelisted_destinations", WhitelistedDestinations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
