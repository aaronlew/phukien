<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenuControl.ascx.cs"
    Inherits="GiaPhuc.Controls.TopMenuControl" %>
<%--<div id="top-menu" class="white">
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
    <ul id="hor-menu" class="mega-menu wrapper">
        <li><a href="/">Home</a></li>
        <%
            foreach (var v in urlDescList)
            {
        %>
        <li><a href="<%=v.url.ParseSimpleUrl(v.title) %>"><span>
            <%=v.title %></span></a></li>
        <%
                } 
        %>
    </ul>
</div>--%>
<div id="top-menu" class="black">
    <ul id="hor-menu" class="mega-menu">
        <li><a href="/">YOOBAO</a>
            <ul>
                <li><a href="/">Pin dự phòng cao cấp</a></li></ul>
        </li>
        <li><a href="/">Apple</a>
            <ul>
                <li><a href="/">iPhone 4/4S</a>
                    <ul>
                        <li><a href="/">Bao da</a></li>
                        <li><a href="/">Ốp lưng</a></li>
                    </ul>
                </li>
                <li><a href="/">iPhone 5/5S</a>
                    <ul>
                        <li><a href="/">Bao da</a></li>
                        <li><a href="/">Ốp lưng</a></li>
                    </ul>
                </li>
                <li></li>
                <li></li>
                <li></li>
                <li><a href="/">iPad 1</a>
                    <ul>
                        <li><a href="/">Bàn phím bluetooth</a></li>
                        <li><a href="/">Bao da</a></li>
                    </ul>
                </li>
                <li><a href="/">iPad 2</a>
                    <ul>
                        <li><a href="/">Bàn phím bluetooth</a></li>
                        <li><a href="/">Bao da</a></li>
                    </ul>
                </li>
                <li><a href="/">iPad 3 (new iPad)</a>
                    <ul>
                        <li><a href="/">Bàn phím bluetooth</a></li>
                        <li><a href="/">Bao da</a></li>
                    </ul>
                </li>
                <li><a href="/">iPad 4</a>
                    <ul>
                        <li><a href="/">Bàn phím bluetooth</a></li>
                        <li><a href="/">Bao da</a></li>
                    </ul>
                </li>
                <li><a href="/">iPad Mini</a>
                    <ul>
                        <li><a href="/">Bàn phím bluetooth</a></li>
                        <li><a href="/">Bao da</a></li>
                    </ul>
                </li>
            </ul>
        </li>
        <li><a href="/">Samsung</a>
            <ul>
                <li><a href="/">S3/S4</a>
                    <ul>
                        <li><a href="/">Bao da</a></li>
                        <li><a href="/">Ốp lưng</a></li>
                    </ul>
                </li>
                <li><a href="/">Galaxy Note</a>
                    <ul>
                        <li><a href="/">Bao da</a></li>
                        <li><a href="/">Ốp lưng</a></li>
                    </ul>
                </li>
                <li><a href="/">Galaxy Note 2</a>
                    <ul>
                        <li><a href="/">Bao da</a></li>
                        <li><a href="/">Ốp lưng</a></li>
                    </ul>
                </li>
                <li><a href="/">Galaxy Tab</a>
                    <ul>
                        <li><a href="/">Bao da</a></li>
                        <li><a href="/">Ốp lưng</a></li>
                    </ul>
                </li>
                <li><a href="/">Galaxy Tab 3</a>
                    <ul>
                        <li><a href="/">Bao da</a></li>
                        <li><a href="/">Ốp lưng</a></li>
                    </ul>
                </li>
            </ul>
        </li>
        <li><a href="/">Phụ kiện khác</a>
            <ul>
                <li><a href="/">Macbook</a>
                    <ul>
                        <li><a href="/">Túi</a></li>
                        <li><a href="/">Phụ kiện</a></li>
                    </ul>
                </li>
                <li><a href="/">Thiết bị mạng</a> </li>
                <li><a href="/">Đồ chơi khác</a> </li>
            </ul>
        </li>
    </ul>
</div>
