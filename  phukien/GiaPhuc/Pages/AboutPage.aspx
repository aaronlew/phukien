<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="AboutPage.aspx.cs" Inherits="GiaPhuc.Pages.AboutPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style>
<!--
 /* Font Definitions */
 @font-face
	{font-family:"Cambria Math";
	panose-1:0 0 0 0 0 0 0 0 0 0;}
@font-face
	{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;}
@font-face
	{font-family:Tahoma;
	panose-1:2 11 6 4 3 5 4 4 2 4;}
@font-face
	{font-family:Verdana;
	panose-1:2 11 6 4 3 5 4 4 2 4;}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:0in;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri","sans-serif";}
h1
	{mso-style-link:"Heading 1 Char";
	margin-right:0in;
	margin-left:0in;
	font-size:24.0pt;
	font-family:"Times New Roman","serif";
	font-weight:bold;}
a:link, span.MsoHyperlink
	{color:blue;
	text-decoration:underline;}
a:visited, span.MsoHyperlinkFollowed
	{color:purple;
	text-decoration:underline;}
p
	{margin-right:0in;
	margin-left:0in;
	font-size:12.0pt;
	font-family:"Times New Roman","serif";}
p.MsoAcetate, li.MsoAcetate, div.MsoAcetate
	{mso-style-link:"Balloon Text Char";
	margin:0in;
	margin-bottom:.0001pt;
	font-size:8.0pt;
	font-family:"Tahoma","sans-serif";}
span.Heading1Char
	{mso-style-name:"Heading 1 Char";
	mso-style-link:"Heading 1";
	font-family:"Times New Roman","serif";
	font-weight:bold;}
span.BalloonTextChar
	{mso-style-name:"Balloon Text Char";
	mso-style-link:"Balloon Text";
	font-family:"Tahoma","sans-serif";}
.MsoChpDefault
	{font-family:"Calibri","sans-serif";}
.MsoPapDefault
	{margin-bottom:10.0pt;
	line-height:115%;}
@page WordSection1
	{size:8.5in 11.0in;
	margin:1.0in 1.0in 1.0in 1.0in;}
