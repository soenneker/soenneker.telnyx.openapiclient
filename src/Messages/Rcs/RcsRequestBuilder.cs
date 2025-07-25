// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Messages.Rcs.Deeplinks;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Messages.Rcs
{
    /// <summary>
    /// Builds and executes requests for operations under \messages\rcs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RcsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The deeplinks property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Messages.Rcs.Deeplinks.DeeplinksRequestBuilder Deeplinks
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Messages.Rcs.Deeplinks.DeeplinksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.Rcs.RcsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RcsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/messages/rcs", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Messages.Rcs.RcsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RcsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/messages/rcs", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
