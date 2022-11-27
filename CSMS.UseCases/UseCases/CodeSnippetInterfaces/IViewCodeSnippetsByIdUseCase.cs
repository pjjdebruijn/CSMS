using CSMS.CoreBusiness;

namespace CSMS.UseCases.UseCases.CodeSnippetInterfaces
{
    public interface IViewCodeSnippetsByIdUseCase
    {
        Task<CodeSnippet> ExecuteAsync(int id);
    }
}