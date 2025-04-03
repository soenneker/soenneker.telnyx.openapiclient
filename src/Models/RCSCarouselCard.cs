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
    /// Carousel of cards.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RCSCarouselCard : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of contents for each card in the carousel. A carousel can have a minimum of 2 cards and a maximum 10 cards.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.RCSCardContent>? CardContents { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.RCSCardContent> CardContents { get; set; }
#endif
        /// <summary>The width of the cards in the carousel.</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.RCSCarouselCard_card_width? CardWidth { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.RCSCarouselCard"/> and sets the default values.
        /// </summary>
        public RCSCarouselCard()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.RCSCarouselCard"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.RCSCarouselCard CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.RCSCarouselCard();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "card_contents", n => { CardContents = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.RCSCardContent>(global::Soenneker.Telnyx.OpenApiClient.Models.RCSCardContent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "card_width", n => { CardWidth = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.RCSCarouselCard_card_width>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.RCSCardContent>("card_contents", CardContents);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.RCSCarouselCard_card_width>("card_width", CardWidth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
