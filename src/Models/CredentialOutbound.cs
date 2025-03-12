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
    public partial class CredentialOutbound : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Set a phone number as the ani_override value to override caller id number on outbound calls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AniOverride { get; set; }
#nullable restore
#else
        public string AniOverride { get; set; }
#endif
        /// <summary>Specifies when we apply your ani_override setting. Only applies when ani_override is not blank.</summary>
        public global::Soenneker.Telnyx.Models.CredentialOutbound_ani_override_type? AniOverrideType { get; set; }
        /// <summary>Forces all SIP calls originated on this connection to be &quot;parked&quot; instead of &quot;bridged&quot; to the destination specified on the URI. Parked calls will return ringback to the caller and will await for a Call Control command to define which action will be taken next.</summary>
        public bool? CallParkingEnabled { get; set; }
        /// <summary>When set, this will limit the total number of outbound calls to phone numbers associated with this connection.</summary>
        public int? ChannelLimit { get; set; }
        /// <summary>Generate ringback tone through 183 session progress message with early media.</summary>
        public bool? GenerateRingbackTone { get; set; }
        /// <summary>When set, ringback will not wait for indication before sending ringback tone to calling party.</summary>
        public bool? InstantRingbackEnabled { get; set; }
        /// <summary>A 2-character country code specifying the country whose national dialing rules should be used. For example, if set to `US` then any US number can be dialed without preprending +1 to the number. When left blank, Telnyx will try US and GB dialing rules, in that order, by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Localization { get; set; }
#nullable restore
#else
        public string Localization { get; set; }
#endif
        /// <summary>Identifies the associated outbound voice profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutboundVoiceProfileId { get; set; }
#nullable restore
#else
        public string OutboundVoiceProfileId { get; set; }
#endif
        /// <summary>This setting only affects connections with Fax-type Outbound Voice Profiles. The setting dictates whether or not Telnyx sends a t.38 reinvite.&lt;br/&gt;&lt;br/&gt; By default, Telnyx will send the re-invite. If set to `customer`, the caller is expected to send the t.38 reinvite.</summary>
        public global::Soenneker.Telnyx.Models.CredentialOutbound_t38_reinvite_source? T38ReinviteSource { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.CredentialOutbound"/> and sets the default values.
        /// </summary>
        public CredentialOutbound()
        {
            AdditionalData = new Dictionary<string, object>();
            AniOverrideType = global::Soenneker.Telnyx.Models.CredentialOutbound_ani_override_type.Always;
            Localization = "US";
            T38ReinviteSource = global::Soenneker.Telnyx.Models.CredentialOutbound_t38_reinvite_source.Telnyx;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.CredentialOutbound"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.CredentialOutbound CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.CredentialOutbound();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ani_override", n => { AniOverride = n.GetStringValue(); } },
                { "ani_override_type", n => { AniOverrideType = n.GetEnumValue<global::Soenneker.Telnyx.Models.CredentialOutbound_ani_override_type>(); } },
                { "call_parking_enabled", n => { CallParkingEnabled = n.GetBoolValue(); } },
                { "channel_limit", n => { ChannelLimit = n.GetIntValue(); } },
                { "generate_ringback_tone", n => { GenerateRingbackTone = n.GetBoolValue(); } },
                { "instant_ringback_enabled", n => { InstantRingbackEnabled = n.GetBoolValue(); } },
                { "localization", n => { Localization = n.GetStringValue(); } },
                { "outbound_voice_profile_id", n => { OutboundVoiceProfileId = n.GetStringValue(); } },
                { "t38_reinvite_source", n => { T38ReinviteSource = n.GetEnumValue<global::Soenneker.Telnyx.Models.CredentialOutbound_t38_reinvite_source>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ani_override", AniOverride);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.CredentialOutbound_ani_override_type>("ani_override_type", AniOverrideType);
            writer.WriteBoolValue("call_parking_enabled", CallParkingEnabled);
            writer.WriteIntValue("channel_limit", ChannelLimit);
            writer.WriteBoolValue("generate_ringback_tone", GenerateRingbackTone);
            writer.WriteBoolValue("instant_ringback_enabled", InstantRingbackEnabled);
            writer.WriteStringValue("localization", Localization);
            writer.WriteStringValue("outbound_voice_profile_id", OutboundVoiceProfileId);
            writer.WriteEnumValue<global::Soenneker.Telnyx.Models.CredentialOutbound_t38_reinvite_source>("t38_reinvite_source", T38ReinviteSource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
