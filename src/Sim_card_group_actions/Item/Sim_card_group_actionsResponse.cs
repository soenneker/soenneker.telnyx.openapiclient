// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Sim_card_group_actions.Item
{
    [Obsolete("This class is obsolete. Use Sim_card_group_actionsGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Sim_card_group_actionsResponse : global::Soenneker.Telnyx.Sim_card_group_actions.Item.Sim_card_group_actionsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Sim_card_group_actions.Item.Sim_card_group_actionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.Sim_card_group_actions.Item.Sim_card_group_actionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Sim_card_group_actions.Item.Sim_card_group_actionsResponse();
        }
    }
}
#pragma warning restore CS0618
