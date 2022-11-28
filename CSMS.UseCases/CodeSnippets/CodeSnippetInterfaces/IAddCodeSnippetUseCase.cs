using CSMS.CoreBusiness;

namespace CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces
{
    public interface IAddCodeSnippetUseCase
    {
        Task ExecuteAsync(CodeSnippet codeSnippet);
    }
}