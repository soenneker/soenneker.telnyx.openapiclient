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
    public partial class BulkMessagingSettingsUpdatePhoneNumbers : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Phone numbers that failed to update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Failed { get; set; }
#nullable restore
#else
        public List<string> Failed { get; set; }
#endif
        /// <summary>Order ID to verify bulk update status.</summary>
        public Guid? OrderId { get; private set; }
        /// <summary>Phone numbers pending to be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Pending { get; set; }
#nullable restore
#else
        public List<string> Pending { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
        public global::Soenneker.Telnyx.Models.BulkMessagingSettingsUpdatePhoneNumbers_record_type? RecordType { get; private set; }
        /// <summary>Phoned numbers updated successfully.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Success { get; set; }
#nullable restore
#else
        public List<string> Success { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.BulkMessagingSettingsUpdatePhoneNumbers"/> and sets the default values.
        /// </summary>
        public BulkMessagingSettingsUpdatePhoneNumbers()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.BulkMessagingSettingsUpdatePhoneNumbers"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.BulkMessagingSettingsUpdatePhoneNumbers CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.BulkMessagingSettingsUpdatePhoneNumbers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failed", n => { Failed = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "order_id", n => { OrderId = n.GetGuidValue(); } },
                { "pending", n => { Pending = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "record_type", n => { RecordType = n.GetEnumValue<global::Soenneker.Telnyx.Models.BulkMessagingSettingsUpdatePhoneNumbers_record_type>(); } },
                { "success", n => { Success = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("failed", Failed);
            writer.WriteCollectionOfPrimitiveValues<string>("pending", Pending);
            writer.WriteCollectionOfPrimitiveValues<string>("success", Success);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
