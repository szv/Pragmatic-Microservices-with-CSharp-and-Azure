using Codebreaker.Client.Games.Item;
using Codebreaker.Client.Models;

using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
namespace Codebreaker.Client.Games;

/// <summary>
/// Builds and executes requests for operations under \games
/// </summary>
public class GamesRequestBuilder : BaseRequestBuilder
{
    /// <summary>Gets an item from the Codebreaker.Client.games.item collection</summary>
    public WithGameItemRequestBuilder this[string position]
    {
        get
        {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position))
                urlTplParams.Add("gameId", position);
            return new WithGameItemRequestBuilder(urlTplParams, RequestAdapter);
        }
    }
    /// <summary>
    /// Instantiates a new GamesRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public GamesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/games{?gameType*,playerName*,date*,ended*}", pathParameters)
    {
    }
    /// <summary>
    /// Instantiates a new GamesRequestBuilder and sets the default values.
    /// </summary>
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    public GamesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/games{?gameType*,playerName*,date*,ended*}", rawUrl)
    {
    }
    /// <summary>
    /// Get games based on query parameters
    /// </summary>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<List<Game>?> GetAsync(Action<GamesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<List<Game>> GetAsync(Action<GamesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
        var requestInfo = ToGetRequestInformation(requestConfiguration);
        var collectionResult = await RequestAdapter.SendCollectionAsync<Game>(requestInfo, Game.CreateFromDiscriminatorValue, default, cancellationToken);
        return collectionResult?.ToList();
    }
    /// <summary>
    /// Creates and starts a game
    /// </summary>
    /// <param name="body">The request body</param>
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public async Task<CreateGameResponse?> PostAsync(CreateGameRequest body, Action<GamesRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default)
    {
#nullable restore
#else
    public async Task<CreateGameResponse> PostAsync(CreateGameRequest body, Action<GamesRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = ToPostRequestInformation(body, requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
            {"400", GameError.CreateFromDiscriminatorValue},
        };
        return await RequestAdapter.SendAsync<CreateGameResponse>(requestInfo, CreateGameResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
    }
    /// <summary>
    /// Get games based on query parameters
    /// </summary>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToGetRequestInformation(Action<GamesRequestBuilderGetRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToGetRequestInformation(Action<GamesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
        var requestInfo = new RequestInformation
        {
            HttpMethod = Method.GET,
            UrlTemplate = UrlTemplate,
            PathParameters = PathParameters,
        };
        requestInfo.Headers.Add("Accept", "application/json");
        if (requestConfiguration != null)
        {
            var requestConfig = new GamesRequestBuilderGetRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddQueryParameters(requestConfig.QueryParameters);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }
        return requestInfo;
    }
    /// <summary>
    /// Creates and starts a game
    /// </summary>
    /// <param name="body">The request body</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public RequestInformation ToPostRequestInformation(CreateGameRequest body, Action<GamesRequestBuilderPostRequestConfiguration>? requestConfiguration = default)
    {
#nullable restore
#else
    public RequestInformation ToPostRequestInformation(CreateGameRequest body, Action<GamesRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
        _ = body ?? throw new ArgumentNullException(nameof(body));
        var requestInfo = new RequestInformation
        {
            HttpMethod = Method.POST,
            UrlTemplate = UrlTemplate,
            PathParameters = PathParameters,
        };
        requestInfo.Headers.Add("Accept", "application/json");
        requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
        if (requestConfiguration != null)
        {
            var requestConfig = new GamesRequestBuilderPostRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }
        return requestInfo;
    }
    /// <summary>
    /// Get games based on query parameters
    /// </summary>
    public class GamesRequestBuilderGetQueryParameters
    {
        /// <summary>The date to filter by</summary>
        public Date? Date { get; set; }
        /// <summary>Whether to filter by ended games</summary>
        public bool? Ended { get; set; }
        /// <summary>The game type to filter by</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GameType { get; set; }
#nullable restore
#else
        public string GameType { get; set; }
#endif
        /// <summary>The player name to filter by</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlayerName { get; set; }
#nullable restore
#else
        public string PlayerName { get; set; }
#endif
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class GamesRequestBuilderGetRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }
        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }
        /// <summary>Request query parameters</summary>
        public GamesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new GamesRequestBuilderGetQueryParameters();
        /// <summary>
        /// Instantiates a new gamesRequestBuilderGetRequestConfiguration and sets the default values.
        /// </summary>
        public GamesRequestBuilderGetRequestConfiguration()
        {
            Options = new List<IRequestOption>();
            Headers = new RequestHeaders();
        }
    }
    /// <summary>
    /// Configuration for the request such as headers, query parameters, and middleware options.
    /// </summary>
    public class GamesRequestBuilderPostRequestConfiguration
    {
        /// <summary>Request headers</summary>
        public RequestHeaders Headers { get; set; }
        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }
        /// <summary>
        /// Instantiates a new gamesRequestBuilderPostRequestConfiguration and sets the default values.
        /// </summary>
        public GamesRequestBuilderPostRequestConfiguration()
        {
            Options = new List<IRequestOption>();
            Headers = new RequestHeaders();
        }
    }
}
