using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
namespace Codebreaker.Client.Models;
public class GameError : ApiException, IParsable
{
    /// <summary>The code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Code { get; set; }
#nullable restore
#else
    public string Code { get; set; }
#endif
    /// <summary>The details property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public List<string>? Details { get; set; }
#nullable restore
#else
    public List<string> Details { get; set; }
#endif
    /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? MessageEscaped { get; set; }
#nullable restore
#else
    public string MessageEscaped { get; set; }
#endif
    /// <summary>The target property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? Target { get; set; }
#nullable restore
#else
    public string Target { get; set; }
#endif
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static GameError CreateFromDiscriminatorValue(IParseNode parseNode)
    {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new GameError();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
    {
        return new Dictionary<string, Action<IParseNode>> {
            {"code", n => { Code = n.GetStringValue(); } },
            {"details", n => { Details = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            {"message", n => { MessageEscaped = n.GetStringValue(); } },
            {"target", n => { Target = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer)
    {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("code", Code);
        writer.WriteCollectionOfPrimitiveValues<string>("details", Details);
        writer.WriteStringValue("message", MessageEscaped);
        writer.WriteStringValue("target", Target);
    }
}
