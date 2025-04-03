// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks
{
    /// <summary>
    /// Builds and executes requests for operations under \available_phone_number_blocks
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Available_phone_number_blocksRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Available_phone_number_blocksRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/available_phone_number_blocks{?filter%5Bcountry_code%5D*,filter%5Blocality%5D*,filter%5Bnational_destination_code%5D*,filter%5Bphone_number_type%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Available_phone_number_blocksRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/available_phone_number_blocks{?filter%5Bcountry_code%5D*,filter%5Blocality%5D*,filter%5Bnational_destination_code%5D*,filter%5Bphone_number_type%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// List available phone number blocks
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksGetResponse?> GetAsAvailable_phone_number_blocksGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder.Available_phone_number_blocksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksGetResponse> GetAsAvailable_phone_number_blocksGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder.Available_phone_number_blocksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List available phone number blocks
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsAvailable_phone_number_blocksGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder.Available_phone_number_blocksRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder.Available_phone_number_blocksRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List available phone number blocks
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder.Available_phone_number_blocksRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder.Available_phone_number_blocksRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List available phone number blocks
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Available_phone_number_blocksRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter phone numbers by country.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcountry_code%5D")]
            public string? FiltercountryCode { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcountry_code%5D")]
            public string FiltercountryCode { get; set; }
#endif
            /// <summary>Filter phone numbers by city.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Blocality%5D")]
            public string? Filterlocality { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Blocality%5D")]
            public string Filterlocality { get; set; }
#endif
            /// <summary>Filter by the national destination code of the number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bnational_destination_code%5D")]
            public string? FilternationalDestinationCode { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bnational_destination_code%5D")]
            public string FilternationalDestinationCode { get; set; }
#endif
            /// <summary>Filter phone numbers by number type.</summary>
            [Obsolete("This property is deprecated, use FilterphoneNumberTypeAsGetFilterPhoneNumberTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bphone_number_type%5D")]
            public string? FilterphoneNumberType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bphone_number_type%5D")]
            public string FilterphoneNumberType { get; set; }
#endif
            /// <summary>Filter phone numbers by number type.</summary>
            [QueryParameter("filter%5Bphone_number_type%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.GetFilterPhone_number_typeQueryParameterType? FilterphoneNumberTypeAsGetFilterPhoneNumberTypeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Available_phone_number_blocksRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_number_blocks.Available_phone_number_blocksRequestBuilder.Available_phone_number_blocksRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
