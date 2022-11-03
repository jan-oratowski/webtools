namespace WebTools.Models.Hash
{
    public interface IHashPageModel : IPageModel
    {
        bool UseBuffer { get; set; }
        Stream? Input { get; set; }
        string? Output { get; set; }
        Task Hash();
    }
}
