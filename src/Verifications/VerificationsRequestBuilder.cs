// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Telnyx.Verifications.By_phone_number;
using Soenneker.Telnyx.Verifications.Call;
using Soenneker.Telnyx.Verifications.Flashcall;
using Soenneker.Telnyx.Verifications.Item;
using Soenneker.Telnyx.Verifications.Sms;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Telnyx.Verifications
{
    /// <summary>
    /// Builds and executes requests for operations under \verifications
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class VerificationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The by_phone_number property</summary>
        public global::Soenneker.Telnyx.Verifications.By_phone_number.By_phone_numberRequestBuilder By_phone_number
        {
            get => new global::Soenneker.Telnyx.Verifications.By_phone_number.By_phone_numberRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The call property</summary>
        public global::Soenneker.Telnyx.Verifications.Call.CallRequestBuilder Call
        {
            get => new global::Soenneker.Telnyx.Verifications.Call.CallRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flashcall property</summary>
        public global::Soenneker.Telnyx.Verifications.Flashcall.FlashcallRequestBuilder Flashcall
        {
            get => new global::Soenneker.Telnyx.Verifications.Flashcall.FlashcallRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sms property</summary>
        public global::Soenneker.Telnyx.Verifications.Sms.SmsRequestBuilder Sms
        {
            get => new global::Soenneker.Telnyx.Verifications.Sms.SmsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.verifications.item collection</summary>
        /// <param name="position">The identifier of the verification to retrieve.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Verifications.Item.WithVerification_ItemRequestBuilder"/></returns>
        public global::Soenneker.Telnyx.Verifications.Item.WithVerification_ItemRequestBuilder this[Guid position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("verification_id", position);
                return new global::Soenneker.Telnyx.Verifications.Item.WithVerification_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.Telnyx.verifications.item collection</summary>
        /// <param name="position">The identifier of the verification to retrieve.</param>
        /// <returns>A <see cref="global::Soenneker.Telnyx.Verifications.Item.WithVerification_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.Telnyx.Verifications.Item.WithVerification_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("verification_id", position);
                return new global::Soenneker.Telnyx.Verifications.Item.WithVerification_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Verifications.VerificationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerificationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/verifications", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.Verifications.VerificationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerificationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/verifications", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
