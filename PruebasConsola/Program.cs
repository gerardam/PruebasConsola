using System;
using System.Data;

//| || // |=|====================================================//
//| ||//  |=| Ejemplo de consola                                //
//| ||\\  |=| Kyocode | www.kyocode.com                         \\
//| || \\ |=|====================================================\\
namespace PruebasConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear DataTable
            DataTable tablaUno = new DataTable("NombreTablaUno");
            tablaUno.Columns.Add("Numero");
            tablaUno.Columns.Add("Nombre");

            //Establecer tipos de datos
            DataTable tablaDos = new DataTable("NombreTablaDos");
            tablaDos.Columns.Add("Numero", typeof(int));
            tablaDos.Columns.Add("Nombre", typeof(string));
        }
    }
}