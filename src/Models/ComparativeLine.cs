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
    public partial class ComparativeLine : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Service alias</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Alias { get; set; }
#nullable restore
#else
        public string Alias { get; set; }
#endif
        /// <summary>The existing_this_month property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail? ExistingThisMonth { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail ExistingThisMonth { get; set; }
#endif
        /// <summary>Service name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The new_this_month property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail? NewThisMonth { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail NewThisMonth { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.ComparativeLine_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ComparativeLine"/> and sets the default values.
        /// </summary>
        public ComparativeLine()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ComparativeLine"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.ComparativeLine CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.ComparativeLine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alias", n => { Alias = n.GetStringValue(); } },
                { "existing_this_month", n => { ExistingThisMonth = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail>(global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "new_this_month", n => { NewThisMonth = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail>(global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ComparativeLine_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alias", Alias);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail>("existing_this_month", ExistingThisMonth);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.MonthDetail>("new_this_month", NewThisMonth);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ComparativeLine_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
