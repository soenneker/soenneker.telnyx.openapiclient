// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Remove_public_ip
{
    [Obsolete("This class is obsolete. Use Remove_public_ipPostResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Remove_public_ipResponse : global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Remove_public_ip.Remove_public_ipPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Remove_public_ip.Remove_public_ipResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Remove_public_ip.Remove_public_ipResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Remove_public_ip.Remove_public_ipResponse();
        }
    }
}
#pragma warning restore CS0618
