// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using Soenneker.Telnyx.OpenApiClient.Texml_applications.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Texml_applications
{
    /// <summary>
    /// Builds and executes requests for operations under \texml_applications
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Texml_applicationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.OpenApiClient.texml_applications.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Item.Texml_applicationsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Item.Texml_applicationsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Item.Texml_applicationsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Texml_applicationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml_applications{?filter%5Bfriendly_name%5D%5Bcontains%5D*,filter%5Boutbound_voice_profile_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Texml_applicationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml_applications{?filter%5Bfriendly_name%5D%5Bcontains%5D*,filter%5Boutbound_voice_profile_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns a list of your TeXML Applications.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 401 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsGetResponse?> GetAsTexml_applicationsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder.Texml_applicationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsGetResponse> GetAsTexml_applicationsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder.Texml_applicationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your TeXML Applications.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 401 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsTexml_applicationsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder.Texml_applicationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder.Texml_applicationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a TeXML Application.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsPostResponse?> PostAsTexml_applicationsPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateTexmlApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsPostResponse> PostAsTexml_applicationsPostResponseAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateTexmlApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsPostResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a TeXML Application.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse">When receiving a 404 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsTexml_applicationsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse?> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateTexmlApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse> PostAsync(global::Soenneker.Telnyx.OpenApiClient.Models.CreateTexmlApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.OpenApiClient.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of your TeXML Applications.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder.Texml_applicationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder.Texml_applicationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a TeXML Application.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.CreateTexmlApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.OpenApiClient.Models.CreateTexmlApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of your TeXML Applications.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Texml_applicationsRequestBuilderGetQueryParameters 
        {
            /// <summary>If present, applications with &lt;code&gt;friendly_name&lt;/code&gt; containing the given value will be returned. Matching is not case-sensitive. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bfriendly_name%5D%5Bcontains%5D")]
            public string? FilterfriendlyNamecontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bfriendly_name%5D%5Bcontains%5D")]
            public string FilterfriendlyNamecontains { get; set; }
#endif
            /// <summary>Identifies the associated outbound voice profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Boutbound_voice_profile_id%5D")]
            public string? FilteroutboundVoiceProfileId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Boutbound_voice_profile_id%5D")]
            public string FilteroutboundVoiceProfileId { get; set; }
#endif
            /// <summary>The page number to load.</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. By default sorting direction is ascending. To have the results sorted in descending order add the &lt;code&gt; -&lt;/code&gt; prefix.&lt;br/&gt;&lt;br/&gt;That is: &lt;ul&gt;  &lt;li&gt;    &lt;code&gt;friendly_name&lt;/code&gt;: sorts the result by the    &lt;code&gt;friendly_name&lt;/code&gt; field in ascending order.  &lt;/li&gt;  &lt;li&gt;    &lt;code&gt;-friendly_name&lt;/code&gt;: sorts the result by the    &lt;code&gt;friendly_name&lt;/code&gt; field in descending order.  &lt;/li&gt;&lt;/ul&gt; &lt;br/&gt; If not given, results are sorted by &lt;code&gt;created_at&lt;/code&gt; in descending order.</summary>
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
            /// <summary>Specifies the sort order for results. By default sorting direction is ascending. To have the results sorted in descending order add the &lt;code&gt; -&lt;/code&gt; prefix.&lt;br/&gt;&lt;br/&gt;That is: &lt;ul&gt;  &lt;li&gt;    &lt;code&gt;friendly_name&lt;/code&gt;: sorts the result by the    &lt;code&gt;friendly_name&lt;/code&gt; field in ascending order.  &lt;/li&gt;  &lt;li&gt;    &lt;code&gt;-friendly_name&lt;/code&gt;: sorts the result by the    &lt;code&gt;friendly_name&lt;/code&gt; field in descending order.  &lt;/li&gt;&lt;/ul&gt; &lt;br/&gt; If not given, results are sorted by &lt;code&gt;created_at&lt;/code&gt; in descending order.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.Telnyx.OpenApiClient.Texml_applications.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Texml_applicationsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Texml_applications.Texml_applicationsRequestBuilder.Texml_applicationsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Texml_applicationsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
