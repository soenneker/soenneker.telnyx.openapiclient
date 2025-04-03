// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ConferenceResourceIndex : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conferences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource>? Conferences { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource> Conferences { get; set; }
#endif
        /// <summary>The number of the last element on the page, zero-indexed.</summary>
        public int? End { get; set; }
        /// <summary>/v2/texml/Accounts/61bf923e-5e4d-4595-a110-56190ea18a1b/Conferences.json?Page=0&amp;PageSize=1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstPageUri { get; set; }
#nullable restore
#else
        public string FirstPageUri { get; set; }
#endif
        /// <summary>/v2/texml/Accounts/61bf923e-5e4d-4595-a110-56190ea18a1b/Conferences.json?Page=1&amp;PageSize=1&amp;PageToken=MTY4AjgyNDkwNzIxMQ</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextPageUri { get; set; }
#nullable restore
#else
        public string NextPageUri { get; set; }
#endif
        /// <summary>Current page number, zero-indexed.</summary>
        public int? Page { get; set; }
        /// <summary>The number of items on the page</summary>
        public int? PageSize { get; set; }
        /// <summary>The number of the first element on the page, zero-indexed.</summary>
        public int? Start { get; set; }
        /// <summary>The URI of the current page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; set; }
#nullable restore
#else
        public string Uri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResourceIndex"/> and sets the default values.
        /// </summary>
        public ConferenceResourceIndex()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResourceIndex"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResourceIndex CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResourceIndex();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conferences", n => { Conferences = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource>(global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "end", n => { End = n.GetIntValue(); } },
                { "first_page_uri", n => { FirstPageUri = n.GetStringValue(); } },
                { "next_page_uri", n => { NextPageUri = n.GetStringValue(); } },
                { "page", n => { Page = n.GetIntValue(); } },
                { "page_size", n => { PageSize = n.GetIntValue(); } },
                { "start", n => { Start = n.GetIntValue(); } },
                { "uri", n => { Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ConferenceResource>("conferences", Conferences);
            writer.WriteIntValue("end", End);
            writer.WriteStringValue("first_page_uri", FirstPageUri);
            writer.WriteStringValue("next_page_uri", NextPageUri);
            writer.WriteIntValue("page", Page);
            writer.WriteIntValue("page_size", PageSize);
            writer.WriteIntValue("start", Start);
            writer.WriteStringValue("uri", Uri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
