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
    public partial class PortoutDetails : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Is true when the number is already ported</summary>
        public bool? AlreadyPorted { get; set; }
        /// <summary>Name of person authorizing the porting order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthorizedName { get; set; }
#nullable restore
#else
        public string AuthorizedName { get; set; }
#endif
        /// <summary>Carrier the number will be ported out to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CarrierName { get; set; }
#nullable restore
#else
        public string CarrierName { get; set; }
#endif
        /// <summary>City or municipality of billing address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>ISO 8601 formatted date of when the portout was created</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The current carrier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrentCarrier { get; set; }
#nullable restore
#else
        public string CurrentCarrier { get; set; }
#endif
        /// <summary>Person name or company name requesting the port</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndUserName { get; set; }
#nullable restore
#else
        public string EndUserName { get; set; }
#endif
        /// <summary>ISO 8601 formatted Date/Time of the FOC date</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FocDate { get; set; }
#nullable restore
#else
        public string FocDate { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>ISO 8601 formatted date of when the portout was created</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InsertedAt { get; set; }
#nullable restore
#else
        public string InsertedAt { get; set; }
#endif
        /// <summary>The Local Service Request</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Lsr { get; set; }
#nullable restore
#else
        public List<string> Lsr { get; set; }
#endif
        /// <summary>Phone numbers associated with this portout</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PhoneNumbers { get; set; }
#nullable restore
#else
        public List<string> PhoneNumbers { get; set; }
#endif
        /// <summary>Port order number assigned by the carrier the number will be ported out to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pon { get; set; }
#nullable restore
#else
        public string Pon { get; set; }
#endif
        /// <summary>The reason why the order is being rejected by the user. If the order is authorized, this field can be left null</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The rejection code for one of the valid rejections to reject a port out order</summary>
        public int? RejectionCode { get; set; }
        /// <summary>ISO 8601 formatted Date/Time of the user requested FOC date</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestedFocDate { get; set; }
#nullable restore
#else
        public string RequestedFocDate { get; set; }
#endif
        /// <summary>First line of billing address (street address)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceAddress { get; set; }
#nullable restore
#else
        public string ServiceAddress { get; set; }
#endif
        /// <summary>New service provider spid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Spid { get; set; }
#nullable restore
#else
        public string Spid { get; set; }
#endif
        /// <summary>State, province, or similar of billing address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Status of portout request</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.PortoutDetails_status? Status { get; set; }
        /// <summary>A key to reference this port out request when contacting Telnyx customer support</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportKey { get; set; }
#nullable restore
#else
        public string SupportKey { get; set; }
#endif
        /// <summary>ISO 8601 formatted date of when the portout was last updated</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>Identifies the user (or organization) who requested the port out</summary>
        public Guid? UserId { get; set; }
        /// <summary>Telnyx partner providing network coverage</summary>
        public Guid? Vendor { get; set; }
        /// <summary>Postal Code of billing address</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zip { get; set; }
#nullable restore
#else
        public string Zip { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PortoutDetails"/> and sets the default values.
        /// </summary>
        public PortoutDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PortoutDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.PortoutDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.PortoutDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "already_ported", n => { AlreadyPorted = n.GetBoolValue(); } },
                { "authorized_name", n => { AuthorizedName = n.GetStringValue(); } },
                { "carrier_name", n => { CarrierName = n.GetStringValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "current_carrier", n => { CurrentCarrier = n.GetStringValue(); } },
                { "end_user_name", n => { EndUserName = n.GetStringValue(); } },
                { "foc_date", n => { FocDate = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "inserted_at", n => { InsertedAt = n.GetStringValue(); } },
                { "lsr", n => { Lsr = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "phone_numbers", n => { PhoneNumbers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "pon", n => { Pon = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "rejection_code", n => { RejectionCode = n.GetIntValue(); } },
                { "requested_foc_date", n => { RequestedFocDate = n.GetStringValue(); } },
                { "service_address", n => { ServiceAddress = n.GetStringValue(); } },
                { "spid", n => { Spid = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortoutDetails_status>(); } },
                { "support_key", n => { SupportKey = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetStringValue(); } },
                { "user_id", n => { UserId = n.GetGuidValue(); } },
                { "vendor", n => { Vendor = n.GetGuidValue(); } },
                { "zip", n => { Zip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("already_ported", AlreadyPorted);
            writer.WriteStringValue("authorized_name", AuthorizedName);
            writer.WriteStringValue("carrier_name", CarrierName);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("current_carrier", CurrentCarrier);
            writer.WriteStringValue("end_user_name", EndUserName);
            writer.WriteStringValue("foc_date", FocDate);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("inserted_at", InsertedAt);
            writer.WriteCollectionOfPrimitiveValues<string>("lsr", Lsr);
            writer.WriteCollectionOfPrimitiveValues<string>("phone_numbers", PhoneNumbers);
            writer.WriteStringValue("pon", Pon);
            writer.WriteStringValue("reason", Reason);
            writer.WriteIntValue("rejection_code", RejectionCode);
            writer.WriteStringValue("requested_foc_date", RequestedFocDate);
            writer.WriteStringValue("service_address", ServiceAddress);
            writer.WriteStringValue("spid", Spid);
            writer.WriteStringValue("state", State);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.PortoutDetails_status>("status", Status);
            writer.WriteStringValue("support_key", SupportKey);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteGuidValue("user_id", UserId);
            writer.WriteGuidValue("vendor", Vendor);
            writer.WriteStringValue("zip", Zip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
