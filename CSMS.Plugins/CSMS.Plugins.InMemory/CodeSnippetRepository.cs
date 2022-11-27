namespace CSMS.Plugins.InMemory
{
    using CSMS.CoreBusiness;
    using CSMS.UseCases.PluginInterfaces;
    using System.Security.Cryptography.X509Certificates;

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
                     Code = @"@page  ""/CodeSnippets""

@inject NavigationManager NavigationManager

<h3>CodeSnippetList</h3>
<br />
<CodeSnippetSearchComponent 
    OnSearchCodeSnippet=""OnCodeSnippetSearch""></CodeSnippetSearchComponent>
<br />
<CodeSnippetListComponent SearchTerm=""@searchTerm""></CodeSnippetListComponent>
<br />
<button 
    type=""button"" 
    class=""btn btn-primary""
    @onclick=""AddCodeSnippet"">Add code snippet</button>


@code {
    private string searchTerm = string.Empty;

    private void OnCodeSnippetSearch(string searchTerm)
    {
        this.searchTerm = searchTerm;
    }

    private void AddCodeSnippet()
    {
        this.NavigationManager.NavigateTo(""/AddCodeSnippet"");
    }
}",
                     Author = "Hoe Lang",
                     Description = "usefull function that returns Foo",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(1984,12,6)),
                     IsDeprecated = false,
                 },
                new CodeSnippet()
                 {
                     Id = 2,
                     Name = "Faa Class",
                     Code = @"    public class ViewCodeSnippetsByNameUseCase : IViewCodeSnippetsByNameUseCase
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
        /// <param name=""name"">name parmater used to perform an asynchrous search operation</param>
        /// <returns>Task<IEnumerable<CodeSnippet>></returns>
        public async Task<IEnumerable<CodeSnippet>> ExecuteAsync(string name = """")
        {
            // Simple PassThrough
            return await this.codeSnippetsRepository.GetCodeSnippetsByNameAsync(name);
        }
    }",
                     Author = "So Lang",
                     Description = "Class for working with Faa",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(1999,2,3)),
                     IsDeprecated = false,
                 },
                new CodeSnippet()
                 {
                     Id = 3,
                     Name= "Fee function",
                     Code = @"// map abstractions to concrete implementations (enables dependency injection)
builder.Services.AddSingleton<ICodeSnippetRepository, CodeSnippetRepository>();
builder.Services.AddTransient<IViewCodeSnippetsByNameUseCase, ViewCodeSnippetsByNameUseCase>();
builder.Services.AddTransient<IAddCodeSnippetUseCase, AddCodeSnippetUseCase>();",
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
                     Code = "                if (false)\r\n            {\r\n\r\n            }",
                     Author= "Chuck Norris",
                     Description = "Function that kicks ass",
                     PublicationDate= DateOnly.FromDateTime(new DateTime(1984,12,6)),
                     IsDeprecated= false,
                 },
                new CodeSnippet()
                 {
                     Id = 6,
                     Name = "KungFooTOO",
                     Code = @"public class AddCodeSnippetUseCase : IAddCodeSnippetUseCase
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
    }",
                     Author = "Bruce Wie",
                     Description = "Function that kicks ass too",
                     PublicationDate = DateOnly.FromDateTime(new DateTime(1984,12,6)),
                     IsDeprecated = false,
                 },
                 new CodeSnippet()
                 {
                     Id = 8,
                     Name = "HaYaaa",
                     Code = @"        public Task AddCodeSnippetAsync(CodeSnippet codeSnippet)
        {
            if (_codeSnippets.Any(x => x.Name.Equals(codeSnippet.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask; 
            }
            var maxId = this._codeSnippets.Max(x => x.Id);

            codeSnippet.Id = maxId;

            return Task.CompletedTask;

        }",
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

        public Task AddCodeSnippetAsync(CodeSnippet codeSnippet)
        {
            if (_codeSnippets.Any(x => x.Name.Equals(codeSnippet.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }
            var maxId = this._codeSnippets.Max(x => x.Id);

            codeSnippet.Id = maxId;
            codeSnippet.PublicationDate = DateOnly.FromDateTime(DateTime.Now);
            codeSnippet.IsDeprecated = false;

            _codeSnippets.Add(codeSnippet);

            return Task.CompletedTask;

        }

        public Task UpdateCodeSnippetAsync(CodeSnippet codeSnippet)
        {
            if (_codeSnippets.Any(j => j.Id != codeSnippet.Id &&
                j.Name.Equals(codeSnippet.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }

            var inv = _codeSnippets.FirstOrDefault(j => j.Id == codeSnippet.Id);
            if (inv != null)
            {
                inv.Name = codeSnippet.Name;
                inv.Description = codeSnippet.Description;
                inv.Author= codeSnippet.Author;
                inv.PublicationDate = codeSnippet.PublicationDate;
                inv.IsDeprecated = codeSnippet.IsDeprecated;
                inv.Code = codeSnippet.Code;
                inv.Category = codeSnippet.Category;
                inv.Language = codeSnippet.Language;
            }

            return Task.CompletedTask;
        }
    }
}