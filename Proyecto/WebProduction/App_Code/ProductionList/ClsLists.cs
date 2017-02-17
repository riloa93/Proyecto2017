using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClsLists
/// </summary>
public class ClsLists
{
    public static void WorkBook()
    {
        var workbook = new XLWorkbook();      //ESTE CODIGO YA FUNCIONA COMPLETAMENTE E INCLUSO MODIFICA EL ARCHIVO YA EXISTENTE
        var worksheet = workbook.Worksheets.Add("Lista de produccion");
        worksheet.Cell("A2").Value = "Prueba de creacion y uso de Closed XML.";
        if (worksheet.Cell("A2").Value.ToString() != "")
        {
            worksheet.Cell("A3").Value = "Consecutivo del ultimo valor añadido.";
        }
        workbook.SaveAs("c:\\Users\\Programacion\\Downloads\\Lista de produccion.xlsx");

        string path = @"\\GlobalServer\Nogales(SERVER)\Administracion\Contabilidad";//path para conexion al arhivo y crearlo
    }
}