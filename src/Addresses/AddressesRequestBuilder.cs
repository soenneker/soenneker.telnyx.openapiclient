// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Addresses.Actions;
using Soenneker.Telnyx.OpenApiClient.Addresses.Item;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Addresses
{
    /// <summary>
    /// Builds and executes requests for operations under \addresses
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AddressesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The actions property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Addresses.Actions.ActionsRequestBuilder Actions
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Addresses.Actions.ActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.addresses.item collection</summary>
        /// <param name="position">address ID</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.Item.AddressesItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Addresses.Item.AddressesItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Addresses.Item.AddressesItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddressesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/addresses{?filter%5Baddress_book%5D%5Beq%5D*,filter%5Bcustomer_reference%5D%5Bcontains%5D*,filter%5Bcustomer_reference%5D%5Beq%5D*,filter%5Bstreet_address%5D%5Bcontains%5D*,filter%5Bused_as_emergency%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AddressesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/addresses{?filter%5Baddress_book%5D%5Beq%5D*,filter%5Bcustomer_reference%5D%5Bcontains%5D*,filter%5Bcustomer_reference%5D%5Beq%5D*,filter%5Bstreet_address%5D%5Bcontains%5D*,filter%5Bused_as_emergency%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of your addresses.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesGetResponse?> GetAsAddressesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder.AddressesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesGetResponse> GetAsAddressesGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder.AddressesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesGetResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your addresses.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsAddressesGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder.AddressesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder.AddressesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an address.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesPostResponse?> PostAsAddressesPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.AddressCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesPostResponse> PostAsAddressesPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.AddressCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesPostResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesPostResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an address.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use PostAsAddressesPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.AddressCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.AddressCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your addresses.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder.AddressesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder.AddressesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates an address.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.AddressCreate body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.AddressCreate body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of your addresses.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AddressesRequestBuilderGetQueryParameters 
        {
            /// <summary>If present, only returns results with the &lt;code&gt;address_book&lt;/code&gt; flag set to the given value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Baddress_book%5D%5Beq%5D")]
            public string? FilteraddressBookeq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Baddress_book%5D%5Beq%5D")]
            public string FilteraddressBookeq { get; set; }
#endif
            /// <summary>If present, addresses with &lt;code&gt;customer_reference&lt;/code&gt; containing the given value will be returned. Matching is not case-sensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcustomer_reference%5D%5Bcontains%5D")]
            public string? FiltercustomerReferencecontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcustomer_reference%5D%5Bcontains%5D")]
            public string FiltercustomerReferencecontains { get; set; }
#endif
            /// <summary>Filter addresses via the customer reference set. Matching is not case-sensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcustomer_reference%5D%5Beq%5D")]
            public string? FiltercustomerReferenceeq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcustomer_reference%5D%5Beq%5D")]
            public string FiltercustomerReferenceeq { get; set; }
#endif
            /// <summary>If present, addresses with &lt;code&gt;street_address&lt;/code&gt; containing the given value will be returned. Matching is not case-sensitive. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstreet_address%5D%5Bcontains%5D")]
            public string? FilterstreetAddresscontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstreet_address%5D%5Bcontains%5D")]
            public string FilterstreetAddresscontains { get; set; }
#endif
            /// <summary>If set as &apos;true&apos;, only addresses used as the emergency address for at least one active phone-number will be returned. When set to &apos;false&apos;, the opposite happens: only addresses not used as the emergency address from phone-numbers will be returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bused_as_emergency%5D")]
            public string? FilterusedAsEmergency { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bused_as_emergency%5D")]
            public string FilterusedAsEmergency { get; set; }
#endif
            /// <summary>The page number to load.</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. By default sorting direction is ascending. To have the results sorted in descending order add the &lt;code&gt; -&lt;/code&gt; prefix.&lt;br/&gt;&lt;br/&gt;That is: &lt;ul&gt;  &lt;li&gt;    &lt;code&gt;street_address&lt;/code&gt;: sorts the result by the    &lt;code&gt;street_address&lt;/code&gt; field in ascending order.  &lt;/li&gt;  &lt;li&gt;    &lt;code&gt;-street_address&lt;/code&gt;: sorts the result by the    &lt;code&gt;street_address&lt;/code&gt; field in descending order.  &lt;/li&gt;&lt;/ul&gt; &lt;br/&gt; If not given, results are sorted by &lt;code&gt;created_at&lt;/code&gt; in descending order.</summary>
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
            /// <summary>Specifies the sort order for results. By default sorting direction is ascending. To have the results sorted in descending order add the &lt;code&gt; -&lt;/code&gt; prefix.&lt;br/&gt;&lt;br/&gt;That is: &lt;ul&gt;  &lt;li&gt;    &lt;code&gt;street_address&lt;/code&gt;: sorts the result by the    &lt;code&gt;street_address&lt;/code&gt; field in ascending order.  &lt;/li&gt;  &lt;li&gt;    &lt;code&gt;-street_address&lt;/code&gt;: sorts the result by the    &lt;code&gt;street_address&lt;/code&gt; field in descending order.  &lt;/li&gt;&lt;/ul&gt; &lt;br/&gt; If not given, results are sorted by &lt;code&gt;created_at&lt;/code&gt; in descending order.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.Telnyx.OpenApiClient.Addresses.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AddressesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Addresses.AddressesRequestBuilder.AddressesRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AddressesRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
