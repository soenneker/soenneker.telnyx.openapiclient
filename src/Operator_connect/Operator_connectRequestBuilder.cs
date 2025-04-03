// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Operator_connect.Actions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Operator_connect
{
    /// <summary>
    /// Builds and executes requests for operations under \operator_connect
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Operator_connectRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The actions property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Operator_connect.Actions.ActionsRequestBuilder Actions
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Operator_connect.Actions.ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Operator_connect.Operator_connectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Operator_connectRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/operator_connect", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Operator_connect.Operator_connectRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Operator_connectRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/operator_connect", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
