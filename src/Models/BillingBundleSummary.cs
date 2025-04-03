// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class BillingBundleSummary : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Bundle&apos;s cost code, this is used to identify the bundle in the billing system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CostCode { get; set; }
#nullable restore
#else
        public string CostCode { get; set; }
#endif
        /// <summary>Date the bundle was created.</summary>
        public Date? CreatedAt { get; set; }
        /// <summary>Bundle&apos;s currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Currency { get; set; }
#nullable restore
#else
        public string Currency { get; set; }
#endif
        /// <summary>Bundle&apos;s ID, this is used to identify the bundle in the API.</summary>
        public Guid? Id { get; set; }
        /// <summary>Available to all customers or only to specific customers.</summary>
        public bool? IsPublic { get; set; }
        /// <summary>Monthly recurring charge price.</summary>
        public float? MrcPrice { get; set; }
        /// <summary>Bundle&apos;s name, this is used to identify the bundle in the UI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Slugified version of the bundle&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>The specs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Specs { get; set; }
#nullable restore
#else
        public List<string> Specs { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.BillingBundleSummary"/> and sets the default values.
        /// </summary>
        public BillingBundleSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.BillingBundleSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.BillingBundleSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.BillingBundleSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cost_code", n => { CostCode = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateValue(); } },
                { "currency", n => { Currency = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "is_public", n => { IsPublic = n.GetBoolValue(); } },
                { "mrc_price", n => { MrcPrice = n.GetFloatValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "slug", n => { Slug = n.GetStringValue(); } },
                { "specs", n => { Specs = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cost_code", CostCode);
            writer.WriteDateValue("created_at", CreatedAt);
            writer.WriteStringValue("currency", Currency);
            writer.WriteGuidValue("id", Id);
            writer.WriteBoolValue("is_public", IsPublic);
            writer.WriteFloatValue("mrc_price", MrcPrice);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("slug", Slug);
            writer.WriteCollectionOfPrimitiveValues<string>("specs", Specs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
