// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Set_standby
{
    [Obsolete("This class is obsolete. Use Set_standbyPostResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Set_standbyResponse : global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Set_standby.Set_standbyPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Set_standby.Set_standbyResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Set_standby.Set_standbyResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Sim_cards.Item.Actions.Set_standby.Set_standbyResponse();
        }
    }
}
#pragma warning restore CS0618
