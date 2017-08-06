﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;

public partial class DynamicData_FieldTemplates_DateCalendar : System.Web.DynamicData.FieldTemplateUserControl
{
    public override Control DataControl
    {
        get
        {
            return Literal1;
        }
    }

    protected override void OnDataBinding(EventArgs e)
    {
        base.OnDataBinding(e);
        string shortDate = string.Empty;
        if (FieldValue != null)
        {
            DateTime dt = (DateTime)FieldValue;
            shortDate = dt.ToShortDateString();            
        }
        Literal1.Text = shortDate;
    }



}
