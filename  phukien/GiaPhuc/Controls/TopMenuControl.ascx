<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenuControl.ascx.cs"
    Inherits="GiaPhuc.Controls.TopMenuControl" %>
<div id="top-menu" class="black">
    <%
        XElement xelement1 = XElement.Load(Server.MapPath("~/web.sitemap"));
        var urlDescList = xelement1.Descendants()
            .Where(sel => (string)sel.Attribute("resourceKey") == "Home")
            .SelectMany(e => e.Elements()).Select(nd => new
                        {
                            title = nd.Attribute("title").Value,
                            description = nd.Attribute("description").Value,
                            url = nd.Attribute("url").Value
                        });
    %>
    <ul id="hor-menu" class="mega-menu wrapper">
        <li><a href="/">Home</a></li>
        <%
            foreach (var v in urlDescList)
            {
        %>
        <li><a href="/<%=v.description %>"><span>
            <%=v.title %></span></a></li>
        <%
            } 
        %>
    </ul>
</div>
