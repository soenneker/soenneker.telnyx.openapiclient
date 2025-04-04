// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.OpenApiClient.Porting.Events;
using Soenneker.Telnyx.OpenApiClient.Porting.Loa_configuration;
using Soenneker.Telnyx.OpenApiClient.Porting.Loa_configurations;
using Soenneker.Telnyx.OpenApiClient.Porting.Reports;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Porting
{
    /// <summary>
    /// Builds and executes requests for operations under \porting
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PortingRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The events property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Porting.Events.EventsRequestBuilder Events
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Porting.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The loa_configuration property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Porting.Loa_configuration.Loa_configurationRequestBuilder Loa_configuration
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Porting.Loa_configuration.Loa_configurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The loa_configurations property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Porting.Loa_configurations.Loa_configurationsRequestBuilder Loa_configurations
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Porting.Loa_configurations.Loa_configurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reports property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Porting.Reports.ReportsRequestBuilder Reports
        {
            get => new global::Soenneker.Telnyx.OpenApiClient.Porting.Reports.ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting.PortingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PortingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Porting.PortingRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PortingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/porting", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
