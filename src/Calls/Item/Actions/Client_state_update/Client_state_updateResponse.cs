// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Calls.Item.Actions.Client_state_update
{
    [Obsolete("This class is obsolete. Use Client_state_updatePutResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Client_state_updateResponse : global::Soenneker.Telnyx.Calls.Item.Actions.Client_state_update.Client_state_updatePutResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Calls.Item.Actions.Client_state_update.Client_state_updateResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.Calls.Item.Actions.Client_state_update.Client_state_updateResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Calls.Item.Actions.Client_state_update.Client_state_updateResponse();
        }
    }
}
#pragma warning restore CS0618
