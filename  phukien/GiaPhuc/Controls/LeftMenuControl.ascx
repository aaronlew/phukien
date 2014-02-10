<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftMenuControl.ascx.cs"
    Inherits="GiaPhuc.Controls.LeftMenuControl" %>
<script type="text/javascript">

    function hoverMenu() {
        var end_num = 4;
        var array_num = $(".navItem").size();
        $(".mainlist").css("position", "static");
        $(".sub-nav-container").css("top", "-10000000px");
        $(".navItem").removeClass("show_back");

        if ($(this).closest('li').has('div').length == 0) return true;

        $(this).addClass("show_back");

        var indexs = $(".navItem").index($(this));
        var show_box_height = $(this).next().height() + $(".right-tr").height() + $(".right-br").height();

        var li_height = $("#litb-nav li").height();
        var li_height_total = (indexs + 1) * (li_height + 1);

        if ((li_height_total + li_height + 1) > show_box_height) {
            $(this).parent().css("position", "relative");
            if (indexs > array_num - end_num) {
                $(this).next().css("top", -show_box_height + 70 + "px");
            } else {
                $(this).next().css("top", "-11px");
            }
        } else {
            $(this).next().css("top", "-17px");
        }
    }

    function hoverMenu1() {

        var end_num = 4;
        var array_num = $(".navItem").size();
        $(".mainlist").css("position", "static");
        $(".sub-nav-container").css("top", "-10000000px");
        $(".navItem").removeClass("show_back");

        if ($(this).closest('li').has('div').length == 0) return true;

        $(this).addClass("show_back");

        var indexs = $(".navItem").index($(this));
        var show_box_height = $(this).next().height() + $(".right-tr").height() + $(".right-br").height();

        var li_height = $("#litb-nav li").height();
        var li_height_total = (indexs + 1) * (li_height + 1);

        if ((li_height_total + li_height + 1) > show_box_height) {
            $(this).parent().css("position", "relative");
            if (indexs > array_num - end_num) {
                $(this).next().css("top", -show_box_height + 70 + "px");
            } else {
                $(this).next().css("top", "-11px");
            }
        } else {
            $(this).next().css("top", "-17px");
        }

        return false;
    }

    $(function () {
        $('#litb-nav li:last').attr('style', 'border-radius:0 0 5px 5px');

        $(".navItem").click(hoverMenu1).hover(
    	  hoverMenu,
    	    function () {
    	        $(".sub-nav-container").hover(
    				function () {
    				    //nothing
    				},
    				function () {
    				    $(this).css("top", "-10000000px");
    				    //$(this).css("z-index","9999999");
    				    $(this).parent().css("position", "static");
    				    $(".navItem").removeClass("show_back");
    				}
    			);
    	    }
    	);

    });

    $(document).click(function () {
        $(".mainlist").css("position", "static");
        $(".sub-nav-container").css("top", "-10000000px");
        $(".navItem").removeClass("show_back");
    });

    //-->

</script>
<div id="left_menu">
    <div id="light_menu" class="menu">
        <ul id="litb-nav">
            <%
                XElement xelement1 = XElement.Load(Server.MapPath("~/web.sitemap"));
                var urlDescList = xelement1.Descendants()
                    .Where(sel => (string)sel.Attribute("resourceKey") == "MainMenu")
                    .SelectMany(e => e.Elements()).Select(nd => new
                                {
                                    title = nd.Attribute("title").Value,
                                    url = nd.Attribute("url").Value,
                                    children = nd.Elements()
                                });
            %>
            <%
                bool first = true;
                foreach (var v in urlDescList)
                {
            %>
            <li class="<%=(first ? "first" : string.Empty) %> mainlist" style="position: static;">
                <a class="navItem" href="<%=v.url %>" title="<%=v.title %>">
                    <%=v.title %></a>
                <%
                    if (first) first = false;
                    if (v.children != null && v.children.Count() > 0)
                    {
                        var ndChild = v.children.Select(nd => new
                        {
                            title = nd.Attribute("title").Value,
                            url = nd.Attribute("url").Value,
                            children = nd.Elements()
                        });
                %>
                <div class="sub-nav-container">
                    <dl>
                        <%
                        int i = 0;
                        foreach (var subItem in ndChild)
                        {
                        %>
                        <dt><a href="<%=subItem.url %>" title="<%=subItem.title %>">
                            <%= subItem.title %></a></dt>
                        <%
                            if (subItem.children != null && subItem.children.Count() > 0)
                            {
                                var ndChildOfChild = subItem.children.Select(nd => new
                                {
                                    title = nd.Attribute("title").Value,
                                    url = nd.Attribute("url").Value,
                                    children = nd.Elements()
                                });
                                foreach (var subOfSubItem in ndChildOfChild)
                                {
                        %>
                        <dd>
                            <a href="<%=subOfSubItem.url %>" title="<%=subOfSubItem.title %>">
                                <%= subOfSubItem.title %></a></dd>
                        <%
                                }
                            }
                            i++;
                        }%>
                    </dl>
                </div>
                <% } %></li>
            <%
                } 
            %>
        </ul>
    </div>
</div>
