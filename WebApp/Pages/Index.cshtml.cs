using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HtmlAgilityPack;
using AngleSharp.Dom;

namespace WebApp.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;

    }

    public async void OnGet()
    {
        


        var url = "https://www.minutouno.com/";

        var httpclient = new HttpClient();
        var html = await httpclient.GetStringAsync(url);
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);
        ViewData["Pagina"] = htmlDocument;

        var ver = htmlDocument.DocumentNode;
        var ver1 = htmlDocument.DocumentNode.GetElementbyTag("h2");

        var ver2 = ver.SelectNodes("h2");
        

        //object p = htmlDocument.querySelectorAll('h2.title');

        //HtmlNodeCollection nodes = htmlDocument.DocumentNode.ChildNodes;

    }

    public async void OnSet()
    {
        var url = "https://www.minutouno.com/";

        var httpclient = new HttpClient();
        var html = await httpclient.GetStringAsync(url);
        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);
        ViewData["Pagina"] = htmlDocument;
    }
}
