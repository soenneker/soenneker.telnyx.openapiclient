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
    public partial class TransferCallRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Enables Answering Machine Detection. When a call is answered, Telnyx runs real-time detection to determine if it was picked up by a human or a machine and sends an `call.machine.detection.ended` webhook with the analysis result. If &apos;greeting_end&apos; or &apos;detect_words&apos; is used and a &apos;machine&apos; is detected, you will receive another &apos;call.machine.greeting.ended&apos; webhook when the answering machine greeting ends with a beep or silence. If `detect_beep` is used, you will only receive &apos;call.machine.greeting.ended&apos; if a beep is detected.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection? AnsweringMachineDetection { get; set; }
        /// <summary>Optional configuration parameters to modify &apos;answering_machine_detection&apos; performance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection_config? AnsweringMachineDetectionConfig { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection_config AnsweringMachineDetectionConfig { get; set; }
#endif
        /// <summary>The URL of a file to be played back when the transfer destination answers before bridging the call. The URL can point to either a WAV or MP3 file. media_name and audio_url cannot be used together in one request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioUrl { get; set; }
#nullable restore
#else
        public string AudioUrl { get; set; }
#endif
        /// <summary>Use this field to add state to every subsequent webhook. It must be a valid Base-64 encoded string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientState { get; set; }
#nullable restore
#else
        public string ClientState { get; set; }
#endif
        /// <summary>Use this field to avoid duplicate commands. Telnyx will ignore any command with the same `command_id` for the same `call_control_id`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommandId { get; set; }
#nullable restore
#else
        public string CommandId { get; set; }
#endif
        /// <summary>Custom headers to be added to the SIP INVITE.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CustomSipHeader>? CustomHeaders { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.CustomSipHeader> CustomHeaders { get; set; }
#endif
        /// <summary>If set to false, early media will not be passed to the originating leg.</summary>
        public bool? EarlyMedia { get; set; }
        /// <summary>The `from` number to be used as the caller id presented to the destination (`to` number). The number should be in +E164 format. This attribute will default to the `to` number of the original call if omitted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? From { get; set; }
#nullable restore
#else
        public string From { get; set; }
#endif
        /// <summary>The `from_display_name` string to be used as the caller id name (SIP From Display Name) presented to the destination (`to` number). The string should have a maximum of 128 characters, containing only letters, numbers, spaces, and -_~!.+ special characters. If ommited, the display name will be the same as the number in the `from` field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromDisplayName { get; set; }
#nullable restore
#else
        public string FromDisplayName { get; set; }
#endif
        /// <summary>Defines whether media should be encrypted on the new call leg.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_media_encryption? MediaEncryption { get; set; }
        /// <summary>The media_name of a file to be played back when the transfer destination answers before bridging the call. The media_name must point to a file previously uploaded to api.telnyx.com/v2/media by the same user/organization. The file must either be a WAV or MP3 file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaName { get; set; }
#nullable restore
#else
        public string MediaName { get; set; }
#endif
        /// <summary>SIP Authentication password used for SIP challenges.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SipAuthPassword { get; set; }
#nullable restore
#else
        public string SipAuthPassword { get; set; }
#endif
        /// <summary>SIP Authentication username used for SIP challenges.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SipAuthUsername { get; set; }
#nullable restore
#else
        public string SipAuthUsername { get; set; }
#endif
        /// <summary>SIP headers to be added to the SIP INVITE. Currently only User-to-User header is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.SipHeader>? SipHeaders { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.SipHeader> SipHeaders { get; set; }
#endif
        /// <summary>Defines SIP transport protocol to be used on the call.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_sip_transport_protocol? SipTransportProtocol { get; set; }
        /// <summary>Use this field to modify sound effects, for example adjust the pitch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications? SoundModifications { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications SoundModifications { get; set; }
#endif
        /// <summary>Use this field to add state to every subsequent webhook for the new leg. It must be a valid Base-64 encoded string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetLegClientState { get; set; }
#nullable restore
#else
        public string TargetLegClientState { get; set; }
#endif
        /// <summary>Sets the maximum duration of a Call Control Leg in seconds. If the time limit is reached, the call will hangup and a `call.hangup` webhook with a `hangup_cause` of `time_limit` will be sent. For example, by setting a time limit of 120 seconds, a Call Leg will be automatically terminated two minutes after being answered. The default time limit is 14400 seconds or 4 hours and this is also the maximum allowed call length.</summary>
        public int? TimeLimitSecs { get; set; }
        /// <summary>The number of seconds that Telnyx will wait for the call to be answered by the destination to which it is being transferred. If the timeout is reached before an answer is received, the call will hangup and a `call.hangup` webhook with a `hangup_cause` of `timeout` will be sent. Minimum value is 5 seconds. Maximum value is 600 seconds.</summary>
        public int? TimeoutSecs { get; set; }
        /// <summary>The DID or SIP URI to dial out to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>Use this field to override the URL for which Telnyx will send subsequent webhooks to for this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebhookUrl { get; set; }
