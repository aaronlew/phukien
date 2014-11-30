<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderControl.ascx.cs"
    Inherits="GiaPhuc.Controls.HeaderControl" %>
<%@ Import Namespace="GiaPhuc.Utility" %>
<div class="page-header">
    <div class="main-width">
        <div class="wrapper">
            <div class="float-right">
                <div>
                    <a href="/gio-hang" class="cart">Giỏ hàng
                        <% if (SessionManager.Cart.Count > 0)
                           { %>
                        <span style="color: Red">
                            <%= "(" + SessionManager.Cart.Sum(x => x.Value.Quantity) + ")" %></span>
                        <% } %>
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>
