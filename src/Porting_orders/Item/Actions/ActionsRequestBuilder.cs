// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Porting_orders.Item.Actions.Activate;
using Soenneker.Telnyx.Porting_orders.Item.Actions.Cancel;
using Soenneker.Telnyx.Porting_orders.Item.Actions.Confirm;
using Soenneker.Telnyx.Porting_orders.Item.Actions.Share;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Porting_orders.Item.Actions
{
    /// <summary>
    /// Builds and executes requests for operations under \porting_orders\{-id}\actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The activate property</summary>
        public global::Soenneker.Telnyx.Porting_orders.Item.Actions.Activate.ActivateRequestBuilder Activate
        {
            get => new global::Soenneker.Telnyx.Porting_orders.Item.Actions.Activate.ActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cancel property</summary>
        public global::Soenneker.Telnyx.Porting_orders.Item.Actions.Cancel.CancelRequestBuilder Cancel
        {
            get => new global::Soenneker.Telnyx.Porting_orders.Item.Actions.Cancel.CancelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The confirm property</summary>
        public global::Soenneker.Telnyx.Porting_orders.Item.Actions.Confirm.ConfirmRequestBuilder Confirm
        {
            get => new global::Soenneker.Telnyx.Porting_orders.Item.Actions.Confirm.ConfirmRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The share property</summary>
        public global::Soenneker.Telnyx.Porting_orders.Item.Actions.Share.ShareRequestBuilder Share
        {
            get => new global::Soenneker.Telnyx.Porting_orders.Item.Actions.Share.ShareRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting_orders.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting_orders/{%2Did}/actions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting_orders.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting_orders/{%2Did}/actions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
