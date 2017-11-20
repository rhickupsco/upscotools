using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Information
/// </summary>
public class Information
{

    private string _salesOrderno;
    private string _itemCode;
    private DateTime _promiseDate;
    private DateTime _originalPromiseDate;
    private string _orderType;
    private string _changeNote;
    private DateTime _changeDate;
    private string _uniqueId;

    public string SalesOrderNo
    {
      get { return _salesOrderno; }
      set { _salesOrderno = value; }
    }
    public string ItemCode
    {
        get { return _itemCode; }
        set { _itemCode = value; }
    }
    public string UniqueId
    {
        get { return _uniqueId; }
        set { _uniqueId = value; }
    }
    public DateTime PromiseDate
    {
        get { return _promiseDate; }
        set { _promiseDate = value; }
    }
    public DateTime OriginalPromiseDate
    {
        get { return _originalPromiseDate; }
        set { _originalPromiseDate = value; }
    }
    public string OrderType
    {
        get { return _orderType; }
        set { _orderType = value; }
    }

    //this is the property that allows for a change to be recorded
    public string ChangeNote
    {
        get { return _changeNote; }
        set { _changeNote = value; }
    }

    public DateTime ChangeDate
    {
        get { return _changeDate; }
        set { _changeDate = value;}
    
    }

    public static DateTime GetDate(string dateToEvaluate)
    {
        string[] formats = { "MM/dd/yyyy", "MM/d/yyyy", "M/d/yyyy h:mm:ss tt","MM/dd/yy","MM/dd/yy hh:mm:ss tt","MM/dd/yy hh:mm:ss","M/d/yyyy h:mm tt",
                         "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                         "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                         "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                         "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm" };
        DateTime dateValue;

        if (DateTime.TryParseExact(dateToEvaluate, formats, new System.Globalization.CultureInfo("en-US"),
            System.Globalization.DateTimeStyles.None, out dateValue))
        {
            return dateValue;
        }
        else
        {
            dateValue = Data_Access.CommonData.DefaultDate;
            return dateValue;
        }
    }



}