// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>
    /// This object represents an Over the Air (OTA) update request. It allows tracking the current status of a operation that apply settings in a particular SIM card. &lt;br/&gt;&lt;br/&gt;
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SimplifiedOTAUpdate : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>Identifies the resource.</summary>
        public Guid? Id { get; private set; }
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The identification UUID of the related SIM card resource.</summary>
        public Guid? SimCardId { get; set; }
        /// <summary>The status property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate_status? Status { get; set; }
        /// <summary>Represents the type of the operation requested. This will relate directly to the source of the request.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate_type? Type { get; set; }
        /// <summary>ISO 8601 formatted date-time indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; private set; }
#nullable restore
#else
        public string UpdatedAt { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate"/> and sets the default values.
        /// </summary>
        public SimplifiedOTAUpdate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "sim_card_id", n => { SimCardId = n.GetGuidValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate_status>(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate_type>(); } },
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
            writer.WriteGuidValue("sim_card_id", SimCardId);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate_status>("status", Status);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SimplifiedOTAUpdate_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
