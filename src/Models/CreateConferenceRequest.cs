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
    public partial class CreateConferenceRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether a beep sound should be played when participants join and/or leave the conference.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest_beep_enabled? BeepEnabled { get; set; }
        /// <summary>Unique identifier and token for controlling the call</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallControlId { get; set; }
#nullable restore
#else
        public string CallControlId { get; set; }
#endif
        /// <summary>Use this field to add state to every subsequent webhook. It must be a valid Base-64 encoded string. The client_state will be updated for the creator call leg and will be used for all webhooks related to the created conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientState { get; set; }
#nullable restore
#else
        public string ClientState { get; set; }
#endif
        /// <summary>Toggle background comfort noise.</summary>
        public bool? ComfortNoise { get; set; }
        /// <summary>Use this field to avoid execution of duplicate commands. Telnyx will ignore subsequent commands with the same `command_id` as one that has already been executed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommandId { get; set; }
#nullable restore
#else
        public string CommandId { get; set; }
#endif
        /// <summary>Time length (minutes) after which the conference will end.</summary>
        public int? DurationMinutes { get; set; }
        /// <summary>The URL of a file to be played to participants joining the conference. The URL can point to either a WAV or MP3 file. hold_media_name and hold_audio_url cannot be used together in one request. Takes effect only when &quot;start_conference_on_create&quot; is set to &quot;false&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HoldAudioUrl { get; set; }
#nullable restore
#else
        public string HoldAudioUrl { get; set; }
#endif
        /// <summary>The media_name of a file to be played to participants joining the conference. The media_name must point to a file previously uploaded to api.telnyx.com/v2/media by the same user/organization. The file must either be a WAV or MP3 file. Takes effect only when &quot;start_conference_on_create&quot; is set to &quot;false&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HoldMediaName { get; set; }
#nullable restore
#else
        public string HoldMediaName { get; set; }
#endif
        /// <summary>The maximum number of active conference participants to allow. Must be between 2 and 800. Defaults to 250</summary>
        public int? MaxParticipants { get; set; }
        /// <summary>Name of the conference</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Whether the conference should be started on creation. If the conference isn&apos;t started all participants that join are automatically put on hold. Defaults to &quot;true&quot;.</summary>
        public bool? StartConferenceOnCreate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest"/> and sets the default values.
        /// </summary>
        public CreateConferenceRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            BeepEnabled = global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest_beep_enabled.Never;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "beep_enabled", n => { BeepEnabled = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest_beep_enabled>(); } },
                { "call_control_id", n => { CallControlId = n.GetStringValue(); } },
                { "client_state", n => { ClientState = n.GetStringValue(); } },
                { "comfort_noise", n => { ComfortNoise = n.GetBoolValue(); } },
                { "command_id", n => { CommandId = n.GetStringValue(); } },
                { "duration_minutes", n => { DurationMinutes = n.GetIntValue(); } },
                { "hold_audio_url", n => { HoldAudioUrl = n.GetStringValue(); } },
                { "hold_media_name", n => { HoldMediaName = n.GetStringValue(); } },
                { "max_participants", n => { MaxParticipants = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "start_conference_on_create", n => { StartConferenceOnCreate = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.CreateConferenceRequest_beep_enabled>("beep_enabled", BeepEnabled);
            writer.WriteStringValue("call_control_id", CallControlId);
            writer.WriteStringValue("client_state", ClientState);
            writer.WriteBoolValue("comfort_noise", ComfortNoise);
            writer.WriteStringValue("command_id", CommandId);
            writer.WriteIntValue("duration_minutes", DurationMinutes);
            writer.WriteStringValue("hold_audio_url", HoldAudioUrl);
            writer.WriteStringValue("hold_media_name", HoldMediaName);
            writer.WriteIntValue("max_participants", MaxParticipants);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("start_conference_on_create", StartConferenceOnCreate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
