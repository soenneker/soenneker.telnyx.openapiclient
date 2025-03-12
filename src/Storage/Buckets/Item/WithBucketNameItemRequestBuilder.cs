// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Storage.Buckets.Item.Item;
using Soenneker.Telnyx.Storage.Buckets.Item.Ssl_certificate;
using Soenneker.Telnyx.Storage.Buckets.Item.Usage;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Storage.Buckets.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \storage\buckets\{bucketName}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithBucketNameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ssl_certificate property</summary>
        public global::Soenneker.Telnyx.Storage.Buckets.Item.Ssl_certificate.Ssl_certificateRequestBuilder Ssl_certificate
        {
            get => new global::Soenneker.Telnyx.Storage.Buckets.Item.Ssl_certificate.Ssl_certificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The usage property</summary>
        public global::Soenneker.Telnyx.Storage.Buckets.Item.Usage.UsageRequestBuilder Usage
        {
            get => new global::Soenneker.Telnyx.Storage.Buckets.Item.Usage.UsageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.storage.buckets.item.item collection</summary>
        /// <param name="position">The name of the object</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Storage.Buckets.Item.Item.WithObjectNameItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Storage.Buckets.Item.Item.WithObjectNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("objectName", position);
                return new global::Soenneker.Telnyx.Storage.Buckets.Item.Item.WithObjectNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Storage.Buckets.Item.WithBucketNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBucketNameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/buckets/{bucketName}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Storage.Buckets.Item.WithBucketNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBucketNameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/buckets/{bucketName}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
