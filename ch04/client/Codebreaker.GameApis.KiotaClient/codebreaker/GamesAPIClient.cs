using Codebreaker.Client.Games;

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;

namespace Codebreaker.Client;
/// <summary>
/// The main entry point of the SDK, exposes the configuration and the fluent API.
/// </summary>
public class GamesAPIClient : BaseRequestBuilder
{
    /// <summary>The games property</summary>
    public GamesRequestBuilder Games
    {
        get =>
        new GamesRequestBuilder(PathParameters, RequestAdapter);
    }
    /// <summary>
    /// Instantiates a new GamesAPIClient and sets the default values.
    /// </summary>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public GamesAPIClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>())
    {
        ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
        ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
    }
}
