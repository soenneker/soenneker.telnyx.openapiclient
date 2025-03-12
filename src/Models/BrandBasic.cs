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
    public partial class BrandBasic : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of campaigns associated with the brand</summary>
        public int? AssignedCampaingsCount { get; set; }
        /// <summary>Unique identifier assigned to the brand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BrandId { get; set; }
#nullable restore
#else
        public string BrandId { get; set; }
#endif
        /// <summary>(Required for Non-profit/private/public) Legal company name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>Date and time that the brand was created at.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>Display or marketing name of the brand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Valid email address of brand support contact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Entity type behind the brand. This is the form of business establishment.</summary>
        public global::Soenneker.Telnyx.Models.EntityType? EntityType { get; set; }
        /// <summary>Failure reasons for brand</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? FailureReasons { get; set; }
#nullable restore
#else
        public UntypedNode FailureReasons { get; set; }
#endif
        /// <summary>The verification status of an active brand</summary>
        public global::Soenneker.Telnyx.Models.BrandIdentityStatus? IdentityStatus { get; set; }
        /// <summary>Status of the brand</summary>
        public global::Soenneker.Telnyx.Models.BrandBasic_status? Status { get; set; }
        /// <summary>Unique identifier assigned to the brand by the registry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TcrBrandId { get; set; }
#nullable restore
#else
        public string TcrBrandId { get; set; }
#endif
        /// <summary>Date and time that the brand was last updated at.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>Brand website URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.BrandBasic"/> and sets the default values.
        /// </summary>
        public BrandBasic()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.BrandBasic"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.BrandBasic CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.BrandBasic();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignedCampaingsCount", n => { AssignedCampaingsCount = n.GetIntValue(); } },
                { "brandId", n => { BrandId = n.GetStringValue(); } },
                { "companyName", n => { CompanyName = n.GetStringValue(); } },
                { "createdAt", n => { CreatedAt = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "entityType", n => { EntityType = n.GetEnumValue<global::Soenneker.Telnyx.Models.EntityType>(); } },
                { "failureReasons", n => { FailureReasons = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "identityStatus", n => { IdentityStatus = n.GetEnumValue<global::Soenneker.Telnyx.Models.BrandIdentityStatus>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.BrandBasic_status>(); } },
                { "tcrBrandId", n => { TcrBrandId = n.GetStringValue(); } },
                { "updatedAt", n => { UpdatedAt = n.GetStringValue(); } },
                { "website", n => { Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("assignedCampaingsCount", AssignedCampaingsCount);
            writer.WriteStringValue("brandId", BrandId);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("createdAt", CreatedAt);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.EntityType>("entityType", EntityType);
            writer.WriteObjectValue<UntypedNode>("failureReasons", FailureReasons);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.BrandIdentityStatus>("identityStatus", IdentityStatus);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.BrandBasic_status>("status", Status);
            writer.WriteStringValue("tcrBrandId", TcrBrandId);
            writer.WriteStringValue("updatedAt", UpdatedAt);
            writer.WriteStringValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
