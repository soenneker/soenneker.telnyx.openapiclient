// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications
{
    /// <summary>
    /// Builds and executes requests for operations under \sim_card_data_usage_notifications
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Sim_card_data_usage_notificationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.sim_card_data_usage_notifications.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Item.Sim_card_data_usage_notificationsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Item.Sim_card_data_usage_notificationsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Item.Sim_card_data_usage_notificationsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.sim_card_data_usage_notifications.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Item.Sim_card_data_usage_notificationsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Item.Sim_card_data_usage_notificationsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Item.Sim_card_data_usage_notificationsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Sim_card_data_usage_notificationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_card_data_usage_notifications{?filter%5Bsim_card_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Sim_card_data_usage_notificationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/sim_card_data_usage_notifications{?filter%5Bsim_card_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists a paginated collection of SIM card data usage notifications. It enables exploring the collection using specific filters.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsGetResponse?> GetAsSim_card_data_usage_notificationsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder.Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsGetResponse> GetAsSim_card_data_usage_notificationsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder.Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists a paginated collection of SIM card data usage notifications. It enables exploring the collection using specific filters.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsSim_card_data_usage_notificationsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder.Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder.Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new SIM card data usage notification.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostResponse?> PostAsSim_card_data_usage_notificationsPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostResponse> PostAsSim_card_data_usage_notificationsPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a new SIM card data usage notification.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsSim_card_data_usage_notificationsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists a paginated collection of SIM card data usage notifications. It enables exploring the collection using specific filters.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder.Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder.Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new SIM card data usage notification.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists a paginated collection of SIM card data usage notifications. It enables exploring the collection using specific filters.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters 
        {
            /// <summary>A valid SIM card ID.</summary>
            [QueryParameter("filter%5Bsim_card_id%5D")]
            public Guid? FiltersimCardId { get; set; }
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
        public partial class Sim_card_data_usage_notificationsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Sim_card_data_usage_notifications.Sim_card_data_usage_notificationsRequestBuilder.Sim_card_data_usage_notificationsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Sim_card_data_usage_notificationsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
