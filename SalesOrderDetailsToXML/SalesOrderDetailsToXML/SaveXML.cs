using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Configuration;

/// <summary>
/// Summary description for SaveXML
/// </summary>
public class SaveXML
{
    public static string FileLocation = ConfigurationManager.AppSettings["XMLFileLocation"];
    public static string AlternateFileLocation = ConfigurationManager.AppSettings["XMLLogFileLocation"];
    
    public static string FileToWriteTo { get; set; }
    public static bool LogExists { get; set; }

    public static Information DBInformation = new Information();

    public static void SaveData(Information info, string writeFileLocation = "useGlobal", bool dateChange = false)
    {
        DBInformation = info;

        //this will use the global FileLocation if 
        if (writeFileLocation == "useGlobal")
        {
            FileToWriteTo = FileLocation;
            LogExists = false;
        }

        else
        {
            FileToWriteTo = AlternateFileLocation;
        }

        //this writes a fresh file if it does not exist
        if (!File.Exists(FileToWriteTo)) {

            string strChangedNote = "nothing";
            string strChangedDate = "nothing";

            if (dateChange == true)
            {
               
                DateTime localPromiseDate = Information.GetDate(DBInformation.PromiseDate.ToShortDateString());

                if (localPromiseDate == Data_Access.CommonData.DefaultDate)
                { strChangedNote = "Sales Order has been Promised : " + localPromiseDate; }
                else { strChangedNote = "Promise date changed to : " + localPromiseDate; }

            }

            XDocument xDocument =
                    new XDocument(
                    new XElement("SalesOrders",
                    new XElement("SalesOrder", new XAttribute("id", info.SalesOrderNo),
                    new XElement("itemCode", new XAttribute("unique", info.UniqueId),
                    new XElement("originalPromiseDate", info.OriginalPromiseDate.ToShortDateString()),
                    new XElement("promiseDate", info.PromiseDate.ToShortDateString()),
                    new XElement("orderType", info.OrderType),
                    new XElement("changeNote", strChangedNote),
                    new XElement("changeDate", strChangedDate),
                    new XElement("dateRecorded", DateTime.Now.ToShortDateString())
                    ))));
            xDocument.Save(FileToWriteTo);


            //Different XML Writer

            //XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            //    xmlWriterSettings.Indent = true;
            //    xmlWriterSettings.NewLineOnAttributes = true;

            //using (XmlWriter xmlWriter = XmlWriter.Create(FileToWriteTo, xmlWriterSettings))
            //{
            //    xmlWriter.WriteStartDocument();
            //    xmlWriter.WriteStartElement("SalesOrders");
            //    xmlWriter.WriteStartElement("SalesOrder");
            //    xmlWriter.WriteAttributeString("id", info.SalesOrderNo);
            //    xmlWriter.WriteEndElement();
            //    xmlWriter.WriteStartElement("itemCode");
            //    xmlWriter.WriteAttributeString("unique", info.UniqueId);
            //    xmlWriter.WriteEndElement();
            //    xmlWriter.WriteElementString("originalpromiseDate", info.OriginalPromiseDate.ToShortDateString());
            //    xmlWriter.WriteElementString("promiseDate", info.PromiseDate.ToShortDateString());               
            //    xmlWriter.WriteElementString("orderType", info.OrderType);
            //    if(dateChange == true)
            //    {
            //        xmlWriter.WriteElementString("changeNote", "Promise date changed to : " + info.PromiseDate.ToShortDateString());
            //        xmlWriter.WriteElementString("changeDate", "Date Detected : " + DateTime.Now.ToLocalTime());
            //    }
            //    else
            //    {
            //        xmlWriter.WriteElementString("changeNote", null);
            //        xmlWriter.WriteElementString("changeDate", null);
            //    }
            //    xmlWriter.WriteElementString("dateRecorded", DateTime.Now.ToShortDateString());
            //    //if(FileToWriteTo == AlternateFileLocation)
            //    //{
            //    //    //xmlWriter.WriteElementString("changeNote", info.ChangeNote.ToString());
            //    //xmlWriter.WriteElementString("changeDate", info.ChangeDate.ToLongTimeString());


            //    //}

            //    xmlWriter.WriteEndElement();
            //    xmlWriter.WriteEndDocument();
            //    xmlWriter.Flush();
            //    xmlWriter.Close();
        }
        //if the XML file does already exist it will append new salesorders and details into the file
        else {
            if (!LogExists)
            {
                //unless it already exists
                if (InList(info) == false)
                {

                    string strChangeNote = "nothing";
                    string strDateChange = "nothing";
                    bool writeChangeNote = true;


                    if (dateChange == true)
                    {

                        /////this may be looking at wrong promise date ----- UPSDATED TO DBINFORMATION object on 11/06/2017 not yet published
                        DateTime localPromiseDate = Information.GetDate(DBInformation.PromiseDate.ToShortDateString());
                        
                        //this checks to see if the Promise Date Change was from another date or the initial Promise
                        if (localPromiseDate == Data_Access.CommonData.DefaultDate)
                        { strChangeNote = "Sales Order has been Promised : " + localPromiseDate; }
                        else { strChangeNote = "Promise date changed to : " + localPromiseDate; }


                        strDateChange = "Date Detected : " + DateTime.Now.ToLocalTime();

                        //Does this specific change note already exist in the change log?
                        if (InList(info, strChangeNote))
                        {
                            writeChangeNote = false;
                        }

                    }



                    if (writeChangeNote == true)
                    { 
                                    //if it does not exist, add the salesorders and its details to the file
                                XDocument xDocument = XDocument.Load(FileToWriteTo);
                                XElement root = xDocument.Element("SalesOrders");
                                IEnumerable<XElement> rows = root.Descendants("SalesOrder");
                                XElement firstRow = rows.First();
                                firstRow.AddBeforeSelf(
                                   new XElement("SalesOrder", new XAttribute("id", info.SalesOrderNo),
                                   new XElement("itemCode", new XAttribute("unique", info.UniqueId), 
                                   new XElement("originalpromiseDate", info.OriginalPromiseDate.ToShortDateString()),
                                   new XElement("promiseDate", info.PromiseDate.ToShortDateString()),
                                   new XElement("orderType", info.OrderType.ToString()),
                                   new XElement("changeNote", strChangeNote),
                                   new XElement("changeDate", strDateChange),
                                   new XElement("dateRecorded", DateTime.Now.ToShortDateString())
                                   )));
                        
                                xDocument.Save(FileToWriteTo);
                }
                }
                else
                {
                    if (dateChange == true)
                    {
                        SaveData(info, "saveToLog", true);
                    }
                    else
                    {
                        if (CheckForChangesToPromiseDate(info))
                        {
                            SaveData(info, "saveToLog", true);
                        }
                    }
                }
            }

    }
           
   
    }

