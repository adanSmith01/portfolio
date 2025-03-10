namespace BlazorApp.Models;

public class Project
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public Image? ProjectImage { get; set;}
    public List<string> Technologies { get; set;} = [];
}