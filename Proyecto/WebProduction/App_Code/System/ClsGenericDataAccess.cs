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
}