// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Texml.Accounts.Item.Calls.Item.Streams.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Texml.Accounts.Item.Calls.Item.Streams
{
    /// <summary>
    /// Builds and executes requests for operations under \texml\Accounts\{account_sid}\Calls\{call_sid}\Streams
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StreamsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.texml.Accounts.item.Calls.item.Streams.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Texml.Accounts.Item.Calls.Item.Streams.Item.WithStreaming_sidJsonItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Texml.Accounts.Item.Calls.Item.Streams.Item.WithStreaming_sidJsonItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("streaming_sid", position);
                return new global::Soenneker.Telnyx.Texml.Accounts.Item.Calls.Item.Streams.Item.WithStreaming_sidJsonItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Texml.Accounts.Item.Calls.Item.Streams.StreamsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StreamsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}/Calls/{call_sid}/Streams", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Texml.Accounts.Item.Calls.Item.Streams.StreamsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StreamsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/texml/Accounts/{account_sid}/Calls/{call_sid}/Streams", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
