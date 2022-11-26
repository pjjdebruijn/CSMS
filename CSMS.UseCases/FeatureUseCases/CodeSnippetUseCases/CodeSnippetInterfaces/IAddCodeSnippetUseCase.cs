using CSMS.CoreBusiness;

namespace CSMS.UseCases.FeatureUseCases.CodeSnippetUseCases.CodeSnippetInterfaces
{
    public interface IAddCodeSnippetUseCase
    {
        Task ExecuteAsync(CodeSnippet codeSnippet);
    }
}