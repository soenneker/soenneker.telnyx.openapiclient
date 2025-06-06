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
namespace Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \customer_service_records\{customer_service_record_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithCustomer_service_record_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCustomer_service_record_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/customer_service_records/{customer_service_record_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCustomer_service_record_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/customer_service_records/{customer_service_record_id}", rawUrl)
        {
        }
        /// <summary>
        /// Get a specific customer service record.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_GetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_500Error">When receiving a 500 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_GetResponse?> GetAsWithCustomer_service_record_GetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_GetResponse> GetAsWithCustomer_service_record_GetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_401Error.CreateFromDiscriminatorValue },
                { "403", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_403Error.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_404Error.CreateFromDiscriminatorValue },
                { "500", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_GetResponse>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_GetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a specific customer service record.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_Response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_401Error">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_403Error">When receiving a 403 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_404Error">When receiving a 404 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_500Error">When receiving a 500 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsWithCustomer_service_record_GetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_Response?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_Response> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_401Error.CreateFromDiscriminatorValue },
                { "403", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_403Error.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_404Error.CreateFromDiscriminatorValue },
                { "500", global::Soenneker.Telnyx.OpenApiClient.Models.WithCustomer_service_record_500Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_Response>(requestInfo, global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a specific customer service record.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.OpenApiClient.Customer_service_records.Item.WithCustomer_service_record_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithCustomer_service_record_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
