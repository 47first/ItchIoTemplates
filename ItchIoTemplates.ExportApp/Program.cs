using ItchIoTemplates.TemplatesExporter;
using ItchIoTemplates.TemplatesExporter.Structs;
using RazorLight;
using RazorLight.Extensions;
using TemplatesBuilder.Models;

var builder = new TemplatesExporterAppBuilder();

builder.Services.AddRazorLight(() => new RazorLightEngineBuilder()
    .UseEmbeddedResourcesProject(
        typeof(Program).Assembly,
        rootNamespace: "TemplatesBuilder.Templates")
    .UseMemoryCachingProvider()
    .Build());

builder.AddExport(new TemplateExportParams
{
    Model = new LogsModel
    {
        Text = "Text"
    },
    PathToSave = Path.Combine(Directory.GetCurrentDirectory(), "logs.html")
});

await builder.Build().Run();
