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
    public partial class PortingOrderSharingToken : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the sharing token expires.</summary>
        public DateTimeOffset? ExpiresAt { get; set; }
        /// <summary>The number of seconds until the sharing token expires</summary>
        public int? ExpiresInSeconds { get; set; }
        /// <summary>Uniquely identifies this sharing token</summary>
        public Guid? Id { get; set; }
        /// <summary>The permissions granted to the sharing token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.Models.PortingOrderSharingToken_permissions?>? Permissions { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.Models.PortingOrderSharingToken_permissions?> Permissions { get; set; }
#endif
        /// <summary>Identifies the porting order resource being shared</summary>
        public Guid? PortingOrderId { get; set; }
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>A signed JWT token that can be used to access the shared resource</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.PortingOrderSharingToken"/> and sets the default values.
        /// </summary>
        public PortingOrderSharingToken()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.PortingOrderSharingToken"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.PortingOrderSharingToken CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.PortingOrderSharingToken();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "expires_at", n => { ExpiresAt = n.GetDateTimeOffsetValue(); } },
                { "expires_in_seconds", n => { ExpiresInSeconds = n.GetIntValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "permissions", n => { Permissions = n.GetCollectionOfEnumValues<global::Soenneker.Telnyx.Models.PortingOrderSharingToken_permissions>()?.AsList(); } },
                { "porting_order_id", n => { PortingOrderId = n.GetGuidValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteDateTimeOffsetValue("expires_at", ExpiresAt);
            writer.WriteIntValue("expires_in_seconds", ExpiresInSeconds);
            writer.WriteGuidValue("id", Id);
            writer.WriteCollectionOfEnumValues<global::Soenneker.Telnyx.Models.PortingOrderSharingToken_permissions>("permissions", Permissions);
            writer.WriteGuidValue("porting_order_id", PortingOrderId);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
