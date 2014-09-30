<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderControl.ascx.cs"
            Inherits="GiaPhuc.Controls.HeaderControl" %>
<%@ Import Namespace="GiaPhuc.Utility" %>
<%@ Register Src="~/Controls/SocialControl.ascx" TagName="Social" TagPrefix="uc" %>
<script type="text/javascript">
    $(document).ready(function() {
        var defaultKeyword = 'Nhập từ khóa tìm kiếm';

        $("#<%= txtSearchBox.ClientID %>").keydown(function(event) {
            var keycode = (event.keyCode ? event.keyCode : (event.which ? event.which : event.charCode));
            if (keycode == 13) {
                if ($(this).val() != defaultKeyword)
                    window.location = "/q/" + $(this).val();
                return false;
            } else {
                return true;
            }
        });

        $("#btnSearch").click(function(event) {
            if ($("#<%= txtSearchBox.ClientID %>").val() != defaultKeyword)
                window.location = "/q/" + $("#<%= txtSearchBox.ClientID %>").val();
        });
    });
</script>
<div class="page-header">
    <div class="main-width">
        <div class="wrapper">
            <uc:Social ID="social1" runat="server" />
            <div class="logo">
                <%--<asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="/static/images/logo_X.png"
                    ToolTip="phukienipadx.com" AlternateText="Pin dự phòng" Height="86px" HotSpotMode="Navigate">
                    <asp:RectangleHotSpot Top="0" Left="0" Right="160" Bottom="160" NavigateUrl="/" />
                </asp:ImageMap>--%>
                <asp:ImageMap ID="ImageMap2" runat="server" ImageUrl="/images/brand.jpg"
                              ToolTip="phukienipadx.com" AlternateText="Pin dự phòng" Height="86px" HotSpotMode="Navigate">
                    <asp:RectangleHotSpot Top="0" Left="0" Right="450" Bottom="163" NavigateUrl="/" />
                </asp:ImageMap>
            </div>
            <div class="float-right">
                <div class="clear">
                </div>
                <div class="search-item">
                    <div>
                        <asp:TextBox ID="txtSearchBox" runat="server" CssClass="water" Text="Nhập từ khóa tìm kiếm"
                                     ToolTip="Nhập từ khóa tìm kiếm"></asp:TextBox></div>
                    <div class="search-button">
                        <a id="btnSearch" href="javascript:void(0)" />
                    </div>
                    <div>
                        <a href="/gio-hang" class="cart">Giỏ hàng
                            <% if (SessionManager.Cart.Count > 0)
                               { %>
                                <span style="color: Red">
                                    <%= "(" + SessionManager.Cart.Sum(x => x.Value.Quantity) + ")" %></span>
                            <% } %>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>