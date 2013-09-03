<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCProductCategory.ascx.cs"
    Inherits="GiaPhuc.Controls.UCProductCategory" %>
<%@ Register Src="~/Controls/UCProductCell.ascx" TagName="ProductCell" TagPrefix="uc" %>
<div class="box-heading">
    <asp:Label ID="lblCategory" runat="server" Text='<%#GetParentCategoryName() %>'></asp:Label>
</div>
<asp:Panel ID="pnlLayout" runat="server" />
