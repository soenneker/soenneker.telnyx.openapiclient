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
    public partial class PortingLOAConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address of the company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.PortingLOAConfiguration_address? Address { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.PortingLOAConfiguration_address Address { get; set; }
#endif
        /// <summary>The name of the company</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>The contact information of the company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.PortingLOAConfiguration_contact? Contact { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.PortingLOAConfiguration_contact Contact { get; set; }
#endif
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Uniquely identifies the LOA configuration.</summary>
        public Guid? Id { get; set; }
        /// <summary>The logo to be used in the LOA.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.PortingLOAConfiguration_logo? Logo { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.PortingLOAConfiguration_logo Logo { get; set; }
#endif
        /// <summary>The name of the LOA configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The organization that owns the LOA configuration</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationId { get; set; }
#nullable restore
#else
        public string OrganizationId { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>ISO 8601 formatted date indicating when the resource was updated.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.PortingLOAConfiguration"/> and sets the default values.
        /// </summary>
        public PortingLOAConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.PortingLOAConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.PortingLOAConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.PortingLOAConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetObjectValue<global::Soenneker.Telnyx.Models.PortingLOAConfiguration_address>(global::Soenneker.Telnyx.Models.PortingLOAConfiguration_address.CreateFromDiscriminatorValue); } },
                { "company_name", n => { CompanyName = n.GetStringValue(); } },
                { "contact", n => { Contact = n.GetObjectValue<global::Soenneker.Telnyx.Models.PortingLOAConfiguration_contact>(global::Soenneker.Telnyx.Models.PortingLOAConfiguration_contact.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "logo", n => { Logo = n.GetObjectValue<global::Soenneker.Telnyx.Models.PortingLOAConfiguration_logo>(global::Soenneker.Telnyx.Models.PortingLOAConfiguration_logo.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "organization_id", n => { OrganizationId = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.PortingLOAConfiguration_address>("address", Address);
            writer.WriteStringValue("company_name", CompanyName);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.PortingLOAConfiguration_contact>("contact", Contact);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteGuidValue("id", Id);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.PortingLOAConfiguration_logo>("logo", Logo);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("organization_id", OrganizationId);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
