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
    public partial class SpeakRequest : IAdditionalDataHolder, IParsable
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
        /// <summary>The language you want spoken. This parameter is ignored when a `Polly.*` voice is specified.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_language? Language { get; set; }
        /// <summary>The text or SSML to be converted into speech. There is a 3,000 character limit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Payload { get; set; }
#nullable restore
#else
        public string Payload { get; set; }
#endif
        /// <summary>The type of the provided payload. The payload can either be plain text, or Speech Synthesis Markup Language (SSML).</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_payload_type? PayloadType { get; set; }
        /// <summary>This parameter impacts speech quality, language options and payload types. When using `basic`, only the `en-US` language and payload type `text` are allowed.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_service_level? ServiceLevel { get; set; }
        /// <summary>When specified, it stops the current audio being played. Specify `current` to stop the current audio being played, and to play the next file in the queue. Specify `all` to stop the current audio file being played and to also clear all audio files from the queue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Stop { get; set; }
#nullable restore
#else
        public string Stop { get; set; }
#endif
        /// <summary>Specifies the voice used in speech synthesis.- Define voices using the format `&lt;Provider&gt;.&lt;Model&gt;.&lt;VoiceId&gt;`. Specifying only the provider will give default values for voice_id and model_id. **Supported Providers:**- **AWS:** Use `AWS.Polly.&lt;VoiceId&gt;` (e.g., `AWS.Polly.Joanna`). For neural voices, which provide more realistic, human-like speech, append `-Neural` to the `VoiceId` (e.g., `AWS.Polly.Joanna-Neural`). For long-form engine, append `-LongForm` to the `VoiceId` (e.g., `AWS.Polly.Danielle-LongForm`). For generative engine, the latest provided by AWS Polly, append `-Generative` to the `VoiceId` (e.g., `AWS.Polly.Danielle-Generative`). Check the [available voices](https://docs.aws.amazon.com/polly/latest/dg/available-voices.html) for compatibility.- **Azure:** Use `Azure.&lt;VoiceId&gt;. (e.g. Azure.en-CA-ClaraNeural, Azure.en-CA-LiamNeural, Azure.en-US-BrianMultilingualNeural, Azure.en-US-Ava:DragonHDLatestNeural. For a complete list of voices, go to [Azure Voice Gallery](https://speech.microsoft.com/portal/voicegallery).)- **ElevenLabs:** Use `ElevenLabs.&lt;ModelId&gt;.&lt;VoiceId&gt;` (e.g., `ElevenLabs.eleven_multilingual_v2.21m00Tcm4TlvDq8ikWAM`). The `ModelId` part is optional. To use ElevenLabs, you must provide your ElevenLabs API key as an integration identifier secret in `&quot;voice_settings&quot;: {&quot;api_key_ref&quot;: &quot;&lt;secret_identifier&gt;&quot;}`. See [integration secrets documentation](https://developers.telnyx.com/api/secrets-manager/integration-secrets/create-integration-secret) for details. Check [available voices](https://elevenlabs.io/docs/api-reference/get-voices). - **Telnyx:** Use `Telnyx.&lt;model_id&gt;.&lt;voice_id&gt;`For service_level basic, you may define the gender of the speaker (male or female).</summary>
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
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest"/> and sets the default values.
        /// </summary>
        public SpeakRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            PayloadType = global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_payload_type.Text;
            ServiceLevel = global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_service_level.Premium;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest();
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
                { "language", n => { Language = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_language>(); } },
                { "payload", n => { Payload = n.GetStringValue(); } },
                { "payload_type", n => { PayloadType = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_payload_type>(); } },
                { "service_level", n => { ServiceLevel = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_service_level>(); } },
                { "stop", n => { Stop = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_language>("language", Language);
            writer.WriteStringValue("payload", Payload);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_payload_type>("payload_type", PayloadType);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.SpeakRequest_service_level>("service_level", ServiceLevel);
            writer.WriteStringValue("stop", Stop);
            writer.WriteStringValue("voice", Voice);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ElevenLabsVoiceSettings>("voice_settings", VoiceSettings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
