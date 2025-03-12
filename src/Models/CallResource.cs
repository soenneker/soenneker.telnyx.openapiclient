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
    public partial class CallResource : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The id of the account the resource belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountSid { get; set; }
#nullable restore
#else
        public string AccountSid { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value of the answering machine detection result, if this feature was enabled for the call.</summary>
        public global::Soenneker.Telnyx.Models.CallResource_answered_by? AnsweredBy { get; set; }
        /// <summary>Caller ID, if present.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallerName { get; set; }
#nullable restore
#else
        public string CallerName { get; set; }
#endif
        /// <summary>The timestamp of when the resource was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateCreated { get; set; }
#nullable restore
#else
        public string DateCreated { get; set; }
#endif
        /// <summary>The timestamp of when the resource was last updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateUpdated { get; set; }
#nullable restore
#else
        public string DateUpdated { get; set; }
#endif
        /// <summary>The direction of this call.</summary>
        public global::Soenneker.Telnyx.Models.CallResource_direction? Direction { get; set; }
        /// <summary>The duration of this call, given in seconds.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Duration { get; set; }
#nullable restore
#else
        public string Duration { get; set; }
#endif
        /// <summary>The end time of this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndTime { get; set; }
#nullable restore
#else
        public string EndTime { get; set; }
#endif
        /// <summary>The phone number or SIP address that made this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? From { get; set; }
#nullable restore
#else
        public string From { get; set; }
#endif
        /// <summary>The from number formatted for display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromFormatted { get; set; }
#nullable restore
#else
        public string FromFormatted { get; set; }
#endif
        /// <summary>The price of this call, the currency is specified in the price_unit field. Only populated when the call cost feature is enabled for the account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Price { get; set; }
#nullable restore
#else
        public string Price { get; set; }
#endif
        /// <summary>The unit in which the price is given.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PriceUnit { get; set; }
#nullable restore
#else
        public string PriceUnit { get; set; }
#endif
        /// <summary>The identifier of this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sid { get; set; }
#nullable restore
#else
        public string Sid { get; set; }
#endif
        /// <summary>The start time of this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>The status of this call.</summary>
        public global::Soenneker.Telnyx.Models.CallResource_status? Status { get; set; }
        /// <summary>The phone number or SIP address that received this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>The to number formatted for display.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ToFormatted { get; set; }
#nullable restore
#else
        public string ToFormatted { get; set; }
#endif
        /// <summary>The relative URI for this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.CallResource"/> and sets the default values.
        /// </summary>
        public CallResource()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.CallResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.CallResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.CallResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_sid", n => { AccountSid = n.GetStringValue(); } },
                { "answered_by", n => { AnsweredBy = n.GetEnumValue<global::Soenneker.Telnyx.Models.CallResource_answered_by>(); } },
                { "caller_name", n => { CallerName = n.GetStringValue(); } },
                { "date_created", n => { DateCreated = n.GetStringValue(); } },
                { "date_updated", n => { DateUpdated = n.GetStringValue(); } },
                { "direction", n => { Direction = n.GetEnumValue<global::Soenneker.Telnyx.Models.CallResource_direction>(); } },
                { "duration", n => { Duration = n.GetStringValue(); } },
                { "end_time", n => { EndTime = n.GetStringValue(); } },
                { "from", n => { From = n.GetStringValue(); } },
                { "from_formatted", n => { FromFormatted = n.GetStringValue(); } },
                { "price", n => { Price = n.GetStringValue(); } },
                { "price_unit", n => { PriceUnit = n.GetStringValue(); } },
                { "sid", n => { Sid = n.GetStringValue(); } },
                { "start_time", n => { StartTime = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.Telnyx.Models.CallResource_status>(); } },
                { "to", n => { To = n.GetStringValue(); } },
                { "to_formatted", n => { ToFormatted = n.GetStringValue(); } },
                { "uri", n => { Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_sid", AccountSid);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.CallResource_answered_by>("answered_by", AnsweredBy);
            writer.WriteStringValue("caller_name", CallerName);
            writer.WriteStringValue("date_created", DateCreated);
            writer.WriteStringValue("date_updated", DateUpdated);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.CallResource_direction>("direction", Direction);
            writer.WriteStringValue("duration", Duration);
            writer.WriteStringValue("end_time", EndTime);
            writer.WriteStringValue("from", From);
            writer.WriteStringValue("from_formatted", FromFormatted);
            writer.WriteStringValue("price", Price);
            writer.WriteStringValue("price_unit", PriceUnit);
            writer.WriteStringValue("sid", Sid);
            writer.WriteStringValue("start_time", StartTime);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.CallResource_status>("status", Status);
            writer.WriteStringValue("to", To);
            writer.WriteStringValue("to_formatted", ToFormatted);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
