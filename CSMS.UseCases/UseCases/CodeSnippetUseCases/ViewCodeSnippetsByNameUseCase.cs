namespace CSMS.UseCases.UseCases.CodeSnippetUseCases
{
    using CSMS.CoreBusiness;
    using CSMS.UseCases.UseCases.CodeSnippetInterfaces;
    using CSMS.UseCases.PluginInterfaces;

    public class ViewCodeSnippetsByNameUseCase : IViewCodeSnippetsByNameUseCase
    {
        private readonly ICodeSnippetRepository codeSnippetsRepository;

        public ViewCodeSnippetsByNameUseCase(ICodeSnippetRepository codeSnippetsRepository)
        {
            this.codeSnippetsRepository = codeSnippetsRepository;
        }

        /// <summary>
        ///     Executes an Asynchrous operation that returns an IEnumerable<Codesnippets> 
        ///     and accepts a string name parameter, neccesary to perform the asynchrous operation.
        ///     poetry in code.
        /// </summary>
        /// <param name="name">name parmater used to perform an asynchrous search operation</param>
        /// <returns>Task<IEnumerable<CodeSnippet>></returns>
        public async Task<IEnumerable<CodeSnippet>> ExecuteAsync(string name = "")
        {
            // Simple PassThrough
            return await this.codeSnippetsRepository.GetCodeSnippetsByNameAsync(name);
        }
    }
}
