// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Conferences;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Recordings;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.RecordingsJson;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Transcriptions;
using Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.TranscriptionsJson;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \texml\Accounts\{account_sid}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithAccount_sItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The Calls property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.CallsRequestBuilder Calls
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Calls.CallsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Conferences property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder Conferences
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Conferences.ConferencesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Recordings property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Recordings.RecordingsRequestBuilder Recordings
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Recordings.RecordingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The RecordingsJson property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.RecordingsJson.RecordingsJsonRequestBuilder RecordingsJson
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.RecordingsJson.RecordingsJsonRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Transcriptions property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Transcriptions.TranscriptionsRequestBuilder Transcriptions
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.Transcriptions.TranscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The TranscriptionsJson property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.TranscriptionsJson.TranscriptionsJsonRequestBuilder TranscriptionsJson
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.TranscriptionsJson.TranscriptionsJsonRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.WithAccount_sItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAccount_sItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Texml.Accounts.Item.WithAccount_sItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAccount_sItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
