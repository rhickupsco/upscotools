using System;
using System.DirectoryServices.AccountManagement;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DynamicData_CustomPages_ADauthenticate : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = Environment.UserName;       

        PrincipalContext pc = new PrincipalContext(ContextType.Machine,username);
        List<GroupPrincipal> gpL = new List<GroupPrincipal>();

        gpL = GetGroups(username);

        foreach (GroupPrincipal role in gpL)
        {
            if (role.Name != null) { ddlRoles.Items.Add(role.Name.ToString().ToUpper()); }
        }

        lblUsername.Text = username.ToUpper();
        
    }

    public List<GroupPrincipal> GetGroups(string userName)
    {
        List<GroupPrincipal> result = new List<GroupPrincipal>();

        // establish domain context
        PrincipalContext yourDomain = new PrincipalContext(ContextType.Domain);

        // find your user
        UserPrincipal user = UserPrincipal.FindByIdentity(yourDomain, userName);

        // if found - grab its groups
        if (user != null)
        {
            PrincipalSearchResult<Principal> groups = user.GetAuthorizationGroups();

            // iterate over all groups
            foreach (Principal p in groups)
            {
                // make sure to add only group principals
                if (p is GroupPrincipal)
                {
                    result.Add((GroupPrincipal)p);
                }
            }
        }

        return result;
    }
}