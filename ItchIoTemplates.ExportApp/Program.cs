using ItchIoTemplates.ExportApp.Models;
using ItchIoTemplates.TemplatesExporter;
using ItchIoTemplates.TemplatesExporter.Structs;
using RazorLight;
using RazorLight.Extensions;

var builder = new TemplatesExporterAppBuilder();

builder.Services.AddRazorLight(() => new RazorLightEngineBuilder()
    .UseEmbeddedResourcesProject(
        typeof(Program).Assembly,
        rootNamespace: "ItchIoTemplates.ExportApp.Templates")
    .UseMemoryCachingProvider()
    .Build());

builder.AddExport(new TemplateExportParams
{
    Model = new BallmenDevLogModel
    {
        WhatIsNewEntries = [],
        WhatIsFixedEntries = []
    },
    PathToSave = "devLogs.html"
});

builder.AddExport(new TemplateExportParams
{
    Model = new BallmenPageContentModel
    {
        CurrentVersion = "1.4.0",
        NearFeatureEntries =
        [
            new()
            {
                Title = "Menu View Update",
                Description = "Beautified and stylized menu visual."
            },
            new()
            {
                Title = "Lobby Major Update",
                Description = "Currently you can only gain players and launch game in online mode. Next lobby update will contain game settings and full offline mode."
            },
            new()
            {
                Title = "4 Player Mode",
                Description = "Why do you need to play 1v1, when you can play 2v2?"
            }
        ],
        CompletedFeatureEntries =
        [
            new()
            {
                Title = "Bots",
                Description = "You will have enough players to play game"
            },
            new()
            {
                Title = "Android support",
                Description = "You can install game on your phone, and play anywhere you want"
            },
            new()
            {
                Title = "Relay support",
                Description = "There will be no need to install virtual LAN solutions like Radmin. You can establish connection out of box"
            },
            new()
            {
                Title = "Lives",
                Description = "Every round you will have 3 lives. Every fall out of bounds will take one live. When any team lost their all lives, the opponent team will get score and round changes."
            }
        ]
    },
    PathToSave = "ballmenPage.html"
});

await builder.Build().Run();
