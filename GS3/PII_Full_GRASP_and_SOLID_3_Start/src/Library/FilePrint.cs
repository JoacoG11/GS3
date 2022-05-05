using System;
using System.IO;

/*Usando RSP separo la responsabilidad de imprimir el archivo de la clase AllInOnePrinter a esta clase*/

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePirnt : IPrinter
    {
        public void Printer(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}