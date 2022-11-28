namespace CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces
{
    using CSMS.CoreBusiness;

    public interface IViewCodeSnippetsByNameUseCase
    {
        Task<IEnumerable<CodeSnippet>> ExecuteAsync(string name = "");
    }
}