using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
/// <summary>
/// Alan O. Rivera Leal UpDate Feb 2017
/// </summary>
public class ClsGenericDataAccess
{
    public static DataTable GetInformation()
    {
        return ClsConfiguration.GetInfo;
    }

    public static DataTable SetCellsValues()
    {
        DataTable T = new DataTable();
        T.Columns.Add("Tipo"); T.Columns.Add("PO"); T.Columns.Add("No_Orden"); T.Columns.Add("Semana"); T.Columns.Add("Asignado"); T.Columns.Add("Vendedor");
        T.Columns.Add("Empresa"); T.Columns.Add("Cliente"); T.Columns.Add("Nombre"); T.Columns.Add("Cantidad"); T.Columns.Add("Ventas"); T.Columns.Add("Diseno");
        T.Columns.Add("Compras"); T.Columns.Add("Produccion"); T.Columns.Add("EM"); T.Columns.Add("EE"); T.Columns.Add("Calidad"); T.Columns.Add("FechaReq");
        T.Columns.Add("FechaEnt"); T.Columns.Add("DiasRest"); T.Columns.Add("SemanaEnt"); T.Columns.Add("PrecioU"); T.Columns.Add("PrecioT"); T.Columns.Add("StatusCont");
        T.Columns.Add("Notas"); T.Columns.Add("Cotizacion");
        DataRow R = T.NewRow();

        R[0] = "Tipo"; R[1] = "PO"; R[2] = "No. Orden"; R[3] = "Semana"; R[4] = "Asignado"; R[5] = "Vendedor"; R[6] = "Empresa"; R[7] = "Cliente"; R[8] = "Nombre";
        R[9] = "Cantidad"; R[10] = "Ventas"; R[11] = "Diseno"; R[12] = "Compras"; R[13] = "Producción"; R[14] = "Ensamble Mecánico"; R[15] = "Ensamble Eléctrico";
        R[16] = "Calidad"; R[17] = "Fecha de requisición"; R[18] = "Fecha de entrega"; R[19] = "Días Restantes"; R[20] = "Semana de entrega"; R[21] = "Precio Unitario";
        R[22] = "Precio Total"; R[23] = "Estatus Contable"; R[24] = "Notas"; R[25] = "Cotización";
        T.Rows.Add(R);

        return T;
    }
}