using System;
using System.Collections.Generic;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Information
/// This is a class that matches the Schema of the XML files that will 
/// Track help to track changes detected by the UPSCOSalesOrderChangeService
/// </summary>

public class InformationList
{
    public InformationList() { SalesOrders = new List<SalesOrder>(); }

    public List<SalesOrder> SalesOrders { get; set; }
}

public class SalesOrder
{
    private string _salesOrderno;
    private DateTime _promiseDate;
    private DateTime _originalPromiseDate;
    private string _orderType;
    private string _changeNote;
    private string _changeDate;


    public string SalesOrderNo
    {
        get { return _salesOrderno.ToString(); }
        set { _salesOrderno = value; }
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

    public string ChangeDate
    {
        get { return _changeDate; }
        set { _changeDate = value; }

    }

}