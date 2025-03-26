// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Managed_accounts.Allocatable_global_outbound_channels;
using Soenneker.Telnyx.Managed_accounts.Item;
using Soenneker.Telnyx.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Managed_accounts
{
    /// <summary>
    /// Builds and executes requests for operations under \managed_accounts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Managed_accountsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The allocatable_global_outbound_channels property</summary>
        public global::Soenneker.Telnyx.Managed_accounts.Allocatable_global_outbound_channels.Allocatable_global_outbound_channelsRequestBuilder Allocatable_global_outbound_channels
        {
            get => new global::Soenneker.Telnyx.Managed_accounts.Allocatable_global_outbound_channels.Allocatable_global_outbound_channelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.managed_accounts.item collection</summary>
        /// <param name="position">Managed Account User ID</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Managed_accounts.Item.Managed_accountsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Managed_accounts.Item.Managed_accountsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Managed_accounts.Item.Managed_accountsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Managed_accountsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/managed_accounts{?filter%5Bemail%5D%5Bcontains%5D*,filter%5Bemail%5D%5Beq%5D*,filter%5Borganization_name%5D%5Bcontains%5D*,filter%5Borganization_name%5D%5Beq%5D*,include_cancelled_accounts*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Managed_accountsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/managed_accounts{?filter%5Bemail%5D%5Bcontains%5D*,filter%5Bemail%5D%5Beq%5D*,filter%5Borganization_name%5D%5Bcontains%5D*,filter%5Borganization_name%5D%5Beq%5D*,include_cancelled_accounts*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists the accounts managed by the current user. Users need to be explictly approved by Telnyx in order to become manager accounts.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Managed_accounts.Managed_accountsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsGetResponse?> GetAsManaged_accountsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder.Managed_accountsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsGetResponse> GetAsManaged_accountsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder.Managed_accountsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsGetResponse>(requestInfo, global::Soenneker.Telnyx.Managed_accounts.Managed_accountsGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the accounts managed by the current user. Users need to be explictly approved by Telnyx in order to become manager accounts.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsManaged_accountsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder.Managed_accountsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder.Managed_accountsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse>(requestInfo, global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new managed account owned by the authenticated user. You need to be explictly approved by Telnyx in order to become a manager account.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Managed_accounts.Managed_accountsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Managed_accounts422Error">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsPostResponse?> PostAsManaged_accountsPostResponseAsync(global::Soenneker.Telnyx.Models.CreateManagedAccountRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsPostResponse> PostAsManaged_accountsPostResponseAsync(global::Soenneker.Telnyx.Models.CreateManagedAccountRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.Models.Managed_accounts422Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsPostResponse>(requestInfo, global::Soenneker.Telnyx.Managed_accounts.Managed_accountsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new managed account owned by the authenticated user. You need to be explictly approved by Telnyx in order to become a manager account.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Managed_accounts422Error">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsManaged_accountsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse?> PostAsync(global::Soenneker.Telnyx.Models.CreateManagedAccountRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse> PostAsync(global::Soenneker.Telnyx.Models.CreateManagedAccountRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.Models.Managed_accounts422Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse>(requestInfo, global::Soenneker.Telnyx.Managed_accounts.Managed_accountsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the accounts managed by the current user. Users need to be explictly approved by Telnyx in order to become manager accounts.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder.Managed_accountsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder.Managed_accountsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new managed account owned by the authenticated user. You need to be explictly approved by Telnyx in order to become a manager account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.CreateManagedAccountRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Models.CreateManagedAccountRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists the accounts managed by the current user. Users need to be explictly approved by Telnyx in order to become manager accounts.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Managed_accountsRequestBuilderGetQueryParameters 
        {
            /// <summary>If present, email containing the given value will be returned. Matching is not case-sensitive. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bemail%5D%5Bcontains%5D")]
            public string? Filteremailcontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bemail%5D%5Bcontains%5D")]
            public string Filteremailcontains { get; set; }
#endif
            /// <summary>If present, only returns results with the &lt;code&gt;email&lt;/code&gt; matching exactly the value given.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bemail%5D%5Beq%5D")]
            public string? Filteremaileq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bemail%5D%5Beq%5D")]
            public string Filteremaileq { get; set; }
#endif
            /// <summary>If present, only returns results with the &lt;code&gt;organization_name&lt;/code&gt; containing the given value. Matching is not case-sensitive. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Borganization_name%5D%5Bcontains%5D")]
            public string? FilterorganizationNamecontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Borganization_name%5D%5Bcontains%5D")]
            public string FilterorganizationNamecontains { get; set; }
#endif
            /// <summary>If present, only returns results with the &lt;code&gt;organization_name&lt;/code&gt; matching exactly the value given.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Borganization_name%5D%5Beq%5D")]
            public string? FilterorganizationNameeq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Borganization_name%5D%5Beq%5D")]
            public string FilterorganizationNameeq { get; set; }
#endif
            /// <summary>Specifies if cancelled accounts should be included in the results.</summary>
            [QueryParameter("include_cancelled_accounts")]
            public bool? IncludeCancelledAccounts { get; set; }
            /// <summary>The page number to load.</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. By default sorting direction is ascending. To have the results sorted in descending order add the &lt;code&gt; -&lt;/code&gt; prefix.&lt;br/&gt;&lt;br/&gt;That is: &lt;ul&gt;  &lt;li&gt;    &lt;code&gt;email&lt;/code&gt;: sorts the result by the    &lt;code&gt;email&lt;/code&gt; field in ascending order.  &lt;/li&gt;  &lt;li&gt;    &lt;code&gt;-email&lt;/code&gt;: sorts the result by the    &lt;code&gt;email&lt;/code&gt; field in descending order.  &lt;/li&gt;&lt;/ul&gt; &lt;br/&gt; If not given, results are sorted by &lt;code&gt;created_at&lt;/code&gt; in descending order.</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>Specifies the sort order for results. By default sorting direction is ascending. To have the results sorted in descending order add the &lt;code&gt; -&lt;/code&gt; prefix.&lt;br/&gt;&lt;br/&gt;That is: &lt;ul&gt;  &lt;li&gt;    &lt;code&gt;email&lt;/code&gt;: sorts the result by the    &lt;code&gt;email&lt;/code&gt; field in ascending order.  &lt;/li&gt;  &lt;li&gt;    &lt;code&gt;-email&lt;/code&gt;: sorts the result by the    &lt;code&gt;email&lt;/code&gt; field in descending order.  &lt;/li&gt;&lt;/ul&gt; &lt;br/&gt; If not given, results are sorted by &lt;code&gt;created_at&lt;/code&gt; in descending order.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.Telnyx.Managed_accounts.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Managed_accountsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Managed_accounts.Managed_accountsRequestBuilder.Managed_accountsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Managed_accountsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
