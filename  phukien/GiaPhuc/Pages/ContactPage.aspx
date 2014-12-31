<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ContactPage.aspx.cs" Inherits="GiaPhuc.Pages.ContactPage" %>

<%@ Register Src="~/Controls/LocationControl.ascx" TagName="Location" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"><div class="box-heading">
                <h2><span>THÔNG TIN LIÊN HỆ</span></h2></div>
    <div style="background-color: #fff">
        <uc:Location ID="Location1" runat="server"></uc:Location>
        <br/>
        <div id="contact-info">
            <div class="location">
                <a href="#">174/47 Thái Phiên • P8, Q11 • TPHCM</a></div>
            <div class="phone">
                <a href="#">0903.71.20.70 • 0908.61.21.40 • 0969.10.71.10</a></div>
        </div>
        <br/>
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
    </div>
</asp:Content>
