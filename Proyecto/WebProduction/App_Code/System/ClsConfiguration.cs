using System.Data;
using System.Xml;

/// <summary>
///  Alan O. Rivera Leal UpDate Feb 2017
/// </summary>
public class ClsConfiguration
{
    private static DataTable getInfo;
    static ClsConfiguration()
    {
        getInfo = getXML();
    }

    private static DataTable getXML()
    {
        DataTable T = new DataTable();
        T.Columns.Add("User"); T.Columns.Add("Pswd"); T.Columns.Add("Roles");
        DataRow R; int col = 0;

        XmlDocument xDoc = new XmlDocument();
        xDoc.Load("C:\\Global\\Proyectos\\GIS Nogales\\WebProduction\\XMLList.xml");
        XmlNodeList users = xDoc.GetElementsByTagName("users");
        XmlNodeList list = ((XmlElement)users[0]).GetElementsByTagName("user");

        foreach (XmlElement node in list)
        {
            R = T.NewRow();
            int i = 0;

            XmlNodeList usr = node.GetElementsByTagName("nickname");
            XmlNodeList pswd = node.GetElementsByTagName("pass");
            XmlNodeList role = node.GetElementsByTagName("role");
            R[col] = usr[i].InnerText; col++;
            R[col] = pswd[i].InnerText; col++;
            R[col] = role[i].InnerText; col = 0;
            T.Rows.Add(R);
        }
        return T;
    }

    public static DataTable GetInfo
    {
        get { return getInfo; }
    }
}