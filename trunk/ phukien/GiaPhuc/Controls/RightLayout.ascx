<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RightLayout.ascx.cs"
    Inherits="GiaPhuc.Controls.RightLayout" %>
<table border="0" class="tproduct">
    <tr class="thead">
        <th>
            BÀI VIẾT
        </th>
    </tr>
    <tr>
        <td>
            <ul class="item topic">
                <% foreach (var item in EZPages)
                   {
                %>
                <li><a href="<%=("/Pages/TopicPage.aspx?ID=" + item.PagesID).ParseSimpleURL(item.PagesTitle) %>">
                    <%=item.PagesTitle %>
                </a></li>
                <%
                   } %>
            </ul>
        </td>
    </tr>
    <tr class="thead">
        <th>
            HỖ TRỢ ONLINE
        </th>
    </tr>
    <tr>
        <td>
            <ul class="item">
                <li><b style="color: Red; text-align: left;">Nice Store TPHCM:</b></li>
                <li><a href="ymsgr:sendim?lieumanhdat1981">
                    <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=lieumanhdat1981&m=g&t=2&l=us"
                        border="0" />
                </a></li>
                <li><a href="ymsgr:sendim?phukienipadx">
                    <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=phukienipadx&m=g&t=2&l=us"
                        border="0" />
                </a></li>
                <li>Mr. Đạt : 0903.71.20.70</li>
                <li>Mr. Hùng: 0908.61.21.40</li>
                <li><b style="color: Red; text-align: left;">Nice Store Hà Nội:</b></li>
                <li><a href="ymsgr:sendim?nanganhbsg">
                    <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=nanganhbsg&m=g&t=2&l=us"
                        border="0" />
                </a></li>
                <li>Mr. Năng: 0979.433.682</li>
            </ul>
        </td>
    </tr>
    <tr class="thead">
        <th>
            THỐNG KÊ TRUY CẬP
        </th>
    </tr>
    <tr>
        <td>
            <ul class="item">
                <li>
                    <g:plusone></g:plusone>
                    <a href="https://twitter.com/share" class="twitter-share-button" data-url="http://www.phukienipadx.com"
                        data-text="phu kien ipadx" data-via="pin du phong" data-related="bao da ipad"
                        data-hashtags="YOOBAO">Tweet</a>
                    <fb:like href="http://phukienipadx.com" layout="button_count" width="10" show_faces="true"
                        font="tahoma">
                                                </fb:like>
                </li>
                <li>Đang truy cập:
                    <%= Application["OnlineUsers"]%></li>
                <li>Lượt truy cập:
                    <%= Application["AccessUsers"]%></li>

                <script type="text/javascript">
                    window.___gcfg = {
                        lang: 'vi-VN'
                    };

                    (function () {
                        var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;
                        po.src = 'https://apis.google.com/js/plusone.js';
                        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
                    })();

                    (function (d, s, id) {
                        var js, fjs = d.getElementsByTagName(s)[0];
                        if (d.getElementById(id)) return;
                        js = d.createElement(s); js.id = id;
                        js.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1";
                        fjs.parentNode.insertBefore(js, fjs);
                    } (document, 'script', 'facebook-jssdk'));


                    !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = "//platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");
                            
                </script>

            </ul>
        </td>
    </tr>
    <tr class="thead">
        <th>
            TIN CÔNG NGHỆ
        </th>
    </tr>
    <tr style="height: 250px;">
        <td>
            <ul class="item topic">
                <% 
                    System.Collections.Generic.IList<RssFeedItem> feedItems = Session["InfoNews"] as System.Collections.Generic.IList<RssFeedItem>;
                    foreach (var news in feedItems)
                    {
                        Response.Write("<li><a href=\"" + news.Link + "\" target=\"_blank\">" + news.Title + "</a></li>");
                    }
                %>
            </ul>
        </td>
    </tr>
    <tr class="thead">
        <th>
            PHỤ KIỆN
            <img src="/Images/hot.gif" alt="phukienipadx.com" />
        </th>
    </tr>
    <tr>
        <td>
            <asp:Repeater ID="rptHotProducts" runat="server">
                <HeaderTemplate>
                    <div class="carousel" style="border: none">
                        <ul>
                </HeaderTemplate>
                <ItemTemplate>
                    <li>
                        <div class="product-cell1">
                            <div class="product-image">
                                <div class="overImg">
                                    <a href="<%#DataBinder.Eval(Container.DataItem, "Url")%>" class="screenshot" rel="<%#DataBinder.Eval(Container.DataItem, "ImagePath")%>">
                                    </a>
                                </div>
                                <img src="<%#DataBinder.Eval(Container.DataItem, "ImagePath")%>" alt="phu kien ipad" />
                            </div>
                            <div class="clear">
                                <div>
                                    <span class="price1">
                                        <%#DataBinder.Eval(Container.DataItem, "PriceName")%>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul> </div>
                </FooterTemplate>
            </asp:Repeater>
        </td>
    </tr>
</table>
