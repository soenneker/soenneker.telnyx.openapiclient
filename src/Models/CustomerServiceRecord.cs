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
    public partial class CustomerServiceRecord : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The error message in case status is `failed`. This field would be null in case of `pending` or `completed` status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorMessage { get; set; }
#nullable restore
#else
        public string ErrorMessage { get; set; }
#endif
        /// <summary>Uniquely identifies this customer service record</summary>
        public Guid? Id { get; private set; }
        /// <summary>The phone number of the customer service record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>The result of the CSR request. This field would be null in case of `pending` or `failed` status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.Models.CustomerServiceRecord_result? Result { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.Models.CustomerServiceRecord_result Result { get; set; }
#endif
        /// <summary>The status of the customer service record</summary>
        public global::Soenneker.Telnyx.Models.CustomerServiceRecord_status? Status { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.CustomerServiceRecord"/> and sets the default values.
        /// </summary>
        public CustomerServiceRecord()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.CustomerServiceRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.CustomerServiceRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.CustomerServiceRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "error_message", n => { ErrorMessage = n.GetStringValue(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "result", n => { Result = n.GetObjectValue<global::Soenneker.Telnyx.Models.CustomerServiceRecord_result>(global::Soenneker.Telnyx.Models.CustomerServiceRecord_result.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.CustomerServiceRecord_status>(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("error_message", ErrorMessage);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteObjectValue<global::Soenneker.Telnyx.Models.CustomerServiceRecord_result>("result", Result);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.CustomerServiceRecord_status>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
