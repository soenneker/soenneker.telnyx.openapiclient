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
    public partial class GatherUsingSpeakRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
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
        /// <summary>The number of milliseconds to wait for input between digits.</summary>
        public int? InterDigitTimeoutMillis { get; set; }
        /// <summary>The text or SSML to be converted into speech when digits don&apos;t match the `valid_digits` parameter or the number of digits is not between `min` and `max`. There is a 3,000 character limit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvalidPayload { get; set; }
#nullable restore
#else
        public string InvalidPayload { get; set; }
#endif
        /// <summary>The language you want spoken. This parameter is ignored when a `Polly.*` voice is specified.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_language? Language { get; set; }
        /// <summary>The maximum number of digits to fetch. This parameter has a maximum value of 128.</summary>
        public int? MaximumDigits { get; set; }
        /// <summary>The maximum number of times that a file should be played back if there is no input from the user on the call.</summary>
        public int? MaximumTries { get; set; }
        /// <summary>The minimum number of digits to fetch. This parameter has a minimum value of 1.</summary>
        public int? MinimumDigits { get; set; }
        /// <summary>The text or SSML to be converted into speech. There is a 3,000 character limit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Payload { get; set; }
#nullable restore
#else
        public string Payload { get; set; }
#endif
        /// <summary>The type of the provided payload. The payload can either be plain text, or Speech Synthesis Markup Language (SSML).</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_payload_type? PayloadType { get; set; }
        /// <summary>This parameter impacts speech quality, language options and payload types. When using `basic`, only the `en-US` language and payload type `text` are allowed.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_service_level? ServiceLevel { get; set; }
        /// <summary>The digit used to terminate input if fewer than `maximum_digits` digits have been gathered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TerminatingDigit { get; set; }
#nullable restore
#else
        public string TerminatingDigit { get; set; }
#endif
        /// <summary>The number of milliseconds to wait for a DTMF response after speak ends before a replaying the sound file.</summary>
        public int? TimeoutMillis { get; set; }
        /// <summary>A list of all digits accepted as valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValidDigits { get; set; }
#nullable restore
#else
        public string ValidDigits { get; set; }
#endif
        /// <summary>Specifies the voice used in speech synthesis.- Define voices using the format `&lt;Provider&gt;.&lt;Model&gt;.&lt;VoiceId&gt;`. Specifying only the provider will give default values for voice_id and model_id. **Supported Providers:**- **AWS:** Use `AWS.Polly.&lt;VoiceId&gt;` (e.g., `AWS.Polly.Joanna`). For neural voices, which provide more realistic, human-like speech, append `-Neural` to the `VoiceId` (e.g., `AWS.Polly.Joanna-Neural`). Check the [available voices](https://docs.aws.amazon.com/polly/latest/dg/available-voices.html) for compatibility.- **Azure:** Use `Azure.&lt;VoiceId&gt;. (e.g. Azure.en-CA-ClaraNeural, Azure.en-CA-LiamNeural, Azure.en-US-BrianMultilingualNeural, Azure.en-US-AvaMultilingualNeural. For a complete list of voices, go to [Azure Voice Gallery](https://speech.microsoft.com/portal/voicegallery).)- **ElevenLabs:** Use `ElevenLabs.&lt;ModelId&gt;.&lt;VoiceId&gt;` (e.g., `ElevenLabs.eleven_multilingual_v2.21m00Tcm4TlvDq8ikWAM`). The `ModelId` part is optional. To use ElevenLabs, you must provide your ElevenLabs API key as an integration identifier secret in `&quot;voice_settings&quot;: {&quot;api_key_ref&quot;: &quot;&lt;secret_identifier&gt;&quot;}`. See [integration secrets documentation](https://developers.telnyx.com/api/secrets-manager/integration-secrets/create-integration-secret) for details. Check [available voices](https://elevenlabs.io/docs/api-reference/get-voices). - **Telnyx:** Use `Telnyx.&lt;model_id&gt;.&lt;voice_id&gt;`For service_level basic, you may define the gender of the speaker (male or female).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Voice { get; set; }
#nullable restore
#else
        public string Voice { get; set; }
#endif
        /// <summary>The settings associated with the voice selected</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.ElevenLabsVoiceSettings? VoiceSettings { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.ElevenLabsVoiceSettings VoiceSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest"/> and sets the default values.
        /// </summary>
        public GatherUsingSpeakRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            PayloadType = global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_payload_type.Text;
            ServiceLevel = global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_service_level.Premium;
            TerminatingDigit = "#";
            ValidDigits = "0123456789#*";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "client_state", n => { ClientState = n.GetStringValue(); } },
                { "command_id", n => { CommandId = n.GetStringValue(); } },
                { "inter_digit_timeout_millis", n => { InterDigitTimeoutMillis = n.GetIntValue(); } },
                { "invalid_payload", n => { InvalidPayload = n.GetStringValue(); } },
                { "language", n => { Language = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_language>(); } },
                { "maximum_digits", n => { MaximumDigits = n.GetIntValue(); } },
                { "maximum_tries", n => { MaximumTries = n.GetIntValue(); } },
                { "minimum_digits", n => { MinimumDigits = n.GetIntValue(); } },
                { "payload", n => { Payload = n.GetStringValue(); } },
                { "payload_type", n => { PayloadType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_payload_type>(); } },
                { "service_level", n => { ServiceLevel = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_service_level>(); } },
                { "terminating_digit", n => { TerminatingDigit = n.GetStringValue(); } },
                { "timeout_millis", n => { TimeoutMillis = n.GetIntValue(); } },
                { "valid_digits", n => { ValidDigits = n.GetStringValue(); } },
                { "voice", n => { Voice = n.GetStringValue(); } },
                { "voice_settings", n => { VoiceSettings = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ElevenLabsVoiceSettings>(global::Soenneker.Telnyx.OpenApiClient.Models.ElevenLabsVoiceSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("client_state", ClientState);
            writer.WriteStringValue("command_id", CommandId);
            writer.WriteIntValue("inter_digit_timeout_millis", InterDigitTimeoutMillis);
            writer.WriteStringValue("invalid_payload", InvalidPayload);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_language>("language", Language);
            writer.WriteIntValue("maximum_digits", MaximumDigits);
            writer.WriteIntValue("maximum_tries", MaximumTries);
            writer.WriteIntValue("minimum_digits", MinimumDigits);
            writer.WriteStringValue("payload", Payload);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_payload_type>("payload_type", PayloadType);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.GatherUsingSpeakRequest_service_level>("service_level", ServiceLevel);
            writer.WriteStringValue("terminating_digit", TerminatingDigit);
            writer.WriteIntValue("timeout_millis", TimeoutMillis);
            writer.WriteStringValue("valid_digits", ValidDigits);
            writer.WriteStringValue("voice", Voice);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ElevenLabsVoiceSettings>("voice_settings", VoiceSettings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
