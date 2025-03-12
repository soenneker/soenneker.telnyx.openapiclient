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
    public partial class SubNumberOrderRegulatoryRequirementWithValue : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The field_type property</summary>
        public global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue_field_type? FieldType { get; private set; }
        /// <summary>The value of the requirement, this could be an id to a resource or a string value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FieldValue { get; set; }
#nullable restore
#else
        public string FieldValue { get; set; }
#endif
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>Unique id for a requirement.</summary>
        public Guid? RequirementId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue"/> and sets the default values.
        /// </summary>
        public SubNumberOrderRegulatoryRequirementWithValue()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "field_type", n => { FieldType = n.GetEnumValue<global::Soenneker.Telnyx.Models.SubNumberOrderRegulatoryRequirementWithValue_field_type>(); } },
                { "field_value", n => { FieldValue = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "requirement_id", n => { RequirementId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("field_value", FieldValue);
            writer.WriteGuidValue("requirement_id", RequirementId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
