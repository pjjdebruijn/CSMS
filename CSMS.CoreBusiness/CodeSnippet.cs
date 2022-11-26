namespace CSMS.CoreBusiness
{
    public class CodeSnippet
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public DateOnly PublicationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public bool IsDeprecated { get; set; } = false;

        public string Category { get; set; } = string.Empty;

        public string Language { get; set; } = string.Empty;

    }
}
 