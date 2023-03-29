//Variables, se declaran antes de utilizarlas.

string nombre = "Jose Luis";
int edad =  27;

//Esto es la interpolacion, pero tambien existe la concatenacion clasica con el signo +
Console.WriteLine($"Me llamo {nombre} y tengo {edad} anios!");
Console.WriteLine($"Tengo {edad} anios y me llamo {nombre}");

int edad_siguiente = edad + 1;
Console.WriteLine($"Tedre {edad_siguiente} anios, el proximo anio y me llamo {nombre}");
