// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Porting_orders.Phone_number_configurations
{
    /// <summary>
    /// Builds and executes requests for operations under \porting_orders\phone_number_configurations
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Phone_number_configurationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_number_configurationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting_orders/phone_number_configurations{?filter%5Bporting_order%2Estatus%5D*,filter%5Bporting_order%2Estatus%5D%5Bin%5D%5B%5D*,filter%5Bporting_order_id%5D*,filter%5Bporting_order_id%5D%5Bin%5D%5B%5D*,filter%5Bporting_phone_number%5D*,filter%5Bporting_phone_number%5D%5Bin%5D%5B%5D*,filter%5Buser_bundle_id%5D*,filter%5Buser_bundle_id%5D%5Bin%5D%5B%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort%5B%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_number_configurationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting_orders/phone_number_configurations{?filter%5Bporting_order%2Estatus%5D*,filter%5Bporting_order%2Estatus%5D%5Bin%5D%5B%5D*,filter%5Bporting_order_id%5D*,filter%5Bporting_order_id%5D%5Bin%5D%5B%5D*,filter%5Bporting_phone_number%5D*,filter%5Bporting_phone_number%5D%5Bin%5D%5B%5D*,filter%5Buser_bundle_id%5D*,filter%5Buser_bundle_id%5D%5Bin%5D%5B%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort%5B%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of phone number configurations paginated.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsGetResponse?> GetAsPhone_number_configurationsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder.Phone_number_configurationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsGetResponse> GetAsPhone_number_configurationsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder.Phone_number_configurationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsGetResponse>(requestInfo, global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of phone number configurations paginated.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsPhone_number_configurationsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder.Phone_number_configurationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder.Phone_number_configurationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse>(requestInfo, global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a list of phone number configurations.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostResponse?> PostAsPhone_number_configurationsPostResponseAsync(global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostResponse> PostAsPhone_number_configurationsPostResponseAsync(global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostResponse>(requestInfo, global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a list of phone number configurations.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsPhone_number_configurationsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse?> PostAsync(global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse> PostAsync(global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse>(requestInfo, global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of phone number configurations paginated.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder.Phone_number_configurationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder.Phone_number_configurationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a list of phone number configurations.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of phone number configurations paginated.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_number_configurationsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter results by porting order id</summary>
            [QueryParameter("filter%5Bporting_order_id%5D")]
            public Guid? FilterportingOrderId { get; set; }
            /// <summary>Filter results by a list of porting order ids</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bporting_order_id%5D%5Bin%5D%5B%5D")]
            public Guid?[]? FilterportingOrderIdin { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bporting_order_id%5D%5Bin%5D%5B%5D")]
            public Guid?[] FilterportingOrderIdin { get; set; }
#endif
            /// <summary>Filter results by a specific porting order status</summary>
            [Obsolete("This property is deprecated, use FilterportingOrderStatusAsGetFilterPortingOrderStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bporting_order%2Estatus%5D")]
            public string? FilterportingOrderStatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bporting_order%2Estatus%5D")]
            public string FilterportingOrderStatus { get; set; }
#endif
            /// <summary>Filter results by a specific porting order status</summary>
            [QueryParameter("filter%5Bporting_order%2Estatus%5D")]
            public global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.GetFilterPorting_orderStatusQueryParameterType? FilterportingOrderStatusAsGetFilterPortingOrderStatusQueryParameterType { get; set; }
            /// <summary>Filter results by specific porting order statuses</summary>
            [Obsolete("This property is deprecated, use FilterportingOrderStatusinAsGetFilterPortingOrderStatusInQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bporting_order%2Estatus%5D%5Bin%5D%5B%5D")]
            public string[]? FilterportingOrderStatusin { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bporting_order%2Estatus%5D%5Bin%5D%5B%5D")]
            public string[] FilterportingOrderStatusin { get; set; }
#endif
            /// <summary>Filter results by specific porting order statuses</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bporting_order%2Estatus%5D%5Bin%5D%5B%5D")]
            public global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.GetFilterPorting_orderStatusInQueryParameterType[]? FilterportingOrderStatusinAsGetFilterPortingOrderStatusInQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bporting_order%2Estatus%5D%5Bin%5D%5B%5D")]
            public global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.GetFilterPorting_orderStatusInQueryParameterType[] FilterportingOrderStatusinAsGetFilterPortingOrderStatusInQueryParameterType { get; set; }
#endif
            /// <summary>Filter results by a specific porting phone number ID</summary>
            [QueryParameter("filter%5Bporting_phone_number%5D")]
            public Guid? FilterportingPhoneNumber { get; set; }
            /// <summary>Filter results by a list of porting phone number IDs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bporting_phone_number%5D%5Bin%5D%5B%5D")]
            public Guid?[]? FilterportingPhoneNumberin { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bporting_phone_number%5D%5Bin%5D%5B%5D")]
            public Guid?[] FilterportingPhoneNumberin { get; set; }
#endif
            /// <summary>Filter results by a specific user bundle ID</summary>
            [QueryParameter("filter%5Buser_bundle_id%5D")]
            public Guid? FilteruserBundleId { get; set; }
            /// <summary>Filter results by a list of user bundle IDs</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Buser_bundle_id%5D%5Bin%5D%5B%5D")]
            public Guid?[]? FilteruserBundleIdin { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Buser_bundle_id%5D%5Bin%5D%5B%5D")]
            public Guid?[] FilteruserBundleIdin { get; set; }
#endif
            /// <summary>The page number to load.</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. If not given, results are sorted by created_at in descending order.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort%5B%5D")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort%5B%5D")]
            public string Sort { get; set; }
#endif
            /// <summary>Specifies the sort order for results. If not given, results are sorted by created_at in descending order.</summary>
            [QueryParameter("sort%5B%5D")]
            public global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_number_configurationsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Porting_orders.Phone_number_configurations.Phone_number_configurationsRequestBuilder.Phone_number_configurationsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_number_configurationsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
