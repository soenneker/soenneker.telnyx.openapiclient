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
    public partial class BundleLimitSchema : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The billing_service property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillingService { get; set; }
#nullable restore
#else
        public string BillingService { get; set; }
#endif
        /// <summary>Use country_iso instead</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The country_code property</summary>
        public int? CountryCode { get; set; }
        /// <summary>The country_iso property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryIso { get; set; }
#nullable restore
#else
        public string CountryIso { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public Date? CreatedAt { get; set; }
        /// <summary>An enumeration.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.BundleLimitDirection? Direction { get; set; }
        /// <summary>The id property</summary>
        public Guid? Id { get; set; }
        /// <summary>The limit property</summary>
        public int? Limit { get; set; }
        /// <summary>The metric property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metric { get; set; }
#nullable restore
#else
        public string Metric { get; set; }
#endif
        /// <summary>The rate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rate { get; set; }
#nullable restore
#else
        public string Rate { get; set; }
#endif
        /// <summary>The service property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service { get; set; }
#nullable restore
#else
        public string Service { get; set; }
#endif
        /// <summary>The types property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Types { get; set; }
#nullable restore
#else
        public List<string> Types { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public Date? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.BundleLimitSchema"/> and sets the default values.
        /// </summary>
        public BundleLimitSchema()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.BundleLimitSchema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.BundleLimitSchema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.BundleLimitSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "billing_service", n => { BillingService = n.GetStringValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "country_code", n => { CountryCode = n.GetIntValue(); } },
                { "country_iso", n => { CountryIso = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateValue(); } },
                { "direction", n => { Direction = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.BundleLimitDirection>(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "limit", n => { Limit = n.GetIntValue(); } },
                { "metric", n => { Metric = n.GetStringValue(); } },
                { "rate", n => { Rate = n.GetStringValue(); } },
                { "service", n => { Service = n.GetStringValue(); } },
                { "types", n => { Types = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("billing_service", BillingService);
            writer.WriteStringValue("country", Country);
            writer.WriteIntValue("country_code", CountryCode);
            writer.WriteStringValue("country_iso", CountryIso);
            writer.WriteDateValue("created_at", CreatedAt);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.BundleLimitDirection>("direction", Direction);
            writer.WriteGuidValue("id", Id);
            writer.WriteIntValue("limit", Limit);
            writer.WriteStringValue("metric", Metric);
            writer.WriteStringValue("rate", Rate);
            writer.WriteStringValue("service", Service);
            writer.WriteCollectionOfPrimitiveValues<string>("types", Types);
            writer.WriteDateValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
