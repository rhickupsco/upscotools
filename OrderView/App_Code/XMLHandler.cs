using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Configuration;
using Data_Access;
using System.Xml.Serialization;

/// <summary>
/// Summary description for SaveXML
/// </summary>

public class XMLHandler
{
    public static string XMLFileLocation = ConfigurationManager.AppSettings["XMLLogFileLocation"];
    public static bool LogExists { get; set; }

    public static List<SalesOrder> ListOfChanges;

    public XMLHandler()
    {
        ListOfChanges = new List<SalesOrder>();
    }

    public List<SalesOrder> GetListOfChanges()
    {

        try
        {

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Load(XMLFileLocation);
            foreach (XElement cr in xdoc.Descendants("SalesOrder"))
            {
                SalesOrder s = new SalesOrder();

                s.SalesOrderNo = cr.Attribute("id").Value;
                s.PromiseDate = CommonData.GetDate(cr.Element("promiseDate").Value);
                s.OriginalPromiseDate = CommonData.GetDate(cr.Element("originalpromiseDate").Value);
                s.OrderType = cr.Element("orderType").Value;
                s.ChangeNote = cr.Element("changeNote").Value;
                s.ChangeDate = cr.Element("changeDate").Value;

                ListOfChanges.Add(s);
            }
  
        }
        catch (Exception )
        {
            throw;
        }

        return ListOfChanges;
    }
}
