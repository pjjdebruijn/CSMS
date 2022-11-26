namespace CSMS.UseCases.PluginInterfaces
{
    using CSMS.CoreBusiness;

    public interface ICodeSnippetRepository
    {
        Task<IEnumerable<CodeSnippet>> GetCodeSnippetsByNameAsync(string name);
    }
}
