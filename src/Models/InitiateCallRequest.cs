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
    public partial class InitiateCallRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the TeXML Application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationSid { get; set; }
#nullable restore
#else
        public string ApplicationSid { get; set; }
#endif
        /// <summary>Select whether to perform answering machine detection in the background. By default execution is blocked until Answering Machine Detection is completed.</summary>
        public bool? AsyncAmd { get; set; }
        /// <summary>URL destination for Telnyx to send AMD callback events to for the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AsyncAmdStatusCallback { get; set; }
#nullable restore
#else
        public string AsyncAmdStatusCallback { get; set; }
#endif
        /// <summary>HTTP request type used for `AsyncAmdStatusCallback`. The default value is inherited from TeXML Application setting.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_AsyncAmdStatusCallbackMethod? AsyncAmdStatusCallbackMethod { get; set; }
        /// <summary>To be used as the caller id name (SIP From Display Name) presented to the destination (`To` number). The string should have a maximum of 128 characters, containing only letters, numbers, spaces, and `-_~!.+` special characters. If ommited, the display name will be the same as the number in the `From` field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallerId { get; set; }
#nullable restore
#else
        public string CallerId { get; set; }
#endif
        /// <summary>Whether to cancel ongoing playback on `greeting ended` detection. Defaults to `true`.</summary>
        public bool? CancelPlaybackOnDetectMessageEnd { get; set; }
        /// <summary>Whether to cancel ongoing playback on `machine` detection. Defaults to `true`.</summary>
        public bool? CancelPlaybackOnMachineDetection { get; set; }
        /// <summary>Allows you to chose between Premium and Standard detections.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_DetectionMode? DetectionMode { get; set; }
        /// <summary>A failover URL for which Telnyx will retrieve the TeXML call instructions if the `Url` is not responding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FallbackUrl { get; set; }
#nullable restore
#else
        public string FallbackUrl { get; set; }
#endif
        /// <summary>The phone number of the party that initiated the call. Phone numbers are formatted with a `+` and country code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? From { get; set; }
#nullable restore
#else
        public string From { get; set; }
#endif
        /// <summary>Enables Answering Machine Detection.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_MachineDetection? MachineDetection { get; set; }
        /// <summary>If initial silence duration is greater than this value, consider it a machine. Ignored when `premium` detection is used.</summary>
        public int? MachineDetectionSilenceTimeout { get; set; }
        /// <summary>Silence duration threshold after a greeting message or voice for it be considered human. Ignored when `premium` detection is used.</summary>
        public int? MachineDetectionSpeechEndThreshold { get; set; }
        /// <summary>Maximum threshold of a human greeting. If greeting longer than this value, considered machine. Ignored when `premium` detection is used.</summary>
        public int? MachineDetectionSpeechThreshold { get; set; }
        /// <summary>Maximum timeout threshold in milliseconds for overall detection.</summary>
        public int? MachineDetectionTimeout { get; set; }
        /// <summary>The list of comma-separated codecs to be offered on a call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredCodecs { get; set; }
#nullable restore
#else
        public string PreferredCodecs { get; set; }
#endif
        /// <summary>Whether to record the entire participant&apos;s call leg. Defaults to `false`.</summary>
        public bool? Record { get; set; }
        /// <summary>The number of channels in the final recording. Defaults to `mono`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingChannels? RecordingChannels { get; set; }
        /// <summary>The URL the recording callbacks will be sent to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingStatusCallback { get; set; }
#nullable restore
#else
        public string RecordingStatusCallback { get; set; }
#endif
        /// <summary>The changes to the recording&apos;s state that should generate a call to `RecoridngStatusCallback`. Can be: `in-progress`, `completed` and `absent`. Separate multiple values with a space. Defaults to `completed`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecordingStatusCallbackEvent { get; set; }
#nullable restore
#else
        public string RecordingStatusCallbackEvent { get; set; }
