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
    public partial class ExternalVetting : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Vetting submission date. This is the date when the vetting request is generated in ISO 8601 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreateDate { get; set; }
#nullable restore
#else
        public string CreateDate { get; set; }
#endif
        /// <summary>External vetting provider ID for the brand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EvpId { get; set; }
#nullable restore
#else
        public string EvpId { get; set; }
#endif
        /// <summary>Vetting effective date. This is the date when vetting was completed, or the starting effective date in ISO 8601 format. If this date is missing, then the vetting was not complete or not valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VettedDate { get; set; }
#nullable restore
#else
        public string VettedDate { get; set; }
#endif
        /// <summary>Identifies the vetting classification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VettingClass { get; set; }
#nullable restore
#else
        public string VettingClass { get; set; }
#endif
        /// <summary>Unique ID that identifies a vetting transaction performed by a vetting provider. This ID is provided by the vetting provider at time of vetting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VettingId { get; set; }
#nullable restore
#else
        public string VettingId { get; set; }
#endif
        /// <summary>Vetting score ranging from 0-100.</summary>
        public int? VettingScore { get; set; }
        /// <summary>Required by some providers for vetting record confirmation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VettingToken { get; set; }
#nullable restore
#else
        public string VettingToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ExternalVetting"/> and sets the default values.
        /// </summary>
        public ExternalVetting()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ExternalVetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.ExternalVetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.ExternalVetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createDate", n => { CreateDate = n.GetStringValue(); } },
                { "evpId", n => { EvpId = n.GetStringValue(); } },
                { "vettedDate", n => { VettedDate = n.GetStringValue(); } },
                { "vettingClass", n => { VettingClass = n.GetStringValue(); } },
                { "vettingId", n => { VettingId = n.GetStringValue(); } },
                { "vettingScore", n => { VettingScore = n.GetIntValue(); } },
                { "vettingToken", n => { VettingToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("createDate", CreateDate);
            writer.WriteStringValue("evpId", EvpId);
            writer.WriteStringValue("vettedDate", VettedDate);
            writer.WriteStringValue("vettingClass", VettingClass);
            writer.WriteStringValue("vettingId", VettingId);
            writer.WriteIntValue("vettingScore", VettingScore);
            writer.WriteStringValue("vettingToken", VettingToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
