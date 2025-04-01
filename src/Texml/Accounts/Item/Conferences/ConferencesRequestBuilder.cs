// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Models;
using Soenneker.Telnyx.Texml.Accounts.Item.Conferences.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Texml.Accounts.Item.Conferences
{
    /// <summary>
    /// Builds and executes requests for operations under \texml\Accounts\{account_sid}\Conferences
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ConferencesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.texml.Accounts.item.Conferences.item collection</summary>
        /// <param name="position">The ConferenceSid that uniquely identifies a conference.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.Item.WithConference_sItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.Item.WithConference_sItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("conference_sid", position);
                return new global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.Item.WithConference_sItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConferencesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}/Conferences{?DateCreated*,DateUpdated*,FriendlyName*,Page*,PageToken*,Status*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConferencesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}/Conferences{?DateCreated*,DateUpdated*,FriendlyName*,Page*,PageToken*,Status*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists conference resources.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Models.ConferenceResourceIndex"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Models.ConferenceResourceIndex?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder.ConferencesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Models.ConferenceResourceIndex> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder.ConferencesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Models.ConferenceResourceIndex>(requestInfo, global::Soenneker.Telnyx.Models.ConferenceResourceIndex.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists conference resources.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder.ConferencesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder.ConferencesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists conference resources.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ConferencesRequestBuilderGetQueryParameters 
        {
            /// <summary>Filters conferences by the creation date. Expected format is YYYY-MM-DD. Also accepts inequality operators, e.g. DateCreated&gt;=2023-05-22.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? DateCreated { get; set; }
#nullable restore
#else
            public string DateCreated { get; set; }
#endif
            /// <summary>Filters conferences by the time they were last updated. Expected format is YYYY-MM-DD. Also accepts inequality operators, e.g. DateUpdated&gt;=2023-05-22.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? DateUpdated { get; set; }
#nullable restore
#else
            public string DateUpdated { get; set; }
#endif
            /// <summary>Filters conferences by their friendly name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? FriendlyName { get; set; }
#nullable restore
#else
            public string FriendlyName { get; set; }
#endif
            /// <summary>The number of the page to be displayed, zero-indexed, should be used in conjuction with PageToken.</summary>
            public int? Page { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Used to request the next page of results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? PageToken { get; set; }
#nullable restore
#else
            public string PageToken { get; set; }
#endif
            /// <summary>Filters conferences by status.</summary>
            [Obsolete("This property is deprecated, use StatusAsGetStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? Status { get; set; }
#nullable restore
#else
            public string Status { get; set; }
#endif
            /// <summary>Filters conferences by status.</summary>
            [QueryParameter("Status")]
            public global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.GetStatusQueryParameterType? StatusAsGetStatusQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ConferencesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder.ConferencesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
