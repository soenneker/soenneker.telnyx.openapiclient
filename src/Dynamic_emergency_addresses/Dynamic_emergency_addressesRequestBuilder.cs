// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Item;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses
{
    /// <summary>
    /// Builds and executes requests for operations under \dynamic_emergency_addresses
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Dynamic_emergency_addressesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.dynamic_emergency_addresses.item collection</summary>
        /// <param name="position">Dynamic Emergency Address id</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Item.Dynamic_emergency_addressesItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Item.Dynamic_emergency_addressesItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Item.Dynamic_emergency_addressesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.dynamic_emergency_addresses.item collection</summary>
        /// <param name="position">Dynamic Emergency Address id</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Item.Dynamic_emergency_addressesItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Item.Dynamic_emergency_addressesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Item.Dynamic_emergency_addressesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Dynamic_emergency_addressesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dynamic_emergency_addresses{?filter%5Bcountry_code%5D*,filter%5Bstatus%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Dynamic_emergency_addressesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/dynamic_emergency_addresses{?filter%5Bcountry_code%5D*,filter%5Bstatus%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the dynamic emergency addresses according to filters
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesGetResponse?> GetAsDynamic_emergency_addressesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder.Dynamic_emergency_addressesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesGetResponse> GetAsDynamic_emergency_addressesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder.Dynamic_emergency_addressesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the dynamic emergency addresses according to filters
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsDynamic_emergency_addressesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder.Dynamic_emergency_addressesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder.Dynamic_emergency_addressesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a dynamic emergency address.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesPostResponse?> PostAsDynamic_emergency_addressesPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.DynamicEmergencyAddress body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesPostResponse> PostAsDynamic_emergency_addressesPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.DynamicEmergencyAddress body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesPostResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a dynamic emergency address.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsDynamic_emergency_addressesPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.DynamicEmergencyAddress body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.DynamicEmergencyAddress body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the dynamic emergency addresses according to filters
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder.Dynamic_emergency_addressesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder.Dynamic_emergency_addressesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a dynamic emergency address.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.DynamicEmergencyAddress body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.DynamicEmergencyAddress body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the dynamic emergency addresses according to filters
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Dynamic_emergency_addressesRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by country code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcountry_code%5D")]
            public string? FiltercountryCode { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcountry_code%5D")]
            public string FiltercountryCode { get; set; }
#endif
            /// <summary>Filter by status.</summary>
            [Obsolete("This property is deprecated, use FilterstatusAsGetFilterStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string Filterstatus { get; set; }
#endif
            /// <summary>Filter by status.</summary>
            [QueryParameter("filter%5Bstatus%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.GetFilterStatusQueryParameterType? FilterstatusAsGetFilterStatusQueryParameterType { get; set; }
            /// <summary>The page number to load.</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Dynamic_emergency_addressesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Dynamic_emergency_addresses.Dynamic_emergency_addressesRequestBuilder.Dynamic_emergency_addressesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Dynamic_emergency_addressesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
