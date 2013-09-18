<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressLineControl.ascx.cs"
    Inherits="GiaPhuc.Controls.AddressLineControl" %>
<p class="wrapper" style="background: #ddd; padding: 5px;">
    <asp:Literal ID="Literal1" runat="server" Text="<%$Resources:Resources, Address1 %>" /></p>
<p class="wrapper" style="background: #eee; padding: 5px;">
    <asp:Literal ID="Literal2" runat="server" Text="<%$Resources:Resources, Address2 %>" /></p>
