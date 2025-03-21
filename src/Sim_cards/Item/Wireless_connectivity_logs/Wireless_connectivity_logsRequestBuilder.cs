// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs
{
    /// <summary>
    /// Builds and executes requests for operations under \sim_cards\{id}\wireless_connectivity_logs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Wireless_connectivity_logsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Wireless_connectivity_logsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_cards/{id}/wireless_connectivity_logs{?page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Wireless_connectivity_logsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_cards/{id}/wireless_connectivity_logs{?page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// This API allows listing a paginated collection of Wireless Connectivity Logs associated with a SIM Card, for troubleshooting purposes.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsGetResponse?> GetAsWireless_connectivity_logsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder.Wireless_connectivity_logsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsGetResponse> GetAsWireless_connectivity_logsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder.Wireless_connectivity_logsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsGetResponse>(requestInfo, global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This API allows listing a paginated collection of Wireless Connectivity Logs associated with a SIM Card, for troubleshooting purposes.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsWireless_connectivity_logsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder.Wireless_connectivity_logsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder.Wireless_connectivity_logsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsResponse>(requestInfo, global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This API allows listing a paginated collection of Wireless Connectivity Logs associated with a SIM Card, for troubleshooting purposes.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder.Wireless_connectivity_logsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder.Wireless_connectivity_logsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This API allows listing a paginated collection of Wireless Connectivity Logs associated with a SIM Card, for troubleshooting purposes.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Wireless_connectivity_logsRequestBuilderGetQueryParameters 
        {
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
        public partial class Wireless_connectivity_logsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Sim_cards.Item.Wireless_connectivity_logs.Wireless_connectivity_logsRequestBuilder.Wireless_connectivity_logsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
