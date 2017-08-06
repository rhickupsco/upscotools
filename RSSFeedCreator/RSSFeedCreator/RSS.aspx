<%@ Page Language="C#"  ContentType="text/xml" AutoEventWireup="true" CodeBehind="RSS.aspx.cs" Inherits="RSSFeedCreator.RSS" %>

<asp:Repeater ID="RepeaterRSS" runat="server">
        <HeaderTemplate>
           <rss version="2.0">
                <channel>
                    <title>Name of the Website</title>
                    <link>http://www.upscoinc.com</link>
                    <description>
                        Upsco Inc.
                    </description>
        </HeaderTemplate>
        <ItemTemplate>
            <item>
                <title><%# RemoveIllegalCharacters(DataBinder.Eval(Container.DataItem, "Title")) %></title>
               <%-- <link>http://www.yourdomain.com/news.aspx?ID=<%# DataBinder.Eval(Container.DataItem, "ArticleID") %></link>--%>
                <author><%# RemoveIllegalCharacters(DataBinder.Eval(Container.DataItem, "Author"))%></author>
                <pubDate><%# String.Format("{0:R}", DataBinder.Eval(Container.DataItem, "DatePublished"))%></pubDate>
                <description><%# RemoveIllegalCharacters(DataBinder.Eval(Container.DataItem, "Description"))%></description>
        </item>
        </ItemTemplate>
        <FooterTemplate>
                </channel>
            </rss>  
        </FooterTemplate>
</asp:Repeater>



