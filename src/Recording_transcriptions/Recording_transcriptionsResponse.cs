// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.Recording_transcriptions
{
    [Obsolete("This class is obsolete. Use Recording_transcriptionsGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Recording_transcriptionsResponse : global::Soenneker.Telnyx.Recording_transcriptions.Recording_transcriptionsGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Recording_transcriptions.Recording_transcriptionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Soenneker.Telnyx.Recording_transcriptions.Recording_transcriptionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.Recording_transcriptions.Recording_transcriptionsResponse();
        }
    }
}
#pragma warning restore CS0618
