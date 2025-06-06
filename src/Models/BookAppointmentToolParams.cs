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
    public partial class BookAppointmentToolParams : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Reference to an integration secret that contains your Cal.com API key. You would pass the `identifier` for an integration secret [/v2/integration_secrets](https://developers.telnyx.com/api/secrets-manager/integration-secrets/create-integration-secret) that refers to your Cal.com API key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApiKeyRef { get; set; }
#nullable restore
#else
        public string ApiKeyRef { get; set; }
#endif
        /// <summary>The name of the attendee [cal.com](https://cal.com/docs/api-reference/v2/bookings/create-a-booking#body-attendee-name). If not provided, the assistant will ask for the attendee&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttendeeName { get; set; }
#nullable restore
#else
        public string AttendeeName { get; set; }
#endif
        /// <summary>The timezone of the attendee [cal.com](https://cal.com/docs/api-reference/v2/bookings/create-a-booking#body-attendee-timezone). If not provided, the assistant will ask for the attendee&apos;s timezone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttendeeTimezone { get; set; }
#nullable restore
#else
        public string AttendeeTimezone { get; set; }
#endif
        /// <summary>Event Type ID for which slots are being fetched. [cal.com](https://cal.com/docs/api-reference/v2/bookings/create-a-booking#body-event-type-id)</summary>
        public int? EventTypeId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.BookAppointmentToolParams"/> and sets the default values.
        /// </summary>
        public BookAppointmentToolParams()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.BookAppointmentToolParams"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.BookAppointmentToolParams CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.BookAppointmentToolParams();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "api_key_ref", n => { ApiKeyRef = n.GetStringValue(); } },
                { "attendee_name", n => { AttendeeName = n.GetStringValue(); } },
                { "attendee_timezone", n => { AttendeeTimezone = n.GetStringValue(); } },
                { "event_type_id", n => { EventTypeId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("api_key_ref", ApiKeyRef);
            writer.WriteStringValue("attendee_name", AttendeeName);
            writer.WriteStringValue("attendee_timezone", AttendeeTimezone);
            writer.WriteIntValue("event_type_id", EventTypeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
