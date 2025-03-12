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
    public partial class CountryCoverage_local : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The features property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Features { get; set; }
#nullable restore
#else
        public List<string> Features { get; set; }
#endif
        /// <summary>The international_sms property</summary>
        public bool? InternationalSms { get; set; }
        /// <summary>The p2p property</summary>
        public bool? P2p { get; set; }
        /// <summary>The quickship property</summary>
        public bool? Quickship { get; set; }
        /// <summary>The reservable property</summary>
        public bool? Reservable { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Models.CountryCoverage_local"/> and sets the default values.
        /// </summary>
        public CountryCoverage_local()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.CountryCoverage_local"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.Models.CountryCoverage_local CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Models.CountryCoverage_local();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "features", n => { Features = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "international_sms", n => { InternationalSms = n.GetBoolValue(); } },
                { "p2p", n => { P2p = n.GetBoolValue(); } },
                { "quickship", n => { Quickship = n.GetBoolValue(); } },
                { "reservable", n => { Reservable = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("features", Features);
            writer.WriteBoolValue("international_sms", InternationalSms);
            writer.WriteBoolValue("p2p", P2p);
            writer.WriteBoolValue("quickship", Quickship);
            writer.WriteBoolValue("reservable", Reservable);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
