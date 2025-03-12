// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Webhook_deliveries.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Webhook_deliveries
{
    /// <summary>
    /// Builds and executes requests for operations under \webhook_deliveries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Webhook_deliveriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.webhook_deliveries.item collection</summary>
        /// <param name="position">Uniquely identifies the webhook_delivery.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Webhook_deliveries.Item.Webhook_deliveriesItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Webhook_deliveries.Item.Webhook_deliveriesItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Webhook_deliveries.Item.Webhook_deliveriesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.webhook_deliveries.item collection</summary>
        /// <param name="position">Uniquely identifies the webhook_delivery.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Webhook_deliveries.Item.Webhook_deliveriesItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.Webhook_deliveries.Item.Webhook_deliveriesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Webhook_deliveries.Item.Webhook_deliveriesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Webhook_deliveriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/webhook_deliveries{?filter%5Battempts%5D%5Bcontains%5D*,filter%5Bevent_type%5D*,filter%5Bfinished_at%5D%5Bgte%5D*,filter%5Bfinished_at%5D%5Blte%5D*,filter%5Bstarted_at%5D%5Bgte%5D*,filter%5Bstarted_at%5D%5Blte%5D*,filter%5Bstatus%5D%5Beq%5D*,filter%5Bwebhook%5D%5Bcontains%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Webhook_deliveriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/webhook_deliveries{?filter%5Battempts%5D%5Bcontains%5D*,filter%5Bevent_type%5D*,filter%5Bfinished_at%5D%5Bgte%5D*,filter%5Bfinished_at%5D%5Blte%5D*,filter%5Bstarted_at%5D%5Bgte%5D*,filter%5Bstarted_at%5D%5Blte%5D*,filter%5Bstatus%5D%5Beq%5D*,filter%5Bwebhook%5D%5Bcontains%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists webhook_deliveries for the authenticated user
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesGetResponse?> GetAsWebhook_deliveriesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder.Webhook_deliveriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesGetResponse> GetAsWebhook_deliveriesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder.Webhook_deliveriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesGetResponse>(requestInfo, global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists webhook_deliveries for the authenticated user
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsWebhook_deliveriesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder.Webhook_deliveriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder.Webhook_deliveriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesResponse>(requestInfo, global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists webhook_deliveries for the authenticated user
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder.Webhook_deliveriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder.Webhook_deliveriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists webhook_deliveries for the authenticated user
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Webhook_deliveriesRequestBuilderGetQueryParameters 
        {
            /// <summary>Return only webhook_deliveries whose `attempts` component contains the given text</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Battempts%5D%5Bcontains%5D")]
            public string? Filterattemptscontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Battempts%5D%5Bcontains%5D")]
            public string Filterattemptscontains { get; set; }
#endif
            /// <summary>Return only webhook_deliveries matching the given value of `event_type`. Accepts multiple values separated by a `,`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bevent_type%5D")]
            public string? FiltereventType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bevent_type%5D")]
            public string FiltereventType { get; set; }
#endif
            /// <summary>Return only webhook_deliveries whose delivery finished later than or at given ISO 8601 datetime</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bfinished_at%5D%5Bgte%5D")]
            public string? FilterfinishedAtgte { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bfinished_at%5D%5Bgte%5D")]
            public string FilterfinishedAtgte { get; set; }
#endif
            /// <summary>Return only webhook_deliveries whose delivery finished earlier than or at given ISO 8601 datetime</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bfinished_at%5D%5Blte%5D")]
            public string? FilterfinishedAtlte { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bfinished_at%5D%5Blte%5D")]
            public string FilterfinishedAtlte { get; set; }
#endif
            /// <summary>Return only webhook_deliveries whose delivery started later than or at given ISO 8601 datetime</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstarted_at%5D%5Bgte%5D")]
            public string? FilterstartedAtgte { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstarted_at%5D%5Bgte%5D")]
            public string FilterstartedAtgte { get; set; }
#endif
            /// <summary>Return only webhook_deliveries whose delivery started earlier than or at given ISO 8601 datetime</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstarted_at%5D%5Blte%5D")]
            public string? FilterstartedAtlte { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstarted_at%5D%5Blte%5D")]
            public string FilterstartedAtlte { get; set; }
#endif
            /// <summary>Return only webhook_deliveries matching the given `status`</summary>
            [Obsolete("This property is deprecated, use FilterstatuseqAsGetFilterStatusEqQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D%5Beq%5D")]
            public string? Filterstatuseq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D%5Beq%5D")]
            public string Filterstatuseq { get; set; }
#endif
            /// <summary>Return only webhook_deliveries matching the given `status`</summary>
            [QueryParameter("filter%5Bstatus%5D%5Beq%5D")]
            public global::Soenneker.Telnyx.Webhook_deliveries.GetFilterStatusEqQueryParameterType? FilterstatuseqAsGetFilterStatusEqQueryParameterType { get; set; }
            /// <summary>Return only webhook deliveries whose `webhook` component contains the given text</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bwebhook%5D%5Bcontains%5D")]
            public string? Filterwebhookcontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bwebhook%5D%5Bcontains%5D")]
            public string Filterwebhookcontains { get; set; }
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
        public partial class Webhook_deliveriesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Webhook_deliveries.Webhook_deliveriesRequestBuilder.Webhook_deliveriesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
