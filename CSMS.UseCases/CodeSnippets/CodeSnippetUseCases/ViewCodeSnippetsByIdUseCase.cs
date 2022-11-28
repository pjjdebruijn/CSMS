using CSMS.CoreBusiness;
using CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces;
using CSMS.UseCases.PluginInterfaces;

namespace CSMS.UseCases.UseCases.CodeSnippetUseCases
{
    public class ViewCodeSnippetsByIdUseCase : IViewCodeSnippetsByIdUseCase
    {
        private readonly ICodeSnippetRepository codeSnippetsRepository;

        public ViewCodeSnippetsByIdUseCase(ICodeSnippetRepository codeSnippetsRepository)
        {
            this.codeSnippetsRepository = codeSnippetsRepository;
        }

        public async Task<CodeSnippet> ExecuteAsync(int id)
        {
            // Simple PassThrough
            return await this.codeSnippetsRepository.GetCodeSnippetsByIdAsync(id);
        }
    }
}