    private static bool CheckForChangesToPromiseDate(Information SOInfo)
    {
        bool changeFound = true;
        DateTime queriedDate = new DateTime();
        DateTime XMLDate = new DateTime();
        

        //Check in the Orginal File
        XDocument doc = XDocument.Load(FileLocation);
        string recordString = string.Empty;


        /////////////////////UP FOR REVIEW//////////////////
        ////Check the information in the Original XML List against what I just queried from database
        //XElement xe = doc.Descendants("SalesOrder")
        //    .FirstOrDefault(el => el.Attribute("id").Value == salesOrderInfo.SalesOrderNo);

        try
        {
            var recordInfo = from rec in doc.Descendants("SalesOrders").Descendants("SalesOrder").Descendants("itemCode")
                             where rec.Attribute("unique").Value == SOInfo.UniqueId.ToString()
                             select rec.Element("promiseDate").Value.ToString();
            recordString = recordInfo.First().ToString();

            if (recordString != string.Empty) { 
                //this means a record was found and now we are evaluating the promise date for that record
                //now query the date from 
                queriedDate = Information.GetDate(DBInformation.PromiseDate.ToShortDateString());
                XMLDate = Information.GetDate(recordString);

                if (XMLDate != queriedDate && XMLDate != Data_Access.CommonData.DefaultDate)
                {
                    changeFound = true;
                    LogExists = false;
                }

                else
                {
                    changeFound = false;
                }
            }
            else
            {
                changeFound = false;
            }
        }
        catch (Exception ex )
        {
            //this means that change was not found
            changeFound = false;
        }
            return changeFound;
    }

