// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Sim_cards.Item.Actions.Disable;
using Soenneker.Telnyx.Sim_cards.Item.Actions.Enable;
using Soenneker.Telnyx.Sim_cards.Item.Actions.Remove_public_ip;
using Soenneker.Telnyx.Sim_cards.Item.Actions.Set_public_ip;
using Soenneker.Telnyx.Sim_cards.Item.Actions.Set_standby;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Sim_cards.Item.Actions
{
    /// <summary>
    /// Builds and executes requests for operations under \sim_cards\{id}\actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The disable property</summary>
        public global::Soenneker.Telnyx.Sim_cards.Item.Actions.Disable.DisableRequestBuilder Disable
        {
            get => new global::Soenneker.Telnyx.Sim_cards.Item.Actions.Disable.DisableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enable property</summary>
        public global::Soenneker.Telnyx.Sim_cards.Item.Actions.Enable.EnableRequestBuilder Enable
        {
            get => new global::Soenneker.Telnyx.Sim_cards.Item.Actions.Enable.EnableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The remove_public_ip property</summary>
        public global::Soenneker.Telnyx.Sim_cards.Item.Actions.Remove_public_ip.Remove_public_ipRequestBuilder Remove_public_ip
        {
            get => new global::Soenneker.Telnyx.Sim_cards.Item.Actions.Remove_public_ip.Remove_public_ipRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The set_public_ip property</summary>
        public global::Soenneker.Telnyx.Sim_cards.Item.Actions.Set_public_ip.Set_public_ipRequestBuilder Set_public_ip
        {
            get => new global::Soenneker.Telnyx.Sim_cards.Item.Actions.Set_public_ip.Set_public_ipRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The set_standby property</summary>
        public global::Soenneker.Telnyx.Sim_cards.Item.Actions.Set_standby.Set_standbyRequestBuilder Set_standby
        {
            get => new global::Soenneker.Telnyx.Sim_cards.Item.Actions.Set_standby.Set_standbyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Sim_cards.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_cards/{id}/actions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Sim_cards.Item.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_cards/{id}/actions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
