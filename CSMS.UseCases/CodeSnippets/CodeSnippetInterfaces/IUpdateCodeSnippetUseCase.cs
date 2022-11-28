using CSMS.CoreBusiness;

namespace CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces
{
    public interface IUpdateCodeSnippetUseCase
    {
        Task ExecuteAsync(CodeSnippet codeSnippet);
    }
}