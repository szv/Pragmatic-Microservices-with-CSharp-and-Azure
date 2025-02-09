﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Codebreaker.GameAPIs.Models;

[JsonConverter(typeof(JsonStringEnumConverter<GameType>))]
public enum GameType
{
    Game6x4,
    Game6x4Mini,
    Game8x5,
    Game5x5x4
}

public record class CreateGameRequest(
    [property: Required] GameType GameType, 
    [property: Required] string PlayerName);

public record class CreateGameResponse(
    [property: Required] Guid GameId, 
    [property: Required] GameType GameType, 
    [property: Required] string PlayerName, 
    [property: Required] int NumberCodes, 
    [property: Required] int MaxMoves)
{
    public required IDictionary<string, IEnumerable<string>> FieldValues { get; init; }
}

public record class UpdateGameRequest(
    [property: Required] Guid GameId, 
    [property: Required] GameType GameType, 
    [property: Required] string PlayerName, 
    [property: Required] int MoveNumber, 
    bool End = false)
{
    public string[]? GuessPegs { get; set; }
}

public record class UpdateGameResponse(
    [property: Required] Guid GameId,
    [property: Required] GameType GameType,
    [property: Required] int MoveNumber,
    [property: Required] bool Ended,
    [property: Required] bool IsVictory,
    [property: Required] string[]? Results);
