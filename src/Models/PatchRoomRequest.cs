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
    public partial class PatchRoomRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enable or disable recording for that room.</summary>
        public bool? EnableRecording { get; set; }
        /// <summary>The maximum amount of participants allowed in a room. If new participants try to join after that limit is reached, their request will be rejected.</summary>
        public int? MaxParticipants { get; set; }
        /// <summary>The unique (within the Telnyx account scope) name of the room.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueName { get; set; }
#nullable restore
#else
        public string UniqueName { get; set; }
#endif
        /// <summary>The failover URL where webhooks related to this room will be sent if sending to the primary URL fails. Must include a scheme, such as &apos;https&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookEventFailoverUrl { get; set; }
#nullable restore
#else
        public string WebhookEventFailoverUrl { get; set; }
#endif
        /// <summary>The URL where webhooks related to this room will be sent. Must include a scheme, such as &apos;https&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookEventUrl { get; set; }
#nullable restore
#else
        public string WebhookEventUrl { get; set; }
#endif
        /// <summary>Specifies how many seconds to wait before timing out a webhook.</summary>
        public int? WebhookTimeoutSecs { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PatchRoomRequest"/> and sets the default values.
        /// </summary>
        public PatchRoomRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.PatchRoomRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.PatchRoomRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.PatchRoomRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enable_recording", n => { EnableRecording = n.GetBoolValue(); } },
                { "max_participants", n => { MaxParticipants = n.GetIntValue(); } },
                { "unique_name", n => { UniqueName = n.GetStringValue(); } },
                { "webhook_event_failover_url", n => { WebhookEventFailoverUrl = n.GetStringValue(); } },
                { "webhook_event_url", n => { WebhookEventUrl = n.GetStringValue(); } },
                { "webhook_timeout_secs", n => { WebhookTimeoutSecs = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enable_recording", EnableRecording);
            writer.WriteIntValue("max_participants", MaxParticipants);
            writer.WriteStringValue("unique_name", UniqueName);
            writer.WriteStringValue("webhook_event_failover_url", WebhookEventFailoverUrl);
            writer.WriteStringValue("webhook_event_url", WebhookEventUrl);
            writer.WriteIntValue("webhook_timeout_secs", WebhookTimeoutSecs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
