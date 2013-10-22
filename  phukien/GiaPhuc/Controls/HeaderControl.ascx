<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderControl.ascx.cs"
    Inherits="GiaPhuc.Controls.HeaderControl" %>
<%@ Register Src="~/Controls/SocialControl.ascx" TagName="Social" TagPrefix="uc" %>
<%@ Import Namespace="System.Linq" %>
<%@ Import Namespace="GiaPhuc.App_Data" %>
<%@ Import Namespace="GiaPhuc.Utility" %>
<script type="text/javascript">
    $(document).ready(function () {
        $("#<%=txtSearchBox.ClientID %>").keydown(function (event) {
            var keycode = (event.keyCode ? event.keyCode : (event.which ? event.which : event.charCode));
            if (keycode == 13) {
                window.location = "/Default.aspx?keyword=" + $(this).val();
                return false;
            } else {
                return true;
            }
        });
    });
</script>
<div class="page-header">
    <div class="main-width">
        <div class="wrapper">
            <div class="logo">
                <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="/static/images/logo horizontal.gif"
                    ToolTip="phukienipadx.com" AlternateText="Pin dự phòng" Height="86px" HotSpotMode="Navigate">
                    <asp:RectangleHotSpot Top="0" Left="0" Right="430" Bottom="86" NavigateUrl="/" />
                </asp:ImageMap>
            </div>
            <div class="float-left">
                <uc:Social ID="social1" runat="server" />
            </div>
            <div class="float-right">
                <div>
                    <a target="_blank" href="/Pages/CartPage.aspx" class="cart">Giỏ hàng <span style="color: Red">
                        <%="(" + SessionManager.Cart.Sum(x => x.Value.Quantity) + ")" %></span> </a>
                </div>
                <div class="clear">
                </div>
                <div class="search-item">
                    <asp:TextBox ID="txtSearchBox" runat="server" CssClass="water" Text="Nhập từ khóa tìm kiếm"
                        ToolTip="Nhập từ khóa tìm kiếm"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
</div>
