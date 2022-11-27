namespace CSMS.UseCases.FeatureUseCases.CodeSnippetInterfaces
{
    using CSMS.CoreBusiness;

    public interface IViewCodeSnippetsByNameUseCase
    {
        Task<IEnumerable<CodeSnippet>> ExecuteAsync(string name = "");
    }
}