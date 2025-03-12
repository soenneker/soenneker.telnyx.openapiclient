// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Models;
using Soenneker.Telnyx.Public_internet_gateways.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Public_internet_gateways
{
    /// <summary>
    /// Builds and executes requests for operations under \public_internet_gateways
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Public_internet_gatewaysRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.public_internet_gateways.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Item.Public_internet_gatewaysItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Public_internet_gateways.Item.Public_internet_gatewaysItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Public_internet_gateways.Item.Public_internet_gatewaysItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.public_internet_gateways.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Item.Public_internet_gatewaysItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.Public_internet_gateways.Item.Public_internet_gatewaysItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Public_internet_gateways.Item.Public_internet_gatewaysItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Public_internet_gatewaysRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/public_internet_gateways{?filter%5Bnetwork_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Public_internet_gatewaysRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/public_internet_gateways{?filter%5Bnetwork_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// List all Public Internet Gateways.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysGetResponse?> GetAsPublic_internet_gatewaysGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder.Public_internet_gatewaysRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysGetResponse> GetAsPublic_internet_gatewaysGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder.Public_internet_gatewaysRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysGetResponse>(requestInfo, global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all Public Internet Gateways.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsPublic_internet_gatewaysGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder.Public_internet_gatewaysRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder.Public_internet_gatewaysRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse>(requestInfo, global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new Public Internet Gateway.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 422 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysPostResponse?> PostAsPublic_internet_gatewaysPostResponseAsync(global::Soenneker.Telnyx.Models.PublicInternetGatewayCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysPostResponse> PostAsPublic_internet_gatewaysPostResponseAsync(global::Soenneker.Telnyx.Models.PublicInternetGatewayCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysPostResponse>(requestInfo, global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new Public Internet Gateway.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 422 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsPublic_internet_gatewaysPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse?> PostAsync(global::Soenneker.Telnyx.Models.PublicInternetGatewayCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse> PostAsync(global::Soenneker.Telnyx.Models.PublicInternetGatewayCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse>(requestInfo, global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all Public Internet Gateways.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder.Public_internet_gatewaysRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder.Public_internet_gatewaysRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new Public Internet Gateway.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.PublicInternetGatewayCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.PublicInternetGatewayCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List all Public Internet Gateways.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Public_internet_gatewaysRequestBuilderGetQueryParameters 
        {
            /// <summary>The associated network id to filter on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bnetwork_id%5D")]
            public string? FilternetworkId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bnetwork_id%5D")]
            public string FilternetworkId { get; set; }
#endif
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
        public partial class Public_internet_gatewaysRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Public_internet_gateways.Public_internet_gatewaysRequestBuilder.Public_internet_gatewaysRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Public_internet_gatewaysRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
