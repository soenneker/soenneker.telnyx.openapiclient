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
namespace Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice
{
    /// <summary>
    /// Builds and executes requests for operations under \phone_numbers\voice
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class VoiceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VoiceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers/voice{?filter%5Bconnection_name%5D%5Bcontains%5D*,filter%5Bcustomer_reference%5D*,filter%5Bphone_number%5D*,filter%5Bvoice%2Eusage_payment_method%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VoiceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers/voice{?filter%5Bconnection_name%5D%5Bcontains%5D*,filter%5Bcustomer_reference%5D*,filter%5Bphone_number%5D*,filter%5Bvoice%2Eusage_payment_method%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// List phone numbers with voice settings
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceGetResponse?> GetAsVoiceGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder.VoiceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceGetResponse> GetAsVoiceGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder.VoiceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List phone numbers with voice settings
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsVoiceGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder.VoiceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder.VoiceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List phone numbers with voice settings
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder.VoiceRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder.VoiceRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List phone numbers with voice settings
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class VoiceRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter contains connection name. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bconnection_name%5D%5Bcontains%5D")]
            public string? FilterconnectionNamecontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bconnection_name%5D%5Bcontains%5D")]
            public string FilterconnectionNamecontains { get; set; }
#endif
            /// <summary>Filter numbers via the customer_reference set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcustomer_reference%5D")]
            public string? FiltercustomerReference { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcustomer_reference%5D")]
            public string FiltercustomerReference { get; set; }
#endif
            /// <summary>Filter by phone number. Requires at least three digits.             Non-numerical characters will result in no values being returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bphone_number%5D")]
            public string? FilterphoneNumber { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bphone_number%5D")]
            public string FilterphoneNumber { get; set; }
#endif
            /// <summary>Filter by usage_payment_method.</summary>
            [Obsolete("This property is deprecated, use FiltervoiceUsagePaymentMethodAsGetFilterVoiceUsagePaymentMethodQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bvoice%2Eusage_payment_method%5D")]
            public string? FiltervoiceUsagePaymentMethod { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bvoice%2Eusage_payment_method%5D")]
            public string FiltervoiceUsagePaymentMethod { get; set; }
#endif
            /// <summary>Filter by usage_payment_method.</summary>
            [QueryParameter("filter%5Bvoice%2Eusage_payment_method%5D")]
            public global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.GetFilterVoiceUsage_payment_methodQueryParameterType? FiltervoiceUsagePaymentMethodAsGetFilterVoiceUsagePaymentMethodQueryParameterType { get; set; }
            /// <summary>The page number to load.</summary>
            [QueryParameter("page%5Bnumber%5D")]
            public int? Pagenumber { get; set; }
            /// <summary>The size of the page.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
            /// <summary>Specifies the sort order for results. If not given, results are sorted by created_at in descending order.</summary>
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
            /// <summary>Specifies the sort order for results. If not given, results are sorted by created_at in descending order.</summary>
            [QueryParameter("sort")]
            public global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class VoiceRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers.Voice.VoiceRequestBuilder.VoiceRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
