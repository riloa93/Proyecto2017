using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClsLists
/// </summary>
public class ClsLists
{
    private static string conectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Programacion\\Downloads\\Lista Produccion.xlsx; Extended Properties=""Excel 12.0 Xml; HDR=YES;""";
    private static OleDbConnection conn = new OleDbConnection(conectionstring);
    public static DataTable GetWorkBook()
    {
        OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Lista de Producción$]", conn);
        DataTable T = new DataTable();
        da.Fill(T);
        return T;
    }

    public static void InsertDataWorkbook()
    {
        //string commstring = "INSERT INTO [Produccion](TIPO,PO,NO ORDEN, SEMANA) VALUES(?,?,?,?)";
        string commstring = "Insert Into [Produccion$](TIPO,PO,NO ORDEN, SEMANA) VALUES(1231235,'123456A',123,9);";
        OleDbCommand comm = new OleDbCommand(commstring, conn);

        try
        {
            /*comm.Parameters.Add("TIPO", OleDbType.Integer).Value = 123135;
            comm.Parameters.Add("PO", OleDbType.VarChar).Value = "123456A";
            comm.Parameters.Add("NO ORDEN", OleDbType.Integer).Value = 123;
            comm.Parameters.Add("SEMANA", OleDbType.Integer).Value = 8;*/

            conn.Open();
            comm.CommandText = commstring;
            int count = comm.ExecuteNonQuery();

        }
        catch (OleDbException ex)
        {
           string err = ex.Message;
        }
        finally
        {
            conn.Close();
        }
    }
}