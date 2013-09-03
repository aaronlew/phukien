<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ContactPage.aspx.cs" Inherits="GiaPhuc.Pages.ContactPage" %>

<%@ Register Src="~/Controls/ContactControl.ascx" TagName="Contact" TagPrefix="uc" %>
<%@ Register Src="~/Controls/LocationControl.ascx" TagName="Location" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color: #fff">
        <uc:Location ID="Location1" runat="server"></uc:Location>
        <uc:Contact ID="Contact1" runat="server"></uc:Contact>
        <div class="clear">
        </div>
    </div>
</asp:Content>