div.WordSection1
	{page:WordSection1;background-color: #fff;padding: 5px;}
-->
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<h1 style="color: cadetblue; margin-bottom: 20px;">
        Các lý do để bạn chọn mua hàng tại PhuKieniPadx.com:</h1>
        
    <p style="text-align: justify">
        + Uy Tín bán hàng – Chúng tôi là nhà cung cấp phụ kiện iPad online Uy Tín nhất,
        tất cả hàng hóa đều được chúng tôi nhập trực tiếp nên luôn bảo đảm chất lượng cao
        nhất.
    </p>
    <p style="text-align: justify">
        + Bảo hành chu đáo nhất – Hiện nay với các sản phẩm điện tử công nghệ cao, chúng
        tôi tự hào luôn có chính sách bảo hành tuyệt đối 1 đổi 1 trong vòng 6 tháng, kiểm
        tra đơn giản nhanh chóng đổi mới trả khách, khách hàng luôn luôn yên tâm sử dụng
        sản phẩm của chúng tôi.
    </p>
    <p style="text-align: justify">
        + Giá hấp dẫn nhất – Do nhập khẩu trực tiếp, đẩy mạnh việc bán hàng online, chi
        phí đầu tư và duy trì showroom ít nên mức giá đến tay bạn là mức giá tuyệt nhất
        Chúng tôi cung cấp hình ảnh và thông số thật của các sản phẩm phụ kiện iPad cụ thể
        tại website, ngoài ra nếu chưa thỏa mãn bạn có thể gọi điện để được tư vấn trực
        tiếp trước khi mua. Bạn có thể đặt hàng online, đặt hàng qua điện thoại chúng tôi
        sẽ giao hàng tận nơi tại Tp.HCM (bất kể quận huyện) hoặc bạn có thể đến tại địa
        chỉ showroom của chúng tôi để xem hàng. Với các bạn ở xa có thể chuyển khoản qua
        ngân hàng và chúng tôi sẽ chuyển phát nhanh cho bạn, tiền chuyển khoản chỉ duy nhất
        món tiền cụ thể của từng sản phẩm, chúng tôi hoàn toàn miễn phí tiền ship hàng trên
        toàn Việt Nam.</p>
    <h1 style="color: cadetblue; margin-bottom: 20px;">
        Giấy phép kinh doanh:</h1>--%>
    <div class="WordSection1">
        <p class="MsoNormal" style='line-height: normal'>
            <b><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>Trang <a href='<asp:Literal runat="server" Text="<%$Resources:Resources, BackLink%>" />' title="phukienipadx">PhuKienIpadX.com</a></span></b></p>
        <p class="MsoNormal" style='line-height: normal'>
            <b><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>Các lý do &#273;&#7875;
                b&#7841;n ch&#7885;n mua hàng t&#7841;i <a href='<asp:Literal runat="server" Text="<%$Resources:Resources, BackLink%>" />' title="phukienipadx">PhuKienIpadX.com</a> </span></b>
        </p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>+ <b>Uy Tín bán
                hàng</b> – </span><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>
                    Chúng tôi là nhà cung c&#7845;p ph&#7909; ki&#7879;n iPad online Uy Tín nh&#7845;t,
                    t&#7845;t c&#7843; hàng hóa &#273;&#7873;u &#273;&#432;&#7907;c chúng tôi nh&#7853;p
                    tr&#7921;c ti&#7871;p nên luôn b&#7843;o &#273;&#7843;m ch&#7845;t l&#432;&#7907;ng
                    cao nh&#7845;t.</span></p>
        <p class="MsoNormal" align="center" style='text-align: center; line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>
                <img width="100%" id="Picture 6" src="/static/images/about/image001.gif"
                    alt="Banner_Nice Store.jpg"></span></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>+ <b><u><span
                style='color: blue'>B&#7843;o hành chu &#273;áo</span></u> nh&#7845;t</b> –
            </span><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>Hi&#7879;n
                nay v&#7899;i các s&#7843;n ph&#7849;m &#273;i&#7879;n t&#7917; công ngh&#7879;
                cao, chúng tôi t&#7921; hào luôn có chính sách b&#7843;o hành tuy&#7879;t &#273;&#7889;i
                1 &#273;&#7893;i 1 trong vòng 6 tháng, ki&#7875;m tra &#273;&#417;n gi&#7843;n nhanh
                chóng &#273;&#7893;i m&#7899;i tr&#7843; khách, khách hàng luôn luôn yên tâm s&#7917;
                d&#7909;ng s&#7843;n ph&#7849;m c&#7911;a chúng tôi.</span></p>
        <p class="MsoNormal" align="center" style='text-align: center; line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>
                <img width="100%" id="Picture 9" src="/static/images/about/image002.gif"
                    alt="bookcover.jpg"></span></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>+ <b>Giá h&#7845;p
                d&#7851;n nh&#7845;t</b> – Do nh&#7853;p kh&#7849;u tr&#7921;c ti&#7871;p, &#273;&#7849;y
                m&#7841;nh vi&#7879;c bán hàng online, chi phí &#273;&#7847;u t&#432; và duy trì
                showroom ít nên m&#7913;c giá &#273;&#7871;n tay b&#7841;n là m&#7913;c giá tuy&#7879;t
                nh&#7845;t</span></p>
        <p class="MsoNormal" align="center" style='text-align: center; line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>
                <img width="313" height="391" id="Picture 10" src="/static/images/about/image003.gif"
                    alt="IMG_0943.JPG"><img width="313" height="391" id="Picture 11" src="/static/images/about/image004.gif"
                        alt="IMG_0944.JPG"><img width="313" height="391" id="Picture 12" src="/static/images/about/image005.gif"
                            alt="IMG_0945.JPG"></span></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>Chúng tôi cung
                c&#7845;p hình &#7843;nh và thông s&#7889; th&#7853;t c&#7911;a các s&#7843;n ph&#7849;m
                ph&#7909; ki&#7879;n iPad c&#7909; th&#7875; t&#7841;i website, ngoài ra n&#7871;u
                ch&#432;a th&#7887;a mãn b&#7841;n có th&#7875; g&#7885;i &#273;i&#7879;n &#273;&#7875;
                &#273;&#432;&#7907;c t&#432; v&#7845;n tr&#7921;c ti&#7871;p tr&#432;&#7899;c khi
                mua. </span>
        </p>
        <p class="MsoNormal" align="center" style='text-align: center; line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>
                <img width="409" height="230" id="Picture 13" src="/static/images/about/image006.gif"
                    alt="click-buy.png"><img width="337" height="252" id="Picture 14" src="/static/images/about/image007.jpg"
                        alt="freeshiptruck.png"></span></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>B&#7841;n có th&#7875;
                &#273;&#7863;t hàng online, &#273;&#7863;t hàng qua &#273;i&#7879;n tho&#7841;i
                chúng tôi s&#7869; giao hàng t&#7853;n n&#417;i t&#7841;i Tp.HCM (b&#7845;t k&#7875;
                qu&#7853;n huy&#7879;n) ho&#7863;c b&#7841;n có th&#7875; &#273;&#7871;n t&#7841;i
                &#273;&#7883;a ch&#7881; showroom c&#7911;a chúng tôi &#273;&#7875; xem hàng.</span></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>V&#7899;i các b&#7841;n
                &#7903; xa có th&#7875; chuy&#7875;n kho&#7843;n qua ngân hàng và chúng tôi s&#7869;
                chuy&#7875;n phát nhanh cho b&#7841;n, ti&#7873;n chuy&#7875;n kho&#7843;n ch&#7881;
                duy nh&#7845;t món ti&#7873;n c&#7909; th&#7875; c&#7911;a t&#7915;ng s&#7843;n
                ph&#7849;m, chúng tôi <b>hoàn toàn mi&#7877;n phí ti&#7873;n ship hàng</b> trên
                toàn Vi&#7879;t Nam.</span></p>
        <p class="MsoNormal" align="center" style='text-align: center; line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>&nbsp;</span></p>
        <p class="MsoNormal">
            <b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif";
                color: black'>&#272;&#7882;A CH&#7880;</span></b><b><span style='font-size: 12.0pt;
                    line-height: 115%; font-family: "Verdana","sans-serif"; color: black'> LIÊN H&#7878;
                    :</span></b><b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif";
                        color: gray'><br>
                        Gi&#7901; m&#7903; c&#7917;a: </span></b><b><span style='font-size: 12.0pt; line-height: 115%;
                            font-family: "Verdana","sans-serif"'>9:00 sáng - 7:00 t&#7889;i <span style='color: #7F7F7F'>
                                (sau 7:00 t&#7889;i vui lòng g&#7885;i &#273;&#7875; &#273;&#432;&#7907;c &#273;ón
                                ti&#7871;p)</span></span></b></p>
        <p class="MsoNormal">
            <b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif"'>
                (làm vi&#7879;c t&#7845;t c&#7843; các ngày trong tu&#7847;n)</span></b></p>
        <p class="MsoNormal">
            <b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif"'>
                Gi&#7901; giao hàng: <span style='color: blue'>24/24</span> –hotline: 0903.71.20.70–
                luôn luôn online<br>
                Add TPHCM: 174/47 Thái Phiên, P.8, Q.11 </span></b>
        </p>
        <p class="MsoNormal">
            <b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif";
                color: gray'>- Tel:</span></b><b><span style='font-size: 12.0pt; line-height: 115%;
                    font-family: "Verdana","sans-serif"'> <span style='color: green'>0903.71.20.70 (Mr.&#272;&#7841;t)</span>
                    (TP HCM)</span></b><b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif"'>
                    </span></b><b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif"'>
                        <br>
                        <span style='color: gray'>Add Hà N&#7897;i:</span> A2-CN8 C&#7909;m KCN T&#7853;p
                        trung v&#7915;a và nh&#7887; - Xuân Ph&#432;&#417;ng - T&#7915; Liêm, Hà N&#7897;i
                        (n&#7857;m trong Tòa nhà Công ty CP Bia Sài Gòn-Hà N&#7897;i) </span>
            </b>
        </p>
        <p class="MsoNormal">
            <b><span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif";
                color: gray'>- Tel:</span></b><b><span style='font-size: 12.0pt; line-height: 115%;
                    font-family: "Verdana","sans-serif"'> 0979.433.682 (A.N&#259;ng)<span style='color: blue'>
                        (Hà N&#7897;i) </span></span></b>
        </p>
        <p class="MsoNormal" style='line-height: normal'>
            <i><u><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>Tài kho&#7843;n
                ngân hàng:</span></u></i><b><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>
                </span></b>
        </p>
        <p class="MsoNormal" style='line-height: normal'>
            <b><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>LIÊU M&#7840;NH
                &#272;&#7840;T</span></b></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>- Ngân hàng Vietcombank:
                0071002899511 </span>
        </p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>- Ngân hàng ACB:
                4214 9435 1338 7857 </span>
        </p>
        <p class="MsoNormal" style='line-height: normal'>
            <b><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>&#272;INH THANH
                BÌNH</span></b></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'>- Ngân hàng &#272;ông
                Á: 01.01.86.15.12</span></p>
        <p class="MsoNormal" style='line-height: normal'>
            <span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"'></span>
        </p>
        <p class="MsoNormal" style='line-height: normal'>
            <b><span style='font-size: 12.0pt; font-family: "Verdana","sans-serif"; color: black'>
                GI&#7844;Y PHÉP KINH DOANH :</span></b></p>
        <p class="MsoNormal">
            <span style='font-size: 12.0pt; line-height: 115%; font-family: "Verdana","sans-serif"'>
                <img width="100%" id="Picture 15" src="/static/images/about/image008.jpg"
                    alt="finish_576x768_3.jpg"></span></p>
    </div>
</asp:Content>
