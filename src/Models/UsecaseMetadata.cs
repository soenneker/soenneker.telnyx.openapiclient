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
    public partial class UsecaseMetadata : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Campaign annual subscription fee</summary>
        public double? AnnualFee { get; set; }
        /// <summary>Maximum number of sub-usecases declaration required.</summary>
        public int? MaxSubUsecases { get; set; }
        /// <summary>Minimum number of sub-usecases declaration required.</summary>
        public int? MinSubUsecases { get; set; }
        /// <summary>Map of usecase metadata for each MNO. Key is the network ID of the MNO (e.g. 10017), Value is the mno metadata for the usecase.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata_mnoMetadata? MnoMetadata { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata_mnoMetadata MnoMetadata { get; set; }
#endif
        /// <summary>Campaign monthly subscription fee</summary>
        public double? MonthlyFee { get; set; }
        /// <summary>Campaign quarterly subscription fee</summary>
        public double? QuarterlyFee { get; set; }
        /// <summary>Campaign usecase</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Usecase { get; set; }
#nullable restore
#else
        public string Usecase { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata"/> and sets the default values.
        /// </summary>
        public UsecaseMetadata()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "annualFee", n => { AnnualFee = n.GetDoubleValue(); } },
                { "maxSubUsecases", n => { MaxSubUsecases = n.GetIntValue(); } },
                { "minSubUsecases", n => { MinSubUsecases = n.GetIntValue(); } },
                { "mnoMetadata", n => { MnoMetadata = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata_mnoMetadata>(global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata_mnoMetadata.CreateFromDiscriminatorValue); } },
                { "monthlyFee", n => { MonthlyFee = n.GetDoubleValue(); } },
                { "quarterlyFee", n => { QuarterlyFee = n.GetDoubleValue(); } },
                { "usecase", n => { Usecase = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("annualFee", AnnualFee);
            writer.WriteIntValue("maxSubUsecases", MaxSubUsecases);
            writer.WriteIntValue("minSubUsecases", MinSubUsecases);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.UsecaseMetadata_mnoMetadata>("mnoMetadata", MnoMetadata);
            writer.WriteDoubleValue("monthlyFee", MonthlyFee);
            writer.WriteDoubleValue("quarterlyFee", QuarterlyFee);
            writer.WriteStringValue("usecase", Usecase);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
