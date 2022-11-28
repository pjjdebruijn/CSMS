using CSMS.CoreBusiness;
using CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces;
using CSMS.UseCases.PluginInterfaces;

namespace CSMS.UseCases.UseCases.CodeSnippetUseCases
{
    public class AddCodeSnippetUseCase : IAddCodeSnippetUseCase
    {
        private readonly ICodeSnippetRepository codeSnippetRepository;

        public AddCodeSnippetUseCase(ICodeSnippetRepository codeSnippetRepository)
        {
            this.codeSnippetRepository = codeSnippetRepository;
        }
        public async Task ExecuteAsync(CodeSnippet codeSnippet)
        {
            await this.codeSnippetRepository.AddCodeSnippetAsync(codeSnippet);
        }
    }
}
