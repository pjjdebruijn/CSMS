namespace CSMS.UseCases.FeatureUseCases.CodeSnippetsUseCases.CodeSnippetInterfaces
{
    using CSMS.CoreBusiness;

    public interface IViewCodeSnippetsByNameUseCase
    {
        Task<IEnumerable<CodeSnippet>> ExecuteAsync(string name = "");
    }
}