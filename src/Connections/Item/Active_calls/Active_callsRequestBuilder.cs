// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls
{
    /// <summary>
    /// Builds and executes requests for operations under \connections\{connection_-id}\active_calls
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Active_callsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Active_callsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/connections/{connection_%2Did}/active_calls{?page%5Bafter%5D*,page%5Bbefore%5D*,page%5Blimit%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Active_callsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/connections/{connection_%2Did}/active_calls{?page%5Bafter%5D*,page%5Bbefore%5D*,page%5Blimit%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all active calls for given connection. Acceptable connections are either SIP connections with webhook_url or xml_request_url, call control or texml. Returned results are cursor paginated.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsGetResponse?> GetAsActive_callsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder.Active_callsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsGetResponse> GetAsActive_callsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder.Active_callsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all active calls for given connection. Acceptable connections are either SIP connections with webhook_url or xml_request_url, call control or texml. Returned results are cursor paginated.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsActive_callsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder.Active_callsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder.Active_callsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all active calls for given connection. Acceptable connections are either SIP connections with webhook_url or xml_request_url, call control or texml. Returned results are cursor paginated.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder.Active_callsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder.Active_callsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all active calls for given connection. Acceptable connections are either SIP connections with webhook_url or xml_request_url, call control or texml. Returned results are cursor paginated.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Active_callsRequestBuilderGetQueryParameters 
        {
            /// <summary>Opaque identifier of next page</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page%5Bafter%5D")]
            public string? Pageafter { get; set; }
#nullable restore
#else
            [QueryParameter("page%5Bafter%5D")]
            public string Pageafter { get; set; }
#endif
            /// <summary>Opaque identifier of previous page</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page%5Bbefore%5D")]
            public string? Pagebefore { get; set; }
#nullable restore
#else
            [QueryParameter("page%5Bbefore%5D")]
            public string Pagebefore { get; set; }
#endif
            /// <summary>Limit of records per single page</summary>
            [QueryParameter("page%5Blimit%5D")]
            public int? Pagelimit { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Active_callsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Connections.Item.Active_calls.Active_callsRequestBuilder.Active_callsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
