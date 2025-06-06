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
    public partial class ManagedAccountMultiListing : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The manager account&apos;s email, which serves as the V1 API user identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApiUser { get; set; }
#nullable restore
#else
        public string ApiUser { get; set; }
#endif
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The managed account&apos;s email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Uniquely identifies the managed account.</summary>
        public Guid? Id { get; set; }
        /// <summary>Boolean value that indicates if the managed account is able to have custom pricing set for it or not. If false, uses the pricing of the manager account. Defaults to false. There may be time lag between when the value is changed and pricing changes take effect.</summary>
        public bool? ManagedAccountAllowCustomPricing { get; set; }
        /// <summary>The ID of the manager account associated with the managed account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagerAccountId { get; set; }
#nullable restore
#else
        public string ManagerAccountId { get; set; }
#endif
        /// <summary>The organization the managed account is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationName { get; set; }
#nullable restore
#else
        public string OrganizationName { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.ManagedAccountMultiListing_record_type? RecordType { get; set; }
        /// <summary>Boolean value that indicates if the billing information and charges to the managed account &quot;roll up&quot; to the manager account. If true, the managed account will not have its own balance and will use the shared balance with the manager account. This value cannot be changed after account creation without going through Telnyx support as changes require manual updates to the account ledger. Defaults to false.</summary>
        public bool? RollupBilling { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ManagedAccountMultiListing"/> and sets the default values.
        /// </summary>
        public ManagedAccountMultiListing()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ManagedAccountMultiListing"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.ManagedAccountMultiListing CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.ManagedAccountMultiListing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "api_user", n => { ApiUser = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "managed_account_allow_custom_pricing", n => { ManagedAccountAllowCustomPricing = n.GetBoolValue(); } },
                { "manager_account_id", n => { ManagerAccountId = n.GetStringValue(); } },
                { "organization_name", n => { OrganizationName = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ManagedAccountMultiListing_record_type>(); } },
                { "rollup_billing", n => { RollupBilling = n.GetBoolValue(); } },
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
            writer.WriteStringValue("api_user", ApiUser);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("email", Email);
            writer.WriteGuidValue("id", Id);
            writer.WriteBoolValue("managed_account_allow_custom_pricing", ManagedAccountAllowCustomPricing);
            writer.WriteStringValue("manager_account_id", ManagerAccountId);
            writer.WriteStringValue("organization_name", OrganizationName);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ManagedAccountMultiListing_record_type>("record_type", RecordType);
            writer.WriteBoolValue("rollup_billing", RollupBilling);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
