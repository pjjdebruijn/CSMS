using CSMS.CoreBusiness;

namespace CSMS.UseCases.UseCases.CodeSnippetInterfaces
{
    public interface IUpdateCodeSnippetUseCase
    {
        Task ExecuteAsync(CodeSnippet codeSnippet);
    }
}