namespace CSMS.UseCases.PluginInterfaces
{
    using CSMS.CoreBusiness;

    public interface ICodeSnippetRepository
    {
        Task AddCodeSnippetAsync(CodeSnippet codeSnippet);
        Task UpdateCodeSnippetAsync(CodeSnippet codeSnippet);
        Task<IEnumerable<CodeSnippet>> GetCodeSnippetsByNameAsync(string name);
    }
}
