//definicion de arreglo de cadenas 
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
//esta variable almancenara los resultados de filtro
IEnumerable<string> query = names
//filtro para obtener los nombres que contiene a 
.Where(n => n.Contains("a"))
//ordenados por el tamaño de caracteres
.OrderBy(n => n.Length)
//Convertir los seleccionados a mayuscula 
.Select(n => n.ToUpper());
//mostrar los nombres con criterios indicados
foreach (var item in query)
    Console.Write($"{item} |");
