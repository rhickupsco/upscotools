using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;

/// <summary>
/// Summary description for SaveXML
/// </summary>
public class SaveXML
{
    public static string FileLocation { get; set; }

    public static void SaveData(Information info)
    {

        string filename = "OrderView_SalesOrderView.xml";
        FileLocation = "C:\\TestDocuments\\" + filename.ToString();

        //this writes a fresh file if it does not exist
        if (!File.Exists(FileLocation)) {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.NewLineOnAttributes = true;
            using (XmlWriter xmlWriter = XmlWriter.Create(FileLocation, xmlWriterSettings))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("SalesOrders");
                xmlWriter.WriteStartElement("SalesOrder");
                xmlWriter.WriteAttributeString("id", info.SalesOrderNo); 
                xmlWriter.WriteElementString("promiseDate", info.PromiseDate.ToShortDateString());
                xmlWriter.WriteElementString("originalPromiseDate", info.OriginalPromiseDate.ToShortDateString());
                xmlWriter.WriteElementString("status", info.PromiseDate.ToShortDateString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }
        //if the XML file does already exist it will append new salesorders and details into the file
        else {
            //unless it already exists
            if (InList(info.SalesOrderNo) == false) { 

            //if it does not exist, add the salesorders and its details to the file
            XDocument xDocument = XDocument.Load(FileLocation);
            XElement root = xDocument.Element("SalesOrders");
            IEnumerable<XElement> rows = root.Descendants("SalesOrder");
            XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
               new XElement("SalesOrder", new XAttribute("id",info.SalesOrderNo),
               new XElement("originalpromiseDate", info.OriginalPromiseDate.ToShortDateString()),
               new XElement("promiseDate", info.PromiseDate.ToShortDateString()),
               new XElement("status", info.Status)));

            xDocument.Save(FileLocation);
            }
    }
           
   
    }

    private static bool InList(string value) {
        bool result = false;

        string filename = "OrderView_SalesOrderView.xml";
        FileLocation = "C:\\TestDocuments\\" + filename.ToString();

        XDocument doc = XDocument.Load(FileLocation);

        try
        {

          XElement xe = doc.Descendants("SalesOrder")
            .FirstOrDefault(el => el.Attribute("id").Value == value);

            //this means I found it
            if (xe != null) {
                result = true;
            }
            else {
                result = false;
            }

            //this is the slow way using looping
            //foreach (XElement xe in doc.Descendants("SalesOrder"))
            //{
            //    string soNumber = string.Empty;

            //    soNumber = xe.Attribute("id").Value;

            //    if (soNumber == value)
            //    {
            //        result = true;
            //        continue;
            //    }

            //    //Debug.WriteLine(string.Format("{0}-{1}", "wrote", soNumber));                
            //}       
        }
        catch (Exception ex)
        {
            result = false;
        }     

        return result;
    }

    //string promise = string.Empty;
    //string oPromise = string.Empty;
    //string status = string.Empty;

    //promise = xe.Element("promiseDate").Value;
    //            oPromise = xe.Element("originalpromiseDate").Value;
    //            status = xe.Element("status").Value;
}