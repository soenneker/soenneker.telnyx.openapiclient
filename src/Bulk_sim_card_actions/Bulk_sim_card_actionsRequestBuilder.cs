// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Item;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions
{
    /// <summary>
    /// Builds and executes requests for operations under \bulk_sim_card_actions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Bulk_sim_card_actionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.bulk_sim_card_actions.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Item.Bulk_sim_card_actionsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Item.Bulk_sim_card_actionsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Item.Bulk_sim_card_actionsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.bulk_sim_card_actions.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Item.Bulk_sim_card_actionsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Item.Bulk_sim_card_actionsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Item.Bulk_sim_card_actionsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Bulk_sim_card_actionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/bulk_sim_card_actions{?filter%5Baction_type%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Bulk_sim_card_actionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/bulk_sim_card_actions{?filter%5Baction_type%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// This API lists a paginated collection of bulk SIM card actions. A bulk SIM card action contains details about a collection of individual SIM card actions.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsGetResponse?> GetAsBulk_sim_card_actionsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder.Bulk_sim_card_actionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsGetResponse> GetAsBulk_sim_card_actionsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder.Bulk_sim_card_actionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This API lists a paginated collection of bulk SIM card actions. A bulk SIM card action contains details about a collection of individual SIM card actions.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsBulk_sim_card_actionsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder.Bulk_sim_card_actionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder.Bulk_sim_card_actionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This API lists a paginated collection of bulk SIM card actions. A bulk SIM card action contains details about a collection of individual SIM card actions.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder.Bulk_sim_card_actionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder.Bulk_sim_card_actionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// This API lists a paginated collection of bulk SIM card actions. A bulk SIM card action contains details about a collection of individual SIM card actions.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Bulk_sim_card_actionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by action type.</summary>
            [Obsolete("This property is deprecated, use FilteractionTypeAsGetFilterActionTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Baction_type%5D")]
            public string? FilteractionType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Baction_type%5D")]
            public string FilteractionType { get; set; }
#endif
            /// <summary>Filter by action type.</summary>
            [QueryParameter("filter%5Baction_type%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.GetFilterAction_typeQueryParameterType? FilteractionTypeAsGetFilterActionTypeQueryParameterType { get; set; }
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
        public partial class Bulk_sim_card_actionsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Bulk_sim_card_actions.Bulk_sim_card_actionsRequestBuilder.Bulk_sim_card_actionsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
