<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="phudieuhungthinh.errors._404" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="refresh" content="5; url=http://phukienipadx.com" />
    <title></title>
    <script type="text/javascript">
        var count = 5;

        var counter = setInterval(timer, 1000); //1000 will  run it every 1 second

        function timer() {
            count = count - 1;
            if (count <= 0) {
                clearInterval(counter);
                return;
            }

            document.getElementById("timer").innerHTML = count + ""; // watch for spelling
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Không tìm thấy trang này!
    </div>
    <div>
        Trình duyệt sẽ chuyển hướng về trang phukienipadx.com trong <span id="timer">5</span>
        giây!
    </div>
    </form>
</body>
</html>
