/*Creo esta interfaz IPrinter (super-tipo), la cual contiene e merodo Printer
a partir de esta creo 2 sub-tipos: FilePrint y ConsolePrint.
De este modo ya no es necesario preguntar por el destino de impresion*/

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void Printer(Recipe recipe);
    }
}