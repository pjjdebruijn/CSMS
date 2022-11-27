using CSMS.CoreBusiness;

namespace CSMS.UseCases.FeatureUseCases.CodeSnippetInterfaces
{
    public interface IAddCodeSnippetUseCase
    {
        Task ExecuteAsync(CodeSnippet codeSnippet);
    }
}