<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FooterControl.ascx.cs"
    Inherits="GiaPhuc.Controls.FooterControl" %>
<div id="footer">
    <div id="limit" class="section group" style="margin-bottom: 20px;">
        <div class="col span_1_of_4">
            <ul>
                <li class="title">HỖ TRỢ KHÁCH HÀNG</li>
                <li><a href="/mua-hang"><span>
                    Hướng dẫn mua hàng</span></a></li>
                <li><a href="/su-dung"><span>
                    Hướng dẫn sử dụng</span></a></li>
                <li><a href="/van-chuyen"><span>
                    Chính sách vận chuyển và giao hàng</span></a></li>
                <li><a href="/doi-tra"><span>
                    Chính sách đổi trả hàng</span></a></li>
                <li><a href="/bao-hanh"><span>
                    Quy định bảo hành</span></a></li>
            </ul>
        </div>
        <div class="col span_1_of_4">
            <ul>
                <li class="title">ABOUT CỬA HÀNG TINH TẾ</li>
                <li><a href="/gioi-thieu">Cửa hàng Tinh Tế</a></li>
                <li><a href="/bao-mat">Chính Sách Bảo Mật</a></li>
                <li><a href="/doi-tac">Tìm Đối Tác</a></li>
                <li><a href="/lien-he">Liên Hệ</a></li>
            </ul>
        </div>
        <div class="col span_1_of_4">
            <ul>
                <li class="title">Được chứng nhận:</li>
            </ul>
        </div>
        <div class="col span_1_of_4">
            <ul style="font-size: 10pt; color: #999;">
                <li class="title">Trực tuyến:
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
        <%--<div class="col span_3_of_4">
            <%
                int i = 0;
                foreach (phukienipadx.Bl.Models.CategoryInfo item in GiaPhuc.Utility.SessionManager.Categories)
                {
                    if (i % 3 == 0)
                    {
            %>
            <ul class="section group">
                <% } %>
                <li class="col span_1_of_3"><a href="<%= (item.Url) %>" title="<%=item.Name %>">
                    <%= item.Name %></a>
                    <%
                    if (item.Categories != null && item.Categories.Count > 0)
                    {%>
                    <ul class="sub">
                        <%
                        foreach (phukienipadx.Bl.Models.CategoryInfo subItem in item.Categories)
                        {
                        %>
                        <li><a href="<%= (subItem.Url) %>" title="<%=subItem.Name %>">
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
        </div>--%>
    </div>
    <div class="section group">
        <p style="font-size: 9pt">
            <b>Cửa hàng TINH TẾ</b>
            <br />
            Số GPKD: 41K8013138 - Ngày cấp 18/6/2012 – UBND Q.11-TP.HCM
            <br />
            Địa chỉ trụ sở chính: 174/47 Thái Phiên, Phường 8, Quận 11, Tp. Hồ Chí Minh
            <br />
            Email: <span style="color: blue"> phukienipadx@gmail.com</span>
            <br />
            Điện thoại: 0903.71.20.70 – 0969.10.71.10</p>
    </div>
</div>
