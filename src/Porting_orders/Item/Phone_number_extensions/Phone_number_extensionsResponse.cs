// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Porting_orders.Item.Phone_number_extensions
{
    [Obsolete("This class is obsolete. Use Phone_number_extensionsGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Phone_number_extensionsResponse : global::Soenneker.Telnyx.Porting_orders.Item.Phone_number_extensions.Phone_number_extensionsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting_orders.Item.Phone_number_extensions.Phone_number_extensionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.Porting_orders.Item.Phone_number_extensions.Phone_number_extensionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Porting_orders.Item.Phone_number_extensions.Phone_number_extensionsResponse();
        }
    }
}
#pragma warning restore CS0618
