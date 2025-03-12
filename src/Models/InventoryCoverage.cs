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
    public partial class InventoryCoverage : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The administrative_area property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdministrativeArea { get; set; }
#nullable restore
#else
        public string AdministrativeArea { get; set; }
#endif
        /// <summary>Indicates if the phone number requires advance requirements.</summary>
        public bool? AdvanceRequirements { get; set; }
        /// <summary>The count property</summary>
        public int? Count { get; set; }
        /// <summary>The coverage_type property</summary>
        public global::Soenneker.Telnyx.Models.InventoryCoverage_coverage_type? CoverageType { get; set; }
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Group { get; set; }
#nullable restore
#else
        public string Group { get; set; }
#endif
        /// <summary>The group_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupType { get; set; }
#nullable restore
#else
        public string GroupType { get; set; }
#endif
        /// <summary>The number_range property</summary>
        public int? NumberRange { get; set; }
        /// <summary>The number_type property</summary>
        public global::Soenneker.Telnyx.Models.InventoryCoverage_number_type? NumberType { get; set; }
        /// <summary>The phone_number_type property</summary>
        public global::Soenneker.Telnyx.Models.InventoryCoverage_phone_number_type? PhoneNumberType { get; set; }
        /// <summary>The record_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.InventoryCoverage"/> and sets the default values.
        /// </summary>
        public InventoryCoverage()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.InventoryCoverage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.InventoryCoverage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.InventoryCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "administrative_area", n => { AdministrativeArea = n.GetStringValue(); } },
                { "advance_requirements", n => { AdvanceRequirements = n.GetBoolValue(); } },
                { "count", n => { Count = n.GetIntValue(); } },
                { "coverage_type", n => { CoverageType = n.GetEnumValue<global::Soenneker.Telnyx.Models.InventoryCoverage_coverage_type>(); } },
                { "group", n => { Group = n.GetStringValue(); } },
                { "group_type", n => { GroupType = n.GetStringValue(); } },
                { "number_range", n => { NumberRange = n.GetIntValue(); } },
                { "number_type", n => { NumberType = n.GetEnumValue<global::Soenneker.Telnyx.Models.InventoryCoverage_number_type>(); } },
                { "phone_number_type", n => { PhoneNumberType = n.GetEnumValue<global::Soenneker.Telnyx.Models.InventoryCoverage_phone_number_type>(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("administrative_area", AdministrativeArea);
            writer.WriteBoolValue("advance_requirements", AdvanceRequirements);
            writer.WriteIntValue("count", Count);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.InventoryCoverage_coverage_type>("coverage_type", CoverageType);
            writer.WriteStringValue("group", Group);
            writer.WriteStringValue("group_type", GroupType);
            writer.WriteIntValue("number_range", NumberRange);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.InventoryCoverage_number_type>("number_type", NumberType);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.InventoryCoverage_phone_number_type>("phone_number_type", PhoneNumberType);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