#nullable restore
#else
        public string WebhookUrl { get; set; }
#endif
        /// <summary>HTTP request type used for `webhook_url`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_webhook_url_method? WebhookUrlMethod { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest"/> and sets the default values.
        /// </summary>
        public TransferCallRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            AnsweringMachineDetection = global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection.Disabled;
            MediaEncryption = global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_media_encryption.Disabled;
            SipTransportProtocol = global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_sip_transport_protocol.UDP;
            WebhookUrlMethod = global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_webhook_url_method.POST;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "answering_machine_detection", n => { AnsweringMachineDetection = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection>(); } },
                { "answering_machine_detection_config", n => { AnsweringMachineDetectionConfig = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection_config>(global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection_config.CreateFromDiscriminatorValue); } },
                { "audio_url", n => { AudioUrl = n.GetStringValue(); } },
                { "client_state", n => { ClientState = n.GetStringValue(); } },
                { "command_id", n => { CommandId = n.GetStringValue(); } },
                { "custom_headers", n => { CustomHeaders = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.CustomSipHeader>(global::Soenneker.Telnyx.OpenApiClient.Models.CustomSipHeader.CreateFromDiscriminatorValue)?.AsList(); } },
                { "early_media", n => { EarlyMedia = n.GetBoolValue(); } },
                { "from", n => { From = n.GetStringValue(); } },
                { "from_display_name", n => { FromDisplayName = n.GetStringValue(); } },
                { "media_encryption", n => { MediaEncryption = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_media_encryption>(); } },
                { "media_name", n => { MediaName = n.GetStringValue(); } },
                { "sip_auth_password", n => { SipAuthPassword = n.GetStringValue(); } },
                { "sip_auth_username", n => { SipAuthUsername = n.GetStringValue(); } },
                { "sip_headers", n => { SipHeaders = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.SipHeader>(global::Soenneker.Telnyx.OpenApiClient.Models.SipHeader.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sip_transport_protocol", n => { SipTransportProtocol = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_sip_transport_protocol>(); } },
                { "sound_modifications", n => { SoundModifications = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications>(global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications.CreateFromDiscriminatorValue); } },
                { "target_leg_client_state", n => { TargetLegClientState = n.GetStringValue(); } },
                { "time_limit_secs", n => { TimeLimitSecs = n.GetIntValue(); } },
                { "timeout_secs", n => { TimeoutSecs = n.GetIntValue(); } },
                { "to", n => { To = n.GetStringValue(); } },
                { "webhook_url", n => { WebhookUrl = n.GetStringValue(); } },
                { "webhook_url_method", n => { WebhookUrlMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_webhook_url_method>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection>("answering_machine_detection", AnsweringMachineDetection);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_answering_machine_detection_config>("answering_machine_detection_config", AnsweringMachineDetectionConfig);
            writer.WriteStringValue("audio_url", AudioUrl);
            writer.WriteStringValue("client_state", ClientState);
            writer.WriteStringValue("command_id", CommandId);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.CustomSipHeader>("custom_headers", CustomHeaders);
            writer.WriteBoolValue("early_media", EarlyMedia);
            writer.WriteStringValue("from", From);
            writer.WriteStringValue("from_display_name", FromDisplayName);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_media_encryption>("media_encryption", MediaEncryption);
            writer.WriteStringValue("media_name", MediaName);
            writer.WriteStringValue("sip_auth_password", SipAuthPassword);
            writer.WriteStringValue("sip_auth_username", SipAuthUsername);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.SipHeader>("sip_headers", SipHeaders);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_sip_transport_protocol>("sip_transport_protocol", SipTransportProtocol);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications>("sound_modifications", SoundModifications);
            writer.WriteStringValue("target_leg_client_state", TargetLegClientState);
            writer.WriteIntValue("time_limit_secs", TimeLimitSecs);
            writer.WriteIntValue("timeout_secs", TimeoutSecs);
            writer.WriteStringValue("to", To);
            writer.WriteStringValue("webhook_url", WebhookUrl);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.TransferCallRequest_webhook_url_method>("webhook_url_method", WebhookUrlMethod);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
