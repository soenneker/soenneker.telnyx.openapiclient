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
namespace Soenneker.Telnyx.Document_links
{
    /// <summary>
    /// Builds and executes requests for operations under \document_links
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Document_linksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Document_linksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/document_links{?filter%5Bdocument_id%5D*,filter%5Blinked_record_type%5D*,filter%5Blinked_resource_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Document_linksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/document_links{?filter%5Bdocument_id%5D*,filter%5Blinked_record_type%5D*,filter%5Blinked_resource_id%5D*,page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// List all documents links ordered by created_at descending.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Document_links.Document_linksGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Document_links.Document_linksGetResponse?> GetAsDocument_linksGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder.Document_linksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Document_links.Document_linksGetResponse> GetAsDocument_linksGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder.Document_linksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "500", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Document_links.Document_linksGetResponse>(requestInfo, global::Soenneker.Telnyx.Document_links.Document_linksGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all documents links ordered by created_at descending.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Document_links.Document_linksResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDocument_linksGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Document_links.Document_linksResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder.Document_linksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Document_links.Document_linksResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder.Document_linksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "500", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Document_links.Document_linksResponse>(requestInfo, global::Soenneker.Telnyx.Document_links.Document_linksResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all documents links ordered by created_at descending.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder.Document_linksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder.Document_linksRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List all documents links ordered by created_at descending.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Document_linksRequestBuilderGetQueryParameters 
        {
            /// <summary>Identifies the associated document to filter on.</summary>
            [QueryParameter("filter%5Bdocument_id%5D")]
            public Guid? FilterdocumentId { get; set; }
            /// <summary>The `linked_record_type` of the document to filter on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Blinked_record_type%5D")]
            public string? FilterlinkedRecordType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Blinked_record_type%5D")]
            public string FilterlinkedRecordType { get; set; }
#endif
            /// <summary>The `linked_resource_id` of the document to filter on.</summary>
            [QueryParameter("filter%5Blinked_resource_id%5D")]
            public Guid? FilterlinkedResourceId { get; set; }
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
        public partial class Document_linksRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Document_links.Document_linksRequestBuilder.Document_linksRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
