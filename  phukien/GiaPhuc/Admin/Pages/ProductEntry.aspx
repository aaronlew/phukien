<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.master" AutoEventWireup="true"
    Inherits="GiaPhuc.Admin.Pages.PagesProductEntry" CodeBehind="ProductEntry.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <link rel="stylesheet" href="/static/css/tabify.css" type="text/css" />
    <link href="/third-party/tiny_mce/themes/advanced/skins/default/ui.css" rel="Stylesheet"
        type="text/css" />
    <link href="/third-party/tiny_mce/plugins/inlinepopups/skins/clearlooks2/window.css"
        rel="Stylesheet" type="text/css" />
    <script src="/Scripts/jquery.tabify.js" type="text/javascript"></script>
    <script src="/third-party/tiny_mce/jquery.tinymce.js" type="text/javascript"></script>
    <script src="/Scripts/autoNumeric-1.7.4.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var style = "/third-party/tiny_mce/themes/advanced/skins/o2k7/content.css";
            var jscript = "/third-party/tiny_mce/tiny_mce.js";

            $('input.auto').autoNumeric({ aSep: ',', aDec: '.', aPad: false, vMin: '-999999999.99' });

            function loadMce(key) {
                $(key).tinymce({
                    remove_script_host: false,
                    convert_urls: false,
                    paste_auto_cleanup_on_paste: false,
                    mode: "textareas",
                    elements: "txt_Detail,contactinfo,signature",
                    // Location of TinyMCE script
                    script_url: jscript,
                    editor_selector: "#<%=txtProducts_Images.ClientID %>",

                    // General options
                    height: 0,
                    width: 698,
                    theme: "advanced",
                    skin: "o2k7",
                    skin_variant: "silver",
                    language: "vi",

                    plugins: "ccSimpleUploader,pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups,insertdatetime,preview,media,searchreplace,print,paste,directionality,fullscreen,noneditable,visualchars,nonbreaking,xhtmlxtras,template,advlist",

                    // Theme options
//                    theme_advanced_buttons1: "emotions,ccSimpleUploader,image",
//                    theme_advanced_buttons2: '',
                    theme_advanced_buttons3: "emotions,ccSimpleUploader,image",
                    theme_advanced_buttons4: '',
                    theme_advanced_toolbar_location: "top",
                    theme_advanced_toolbar_align: "left",

                    relative_urls: false,
                    file_browser_callback: "ccSimpleUploader",
                    plugin_ccSimpleUploader_upload_path: '/Upload/',
                    plugin_ccSimpleUploader_upload_substitute_path: '/Upload/',

                    // Example content CSS (should be your site CSS)
                    content_css: style,

                    // Style formats 
                    style_formats: [
                    { title: 'Bold text', inline: 'b' },
                    { title: 'Red text', inline: 'span', styles: { color: '#ff0000'} },
                    { title: 'Red header', block: 'h1', styles: { color: '#ff0000'} },
                    { title: 'Example 1', inline: 'span', classes: 'example1' },
                    { title: 'Example 2', inline: 'span', classes: 'example2' },
                    { title: 'Table styles' },
                    { title: 'Table row 1', selector: 'tr', classes: 'tablerow1' }
                    ],

                    // Drop lists for link/image/media/template dialogs
                    template_external_list_url: "lists/template_list.js",
                    external_link_list_url: "lists/link_list.js",
                    external_image_list_url: "lists/image_list.js",
                    media_external_list_url: "lists/media_list.js",

                    // Replace values for the template plugin
                    template_replace_values: {
                        username: "Some User",
                        staffid: "991234"
                    },
                    save_onsavecallback: void (0),
                    save_oncancelcallback: void (0)
                });
            }

            loadMce('#<%=txtProducts_Images.ClientID %>');
            loadMce('#<%=txtProducts_Description.ClientID %>');

            $("#tabs").idTabs();

            changeDiscountPriceStatus($('#<%=chkIsDiscount.ClientID %>').is(':checked'));
        });

        function changeDiscountPriceStatus(state) {
            if (state)
                $('#discount').show();
            else {
                $('#discount').hide();
            }
        }

        function changePriceStatus(state) {
            document.getElementById('<%=txtPrice.ClientID %>').disabled = state;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div style="width: 22%; float: left; font-size: 8pt;">
        <asp:CheckBoxList ID="chklCategory" runat="server">
        </asp:CheckBoxList>
    </div>
    <fieldset class="dataentry">
        <legend>Product Information:</legend>
        <div>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
        </div>
        <div class="clear">
            <div class="label">
                Mã sản phẩm:
            </div>
            <asp:TextBox ID="txtProductCode" runat="server"></asp:TextBox>
        </div>
        <div class="clear">
            <div class="label">
                Tên sản phẩm:
            </div>
            <asp:TextBox ID="txtProductName" runat="server" Width="580px"></asp:TextBox>
        </div>
        <div class="clear">
            <div class="label">
                Hình ảnh:
            </div>
            <asp:Image ID="imgProduct" runat="server" Width="100px" AlternateText="phu kien ipadx" />
            <asp:Image ID="imgProduct1" runat="server" Width="100px" AlternateText="phu kien ipadx" />
            <asp:Image ID="imgProduct2" runat="server" Width="100px" AlternateText="phu kien ipadx" />
            <asp:Image ID="imgProduct3" runat="server" Width="100px" AlternateText="phu kien ipadx" />
        </div>
        <div class="clear">
            <div class="label">
                &nbsp;
            </div>
            <div style="width: 380px; float: left">
                <asp:FileUpload ID="uplProductImage" runat="server"></asp:FileUpload>
                <asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>
                <asp:FileUpload ID="FileUpload2" runat="server"></asp:FileUpload>
                <asp:FileUpload ID="FileUpload3" runat="server"></asp:FileUpload>
            </div>
            <ul style="list-style: none; float: right; padding: 10px; background-color: gold">
                <li>
                    <asp:CheckBox ID="chkIsSpecial" runat="server" Text="Sản phẩm bán chạy"></asp:CheckBox></li>
                <li>
                    <asp:CheckBox ID="chkIsDiscount" runat="server" Text="Sản phẩm giảm giá" onclick="changeDiscountPriceStatus($(this).is(':checked'));"></asp:CheckBox></li>
                <li>
                    <asp:CheckBox ID="chkActive" runat="server" Text="Kích hoạt"></asp:CheckBox></li>
            </ul>
        </div>
        <div class="clear" id="discount">
            <div class="label">
                Giá chưa giảm:
            </div>
            <asp:TextBox ID="txtDiscountPrice" runat="server" CssClass="auto"></asp:TextBox>
        </div>
        <div class="clear">
            <div class="label">
                <asp:RadioButton ID="chkPrice" runat="server" Text="Giá bán:" GroupName="grpPrice"
                    Checked="true" onclick="changePriceStatus(false);" />
            </div>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="auto"></asp:TextBox>
        </div>
        <div class="clear">
            <div class="label">
                <asp:RadioButton ID="chkIsCall" runat="server" Text="Giá CALL." GroupName="grpPrice"
                    onclick="changePriceStatus(true);" />
            </div>
        </div>
        <div class="clear">
            <div id="tabs" class="usual">
                <ul>
                    <li><a href="#tab1" class="selected">MÔ TẢ SẢN PHẨM</a></li>
                    <li><a href="#tab2">THÔNG TIN KỸ THUẬT</a></li>
                </ul>
                <div id="tab1">
                    <asp:TextBox ID="txtProducts_Description" runat="server" Rows="38" Width="900" Height="600"
                        TextMode="MultiLine" CssClass="tinymce"></asp:TextBox>
                </div>
                <div id="tab2">
                    <asp:TextBox ID="txtProducts_Images" runat="server" Rows="38" Width="900" Height="600"
                        TextMode="MultiLine" CssClass="tinymce"></asp:TextBox>
                </div>
            </div>
        </div>
    </fieldset>
    <%--<fieldset class="dataentry">
        <legend>Meta tags of Product:</legend>
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
    </fieldset>--%>
    <div class="clear button">
        <asp:HyperLink ID="lnkBackToList" NavigateUrl="/" runat="server"><span>Back to Home</span></asp:HyperLink>
        <asp:LinkButton ID="lnkSave" runat="server" OnClick="LnkSaveClick"><span>Save</span></asp:LinkButton>
    </div>
</asp:Content>
