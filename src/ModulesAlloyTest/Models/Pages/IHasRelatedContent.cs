using EPiServer.Core;

namespace ModulesAlloyTest.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
