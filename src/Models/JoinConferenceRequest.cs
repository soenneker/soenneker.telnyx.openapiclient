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
    public partial class JoinConferenceRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether a beep sound should be played when the participant joins and/or leaves the conference. Can be used to override the conference-level setting.</summary>
        public global::Soenneker.Telnyx.Models.JoinConferenceRequest_beep_enabled? BeepEnabled { get; set; }
        /// <summary>Unique identifier and token for controlling the call</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallControlId { get; set; }
#nullable restore
#else
        public string CallControlId { get; set; }
#endif
        /// <summary>Use this field to add state to every subsequent webhook. It must be a valid Base-64 encoded string. Please note that the client_state will be updated for the participient call leg and the change will not affect conferencing webhooks unless the participient is the owner of the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientState { get; set; }
#nullable restore
#else
        public string ClientState { get; set; }
#endif
        /// <summary>Use this field to avoid execution of duplicate commands. Telnyx will ignore subsequent commands with the same `command_id` as one that has already been executed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommandId { get; set; }
#nullable restore
#else
        public string CommandId { get; set; }
#endif
        /// <summary>Whether the conference should end and all remaining participants be hung up after the participant leaves the conference. Defaults to &quot;false&quot;.</summary>
        public bool? EndConferenceOnExit { get; set; }
        /// <summary>Whether the participant should be put on hold immediately after joining the conference. Defaults to &quot;false&quot;.</summary>
        public bool? Hold { get; set; }
        /// <summary>The URL of a file to be played to the participant when they are put on hold after joining the conference. hold_media_name and hold_audio_url cannot be used together in one request. Takes effect only when &quot;start_conference_on_create&quot; is set to &quot;false&quot;. This property takes effect only if &quot;hold&quot; is set to &quot;true&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HoldAudioUrl { get; set; }
#nullable restore
#else
        public string HoldAudioUrl { get; set; }
#endif
        /// <summary>The media_name of a file to be played to the participant when they are put on hold after joining the conference. The media_name must point to a file previously uploaded to api.telnyx.com/v2/media by the same user/organization. The file must either be a WAV or MP3 file. Takes effect only when &quot;start_conference_on_create&quot; is set to &quot;false&quot;. This property takes effect only if &quot;hold&quot; is set to &quot;true&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HoldMediaName { get; set; }
#nullable restore
#else
        public string HoldMediaName { get; set; }
#endif
        /// <summary>Whether the participant should be muted immediately after joining the conference. Defaults to &quot;false&quot;.</summary>
        public bool? Mute { get; set; }
        /// <summary>Whether the conference should end after the participant leaves the conference. NOTE this doesn&apos;t hang up the other participants. Defaults to &quot;false&quot;.</summary>
        public bool? SoftEndConferenceOnExit { get; set; }
        /// <summary>Whether the conference should be started after the participant joins the conference. Defaults to &quot;false&quot;.</summary>
        public bool? StartConferenceOnEnter { get; set; }
        /// <summary>Sets the joining participant as a supervisor for the conference. A conference can have multiple supervisors. &quot;barge&quot; means the supervisor enters the conference as a normal participant. This is the same as &quot;none&quot;. &quot;monitor&quot; means the supervisor is muted but can hear all participants. &quot;whisper&quot; means that only the specified &quot;whisper_call_control_ids&quot; can hear the supervisor. Defaults to &quot;none&quot;.</summary>
        public global::Soenneker.Telnyx.Models.JoinConferenceRequest_supervisor_role? SupervisorRole { get; set; }
        /// <summary>Array of unique call_control_ids the joining supervisor can whisper to. If none provided, the supervisor will join the conference as a monitoring participant only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WhisperCallControlIds { get; set; }
#nullable restore
#else
        public List<string> WhisperCallControlIds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.JoinConferenceRequest"/> and sets the default values.
        /// </summary>
        public JoinConferenceRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.JoinConferenceRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.JoinConferenceRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.JoinConferenceRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "beep_enabled", n => { BeepEnabled = n.GetEnumValue<global::Soenneker.Telnyx.Models.JoinConferenceRequest_beep_enabled>(); } },
                { "call_control_id", n => { CallControlId = n.GetStringValue(); } },
                { "client_state", n => { ClientState = n.GetStringValue(); } },
                { "command_id", n => { CommandId = n.GetStringValue(); } },
                { "end_conference_on_exit", n => { EndConferenceOnExit = n.GetBoolValue(); } },
                { "hold", n => { Hold = n.GetBoolValue(); } },
                { "hold_audio_url", n => { HoldAudioUrl = n.GetStringValue(); } },
                { "hold_media_name", n => { HoldMediaName = n.GetStringValue(); } },
                { "mute", n => { Mute = n.GetBoolValue(); } },
                { "soft_end_conference_on_exit", n => { SoftEndConferenceOnExit = n.GetBoolValue(); } },
                { "start_conference_on_enter", n => { StartConferenceOnEnter = n.GetBoolValue(); } },
                { "supervisor_role", n => { SupervisorRole = n.GetEnumValue<global::Soenneker.Telnyx.Models.JoinConferenceRequest_supervisor_role>(); } },
                { "whisper_call_control_ids", n => { WhisperCallControlIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.JoinConferenceRequest_beep_enabled>("beep_enabled", BeepEnabled);
            writer.WriteStringValue("call_control_id", CallControlId);
            writer.WriteStringValue("client_state", ClientState);
            writer.WriteStringValue("command_id", CommandId);
            writer.WriteBoolValue("end_conference_on_exit", EndConferenceOnExit);
            writer.WriteBoolValue("hold", Hold);
            writer.WriteStringValue("hold_audio_url", HoldAudioUrl);
            writer.WriteStringValue("hold_media_name", HoldMediaName);
            writer.WriteBoolValue("mute", Mute);
            writer.WriteBoolValue("soft_end_conference_on_exit", SoftEndConferenceOnExit);
            writer.WriteBoolValue("start_conference_on_enter", StartConferenceOnEnter);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.JoinConferenceRequest_supervisor_role>("supervisor_role", SupervisorRole);
            writer.WriteCollectionOfPrimitiveValues<string>("whisper_call_control_ids", WhisperCallControlIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
