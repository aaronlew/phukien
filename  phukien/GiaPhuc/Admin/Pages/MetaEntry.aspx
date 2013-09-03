<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.master" AutoEventWireup="true" Inherits="Pages_MetaEntry" Codebehind="MetaEntry.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <fieldset class="dataentry">
        <legend>Meta tags:</legend>
        <div>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
        </div>
        <div class="clear">
            <div class="label">
                Title:
            </div>
            <div>
                <asp:TextBox ID="txtTitle" runat="server" Width="79%" MaxLength="72"></asp:TextBox>
            </div>
        </div>
        <div class="clear">
            <div class="label">
                Keywords:
            </div>
            <div>
                <asp:TextBox ID="txtKeywords" runat="server" Width="79%" MaxLength="100"></asp:TextBox>
            </div>
        </div>
        <div class="clear">
            <div class="label">
                Description:
            </div>
            <div>
                <asp:TextBox ID="txtDescription" runat="server" Width="79%" Rows="3" TextMode="MultiLine"
                    MaxLength="185"></asp:TextBox>
            </div>
        </div>
        <div>
            <asp:RegularExpressionValidator ID="regComments" runat="server" ControlToValidate="txtDescription"
                ValidationExpression="^[\s\S]{0,200}$" ErrorMessage="Maximum 200 characters are allowed in comments box."
                Text="Maximum 200 characters are allowed in description
box."> </asp:RegularExpressionValidator>
        </div>
    </fieldset>
    <div class="clear button">
        <asp:HyperLink ID="lnkBackToList" NavigateUrl="/" runat="server"><span>Back to Home</span></asp:HyperLink>
        <asp:LinkButton ID="lnkSave" runat="server" OnClick="lnkSave_Click"><span>Save</span></asp:LinkButton>
    </div>
</asp:Content>
