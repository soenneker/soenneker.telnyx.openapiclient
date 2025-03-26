// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Models;
using Soenneker.Telnyx.Phone_numbers.Csv_downloads;
using Soenneker.Telnyx.Phone_numbers.Inbound_channels;
using Soenneker.Telnyx.Phone_numbers.Item;
using Soenneker.Telnyx.Phone_numbers.Jobs;
using Soenneker.Telnyx.Phone_numbers.Messaging;
using Soenneker.Telnyx.Phone_numbers.Slim;
using Soenneker.Telnyx.Phone_numbers.Voice;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Telnyx.Phone_numbers
{
    /// <summary>
    /// Builds and executes requests for operations under \phone_numbers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Phone_numbersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The csv_downloads property</summary>
        public global::Soenneker.Telnyx.Phone_numbers.Csv_downloads.Csv_downloadsRequestBuilder Csv_downloads
        {
            get => new global::Soenneker.Telnyx.Phone_numbers.Csv_downloads.Csv_downloadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The inbound_channels property</summary>
        public global::Soenneker.Telnyx.Phone_numbers.Inbound_channels.Inbound_channelsRequestBuilder Inbound_channels
        {
            get => new global::Soenneker.Telnyx.Phone_numbers.Inbound_channels.Inbound_channelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The jobs property</summary>
        public global::Soenneker.Telnyx.Phone_numbers.Jobs.JobsRequestBuilder Jobs
        {
            get => new global::Soenneker.Telnyx.Phone_numbers.Jobs.JobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The messaging property</summary>
        public global::Soenneker.Telnyx.Phone_numbers.Messaging.MessagingRequestBuilder Messaging
        {
            get => new global::Soenneker.Telnyx.Phone_numbers.Messaging.MessagingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The slim property</summary>
        public global::Soenneker.Telnyx.Phone_numbers.Slim.SlimRequestBuilder Slim
        {
            get => new global::Soenneker.Telnyx.Phone_numbers.Slim.SlimRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The voice property</summary>
        public global::Soenneker.Telnyx.Phone_numbers.Voice.VoiceRequestBuilder Voice
        {
            get => new global::Soenneker.Telnyx.Phone_numbers.Voice.VoiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.phone_numbers.item collection</summary>
        /// <param name="position">Identifies the resource.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Phone_numbers.Item.ItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Phone_numbers.Item.ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("%2Did", position);
                return new global::Soenneker.Telnyx.Phone_numbers.Item.ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers{?filter%5Bbilling_group_id%5D*,filter%5Bconnection_id%5D*,filter%5Bcountry_iso_alpha2%5D*,filter%5Bcustomer_reference%5D*,filter%5Bemergency_address_id%5D*,filter%5Bnumber_type%5D%5Beq%5D*,filter%5Bphone_number%5D*,filter%5Bsource%5D*,filter%5Bstatus%5D*,filter%5Btag%5D*,filter%5Bvoice%2Econnection_name%5D%5Bcontains%5D*,filter%5Bvoice%2Econnection_name%5D%5Bends_with%5D*,filter%5Bvoice%2Econnection_name%5D%5Beq%5D*,filter%5Bvoice%2Econnection_name%5D%5Bstarts_with%5D*,filter%5Bvoice%2Eusage_payment_method%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Phone_numbersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/phone_numbers{?filter%5Bbilling_group_id%5D*,filter%5Bconnection_id%5D*,filter%5Bcountry_iso_alpha2%5D*,filter%5Bcustomer_reference%5D*,filter%5Bemergency_address_id%5D*,filter%5Bnumber_type%5D%5Beq%5D*,filter%5Bphone_number%5D*,filter%5Bsource%5D*,filter%5Bstatus%5D*,filter%5Btag%5D*,filter%5Bvoice%2Econnection_name%5D%5Bcontains%5D*,filter%5Bvoice%2Econnection_name%5D%5Bends_with%5D*,filter%5Bvoice%2Econnection_name%5D%5Beq%5D*,filter%5Bvoice%2Econnection_name%5D%5Bstarts_with%5D*,filter%5Bvoice%2Eusage_payment_method%5D*,page%5Bnumber%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// List phone numbers
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Phone_numbers.Phone_numbersGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersGetResponse?> GetAsPhone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersGetResponse> GetAsPhone_numbersGetResponseAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersGetResponse>(requestInfo, global::Soenneker.Telnyx.Phone_numbers.Phone_numbersGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List phone numbers
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Phone_numbers.Phone_numbersResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Soenneker.Telnyx.Models.Errors">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsPhone_numbersGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersResponse?> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersResponse> GetAsync(Action<RequestConfiguration<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Soenneker.Telnyx.Models.Errors.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersResponse>(requestInfo, global::Soenneker.Telnyx.Phone_numbers.Phone_numbersResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List phone numbers
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List phone numbers
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_numbersRequestBuilderGetQueryParameters 
        {
            /// <summary>Filter by the billing_group_id associated with phone numbers. To filter to only phone numbers that have no billing group associated them, set the value of this filter to the string &apos;null&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bbilling_group_id%5D")]
            public string? FilterbillingGroupId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bbilling_group_id%5D")]
            public string FilterbillingGroupId { get; set; }
#endif
            /// <summary>Filter by connection_id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bconnection_id%5D")]
            public string? FilterconnectionId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bconnection_id%5D")]
            public string FilterconnectionId { get; set; }
#endif
            /// <summary>Filter by phone number country ISO alpha-2 code. Can be a single value or an array of values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bcountry_iso_alpha2%5D")]
            public string? FiltercountryIsoAlpha2 { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bcountry_iso_alpha2%5D")]
            public string FiltercountryIsoAlpha2 { get; set; }
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
            /// <summary>Filter by the emergency_address_id associated with phone numbers. To filter only phone numbers that have no emergency address associated with them, set the value of this filter to the string &apos;null&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bemergency_address_id%5D")]
            public string? FilteremergencyAddressId { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bemergency_address_id%5D")]
            public string FilteremergencyAddressId { get; set; }
#endif
            /// <summary>Filter phone numbers by phone number type.</summary>
            [Obsolete("This property is deprecated, use FilternumberTypeeqAsGetFilterNumberTypeEqQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bnumber_type%5D%5Beq%5D")]
            public string? FilternumberTypeeq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bnumber_type%5D%5Beq%5D")]
            public string FilternumberTypeeq { get; set; }
#endif
            /// <summary>Filter phone numbers by phone number type.</summary>
            [QueryParameter("filter%5Bnumber_type%5D%5Beq%5D")]
            public global::Soenneker.Telnyx.Phone_numbers.GetFilterNumber_typeEqQueryParameterType? FilternumberTypeeqAsGetFilterNumberTypeEqQueryParameterType { get; set; }
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
            /// <summary>Filter phone numbers by their source. Use &apos;ported&apos; for numbers ported from other carriers, or &apos;purchased&apos; for numbers bought directly from Telnyx.</summary>
            [Obsolete("This property is deprecated, use FiltersourceAsGetFilterSourceQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bsource%5D")]
            public string? Filtersource { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bsource%5D")]
            public string Filtersource { get; set; }
#endif
            /// <summary>Filter phone numbers by their source. Use &apos;ported&apos; for numbers ported from other carriers, or &apos;purchased&apos; for numbers bought directly from Telnyx.</summary>
            [QueryParameter("filter%5Bsource%5D")]
            public global::Soenneker.Telnyx.Phone_numbers.GetFilterSourceQueryParameterType? FiltersourceAsGetFilterSourceQueryParameterType { get; set; }
            /// <summary>Filter by phone number status.</summary>
            [Obsolete("This property is deprecated, use FilterstatusAsGetFilterStatusQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bstatus%5D")]
            public string? Filterstatus { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bstatus%5D")]
            public string Filterstatus { get; set; }
#endif
            /// <summary>Filter by phone number status.</summary>
            [QueryParameter("filter%5Bstatus%5D")]
            public global::Soenneker.Telnyx.Phone_numbers.GetFilterStatusQueryParameterType? FilterstatusAsGetFilterStatusQueryParameterType { get; set; }
            /// <summary>Filter by phone number tags.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Btag%5D")]
            public string? Filtertag { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Btag%5D")]
            public string Filtertag { get; set; }
#endif
            /// <summary>Filter contains connection name. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Bcontains%5D")]
            public string? FiltervoiceConnectionNamecontains { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Bcontains%5D")]
            public string FiltervoiceConnectionNamecontains { get; set; }
#endif
            /// <summary>Filter ends with connection name. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Bends_with%5D")]
            public string? FiltervoiceConnectionNameendsWith { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Bends_with%5D")]
            public string FiltervoiceConnectionNameendsWith { get; set; }
#endif
            /// <summary>Filter by connection name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Beq%5D")]
            public string? FiltervoiceConnectionNameeq { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Beq%5D")]
            public string FiltervoiceConnectionNameeq { get; set; }
#endif
            /// <summary>Filter starts with connection name. Requires at least three characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Bstarts_with%5D")]
            public string? FiltervoiceConnectionNamestartsWith { get; set; }
#nullable restore
#else
            [QueryParameter("filter%5Bvoice%2Econnection_name%5D%5Bstarts_with%5D")]
            public string FiltervoiceConnectionNamestartsWith { get; set; }
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
            public global::Soenneker.Telnyx.Phone_numbers.GetFilterVoiceUsage_payment_methodQueryParameterType? FiltervoiceUsagePaymentMethodAsGetFilterVoiceUsagePaymentMethodQueryParameterType { get; set; }
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
            public global::Soenneker.Telnyx.Phone_numbers.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Phone_numbersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Soenneker.Telnyx.Phone_numbers.Phone_numbersRequestBuilder.Phone_numbersRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
