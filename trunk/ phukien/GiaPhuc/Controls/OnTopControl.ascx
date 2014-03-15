<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OnTopControl.ascx.cs"
    Inherits="GiaPhuc.Controls.OnTopControl" %>
<div style="position: fixed; width: 100%">
    <div class="onTop wrapper">
        <div id="divAddress">
            <p class="add1">
                <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Resources, Address1 %>" /></p>
        </div>
        <div id='cssmenu'>
            <ul>
                <li class='has-sub last'><a href="ymsgr:sendim?lieumanhdat1981">
                    <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=lieumanhdat1981"
                        title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com" />&nbsp; Bán hàng
                    1</a> </li>
                <li><a href="ymsgr:sendim?phukienipadx">
                    <img alt="Chat with phukienipadx.com" src="http://opi.yahoo.com/online?u=phukienipadx"
                        title="Bao da ipad, pin dự phòng YOOBAO, phukienipadx.com" />&nbsp; Bán hàng
                    2</a> </li>
            </ul>
        </div>
    </div>
</div>
<div style="display: inline-block; height: 38px;">
</div>
