// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Payment.Auto_recharge_prefs;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Payment
{
    /// <summary>
    /// Builds and executes requests for operations under \payment
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaymentRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The auto_recharge_prefs property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Payment.Auto_recharge_prefs.Auto_recharge_prefsRequestBuilder Auto_recharge_prefs
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Payment.Auto_recharge_prefs.Auto_recharge_prefsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Payment.PaymentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/payment", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Payment.PaymentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/payment", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
