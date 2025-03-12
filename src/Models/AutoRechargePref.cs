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
    public partial class AutoRechargePref : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether auto recharge is enabled.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The unique identifier for the auto recharge preference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The invoice_enabled property</summary>
        public bool? InvoiceEnabled { get; set; }
        /// <summary>The payment preference for auto recharge.</summary>
        public global::Soenneker.Telnyx.Models.AutoRechargePref_preference? Preference { get; set; }
        /// <summary>The amount to recharge the account, the actual recharge amount will be the amount necessary to reach the threshold amount plus the recharge amount.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RechargeAmount { get; set; }
#nullable restore
#else
        public string RechargeAmount { get; set; }
#endif
        /// <summary>The record type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>The threshold amount at which the account will be recharged.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThresholdAmount { get; set; }
#nullable restore
#else
        public string ThresholdAmount { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.AutoRechargePref"/> and sets the default values.
        /// </summary>
        public AutoRechargePref()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.AutoRechargePref"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.AutoRechargePref CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.AutoRechargePref();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enabled", n => { Enabled = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "invoice_enabled", n => { InvoiceEnabled = n.GetBoolValue(); } },
                { "preference", n => { Preference = n.GetEnumValue<global::Soenneker.Telnyx.Models.AutoRechargePref_preference>(); } },
                { "recharge_amount", n => { RechargeAmount = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "threshold_amount", n => { ThresholdAmount = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("invoice_enabled", InvoiceEnabled);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.AutoRechargePref_preference>("preference", Preference);
            writer.WriteStringValue("recharge_amount", RechargeAmount);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteStringValue("threshold_amount", ThresholdAmount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
