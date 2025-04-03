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
    public partial class NumberLookupRecord : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The caller_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.CallerName? CallerName { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.CallerName CallerName { get; set; }
#endif
        /// <summary>The carrier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.Carrier? Carrier { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.Carrier Carrier { get; set; }
#endif
        /// <summary>Region code that matches the specific country calling code</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>Unused</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Fraud { get; set; }
#nullable restore
#else
        public string Fraud { get; set; }
#endif
        /// <summary>Hyphen-separated national number, preceded by the national destination code (NDC), with a 0 prefix, if an NDC is found</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NationalFormat { get; set; }
#nullable restore
#else
        public string NationalFormat { get; set; }
#endif
        /// <summary>E164-formatted phone number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The portability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.Portability? Portability { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.Portability Portability { get; set; }
#endif
        /// <summary>Identifies the type of record</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordType { get; set; }
#nullable restore
#else
        public string RecordType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.NumberLookupRecord"/> and sets the default values.
        /// </summary>
        public NumberLookupRecord()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.NumberLookupRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.NumberLookupRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.NumberLookupRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "caller_name", n => { CallerName = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.CallerName>(global::Soenneker.Telnyx.OpenApiClient.Models.CallerName.CreateFromDiscriminatorValue); } },
                { "carrier", n => { Carrier = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.Carrier>(global::Soenneker.Telnyx.OpenApiClient.Models.Carrier.CreateFromDiscriminatorValue); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "fraud", n => { Fraud = n.GetStringValue(); } },
                { "national_format", n => { NationalFormat = n.GetStringValue(); } },
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "portability", n => { Portability = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.Portability>(global::Soenneker.Telnyx.OpenApiClient.Models.Portability.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.CallerName>("caller_name", CallerName);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.Carrier>("carrier", Carrier);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteStringValue("fraud", Fraud);
            writer.WriteStringValue("national_format", NationalFormat);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.Portability>("portability", Portability);
            writer.WriteStringValue("record_type", RecordType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
