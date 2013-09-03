<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="TopicPage.aspx.cs" Inherits="GiaPhuc.Pages.TopicPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color: #fff">
        <div id="divContent" runat="server">
        </div>
        <div>
            <a href='<asp:Literal runat="server" Text="<%$Resources:Resources, BackLink%>" />'
                class="backtohome">Trở về trang chủ</a> <a href="#" class="backtotop">Lên đầu trang</a></div>
        <div class="clear">
        </div>
    </div>
</asp:Content>
