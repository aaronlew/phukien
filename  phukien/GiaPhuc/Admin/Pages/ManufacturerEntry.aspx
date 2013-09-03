<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="ManufacturerEntry.aspx.cs" Inherits="GiaPhuc.Admin.Pages.ManufacturerEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td style="width: 86px">Phụ kiện cho sản phẩm:
            </td>
            <td style="padding: 6px">
                <asp:TextBox ID="txtManufacturerName" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div class="clear button">
        <asp:HyperLink ID="lnkBackToList" NavigateUrl="/Admin/Pages/ManufacturerManager.aspx" runat="server"><span>Back to Home</span></asp:HyperLink>
        <asp:LinkButton ID="lnkSave" runat="server" OnClick="lnkSave_Click"><span>Save</span></asp:LinkButton>
    </div>
</asp:Content>
