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
    public partial class PhoneNumberBlocksJob : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; private set; }
#nullable restore
#else
        public string CreatedAt { get; private set; }
#endif
        /// <summary>ISO 8601 formatted date indicating when the estimated time of completion of the background job.</summary>
        public DateTimeOffset? Etc { get; private set; }
        /// <summary>The failed_operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobFailedOperation>? FailedOperations { get; private set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobFailedOperation> FailedOperations { get; private set; }
#endif
        /// <summary>Identifies the resource.</summary>
        public Guid? Id { get; private set; }
        /// <summary>Identifies the type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; private set; }
#nullable restore
#else
        public string RecordType { get; private set; }
#endif
        /// <summary>Indicates the completion status of the background operation.</summary>
        public global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob_status? Status { get; private set; }
        /// <summary>The successful_operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobSuccessfulOperation>? SuccessfulOperations { get; private set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobSuccessfulOperation> SuccessfulOperations { get; private set; }
#endif
        /// <summary>Identifies the type of the background job.</summary>
        public global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob_type? Type { get; private set; }
        /// <summary>ISO 8601 formatted date indicating when the resource was updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; private set; }
#nullable restore
#else
        public string UpdatedAt { get; private set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob"/> and sets the default values.
        /// </summary>
        public PhoneNumberBlocksJob()
        {
            AdditionalData = new Dictionary<string, object>();
            Status = global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob_status.Pending;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob();
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
                { "etc", n => { Etc = n.GetDateTimeOffsetValue(); } },
                { "failed_operations", n => { FailedOperations = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobFailedOperation>(global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobFailedOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "id", n => { Id = n.GetGuidValue(); } },
                { "record_type", n => { RecordType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob_status>(); } },
                { "successful_operations", n => { SuccessfulOperations = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobSuccessfulOperation>(global::Soenneker.Telnyx.Models.PhoneNumberBlocksJobSuccessfulOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.Telnyx.Models.PhoneNumberBlocksJob_type>(); } },
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
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
