using System;
using System.IO;

/*Usando RSP separo la responsabilidad de imprimir por consola de la clase AllInOnePrinter a esta clase*/

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePirnt : IPrinter
    {
        public void Printer(Recipe recipe)
        {
           Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}