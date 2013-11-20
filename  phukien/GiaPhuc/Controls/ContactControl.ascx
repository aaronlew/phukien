<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactControl.ascx.cs"
    Inherits="GiaPhuc.Controls.ContactControl" %>
<div id="support">
    <b style="color: blue">TPHCM:</b>
    <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Resources, Address1 %>"></asp:Literal>
    <div class="support">
        <ul style="color: blue;">
            <li>
                <asp:Literal ID="Literal2" runat="server" Text="<%$Resources:Resources, UserSupport1 %>"></asp:Literal></li>
            <li><a href="ymsgr:sendim?lieumanhdat1981">
                <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=lieumanhdat1981&m=g&t=2&l=us"></img>
            </a></li>
        </ul>
        <ul style="color: blue;">
            <li>
                <asp:Literal ID="Literal3" runat="server" Text="<%$Resources:Resources, UserSupport2 %>"></asp:Literal></li>
            <li><a href="ymsgr:sendim?phukienipadx">
                <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=phukienipadx&m=g&t=2&l=us"></img>
            </a></li>
        </ul>
    </div>
    <div class="clear">
    </div>
    <%--<b style="color: red">HÀ NỘI:</b>
    <asp:Literal ID="Literal4" runat="server" Text="<%$Resources:Resources, Address2 %>"></asp:Literal>
    <div>
        <ul style="color: blue; list-style: none">
            <li><b>
                <asp:Literal ID="Literal5" runat="server" Text="<%$Resources:Resources, UserSupport3 %>"></asp:Literal></b><span
                    style="color: red; font-style: italic">Vui lòng gọi trước khi đến cửa hàng</span></li>
            <li><a href="ymsgr:sendim?nanganhbsg">
                <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=nanganhbsg&m=g&t=2&l=us" />
            </a></li>
        </ul>
    </div>--%>
</div>