    private static bool InList(Information SalesOrderInfo, string changeValue = null) {
        bool result = false;

        XDocument doc = XDocument.Load(FileToWriteTo);
        try
        {
            bool soLineRecordExists = false;

            soLineRecordExists = SalesOrderItemExists(SalesOrderInfo, doc);


            //XElement xe = doc.Descendants("SalesOrder")
            //  .FirstOrDefault(el => el.Attribute("id").Value == value);
            bool changeRecordExists = false;

            //this means I found it
            if (soLineRecordExists)
            {
                result = true;
                if (FileToWriteTo == AlternateFileLocation)
                {
                    LogExists = true;

                    if (changeValue != null)
                    {
                        changeRecordExists = ChangeIsRecorded(SalesOrderInfo, doc, changeValue);

                        //if the exact change exists in the changelog, don't write it again
                        //only write if it is a different change
                        if (changeRecordExists)
                        {
                            result = false;
                        }
                        else
                        {
                            result = true;
                        }


                    }
                }

            }
            else
            {
                result = false;
            }
        
        }

        ////this means I found it
        //if (xe != null) {
        //    result = true;
        //    if(FileToWriteTo == AlternateFileLocation)
        //    {
        //        LogExists = true;

        //        //if the exact change exists in the changelog, don't write it again
        //        //only write if it is a different change
        //        if (xeChangeNote != null)
        //        {
        //            result = true;
        //        }                 
        //        else
        //        {
        //            result = false;
        //        }


        //    }

        //}
        //else {
        //    result = false;
        //}

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

        catch (Exception e)
        {
            result = false;
            EventLog.WriteEntry("Error Occured when searching for SalesOrder in XML: ", e.Message + "Trace" +
                 e.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);
        }     

        return result;
    }

    private static bool ChangeIsRecorded(Information SOInfo, XDocument doc, string existingNote = null )
    {
        string recordString = string.Empty;
        string localNote = null;

        if(existingNote != null)
        {
            localNote = existingNote;
        }

        try
        {
            var recordInfo = from rec in doc.Descendants("SalesOrders").Descendants("SalesOrder").Descendants("itemCode")
                                     where rec.Attribute("unique").Value == SOInfo.UniqueId.ToString()                                     
                             select rec.Element("changeNote").Value.ToString();
            recordString = recordInfo.First().ToString();
            if (recordString != string.Empty)
                if (recordString == localNote  && FileToWriteTo == AlternateFileLocation)
                    {
                        return true;
                    }
                else
                {
                    return false;
                }
               
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            //this means that change was not found
            return false;
        }
    }

    private static bool SalesOrderItemExists(Information SOInfo, XDocument doc)
    {
        string recordString = string.Empty;
        try
        {
            var recordInfo = from rec in doc.Descendants("SalesOrders").Descendants("SalesOrder").Descendants("itemCode")
                             where rec.Attribute("unique").Value == SOInfo.UniqueId.ToString() 
                             select rec.Element("changeNote").Value.ToString();
            recordString = recordInfo.First().ToString();
            if (recordString != string.Empty)
                //now check if that specific Change exists
                if (FileToWriteTo == FileLocation)
                {
                    return true;
                }
                else {
                    if(ChangeIsRecorded(SOInfo, doc, recordString))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                   
            else
            {
                return false;
            }
        }
        catch (Exception e)
        {
            //this means that change was not found
            return false;
        }
    }

}