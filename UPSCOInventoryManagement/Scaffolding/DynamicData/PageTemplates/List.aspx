<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeFile="List.aspx.cs" Inherits="List" %>

<%@ Register src="~/DynamicData/Content/GridViewPager.ascx" tagname="GridViewPager" tagprefix="asp" %>
<%@ Register src="~/DynamicData/Content/FilterUserControl.ascx" tagname="DynamicFilter" tagprefix="asp" %>
<%@ Register Assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" Namespace="System.Web.UI.WebControls" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DynamicDataManager ID="DynamicDataManager1" runat="server" AutoLoadForeignKeys="true" />

    <h2><%= table.DisplayName%></h2>

    <asp:ScriptManagerProxy runat="server" ID="ScriptManagerProxy1" />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
        <ContentTemplate>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" EnableClientScript="true"
                HeaderText="List of validation errors" />
            <asp:DynamicValidator runat="server" ID="GridViewValidator" ControlToValidate="GridView1" Display="None" />
            <fieldset id="MultiSearchAssigneesFieldSet" class="DD" runat="server" visible="false">
                <legend>Search for people by Name, Title, or phone extension "Phone extensions must start with x "</legend>
                <asp:TextBox ID="txbMultiColumnSearch" CssClass="DDText" runat="server" />
                <asp:Button ID="btnMultiColumnSearchSubmit" CssClass="ui-button" CausesValidation="false" runat="server" Text="Search" OnClick="btnMultiColumnSearchSubmit_Click"
                    />
                <asp:Button ID="btnMultiColumnSearchClear" CssClass="ui-button" CausesValidation="false" runat="server" Text="Clear" OnClick="btnMultiColumnSearchSubmit_Click"
                   />
            </fieldset>
           <%-- <fieldset id="MultiSearchComputersFieldSet" class="DD" runat="server" visible="false">
                <legend>Search by Asset Tag or Computer Name</legend>
                <asp:TextBox ID="txbMultiColumnSearchComputer" CssClass="DDText" runat="server" />
                <asp:Button ID="Button1" CssClass="ui-button" runat="server" CausesValidation="false" Text="Search" OnClick="btnMultiColumnSearchComputersSubmit_Click"
                    />
                <asp:Button ID="btnMultiComputerClear" CssClass="ui-button" CausesValidation="false" runat="server" Text="Clear" OnClick="btnMultiColumnSearchComputersSubmit_Click"
                   />
            </fieldset>--%>

            <asp:FilterRepeater ID="FilterRepeater" runat="server">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("DisplayName") %>' AssociatedControlID="DynamicFilter$DropDownList1" />
                    <asp:DynamicFilter runat="server" ID="DynamicFilter" OnSelectedIndexChanged="OnFilterSelectedIndexChanged" />
                </ItemTemplate>
                <FooterTemplate><br /><br /></FooterTemplate>
            </asp:FilterRepeater>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="GridDataSource" AllowPaging="True" AllowSorting="True" CssClass="gridview" PageSize="100" >
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="EditHyperLink" runat="server"
                                NavigateUrl='<%# table.GetActionPath(PageAction.Edit, GetDataItem()) %>'
                            Text="Edit" />&nbsp;<asp:LinkButton ID="DeleteLinkButton" runat="server" CommandName="Delete"
                                CausesValidation="false" Text="Delete"
                                OnClientClick='return confirm("Are you sure you want to delete this item?");'
                            />&nbsp;
                            <asp:HyperLink ID="DetailsHyperLink" runat="server"
                                NavigateUrl='<%# table.GetActionPath(PageAction.Details, GetDataItem()) %>'
                                Text="Details" />
                          <%--  <asp:Hyperlink ID="DellHyperlink" runat="server"
                                NavigateUrl='<%# Eval("AssetTag","http://www.dell.com/support/home/us/en/19/product-support/servicetag/{0}") %>'
                                Text="Dell Support" />--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <PagerStyle CssClass="footer"/>        
                <PagerTemplate>
                    <asp:GridViewPager runat="server"  />
                </PagerTemplate>
                <EmptyDataTemplate>
                    There are currently no items in this table.
                </EmptyDataTemplate>
            </asp:GridView>

            <asp:EntityDataSource ID="GridDataSource" runat="server" EnableDelete="true">
                <WhereParameters>
                    <asp:DynamicControlParameter ControlID="FilterRepeater" />
                </WhereParameters>
            </asp:EntityDataSource>

            <br />

            <div class="bottomhyperlink">
                <asp:HyperLink ID="InsertHyperLink" runat="server"><img runat="server" src="~/DynamicData/Content/Images/plus.png" alt="Add" />Add New</asp:HyperLink>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
