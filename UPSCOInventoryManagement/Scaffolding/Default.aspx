<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    <h2>Administrative View</h2>
    
    <br /><br />
    <script src="Scripts/browserZoomDouble.js"></script>
    <asp:gridview id="Menu1" runat="server" autogeneratecolumns="false"
        cssclass="gridview" alternatingrowstyle-cssclass="even">
        <Columns>
            <asp:TemplateField HeaderText="Table Name" SortExpression="TableName">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("ListActionPath") %>'>
                        <%#Eval("DisplayName") %></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:gridview>
</asp:Content>


