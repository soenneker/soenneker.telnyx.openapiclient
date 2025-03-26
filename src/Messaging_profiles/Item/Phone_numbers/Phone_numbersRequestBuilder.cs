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
namespace Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers
{
    /// <summary>
    /// Builds and executes requests for operations under \messaging_profiles\{-id}\phone_numbers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Phone_numbersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/messaging_profiles/{%2Did}/phone_numbers{?page%5Bnumber%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/messaging_profiles/{%2Did}/phone_numbers{?page%5Bnumber%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// List phone numbers associated with a messaging profile
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersGetResponse?> GetAsPhone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersGetResponse> GetAsPhone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersGetResponse>(requestInfo, global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List phone numbers associated with a messaging profile
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsPhone_numbersGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersResponse>(requestInfo, global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List phone numbers associated with a messaging profile
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List phone numbers associated with a messaging profile
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_numbersRequestBuilderGetQueryParameters 
        {
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
        public partial class Phone_numbersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Messaging_profiles.Item.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
