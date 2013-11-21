<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FooterControl.ascx.cs"
    Inherits="GiaPhuc.Controls.FooterControl" %>
<div id="footer">
    <div id="limit" class="section group">
        <div class="col span_1_of_4">
            <%
                XElement xelement1 = XElement.Load(Server.MapPath("~/web.sitemap"));
                var urlDescList = xelement1.Descendants()
                    .Where(sel => (string)sel.Attribute("resourceKey") == "Home")
                    .SelectMany(e => e.Elements()).Select(nd => new
                                {
                                    title = nd.Attribute("title").Value,
                                    url = nd.Attribute("url").Value
                                });
            %>
            <ul>
                <%
                    foreach (var v in urlDescList)
                    {
                %>
                <li><a target="_blank" href="<%=v.url.ParseSimpleUrl(v.title) %>"><span>
                    <%=v.title %></span></a></li>
                <%
                    } 
                %>
            </ul>
            <ul style="font-size: 10pt; color: #999;">
                <li class="center">Online:
                    <%= Application["OnlineUsers"] %></li>
                <li><span id="visitorCount"></span>
                    <script type="text/javascript">
                        $(document).ready(function () {
                            $.get('/VisitorCounter.ashx', function (data) {
                                $('#visitorCount').html(data);
                            });
                        });

                    </script>
                </li>
            </ul>
        </div>
        <div class="col span_3_of_4">
            <%
                int i = 0;
                foreach (phukienipadx.Bl.Models.CategoryInfo item in GiaPhuc.Utility.SessionManager.Categories)
                {
                    if (i % 3 == 0)
                    {
            %>
            <ul class="section group">
                <% } %>
                <li class="col span_1_of_3"><a target="_blank" href="<%= ("/Default.aspx?CategoryID=" + item.CategoryId).ParseSimpleUrl(item.Name) %>"
                    title="<%=item.Name %>">
                    <%= item.Name %></a>
                    <%
                    if (item.Categories != null && item.Categories.Count > 0)
                    {%>
                    <ul class="sub">
                        <%
                        foreach (phukienipadx.Bl.Models.CategoryInfo subItem in item.Categories)
                        {
                        %>
                        <li><a target="_blank" href="<%= ("/Default.aspx?CategoryID=" + subItem.CategoryId).ParseSimpleUrl(subItem.Name) %>"
                            title="<%=subItem.Name %>">
                            <%= subItem.Name %></a></li>
                        <%
                        }%>
                    </ul>
                    <% } %>
                </li>
                <%
                    if (i % 3 == 2 || i == GiaPhuc.Utility.SessionManager.Categories.Count - 1)
                    { %>
            </ul>
            <% } %>
            <%
                    i++;
                }
            %>
        </div>
    </div>
</div>
