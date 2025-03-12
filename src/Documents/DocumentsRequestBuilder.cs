// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Documents.Item;
using Soenneker.Telnyx.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Documents
{
    /// <summary>
    /// Builds and executes requests for operations under \documents
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DocumentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.documents.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.Item.DocumentsItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Documents.Item.DocumentsItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Documents.Item.DocumentsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.documents.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.Item.DocumentsItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.Documents.Item.DocumentsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("id", position);
                return new global::Soenneker.Telnyx.Documents.Item.DocumentsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocumentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/documents{?filter%5Bcreated_at%5D%5Bgt%5D*,filter%5Bcreated_at%5D%5Blt%5D*,filter%5Bcustomer_reference%5D%5Beq%5D*,filter%5Bcustomer_reference%5D%5Bin%5D%5B%5D*,filter%5Bfilename%5D%5Bcontains%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort%5B%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DocumentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/documents{?filter%5Bcreated_at%5D%5Bgt%5D*,filter%5Bcreated_at%5D%5Blt%5D*,filter%5Bcustomer_reference%5D%5Beq%5D*,filter%5Bcustomer_reference%5D%5Bin%5D%5B%5D*,filter%5Bfilename%5D%5Bcontains%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort%5B%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// List all documents ordered by created_at descending.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.DocumentsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsGetResponse?> GetAsDocumentsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsGetResponse> GetAsDocumentsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "500", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Documents.DocumentsGetResponse>(requestInfo, global::Soenneker.Telnyx.Documents.DocumentsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all documents ordered by created_at descending.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.DocumentsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDocumentsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "500", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Documents.DocumentsResponse>(requestInfo, global::Soenneker.Telnyx.Documents.DocumentsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Upload a document.&lt;br /&gt;&lt;br /&gt;Uploaded files must be linked to a service within 30 minutes or they will be automatically deleted.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.DocumentsPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 422 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsPostResponse?> PostAsDocumentsPostResponseAsync(global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsPostResponse> PostAsDocumentsPostResponseAsync(global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
                { "500", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Documents.DocumentsPostResponse>(requestInfo, global::Soenneker.Telnyx.Documents.DocumentsPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Upload a document.&lt;br /&gt;&lt;br /&gt;Uploaded files must be linked to a service within 30 minutes or they will be automatically deleted.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.DocumentsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 422 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use PostAsDocumentsPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsResponse?> PostAsync(global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Documents.DocumentsResponse> PostAsync(global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "422", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
                { "500", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Documents.DocumentsResponse>(requestInfo, global::Soenneker.Telnyx.Documents.DocumentsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List all documents ordered by created_at descending.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Upload a document.&lt;br /&gt;&lt;br /&gt;Uploaded files must be linked to a service within 30 minutes or they will be automatically deleted.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember1"/>, <see cref="global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember2"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DocumentsPostRequestBody : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember1"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember1? DocumentsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember1 DocumentsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember2"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember2? DocumentsPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember2 DocumentsPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.DocumentsPostRequestBodyMember1 = new global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.DocumentsPostRequestBodyMember2 = new global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember2();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(DocumentsPostRequestBodyMember1 != null)
                {
                    return DocumentsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(DocumentsPostRequestBodyMember2 != null)
                {
                    return DocumentsPostRequestBodyMember2.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(DocumentsPostRequestBodyMember1 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember1>(null, DocumentsPostRequestBodyMember1);
                }
                else if(DocumentsPostRequestBodyMember2 != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Telnyx.Documents.DocumentsPostRequestBodyMember2>(null, DocumentsPostRequestBodyMember2);
                }
            }
        }
        /// <summary>
        /// List all documents ordered by created_at descending.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DocumentsRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by created at greater than provided value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcreated_at%5D%5Bgt%5D")]
            public string? FiltercreatedAtgt { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcreated_at%5D%5Bgt%5D")]
            public string FiltercreatedAtgt { get; set; }
#endif
            /// <summary>Filter by created at less than provided value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcreated_at%5D%5Blt%5D")]
            public string? FiltercreatedAtlt { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcreated_at%5D%5Blt%5D")]
            public string FiltercreatedAtlt { get; set; }
#endif
            /// <summary>Filter documents by a customer references.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcustomer_reference%5D%5Beq%5D")]
            public string? FiltercustomerReferenceeq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcustomer_reference%5D%5Beq%5D")]
            public string FiltercustomerReferenceeq { get; set; }
#endif
            /// <summary>Filter documents by a list of customer references.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcustomer_reference%5D%5Bin%5D%5B%5D")]
            public string? FiltercustomerReferencein { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcustomer_reference%5D%5Bin%5D%5B%5D")]
            public string FiltercustomerReferencein { get; set; }
#endif
            /// <summary>Filter by string matching part of filename.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bfilename%5D%5Bcontains%5D")]
            public string? Filterfilenamecontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bfilename%5D%5Bcontains%5D")]
            public string Filterfilenamecontains { get; set; }
#endif
            /// <summary>The page number to load</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. If you want to sort by a field in ascending order, include it as a sort parameter. If you want to sort in descending order, prepend a `-` in front of the field name.</summary>
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
            /// <summary>Specifies the sort order for results. If you want to sort by a field in ascending order, include it as a sort parameter. If you want to sort in descending order, prepend a `-` in front of the field name.</summary>
            [QueryParameter("sort%5B%5D")]
            public global::Soenneker.Telnyx.Documents.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DocumentsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Documents.DocumentsRequestBuilder.DocumentsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DocumentsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
