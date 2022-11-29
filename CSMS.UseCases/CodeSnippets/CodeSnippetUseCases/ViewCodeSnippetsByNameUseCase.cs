using CSMS.CoreBusiness;
using CSMS.UseCases.CodeSnippets.CodeSnippetInterfaces;
using CSMS.UseCases.PluginInterfaces;

namespace CSMS.UseCases.UseCases.CodeSnippetUseCases
{
    public class ViewCodeSnippetsByNameUseCase : IViewCodeSnippetsByNameUseCase
    {
        private readonly ICodeSnippetRepository codeSnippetsRepository;

        public ViewCodeSnippetsByNameUseCase(ICodeSnippetRepository codeSnippetsRepository)
        {
            this.codeSnippetsRepository = codeSnippetsRepository;
        }

        public async Task<IEnumerable<CodeSnippet>> ExecuteAsync(string name = "")
        {
            return await this.codeSnippetsRepository.GetCodeSnippetsByNameAsync(name);
        }
    }
}
