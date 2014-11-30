<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HorizontalBannerControl.ascx.cs"
    Inherits="GiaPhuc.Controls.HorizontalBannerControl" %>
<%@ Import Namespace="GiaPhuc.Utility" %>
<%--<div class="group section">
    <div class="col span_2_of_3">
        <div class="image_carousel">
            <ul id="foo2" style="height: 140px;">
                <%
                    int i = 0;
                    foreach (var item in SessionManager.SpecProducts)
                    {
                        if (i % 2 == 0)
                        {
                %><li class="section group">
                    <div class="col span_1_of_2">
                        <div class="section group">
                            <div class="product-cell">
                                <div class="col span_1_of_2">
                                    <a href="#">
                                        <img src="../images/about/image001.gif" alt="" /></a>
                                </div>
                                <div class="col span_1_of_2">
                                    <div class="description">
                                        <a href="#" />
                                        <p>
                                            123</p>
                                        <div class="price">
                                            123</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <%
                        }
                        else
                        {
                    %>
                    <div class="col span_1_of_2">
                        <div class="section group">
                            <div class="product-cell">
                                <div class="col span_1_of_2">
                                    <a href="#">
                                        <img src="../images/about/image001.gif" alt="" /></a>
                                </div>
                                <div class="col span_1_of_2">
                                    <div class="description">
                                        <a href="#" />
                                        <p>
                                            123</p>
                                        <div class="price">
                                            123</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <%
                        }

                        i++;

                    } %>
            </ul>
        </div>
        <a class="prev" id="foo2_prev" href="#"><span>prev</span></a> <a class="next" id="foo2_next"
            href="#"><span>next</span></a>
    </div>
</div>--%>
<div class="wrapper">
    <img src="/images/flash-demo.jpg" alt="tinh tế" />
</div>
