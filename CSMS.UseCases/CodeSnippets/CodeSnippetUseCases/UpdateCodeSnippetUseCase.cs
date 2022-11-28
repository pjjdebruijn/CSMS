using CSMS.CoreBusiness;
using CSMS.UseCases.PluginInterfaces;
using CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces;

namespace CSMS.UseCases.UseCases.CodeSnippetUseCases
{
    public class UpdateCodeSnippetUseCase : IUpdateCodeSnippetUseCase
    {
        private readonly ICodeSnippetRepository codeSnippetRepository;

        public UpdateCodeSnippetUseCase(ICodeSnippetRepository codeSnippetRepository)
        {
            this.codeSnippetRepository = codeSnippetRepository;
        }

        public async Task ExecuteAsync(CodeSnippet codeSnippet)
        {
            await codeSnippetRepository.UpdateCodeSnippetAsync(codeSnippet);
        }
    }
}
