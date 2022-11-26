namespace CSMS.Plugins.InMemory
{
    using CSMS.CoreBusiness;
    using CSMS.UseCases.PluginInterfaces;

    /// <summary>
    ///     This plugin implements the CSMS.UseCasePluginInterface
    ///     When this plugin is registered in Program.cs of our webapp, 
    ///     then this can be plugged into our usecaseinterface
    ///     and can then be used by our application, without the application becoming dependant
    ///     on the plugin. 
    ///     The UseCaseLAyers is dependant on the interface (=abstraction) only.
    /// </summary>
    public class CodeSnippetRepository : ICodeSnippetRepository
    {
        //mock some data (list of some code snippets)
        private List<CodeSnippet> _codeSnippets;

        public CodeSnippetRepository()
        {
            _codeSnippets = new List<CodeSnippet>()
            {
                 new CodeSnippet()
                 {
                     Id = 1,
                     Name = "Foo function",
                     Code = "Bar",
                     Author = "Hoe Lang",
                     Description = "usefull function that returns Foo",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(1984,12,6)),
                     IsDeprecated = false,
                 },
                new CodeSnippet()
                 {
                     Id = 2,
                     Name = "Faa Class",
                     Code = "Bor",
                     Author = "So Lang",
                     Description = "Class for working with Faa",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(1999,2,3)),
                     IsDeprecated = false,
                 },
                new CodeSnippet()
                 {
                     Id = 3,
                     Name= "Fee function",
                     Code = "Bier",
                     Author = "Fee fa Tovenaar",
                     Description = "verwerkt automagisch Fee",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(2021,7,26)),
                     IsDeprecated = false,
                 },
                new CodeSnippet()
                 {
                     Id = 4,
                     Name = "FuYooooooH",
                     Code = "                if (true)\r\n            {\r\n\r\n            }",
                     Author = "Barry White",
                     Description = "function that is very Fuyoooh!",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(1984,12,6)),
                     IsDeprecated = false,
                 },
                new CodeSnippet()
                 {
                     Id = 5,
                     Name = "KungFoo",
                     Code = "                if (true)\r\n            {\r\n\r\n            }",
                     Author= "Chuck Norris",
                     Description = "Function that kicks ass",
                     PublicationDate= DateOnly.FromDateTime(new DateTime(1984,12,6)),
                     IsDeprecated= false,
                 },
                new CodeSnippet()
                 {
                     Id = 6,
                     Name = "KungFooTOO",
                     Code = "Bar",
                     Author = "Bruce Wie",
                     Description = "Function that kicks ass too",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(1984,12,6)),
                     IsDeprecated = false,
                 },
                 new CodeSnippet()
                 {
                     Id = 8,
                     Name = "HaYaaa",
                     Code = "HaYaaa",
                     Author = "Mopper Smurf",
                     Description = "id:10T Function",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(2005,6,7)),
                     IsDeprecated = true,
                 },
            };
        }

        public async Task<IEnumerable<CodeSnippet>> GetCodeSnippetsByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return await Task.FromResult(this._codeSnippets);
            }

            IEnumerable<CodeSnippet> result = this._codeSnippets
            .Where(x => x.Name.Contains
            (name, StringComparison.OrdinalIgnoreCase));
            return result;
        }
    }
}