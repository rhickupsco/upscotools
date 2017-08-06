<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PeoplePicker_Edit.ascx.cs" Inherits="DynamicData_FieldTemplates_PeoplePicker_EditField" %>

<asp:TextBox ID="UserName" runat="server" CssClass="droplist" Text='<%# FieldValueEditString %>'></asp:TextBox>

<asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="UserName" Display="Dynamic" Enabled="false" />
<asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="UserName" Display="Dynamic" Enabled="false" />
<asp:DynamicValidator runat="server" ID="DynamicValidator1" ControlToValidate="UserName" Display="Dynamic" />
