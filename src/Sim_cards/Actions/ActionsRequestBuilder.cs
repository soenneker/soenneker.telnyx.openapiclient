// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Sim_cards.Actions.Bulk_set_public_ips;
using Soenneker.Telnyx.Sim_cards.Actions.Validate_registration_codes;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Sim_cards.Actions
{
    /// <summary>
    /// Builds and executes requests for operations under \sim_cards\actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The bulk_set_public_ips property</summary>
        public global::Soenneker.Telnyx.Sim_cards.Actions.Bulk_set_public_ips.Bulk_set_public_ipsRequestBuilder Bulk_set_public_ips
        {
            get => new global::Soenneker.Telnyx.Sim_cards.Actions.Bulk_set_public_ips.Bulk_set_public_ipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The validate_registration_codes property</summary>
        public global::Soenneker.Telnyx.Sim_cards.Actions.Validate_registration_codes.Validate_registration_codesRequestBuilder Validate_registration_codes
        {
            get => new global::Soenneker.Telnyx.Sim_cards.Actions.Validate_registration_codes.Validate_registration_codesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Sim_cards.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_cards/actions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Sim_cards.Actions.ActionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ActionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_cards/actions", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
