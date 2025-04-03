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
    public partial class ChatCompletionRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If you are using an external inference provider like xAI or OpenAI, this field allows you to pass along a reference to your API key. After creating an [integration secret](https://developers.telnyx.com/api/secrets-manager/integration-secrets/create-integration-secret) for you API key, pass the secret&apos;s `identifier` in this field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApiKeyRef { get; set; }
#nullable restore
#else
        public string ApiKeyRef { get; set; }
#endif
        /// <summary>This is used with `use_beam_search` to determine how many candidate beams to explore.</summary>
        public int? BestOf { get; set; }
        /// <summary>This is used with `use_beam_search`. If `true`, generation stops as soon as there are `best_of` complete candidates; if `false`, a heuristic is applied and the generation stops when is it very unlikely to find better candidates.</summary>
        public bool? EarlyStopping { get; set; }
        /// <summary>Higher values will penalize the model from repeating the same output tokens.</summary>
        public double? FrequencyPenalty { get; set; }
        /// <summary>If specified, the output will be exactly one of the choices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GuidedChoice { get; set; }
#nullable restore
#else
        public List<string> GuidedChoice { get; set; }
#endif
        /// <summary>Must be a valid JSON schema. If specified, the output will follow the JSON schema.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_guided_json? GuidedJson { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_guided_json GuidedJson { get; set; }
#endif
        /// <summary>If specified, the output will follow the regex pattern.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GuidedRegex { get; set; }
#nullable restore
#else
        public string GuidedRegex { get; set; }
#endif
        /// <summary>This is used with `use_beam_search` to prefer shorter or longer completions.</summary>
        public double? LengthPenalty { get; set; }
        /// <summary>Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.</summary>
        public bool? Logprobs { get; set; }
        /// <summary>Maximum number of completion tokens the model should generate.</summary>
        public int? MaxTokens { get; set; }
        /// <summary>A list of the previous chat messages for context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam>? Messages { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam> Messages { get; set; }
#endif
        /// <summary>This is an alternative to `top_p` that [many prefer](https://github.com/huggingface/transformers/issues/27670). Must be in [0, 1].</summary>
        public double? MinP { get; set; }
        /// <summary>The language model to chat with. If you are optimizing for speed + price, try `meta-llama/Meta-Llama-3.1-8B-Instruct`. For quality, try `meta-llama/Meta-Llama-3.1-70B-Instruct`. Or explore our [LLM Library](https://telnyx.com/products/llm-library).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>This will return multiple choices for you instead of a single chat completion.</summary>
        public double? N { get; set; }
        /// <summary>Higher values will penalize the model from repeating the same output tokens.</summary>
        public double? PresencePenalty { get; set; }
        /// <summary>The response_format property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionResponseFormatParam? ResponseFormat { get; set; }
#nullable restore
#else
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionResponseFormatParam ResponseFormat { get; set; }
#endif
        /// <summary>Whether or not to stream data-only server-sent events as they become available.</summary>
        public bool? Stream { get; set; }
        /// <summary>Adjusts the &quot;creativity&quot; of the model. Lower values make the model more deterministic and repetitive, while higher values make the model more random and creative.</summary>
        public double? Temperature { get; set; }
        /// <summary>The tool_choice property</summary>
        public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_tool_choice? ToolChoice { get; set; }
        /// <summary>The `function` tool type follows the same schema as the [OpenAI Chat Completions API](https://platform.openai.com/docs/api-reference/chat). The `retrieval` tool type is unique to Telnyx. You may pass a list of [embedded storage buckets](https://developers.telnyx.com/api/inference/inference-embedding/post-embedding) for retrieval-augmented generation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools>? Tools { get; set; }
#nullable restore
#else
        public List<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools> Tools { get; set; }
#endif
        /// <summary>This is used with `logprobs`. An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability.</summary>
        public int? TopLogprobs { get; set; }
        /// <summary>An alternative or complement to `temperature`. This adjusts how many of the top possibilities to consider.</summary>
        public double? TopP { get; set; }
        /// <summary>Setting this to `true` will allow the model to [explore more completion options](https://huggingface.co/blog/how-to-generate#beam-search). This is not supported by OpenAI.</summary>
        public bool? UseBeamSearch { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest"/> and sets the default values.
        /// </summary>
        public ChatCompletionRequest()
        {
            AdditionalData = new Dictionary<string, object>();
            Model = "meta-llama/Meta-Llama-3.1-8B-Instruct";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "api_key_ref", n => { ApiKeyRef = n.GetStringValue(); } },
                { "best_of", n => { BestOf = n.GetIntValue(); } },
                { "early_stopping", n => { EarlyStopping = n.GetBoolValue(); } },
                { "frequency_penalty", n => { FrequencyPenalty = n.GetDoubleValue(); } },
                { "guided_choice", n => { GuidedChoice = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "guided_json", n => { GuidedJson = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_guided_json>(global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_guided_json.CreateFromDiscriminatorValue); } },
                { "guided_regex", n => { GuidedRegex = n.GetStringValue(); } },
                { "length_penalty", n => { LengthPenalty = n.GetDoubleValue(); } },
                { "logprobs", n => { Logprobs = n.GetBoolValue(); } },
                { "max_tokens", n => { MaxTokens = n.GetIntValue(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam>(global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam.CreateFromDiscriminatorValue)?.AsList(); } },
                { "min_p", n => { MinP = n.GetDoubleValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "n", n => { N = n.GetDoubleValue(); } },
                { "presence_penalty", n => { PresencePenalty = n.GetDoubleValue(); } },
                { "response_format", n => { ResponseFormat = n.GetObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionResponseFormatParam>(global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionResponseFormatParam.CreateFromDiscriminatorValue); } },
                { "stream", n => { Stream = n.GetBoolValue(); } },
                { "temperature", n => { Temperature = n.GetDoubleValue(); } },
                { "tool_choice", n => { ToolChoice = n.GetEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_tool_choice>(); } },
                { "tools", n => { Tools = n.GetCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools>(global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools.CreateFromDiscriminatorValue)?.AsList(); } },
                { "top_logprobs", n => { TopLogprobs = n.GetIntValue(); } },
                { "top_p", n => { TopP = n.GetDoubleValue(); } },
                { "use_beam_search", n => { UseBeamSearch = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("api_key_ref", ApiKeyRef);
            writer.WriteIntValue("best_of", BestOf);
            writer.WriteBoolValue("early_stopping", EarlyStopping);
            writer.WriteDoubleValue("frequency_penalty", FrequencyPenalty);
            writer.WriteCollectionOfPrimitiveValues<string>("guided_choice", GuidedChoice);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_guided_json>("guided_json", GuidedJson);
            writer.WriteStringValue("guided_regex", GuidedRegex);
            writer.WriteDoubleValue("length_penalty", LengthPenalty);
            writer.WriteBoolValue("logprobs", Logprobs);
            writer.WriteIntValue("max_tokens", MaxTokens);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionSystemMessageParam>("messages", Messages);
            writer.WriteDoubleValue("min_p", MinP);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("n", N);
            writer.WriteDoubleValue("presence_penalty", PresencePenalty);
            writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionResponseFormatParam>("response_format", ResponseFormat);
            writer.WriteBoolValue("stream", Stream);
            writer.WriteDoubleValue("temperature", Temperature);
            writer.WriteEnumValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest_tool_choice>("tool_choice", ToolChoice);
            writer.WriteCollectionOfObjectValues<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools>("tools", Tools);
            writer.WriteIntValue("top_logprobs", TopLogprobs);
            writer.WriteDoubleValue("top_p", TopP);
            writer.WriteBoolValue("use_beam_search", UseBeamSearch);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionToolParam"/>, <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.Retrieval"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ChatCompletionRequest_tools : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionToolParam"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionToolParam? ChatCompletionToolParam { get; set; }
#nullable restore
#else
            public global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionToolParam ChatCompletionToolParam { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.Retrieval"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Soenneker.Telnyx.OpenApiClient.Models.Retrieval? Retrieval { get; set; }
#nullable restore
#else
            public global::Soenneker.Telnyx.OpenApiClient.Models.Retrieval Retrieval { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionRequest.ChatCompletionRequest_tools();
                if("ChatCompletionToolParam".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ChatCompletionToolParam = new global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionToolParam();
                }
                else if("Retrieval".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.Retrieval = new global::Soenneker.Telnyx.OpenApiClient.Models.Retrieval();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ChatCompletionToolParam != null)
                {
                    return ChatCompletionToolParam.GetFieldDeserializers();
                }
                else if(Retrieval != null)
                {
                    return Retrieval.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ChatCompletionToolParam != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.ChatCompletionToolParam>(null, ChatCompletionToolParam);
                }
                else if(Retrieval != null)
                {
                    writer.WriteObjectValue<global::Soenneker.Telnyx.OpenApiClient.Models.Retrieval>(null, Retrieval);
                }
            }
        }
    }
}
#pragma warning restore CS0618
