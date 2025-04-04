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
namespace Soenneker.Telnyx.OpenApiClient.Inventory_coverage
{
    /// <summary>
    /// Builds and executes requests for operations under \inventory_coverage
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Inventory_coverageRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Inventory_coverageRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/inventory_coverage?filter[groupBy]={filter%5BgroupBy%5D}{&filter%5Badministrative_area%5D*,filter%5Bcount%5D*,filter%5Bcountry_code%5D*,filter%5Bfeatures%5D*,filter%5Bnpa%5D*,filter%5Bnxx%5D*,filter%5Bphone_number_type%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Inventory_coverageRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/inventory_coverage?filter[groupBy]={filter%5BgroupBy%5D}{&filter%5Badministrative_area%5D*,filter%5Bcount%5D*,filter%5Bcountry_code%5D*,filter%5Bfeatures%5D*,filter%5Bnpa%5D*,filter%5Bnxx%5D*,filter%5Bphone_number_type%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Creates an inventory coverage request. If locality, npa or national_destination_code is used in groupBy, and no region or locality filters are used, the whole paginated set is returned.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageGetResponse?> GetAsInventory_coverageGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder.Inventory_coverageRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageGetResponse> GetAsInventory_coverageGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder.Inventory_coverageRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an inventory coverage request. If locality, npa or national_destination_code is used in groupBy, and no region or locality filters are used, the whole paginated set is returned.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsInventory_coverageGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder.Inventory_coverageRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder.Inventory_coverageRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates an inventory coverage request. If locality, npa or national_destination_code is used in groupBy, and no region or locality filters are used, the whole paginated set is returned.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder.Inventory_coverageRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder.Inventory_coverageRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Creates an inventory coverage request. If locality, npa or national_destination_code is used in groupBy, and no region or locality filters are used, the whole paginated set is returned.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Inventory_coverageRequestBuilderGetQueryParameters 
        {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Badministrative_area%5D")]
            public string? FilteradministrativeArea { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Badministrative_area%5D")]
            public string FilteradministrativeArea { get; set; }
#endif
            [QueryParameter("filter%5Bcount%5D")]
            public bool? Filtercount { get; set; }
            [Obsolete("This property is deprecated, use FiltercountryCodeAsGetFilterCountryCodeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcountry_code%5D")]
            public string? FiltercountryCode { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcountry_code%5D")]
            public string FiltercountryCode { get; set; }
#endif
            [QueryParameter("filter%5Bcountry_code%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.GetFilterCountry_codeQueryParameterType? FiltercountryCodeAsGetFilterCountryCodeQueryParameterType { get; set; }
            /// <summary>Filter if the phone number should be used for voice, fax, mms, sms, emergency. Returns features in the response when used.</summary>
            [Obsolete("This property is deprecated, use FilterfeaturesAsGetFilterFeaturesQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bfeatures%5D")]
            public string[]? Filterfeatures { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bfeatures%5D")]
            public string[] Filterfeatures { get; set; }
#endif
            /// <summary>Filter if the phone number should be used for voice, fax, mms, sms, emergency. Returns features in the response when used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bfeatures%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.GetFilterFeaturesQueryParameterType[]? FilterfeaturesAsGetFilterFeaturesQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bfeatures%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.GetFilterFeaturesQueryParameterType[] FilterfeaturesAsGetFilterFeaturesQueryParameterType { get; set; }
#endif
            [Obsolete("This property is deprecated, use FiltergroupByAsGetFilterGroupByQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5BgroupBy%5D")]
            public string? FiltergroupBy { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5BgroupBy%5D")]
            public string FiltergroupBy { get; set; }
#endif
            [QueryParameter("filter%5BgroupBy%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.GetFilterGroupByQueryParameterType? FiltergroupByAsGetFilterGroupByQueryParameterType { get; set; }
            [QueryParameter("filter%5Bnpa%5D")]
            public int? Filternpa { get; set; }
            [QueryParameter("filter%5Bnxx%5D")]
            public int? Filternxx { get; set; }
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
            [QueryParameter("filter%5Bphone_number_type%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.GetFilterPhone_number_typeQueryParameterType? FilterphoneNumberTypeAsGetFilterPhoneNumberTypeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Inventory_coverageRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Inventory_coverage.Inventory_coverageRequestBuilder.Inventory_coverageRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
