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
namespace Soenneker.Telnyx.OpenApiClient.Available_phone_numbers
{
    /// <summary>
    /// Builds and executes requests for operations under \available_phone_numbers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Available_phone_numbersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Available_phone_numbersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/available_phone_numbers{?filter%5Badministrative_area%5D*,filter%5Bbest_effort%5D*,filter%5Bcountry_code%5D*,filter%5Bexclude_held_numbers%5D*,filter%5Bfeatures%5D*,filter%5Blimit%5D*,filter%5Blocality%5D*,filter%5Bnational_destination_code%5D*,filter%5Bphone_number%5D%5Bcontains%5D*,filter%5Bphone_number%5D%5Bends_with%5D*,filter%5Bphone_number%5D%5Bstarts_with%5D*,filter%5Bphone_number_type%5D*,filter%5Bquickship%5D*,filter%5Brate_center%5D*,filter%5Breservable%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Available_phone_numbersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/available_phone_numbers{?filter%5Badministrative_area%5D*,filter%5Bbest_effort%5D*,filter%5Bcountry_code%5D*,filter%5Bexclude_held_numbers%5D*,filter%5Bfeatures%5D*,filter%5Blimit%5D*,filter%5Blocality%5D*,filter%5Bnational_destination_code%5D*,filter%5Bphone_number%5D%5Bcontains%5D*,filter%5Bphone_number%5D%5Bends_with%5D*,filter%5Bphone_number%5D%5Bstarts_with%5D*,filter%5Bphone_number_type%5D*,filter%5Bquickship%5D*,filter%5Brate_center%5D*,filter%5Breservable%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// List available phone numbers
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersGetResponse?> GetAsAvailable_phone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder.Available_phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersGetResponse> GetAsAvailable_phone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder.Available_phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List available phone numbers
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsAvailable_phone_numbersGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder.Available_phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder.Available_phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List available phone numbers
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder.Available_phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder.Available_phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List available phone numbers
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Available_phone_numbersRequestBuilderGetQueryParameters 
        {
            /// <summary>Find numbers in a particular US state or CA province.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Badministrative_area%5D")]
            public string? FilteradministrativeArea { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Badministrative_area%5D")]
            public string FilteradministrativeArea { get; set; }
#endif
            /// <summary>Filter to determine if best effort results should be included. Only available in USA/CANADA.</summary>
            [QueryParameter("filter%5Bbest_effort%5D")]
            public bool? FilterbestEffort { get; set; }
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
            /// <summary>Filter to exclude phone numbers that are currently on hold/reserved for your account.</summary>
            [QueryParameter("filter%5Bexclude_held_numbers%5D")]
            public bool? FilterexcludeHeldNumbers { get; set; }
            /// <summary>Filter phone numbers with specific features.</summary>
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
            /// <summary>Filter phone numbers with specific features.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bfeatures%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.GetFilterFeaturesQueryParameterType[]? FilterfeaturesAsGetFilterFeaturesQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bfeatures%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.GetFilterFeaturesQueryParameterType[] FilterfeaturesAsGetFilterFeaturesQueryParameterType { get; set; }
#endif
            /// <summary>Limits the number of results.</summary>
            [QueryParameter("filter%5Blimit%5D")]
            public int? Filterlimit { get; set; }
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
            /// <summary>Filter numbers containing a pattern (excludes NDC if used with `national_destination_code` filter).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bphone_number%5D%5Bcontains%5D")]
            public string? FilterphoneNumbercontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bphone_number%5D%5Bcontains%5D")]
            public string FilterphoneNumbercontains { get; set; }
#endif
            /// <summary>Filter numbers ending with a pattern (excludes NDC if used with `national_destination_code` filter).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bphone_number%5D%5Bends_with%5D")]
            public string? FilterphoneNumberendsWith { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bphone_number%5D%5Bends_with%5D")]
            public string FilterphoneNumberendsWith { get; set; }
#endif
            /// <summary>Filter numbers starting with a pattern (excludes NDC if used with `national_destination_code` filter).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bphone_number%5D%5Bstarts_with%5D")]
            public string? FilterphoneNumberstartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bphone_number%5D%5Bstarts_with%5D")]
            public string FilterphoneNumberstartsWith { get; set; }
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
            public global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.GetFilterPhone_number_typeQueryParameterType? FilterphoneNumberTypeAsGetFilterPhoneNumberTypeQueryParameterType { get; set; }
            /// <summary>Filter to exclude phone numbers that need additional time after to purchase to activate. Only applicable for +1 toll_free numbers.</summary>
            [QueryParameter("filter%5Bquickship%5D")]
            public bool? Filterquickship { get; set; }
            /// <summary>Filter phone numbers by rate center. This filter is only applicable to USA and Canada numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Brate_center%5D")]
            public string? FilterrateCenter { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Brate_center%5D")]
            public string FilterrateCenter { get; set; }
#endif
            /// <summary>Filter to ensure only numbers that can be reserved are included in the results.</summary>
            [QueryParameter("filter%5Breservable%5D")]
            public bool? Filterreservable { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Available_phone_numbersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Available_phone_numbers.Available_phone_numbersRequestBuilder.Available_phone_numbersRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
