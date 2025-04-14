// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs
{
    /// <summary>
    /// Builds and executes requests for operations under \porting_orders\{-id}\activation_jobs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Activation_jobsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.porting_orders.item.activation_jobs.item collection</summary>
        /// <param name="position">Activation Job Identifier</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Item.WithActivationJobItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Item.WithActivationJobItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("activationJobId", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Item.WithActivationJobItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.porting_orders.item.activation_jobs.item collection</summary>
        /// <param name="position">Activation Job Identifier</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Item.WithActivationJobItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Item.WithActivationJobItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("activationJobId", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Item.WithActivationJobItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Activation_jobsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting_orders/{%2Did}/activation_jobs{?page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Activation_jobsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting_orders/{%2Did}/activation_jobs{?page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of your porting activation jobs.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsGetResponse?> GetAsActivation_jobsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder.Activation_jobsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsGetResponse> GetAsActivation_jobsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder.Activation_jobsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your porting activation jobs.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsActivation_jobsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder.Activation_jobsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder.Activation_jobsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your porting activation jobs.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder.Activation_jobsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder.Activation_jobsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of your porting activation jobs.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Activation_jobsRequestBuilderGetQueryParameters 
        {
            /// <summary>The page number to load</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Activation_jobsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Porting_orders.Item.Activation_jobs.Activation_jobsRequestBuilder.Activation_jobsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
