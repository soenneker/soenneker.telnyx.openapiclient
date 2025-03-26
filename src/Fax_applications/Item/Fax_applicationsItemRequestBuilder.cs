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
namespace Soenneker.Telnyx.Fax_applications.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \fax_applications\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Fax_applicationsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Fax_applicationsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fax_applications/{id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Fax_applicationsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fax_applications/{id}", rawUrl)
        {
        }
        /// <summary>
        /// Permanently deletes a Fax Application. Deletion may be prevented if the application is in use by phone numbers.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsDeleteResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsDeleteResponse?> DeleteAsFax_applicationsDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsDeleteResponse> DeleteAsFax_applicationsDeleteResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsDeleteResponse>(requestInfo, global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsDeleteResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Permanently deletes a Fax Application. Deletion may be prevented if the application is in use by phone numbers.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 404 status code</exception>
        [Obsolete("This method is obsolete. Use DeleteAsFax_applicationsDeleteResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse?> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse> DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse>(requestInfo, global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Return the details of an existing Fax Application inside the &apos;data&apos; attribute of the response.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsGetResponse?> GetAsFax_applicationsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsGetResponse> GetAsFax_applicationsGetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsGetResponse>(requestInfo, global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Return the details of an existing Fax Application inside the &apos;data&apos; attribute of the response.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 400 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 404 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsFax_applicationsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "401", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse>(requestInfo, global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates settings of an existing Fax Application based on the parameters of the request.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsPatchResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsPatchResponse?> PatchAsFax_applicationsPatchResponseAsync(global::Soenneker.Telnyx.Models.UpdateFaxApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsPatchResponse> PatchAsFax_applicationsPatchResponseAsync(global::Soenneker.Telnyx.Models.UpdateFaxApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsPatchResponse>(requestInfo, global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsPatchResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates settings of an existing Fax Application based on the parameters of the request.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 401 status code</exception>
        /// <exception cref="global::Soenneker.Telnyx.Models.ErrorResponse">When receiving a 404 status code</exception>
        [Obsolete("This method is obsolete. Use PatchAsFax_applicationsPatchResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse?> PatchAsync(global::Soenneker.Telnyx.Models.UpdateFaxApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse> PatchAsync(global::Soenneker.Telnyx.Models.UpdateFaxApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "401", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
                { "404", global::Soenneker.Telnyx.Models.ErrorResponse.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse>(requestInfo, global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Permanently deletes a Fax Application. Deletion may be prevented if the application is in use by phone numbers.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Return the details of an existing Fax Application inside the &apos;data&apos; attribute of the response.
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
        /// Updates settings of an existing Fax Application based on the parameters of the request.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Soenneker.Telnyx.Models.UpdateFaxApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Soenneker.Telnyx.Models.UpdateFaxApplicationRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Fax_applications.Item.Fax_applicationsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Fax_applicationsItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Fax_applicationsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Fax_applicationsItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
