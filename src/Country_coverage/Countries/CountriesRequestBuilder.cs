// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Country_coverage.Countries.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Country_coverage.Countries
{
    /// <summary>
    /// Builds and executes requests for operations under \country_coverage\countries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CountriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.Telnyx.country_coverage.countries.item collection</summary>
        /// <param name="position">Country ISO code.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Country_coverage.Countries.Item.WithCountry_codeItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Country_coverage.Countries.Item.WithCountry_codeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("country_code", position);
                return new global::Soenneker.Telnyx.Country_coverage.Countries.Item.WithCountry_codeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Country_coverage.Countries.CountriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CountriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/country_coverage/countries", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Country_coverage.Countries.CountriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CountriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/country_coverage/countries", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
