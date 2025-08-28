using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Search.Core.DependencyInjection;
using Umbraco.Cms.Search.Provider.Examine.DependencyInjection;

namespace Site.DependencyInjection;

public class SiteComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder
            // add core services for search abstractions
            .AddSearchCore()
            // use the Examine search provider
            .AddExamineSearchProvider()
            // force rebuild indexes after startup
            .RebuildIndexesAfterStartup();

        builder
            // configure the Examine search provider for this site
            .ConfigureExamineSearchProvider()
            // configure System.Text.Json to allow serializing output models
            .ConfigureJsonOptions();
    }
}