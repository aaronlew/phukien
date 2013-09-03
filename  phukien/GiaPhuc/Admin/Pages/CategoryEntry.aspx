<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true" CodeBehind="CategoryEntry.aspx.cs" Inherits="GiaPhuc.Admin.Pages.CategoryEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td style="width: 86px">Phụ kiện:
            </td>
            <td style="padding: 6px">
                <asp:TextBox ID="txtCategoryName" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:CheckBox ID="chkDeactive" runat="server" Text="Ngưng sử dụng"></asp:CheckBox>
            </td>
        </tr>
    </table>
    <div class="clear button">
        <asp:HyperLink ID="lnkBackToList" NavigateUrl="/Admin/Pages/CategoryManager.aspx" runat="server"><span>Back to Home</span></asp:HyperLink>
        <asp:LinkButton ID="lnkSave" runat="server" OnClick="lnkSave_Click"><span>Save</span></asp:LinkButton>
    </div>
</asp:Content>
