namespace ItchIoTemplates.ExportApp.Models;

public record BallmenPageContentModel
{
    public required string CurrentVersion { get; init; }

    public required BallmenPageEntry[] NearFeatureEntries { get; init; }

    public required BallmenPageEntry[] CompletedFeatureEntries { get; init; }
}

public record BallmenPageEntry
{
    public required string Title { get; init; }

    public required string Description { get; init; }
}
