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
namespace Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements
{
    /// <summary>
    /// Builds and executes requests for operations under \phone_numbers_regulatory_requirements
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Phone_numbers_regulatory_requirementsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbers_regulatory_requirementsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers_regulatory_requirements?filter[phone_number]={filter%5Bphone_number%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbers_regulatory_requirementsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers_regulatory_requirements?filter[phone_number]={filter%5Bphone_number%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve regulatory requirements for a list of phone numbers
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsGetResponse?> GetAsPhone_numbers_regulatory_requirementsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder.Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsGetResponse> GetAsPhone_numbers_regulatory_requirementsGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder.Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsGetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve regulatory requirements for a list of phone numbers
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsPhone_numbers_regulatory_requirementsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder.Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder.Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.OpenApiClient.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve regulatory requirements for a list of phone numbers
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder.Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder.Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve regulatory requirements for a list of phone numbers
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters 
        {
            /// <summary>Record type phone number/ phone numbers</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bphone_number%5D")]
            public string? FilterphoneNumber { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bphone_number%5D")]
            public string FilterphoneNumber { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_numbers_regulatory_requirementsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.OpenApiClient.Phone_numbers_regulatory_requirements.Phone_numbers_regulatory_requirementsRequestBuilder.Phone_numbers_regulatory_requirementsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
