namespace ItchIoTemplates.ExportApp.Models;

public record BallmenDevLogModel
{
    public required LogEntry[] WhatIsNewEntries { get; init; }

    public required LogEntry[] WhatIsFixedEntries { get; init; }
}

public record LogEntry
{
    public required string Title { get; init; }

    public required string Description { get; init; }
}
