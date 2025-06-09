namespace ItchIoTemplates.TemplatesExporter.Structs;

public struct TemplateExportParams
{
    public required object Model { get; init; }

    public required string PathToSave { get; init; }
}
