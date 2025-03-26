// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Porting.Events.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Porting.Events
{
    /// <summary>
    /// Builds and executes requests for operations under \porting\events
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EventsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.porting.events.item collection</summary>
        /// <param name="position">Identifies the porting event.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Events.Item.EventsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Porting.Events.Item.EventsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Porting.Events.Item.EventsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.porting.events.item collection</summary>
        /// <param name="position">Identifies the porting event.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Events.Item.EventsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.Porting.Events.Item.EventsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Porting.Events.Item.EventsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting/events{?filter%5Bcreated_at%5D%5Bgte%5D*,filter%5Bcreated_at%5D%5Blte%5D*,filter%5Bporting_order_id%5D*,filter%5Btype%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EventsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting/events{?filter%5Bcreated_at%5D%5Bgte%5D*,filter%5Bcreated_at%5D%5Blte%5D*,filter%5Bporting_order_id%5D*,filter%5Btype%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of all porting events.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Events.EventsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting.Events.EventsGetResponse?> GetAsEventsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting.Events.EventsGetResponse> GetAsEventsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting.Events.EventsGetResponse>(requestInfo, global::Soenneker.Telnyx.Porting.Events.EventsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of all porting events.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Events.EventsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsEventsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting.Events.EventsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting.Events.EventsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting.Events.EventsResponse>(requestInfo, global::Soenneker.Telnyx.Porting.Events.EventsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of all porting events.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of all porting events.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class EventsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by created at greater than or equal to.</summary>
            [QueryParameter("filter%5Bcreated_at%5D%5Bgte%5D")]
            public DateTimeOffset? FiltercreatedAtgte { get; set; }
            /// <summary>Filter by created at less than or equal to.</summary>
            [QueryParameter("filter%5Bcreated_at%5D%5Blte%5D")]
            public DateTimeOffset? FiltercreatedAtlte { get; set; }
            /// <summary>Filter by porting order ID.</summary>
            [QueryParameter("filter%5Bporting_order_id%5D")]
            public Guid? FilterportingOrderId { get; set; }
            /// <summary>Filter by event type.</summary>
            [Obsolete("This property is deprecated, use FiltertypeAsGetFilterTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btype%5D")]
            public string? Filtertype { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btype%5D")]
            public string Filtertype { get; set; }
#endif
            /// <summary>Filter by event type.</summary>
            [QueryParameter("filter%5Btype%5D")]
            public global::Soenneker.Telnyx.Porting.Events.GetFilterTypeQueryParameterType? FiltertypeAsGetFilterTypeQueryParameterType { get; set; }
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
        public partial class EventsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Porting.Events.EventsRequestBuilder.EventsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
