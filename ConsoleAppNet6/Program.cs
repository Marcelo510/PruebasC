


//using System.Collections;

////var medios = new[] { "cheques", "bonos", "acciones", 1000, "transferencia" };


////var medios2 = {"cheques", "bonos", "acciones", 1000, "transferencia"};

//ArrayList arraylist = new ArrayList() { "cheques", "bonos", "acciones", 1000, "transferencia" };

//var elre = arraylist[1];
//var otro = elre[2];
//Console.WriteLine(elre);



using HtmlAgilityPack;

var url = "https://www.minutouno.com/";

var httpclient = new HttpClient();
var html = await httpclient.GetStringAsync(url);
var htmlDocument = new HtmlDocument();
htmlDocument.LoadHtml(html);
string a;
a = "adfas";




//var lava = document.querySelectorAll('h2.title')
