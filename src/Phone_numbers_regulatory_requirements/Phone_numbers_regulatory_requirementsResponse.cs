// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements
{
    [Obsolete("This class is obsolete. Use Phone_numbers_regulatory_requirementsGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Phone_numbers_regulatory_requirementsResponse : global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse();
        }
    }
}
#pragma warning restore CS0618
