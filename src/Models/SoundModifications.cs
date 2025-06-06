// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>
    /// Use this field to modify sound effects, for example adjust the pitch.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SoundModifications : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Adjust the pitch in octaves, values should be between -1 and 1, default 0</summary>
        public double? Octaves { get; set; }
        /// <summary>Set the pitch directly, value should be &gt; 0, default 1 (lower = lower tone)</summary>
        public double? Pitch { get; set; }
        /// <summary>Adjust the pitch in semitones, values should be between -14 and 14, default 0</summary>
        public double? Semitone { get; set; }
        /// <summary>The track to which the sound modifications will be applied. Accepted values are `inbound` or `outbound`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Track { get; set; }
#nullable restore
#else
        public string Track { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications"/> and sets the default values.
        /// </summary>
        public SoundModifications()
        {
            AdditionalData = new Dictionary<string, object>();
            Track = "outbound";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.SoundModifications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "octaves", n => { Octaves = n.GetDoubleValue(); } },
                { "pitch", n => { Pitch = n.GetDoubleValue(); } },
                { "semitone", n => { Semitone = n.GetDoubleValue(); } },
                { "track", n => { Track = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("octaves", Octaves);
            writer.WriteDoubleValue("pitch", Pitch);
            writer.WriteDoubleValue("semitone", Semitone);
            writer.WriteStringValue("track", Track);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
