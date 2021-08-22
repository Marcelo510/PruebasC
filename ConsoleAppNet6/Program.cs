


using System.Collections;

//var medios = new[] { "cheques", "bonos", "acciones", 1000, "transferencia" };


//var medios2 = {"cheques", "bonos", "acciones", 1000, "transferencia"};

ArrayList arraylist = new ArrayList() { "cheques", "bonos", "acciones", 1000, "transferencia" };

var elre = arraylist[1];
var otro = elre[2];
Console.WriteLine(elre);
