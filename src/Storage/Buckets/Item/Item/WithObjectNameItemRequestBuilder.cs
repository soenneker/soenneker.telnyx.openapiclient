// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Storage.Buckets.Item.Item.Presigned_url;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Storage.Buckets.Item.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \storage\buckets\{bucketName}\{objectName}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithObjectNameItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The presigned_url property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Storage.Buckets.Item.Item.Presigned_url.Presigned_urlRequestBuilder Presigned_url
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Storage.Buckets.Item.Item.Presigned_url.Presigned_urlRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Storage.Buckets.Item.Item.WithObjectNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithObjectNameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/buckets/{bucketName}/{objectName}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Storage.Buckets.Item.Item.WithObjectNameItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithObjectNameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/storage/buckets/{bucketName}/{objectName}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
