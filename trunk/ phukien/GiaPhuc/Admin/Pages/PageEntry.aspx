<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminSite.Master" AutoEventWireup="true"
    CodeBehind="PageEntry.aspx.cs" Inherits="GiaPhuc.Admin.PageEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="/third-party/tiny_mce/themes/advanced/skins/default/ui.css" rel="Stylesheet"
        type="text/css" />
    <link href="/third-party/tiny_mce/plugins/inlinepopups/skins/clearlooks2/window.css"
        rel="Stylesheet" type="text/css" />

    <script src="/third-party/tiny_mce/jquery.tinymce.js" type="text/javascript"></script>

    <script type="text/javascript">

        $(document).ready(function () {
            var style = "/third-party/tiny_mce/themes/advanced/skins/o2k7/content.css";
            var jscript = "/third-party/tiny_mce/tiny_mce.js";

            function loadMce(key) {
                $(key).tinymce({
                    remove_script_host: false,
                    convert_urls: false,
                    paste_auto_cleanup_on_paste: false,
                    mode: "textareas",
                    elements: "txt_Detail,contactinfo,signature",
                    // Location of TinyMCE script
                    script_url: jscript,

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

            loadMce('#<%=elm1.ClientID %>');
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td style="width: 86px">
                Chủ đề:
            </td>
            <td style="padding: 6px">
                <asp:TextBox ID="txtTitle" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 86px">
                Nhóm tin:
            </td>
            <td style="padding: 6px">
                <asp:DropDownList ID="ddlNewsCategory" runat="server" Width="100%">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <textarea id="elm1" runat="server" name="elm1" rows="35" cols="80" style="width: 100%"
                    class="tinymce"></textarea>
            </td>
        </tr>
    </table>
    <div class="clear button">
        <asp:HyperLink ID="lnkBackToList" NavigateUrl="/Admin/Pages/PageManager.aspx" runat="server"><span>Back to Home</span></asp:HyperLink>
        <asp:LinkButton ID="lnkSave" runat="server" OnClick="lnkSave_Click"><span>Save</span></asp:LinkButton>
    </div>
</asp:Content>