#endif
        /// <summary>HTTP request type used for `RecordingStatusCallback`. Defaults to `POST`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingStatusCallbackMethod? RecordingStatusCallbackMethod { get; set; }
        /// <summary>The number of seconds that Telnyx will wait for the recording to be stopped if silence is detected. The timer only starts when the speech is detected. Please note that the transcription is used to detect silence and the related charge will be applied. The minimum value is 0. The default value is 0 (infinite)</summary>
        public int? RecordingTimeout { get; set; }
        /// <summary>The audio track to record for the call. The default is `both`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingTrack? RecordingTrack { get; set; }
        /// <summary>Whether to send RecordingUrl in webhooks.</summary>
        public bool? SendRecordingUrl { get; set; }
        /// <summary>The password to use for SIP authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SipAuthPassword { get; set; }
#nullable restore
#else
        public string SipAuthPassword { get; set; }
#endif
        /// <summary>The username to use for SIP authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SipAuthUsername { get; set; }
#nullable restore
#else
        public string SipAuthUsername { get; set; }
#endif
        /// <summary>URL destination for Telnyx to send status callback events to for the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusCallback { get; set; }
#nullable restore
#else
        public string StatusCallback { get; set; }
#endif
        /// <summary>The call events for which Telnyx should send a webhook. Multiple events can be defined when separated by a space.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackEvent? StatusCallbackEvent { get; set; }
        /// <summary>HTTP request type used for `StatusCallback`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackMethod? StatusCallbackMethod { get; set; }
        /// <summary>The phone number of the called party. Phone numbers are formatted with a `+` and country code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>Whether to trim any leading and trailing silence from the recording. Defaults to `trim-silence`.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_Trim? Trim { get; set; }
        /// <summary>The URL from which Telnyx will retrieve the TeXML call instructions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>HTTP request type used for `Url`. The default value is inherited from TeXML Application setting.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_UrlMethod? UrlMethod { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest"/> and sets the default values.
        /// </summary>
        public InitiateCallRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            AsyncAmdStatusCallbackMethod = global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_AsyncAmdStatusCallbackMethod.POST;
            DetectionMode = global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_DetectionMode.Regular;
            MachineDetection = global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_MachineDetection.Disable;
            StatusCallbackEvent = global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackEvent.Completed;
            StatusCallbackMethod = global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackMethod.POST;
            UrlMethod = global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_UrlMethod.POST;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ApplicationSid", n => { ApplicationSid = n.GetStringValue(); } },
                { "AsyncAmd", n => { AsyncAmd = n.GetBoolValue(); } },
                { "AsyncAmdStatusCallback", n => { AsyncAmdStatusCallback = n.GetStringValue(); } },
                { "AsyncAmdStatusCallbackMethod", n => { AsyncAmdStatusCallbackMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_AsyncAmdStatusCallbackMethod>(); } },
                { "CallerId", n => { CallerId = n.GetStringValue(); } },
                { "CancelPlaybackOnDetectMessageEnd", n => { CancelPlaybackOnDetectMessageEnd = n.GetBoolValue(); } },
                { "CancelPlaybackOnMachineDetection", n => { CancelPlaybackOnMachineDetection = n.GetBoolValue(); } },
                { "DetectionMode", n => { DetectionMode = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_DetectionMode>(); } },
                { "FallbackUrl", n => { FallbackUrl = n.GetStringValue(); } },
                { "From", n => { From = n.GetStringValue(); } },
                { "MachineDetection", n => { MachineDetection = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_MachineDetection>(); } },
                { "MachineDetectionSilenceTimeout", n => { MachineDetectionSilenceTimeout = n.GetIntValue(); } },
                { "MachineDetectionSpeechEndThreshold", n => { MachineDetectionSpeechEndThreshold = n.GetIntValue(); } },
                { "MachineDetectionSpeechThreshold", n => { MachineDetectionSpeechThreshold = n.GetIntValue(); } },
                { "MachineDetectionTimeout", n => { MachineDetectionTimeout = n.GetIntValue(); } },
                { "PreferredCodecs", n => { PreferredCodecs = n.GetStringValue(); } },
                { "Record", n => { Record = n.GetBoolValue(); } },
                { "RecordingChannels", n => { RecordingChannels = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingChannels>(); } },
                { "RecordingStatusCallback", n => { RecordingStatusCallback = n.GetStringValue(); } },
                { "RecordingStatusCallbackEvent", n => { RecordingStatusCallbackEvent = n.GetStringValue(); } },
                { "RecordingStatusCallbackMethod", n => { RecordingStatusCallbackMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingStatusCallbackMethod>(); } },
                { "RecordingTimeout", n => { RecordingTimeout = n.GetIntValue(); } },
                { "RecordingTrack", n => { RecordingTrack = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingTrack>(); } },
                { "SendRecordingUrl", n => { SendRecordingUrl = n.GetBoolValue(); } },
                { "SipAuthPassword", n => { SipAuthPassword = n.GetStringValue(); } },
                { "SipAuthUsername", n => { SipAuthUsername = n.GetStringValue(); } },
                { "StatusCallback", n => { StatusCallback = n.GetStringValue(); } },
                { "StatusCallbackEvent", n => { StatusCallbackEvent = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackEvent>(); } },
                { "StatusCallbackMethod", n => { StatusCallbackMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackMethod>(); } },
                { "To", n => { To = n.GetStringValue(); } },
                { "Trim", n => { Trim = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_Trim>(); } },
                { "Url", n => { Url = n.GetStringValue(); } },
                { "UrlMethod", n => { UrlMethod = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_UrlMethod>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ApplicationSid", ApplicationSid);
            writer.WriteBoolValue("AsyncAmd", AsyncAmd);
            writer.WriteStringValue("AsyncAmdStatusCallback", AsyncAmdStatusCallback);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_AsyncAmdStatusCallbackMethod>("AsyncAmdStatusCallbackMethod", AsyncAmdStatusCallbackMethod);
            writer.WriteStringValue("CallerId", CallerId);
            writer.WriteBoolValue("CancelPlaybackOnDetectMessageEnd", CancelPlaybackOnDetectMessageEnd);
            writer.WriteBoolValue("CancelPlaybackOnMachineDetection", CancelPlaybackOnMachineDetection);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_DetectionMode>("DetectionMode", DetectionMode);
            writer.WriteStringValue("FallbackUrl", FallbackUrl);
            writer.WriteStringValue("From", From);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_MachineDetection>("MachineDetection", MachineDetection);
            writer.WriteIntValue("MachineDetectionSilenceTimeout", MachineDetectionSilenceTimeout);
            writer.WriteIntValue("MachineDetectionSpeechEndThreshold", MachineDetectionSpeechEndThreshold);
            writer.WriteIntValue("MachineDetectionSpeechThreshold", MachineDetectionSpeechThreshold);
            writer.WriteIntValue("MachineDetectionTimeout", MachineDetectionTimeout);
            writer.WriteStringValue("PreferredCodecs", PreferredCodecs);
            writer.WriteBoolValue("Record", Record);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingChannels>("RecordingChannels", RecordingChannels);
            writer.WriteStringValue("RecordingStatusCallback", RecordingStatusCallback);
            writer.WriteStringValue("RecordingStatusCallbackEvent", RecordingStatusCallbackEvent);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingStatusCallbackMethod>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod);
            writer.WriteIntValue("RecordingTimeout", RecordingTimeout);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_RecordingTrack>("RecordingTrack", RecordingTrack);
            writer.WriteBoolValue("SendRecordingUrl", SendRecordingUrl);
            writer.WriteStringValue("SipAuthPassword", SipAuthPassword);
            writer.WriteStringValue("SipAuthUsername", SipAuthUsername);
            writer.WriteStringValue("StatusCallback", StatusCallback);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackEvent>("StatusCallbackEvent", StatusCallbackEvent);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_StatusCallbackMethod>("StatusCallbackMethod", StatusCallbackMethod);
            writer.WriteStringValue("To", To);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_Trim>("Trim", Trim);
            writer.WriteStringValue("Url", Url);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.InitiateCallRequest_UrlMethod>("UrlMethod", UrlMethod);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
