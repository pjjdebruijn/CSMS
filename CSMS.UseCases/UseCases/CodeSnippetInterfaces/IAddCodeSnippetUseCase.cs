using CSMS.CoreBusiness;

namespace CSMS.UseCases.UseCases.CodeSnippetInterfaces
{
    public interface IAddCodeSnippetUseCase
    {
        Task ExecuteAsync(CodeSnippet codeSnippet);
    }
}