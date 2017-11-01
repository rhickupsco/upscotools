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
    private DateTime _promiseDate;
    private DateTime _originalPromiseDate;
    private string _status;

    public string SalesOrderNo
    {
      get { return _salesOrderno; }
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
    public string Status
    {
        get { return _status; }
        set { _status = value; }
    }
}