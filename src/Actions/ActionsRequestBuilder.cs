// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Actions.Purchase;
using Soenneker.Telnyx.Actions.Register;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Actions
{
    /// <summary>
    /// Builds and executes requests for operations under \actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The purchase property</summary>
        public global::Soenneker.Telnyx.Actions.Purchase.PurchaseRequestBuilder Purchase
        {
            get => new global::Soenneker.Telnyx.Actions.Purchase.PurchaseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The register property</summary>
        public global::Soenneker.Telnyx.Actions.Register.RegisterRequestBuilder Register
        {
            get => new global::Soenneker.Telnyx.Actions.Register.RegisterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/actions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/actions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
