<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PostsControl.ascx.cs"
    Inherits="GiaPhuc.Controls.PostsControl" %>
<div id="posts">
    <div class="shadow">
    </div>
    <div class="content">
        <div class="main-pic"><img src="/static/images/iPad_5_release_date.jpg" alt="ipad 5" title="ipad 5" /></div>
        <%
            XElement xelement1 = XElement.Load(Server.MapPath("~/web.sitemap"));
            var urlDescList = xelement1.Descendants()
                .Where(sel => (string)sel.Attribute("resourceKey") == "Post")
                .SelectMany(e => e.Elements()).Select(nd => new
                            {
                                title = nd.Attribute("title").Value,
                                url = nd.Attribute("url").Value,
                                description = nd.Attribute("description").Value
                            });
        %>
        <ul>
            <%
                foreach (var v in urlDescList)
                {
            %>
            <li><a target="_blank" href="<%=v.url.ParseSimpleUrl(v.title) %>">
                <img src="<%=v.description %>" alt="<%=v.title %>" title="<%=v.title %>" />
                <span>
                    <%=v.title %></span></a></li>
            <%
                } 
            %>
        </ul>
    </div>
</div>
