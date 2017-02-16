using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Xml;

/// <summary>
/// Alan O. Rivera Leal Update 16-Feb-17
/// </summary>
public class ClsUsers
{
    public static string CheckPassword(string user, string password)
    {
        string Result = "";
        DataTable T = ClsGenericDataAccess.GetInformation();

        if (T.Rows.Count > 0)
        {
            string pswdhash = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Trim(), "SHA1");
            string usrhash = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Trim(), "SHA1");

            for (int i = 0; i < T.Rows.Count; i++)
            {
                if (usrhash == T.Rows[i][0].ToString().Trim() && pswdhash == T.Rows[i][1].ToString().Trim())
                {
                    Result = T.Rows[i][2].ToString().Trim() + "," + T.Rows[i][0].ToString().Trim() + "," + T.Rows[i][1].ToString().Trim() + ",T";
                    break;
                }
                else Result = "";
            }
        }
        else Result = "";

        return Result;
    }

    //public static void EncryptXML(string usr, string psw, string role)
    //{
    //    string usrHash = FormsAuthentication.HashPasswordForStoringInConfigFile(usr.Trim(), "SHA1");
    //    string pswHash = FormsAuthentication.HashPasswordForStoringInConfigFile(psw.Trim(), "SHA1");
    //    string roleHash = FormsAuthentication.HashPasswordForStoringInConfigFile(role.Trim(), "SHA1");
    //}
}