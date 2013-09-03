<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    EnableEventValidation="false" CodeBehind="CartPage.aspx.cs" Inherits="GiaPhuc.Pages.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="/Scripts/knockout-2.2.1.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="cartDiv">
        <div class="category-caption">
            <span>GIỎ HÀNG</span></div>
        <div class="shop-cart">
            <table class="tproduct" width='100%' data-bind="visible: lines().length > 0">
                <thead>
                    <tr>
                        <th width='10%'>
                            #
                        </th>
                        <th width='45%' colspan="2">
                            Phụ kiện
                        </th>
                        <th class='price' width='10%'>
                            Giá
                        </th>
                        <th class='quantity' width='12%'>
                            Số lượng
                        </th>
                        <th class='price' width='15%'>
                            Thành tiền
                        </th>
                        <th width='8%'>
                        </th>
                    </tr>
                </thead>
                <tbody data-bind='foreach: lines'>
                    <tr>
                        <td class="name">
                            <span data-bind='text: ProductNumber'></span>
                        </td>
                        <td class="imgage">
                            <img data-bind='attr: { src: ImagePath() }' width="100" alt="phukienipadx.com" />
                        </td>
                        <td class="name">
                            <span data-bind='text: ProductName'></span>
                        </td>
                        <td class="price">
                            <span data-bind='text: formatCurrency(Price())'></span>
                        </td>
                        <td class="quantity" onmouseover="javascript:enableChange(this, true);" onmouseout="javascript:enableChange(this, false);">
                            <a href='#' data-bind='click: $parent.minusQty' class="button" style="float: left">-</a>
                            <span data-bind='text: Quantity()'></span><a href='#' data-bind='click: $parent.plusQty'
                                class="button" style="float: right">+</a>
                        </td>
                        <td class='price'>
                            <span data-bind='text: formatCurrency(subtotal())'></span>
                        </td>
                        <td class='button'>
                            <button data-bind="click: $parent.removeItem" class="button-delete">
                            </button>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="5" class='grandtotal'>
                            Tổng cộng:
                        </td>
                        <td class="price">
                            <span data-bind='text: formatCurrency(grandTotal())'></span>
                        </td>
                        <td>
                        </td>
                    </tr>
                </tfoot>
            </table>
            <div class="clear" data-bind="visible: lines().length == 0">
                Không có sản phẩm nào trong giỏ hàng</div>
            <div class="float-right">
                <a href='<asp:Literal runat="server" Text="<%$Resources:Resources, BackLink%>" />'
                    class="button">Tiếp tục mua hàng</a>
            </div>
            <div class="clear">
            </div>
        </div>
        <div class="clear">
        </div>
        <div data-bind="visible: lines().length > 0">
            <div class="category-caption">
                <span>THÔNG TIN QUÝ KHÁCH</span></div>
            <table border="0" width="100%" id="custTable">
                <tbody>
                    <tr>
                        <td colspan="2" style="color: Blue">
                            Quý khách vui lòng nhập đầy đủ thông tin dưới đây để việc giao hàng được tiến hành
                            chính xác.
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 25%">
                            Họ tên:
                        </td>
                        <td style="width: 75%">
                            <asp:TextBox ID="txtCustomerName" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCustomerName"
                                Text="Vui lòng nhập họ tên" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Số điện thoại:
                        </td>
                        <td>
                            <asp:TextBox ID="txtPhone" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtPhone"
                                Text="Vui lòng nhập số điện thoại" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Email:
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" />
                            <asp:RegularExpressionValidator ID="regexEmailValid" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                ControlToValidate="txtEmail" ErrorMessage="Vui lòng nhập đúng định dạng email. Vd: abc@nice.com"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Tỉnh thành:
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlProvince" runat="server">
                                <asp:ListItem Value="">Chọn tỉnh/ thành phố</asp:ListItem>
                                <asp:ListItem Value="58">Hồ Chí Minh</asp:ListItem>
                                <asp:ListItem Value="24">Hà Nội</asp:ListItem>
                                <asp:ListItem Value="13">Cần Thơ</asp:ListItem>
                                <asp:ListItem Value="15">Đà Nẵng</asp:ListItem>
                                <asp:ListItem Value="27">Hải Phòng</asp:ListItem>
                                <asp:ListItem Value="1">An Giang</asp:ListItem>
                                <asp:ListItem Value="2">Bà Rịa-Vũng Tàu</asp:ListItem>
                                <asp:ListItem Value="3">Bắc Giang</asp:ListItem>
                                <asp:ListItem Value="4">Bắc Kạn</asp:ListItem>
                                <asp:ListItem Value="5">Bạc Liêu</asp:ListItem>
                                <asp:ListItem Value="6">Bắc Ninh</asp:ListItem>
                                <asp:ListItem Value="7">Bến Tre</asp:ListItem>
                                <asp:ListItem Value="8">Bình Định</asp:ListItem>
                                <asp:ListItem Value="9">Bình Dương</asp:ListItem>
                                <asp:ListItem Value="10">Bình Phước</asp:ListItem>
                                <asp:ListItem Value="11">Bình Thuận</asp:ListItem>
                                <asp:ListItem Value="12">Cà Mau</asp:ListItem>
                                <asp:ListItem Value="14">Cao Bằng</asp:ListItem>
                                <asp:ListItem Value="16">Đăk Lăk</asp:ListItem>
                                <asp:ListItem Value="17">Đăk Nông</asp:ListItem>
                                <asp:ListItem Value="18">Điện Biên</asp:ListItem>
                                <asp:ListItem Value="19">Đồng Nai</asp:ListItem>
                                <asp:ListItem Value="20">Đồng Tháp</asp:ListItem>
                                <asp:ListItem Value="21">Gia Lai</asp:ListItem>
                                <asp:ListItem Value="22">Hà Giang</asp:ListItem>
                                <asp:ListItem Value="23">Hà Nam</asp:ListItem>
                                <asp:ListItem Value="25">Hà Tĩnh</asp:ListItem>
                                <asp:ListItem Value="26">Hải Dương</asp:ListItem>
                                <asp:ListItem Value="28">Hậu Giang</asp:ListItem>
                                <asp:ListItem Value="29">Hoà Bình</asp:ListItem>
                                <asp:ListItem Value="30">Hưng Yên</asp:ListItem>
                                <asp:ListItem Value="31">Khánh Hòa</asp:ListItem>
                                <asp:ListItem Value="32">Kiên Giang</asp:ListItem>
                                <asp:ListItem Value="33">Kon Tum</asp:ListItem>
                                <asp:ListItem Value="34">Lai Châu</asp:ListItem>
                                <asp:ListItem Value="35">Lâm Đồng</asp:ListItem>
                                <asp:ListItem Value="36">Lạng Sơn</asp:ListItem>
                                <asp:ListItem Value="37">Lào Cai</asp:ListItem>
                                <asp:ListItem Value="38">Long An</asp:ListItem>
                                <asp:ListItem Value="39">Nam Định</asp:ListItem>
                                <asp:ListItem Value="40">Nghệ An</asp:ListItem>
                                <asp:ListItem Value="41">Ninh Bình</asp:ListItem>
                                <asp:ListItem Value="42">Ninh Thuận</asp:ListItem>
                                <asp:ListItem Value="43">Phú Thọ</asp:ListItem>
                                <asp:ListItem Value="44">Phú Yên</asp:ListItem>
                                <asp:ListItem Value="45">Quảng Bình</asp:ListItem>
                                <asp:ListItem Value="46">Quảng Nam</asp:ListItem>
                                <asp:ListItem Value="47">Quảng Ngãi</asp:ListItem>
                                <asp:ListItem Value="48">Quảng Ninh</asp:ListItem>
                                <asp:ListItem Value="49">Quảng Trị</asp:ListItem>
                                <asp:ListItem Value="50">Sóc Trăng</asp:ListItem>
                                <asp:ListItem Value="51">Sơn La</asp:ListItem>
                                <asp:ListItem Value="52">Tây Ninh</asp:ListItem>
                                <asp:ListItem Value="53">Thái Bình</asp:ListItem>
                                <asp:ListItem Value="54">Thái Nguyên</asp:ListItem>
                                <asp:ListItem Value="55">Thanh Hóa</asp:ListItem>
                                <asp:ListItem Value="56">Thừa Thiên-Huế</asp:ListItem>
                                <asp:ListItem Value="57">Tiền Giang</asp:ListItem>
                                <asp:ListItem Value="59">Trà Vinh</asp:ListItem>
                                <asp:ListItem Value="60">Tuyên Quang</asp:ListItem>
                                <asp:ListItem Value="61">Vĩnh Long</asp:ListItem>
                                <asp:ListItem Value="62">Vĩnh Phúc</asp:ListItem>
                                <asp:ListItem Value="63">Yên Bái</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Địa chỉ giao hàng:
                        </td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="1" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Phương thức thanh toán:
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPaidMethod" runat="server">
                                <asp:ListItem Value="0">Tiền mặt</asp:ListItem>
                                <asp:ListItem Value="1">Chuyển khoản</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Phương thức giao hàng:
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlShipMethod" runat="server">
                                <asp:ListItem Value="0">Giao tận nơi</asp:ListItem>
                                <asp:ListItem Value="1">Gửi qua bưu điện</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Ghi chú:
                        </td>
                        <td>
                            <asp:TextBox ID="txtMemo" runat="server" TextMode="MultiLine" Rows="6" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="color: Green">
                            <asp:Literal ID="litResult" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="sendButton" runat="server" Text="ĐẶT HÀNG" CssClass="button" OnClick="sendButton_Click"
                                UseSubmitBehavior="false" />
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <script type="text/javascript">
        function enableChange(tag, b) {
            if (b) {
                $(tag).find('a').show();
            }
            else {
                $(tag).find('a').hide();
            }
        }

        function changeQty(line, up) {
            if ((!up && line.Quantity() > 1) || (up && line.Quantity() < 999)) {
                var param = { productId: line.ProductNumber(), qty: line.Quantity(), plus: up };

                $.ajax({
                    type: "POST",
                    url: "/CMS.asmx/MinusPlusQty",
                    data: JSON.stringify(param),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: false,
                    success: function (data) {
                        if (up) {
                            var qty = line.Quantity() + 1;
                            line.Quantity(qty);
                        }
                        else {
                            var qty = line.Quantity() - 1;
                            line.Quantity(qty);
                        }
                    }
                });
            }
        }

        function formatCurrency(value) {
            return value.toFixed(0) + "₫";
        }

        $(document).ready(function () {

            var ShopCart = function () {
                var self = this;
                self.ProductId = ko.observable(0);
                self.ProductNumber = ko.observable('#');
                self.ImagePath = ko.observable('/static/images/logo horizontal.gif');
                self.ProductName = ko.observable('phukienipadx.com');
                self.Price = ko.observable(9999);
                self.Quantity = ko.observable(1);
                self.subtotal = ko.computed(function () {
                    return self.Price() * parseInt("0" + self.Quantity(), 10);
                });
            };

            var Cart = function () {
                // Stores an array of lines, and from these, can work out the grandTotal
                var self = this;

                var url = "/CMS.asmx/GetCart";
                $.ajax({
                    type: "POST",
                    url: url,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: false,
                    success: function (data) {
                        // Now use this data to update your view models, 
                        // and Knockout will update your UI automatically 
                        self.lines = ko.observableArray([]); // Put one line in by default

                        $.each(data.d, function () {
                            var item = new ShopCart();
                            item.ProductId(this.ProductId);
                            item.ProductNumber(this.ProductNumber);
                            item.ImagePath(this.ImagePath);
                            item.ProductName(this.ProductName);
                            item.Price(this.Price);
                            item.Quantity(this.Quantity);
                            self.lines.push(item);
                        });
                    }
                });

                self.grandTotal = ko.computed(function () {
                    var total = 0;
                    $.each(self.lines(), function () { total += this.subtotal(); });
                    return total;
                });
                // Operations
                self.removeItem = function (line) {
                    $.ajax({
                        type: "POST",
                        url: "/CMS.asmx/RemoveItem",
                        data: JSON.stringify({ productId: line.ProductId() }),
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: false,
                        success: function (data) {
                            if (data.d) {
                                self.lines.remove(line);
                            }
                        }
                    });
                };
                self.minusQty = function (line) {
                    changeQty(line, false);
                };
                self.plusQty = function (line) {
                    changeQty(line, true);
                };
                self.save = function () {
                    var dataToSave = $.map(self.lines(), function (line) {
                        return line.product() ? {
                            productName: line.ProductName(),
                            quantity: line.Quantity()
                        } : undefined;
                    });
                    alert("Could now send this to server: " + JSON.stringify(dataToSave));
                };
            };

            ko.applyBindings(new Cart());
        });
    </script>
</asp:Content>
