using CSMS.CoreBusiness;

namespace CSMS.UseCases.PluginInterfaces
{
    public interface ICodeSnippetRepository
    {
        Task AddCodeSnippetAsync(CodeSnippet codeSnippet);
        Task UpdateCodeSnippetAsync(CodeSnippet codeSnippet);
        Task<IEnumerable<CodeSnippet>> GetCodeSnippetsByNameAsync(string name);
        Task<CodeSnippet> GetCodeSnippetsByIdAsync(int id);
    }
}
