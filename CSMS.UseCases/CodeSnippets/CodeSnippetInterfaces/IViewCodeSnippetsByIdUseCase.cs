using CSMS.CoreBusiness;

namespace CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces
{
    public interface IViewCodeSnippetsByIdUseCase
    {
        Task<CodeSnippet> ExecuteAsync(int id);
    }
}