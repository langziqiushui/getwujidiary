<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="proccessDataList.aspx.cs" Inherits="WebClient.proccessDataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <script src="/js/1.js"></script>
    <script src="/js/2.js"></script>
    <script src="/js/3.js"></script>

    <script>
        function savedata() {
            var data = $("#data").val();
            var strtokens = data.split(/\r?\n/);
            for (var i = 0; i < strtokens.length; i++) {
                if (strtokens[i]) {
                    $.ajax({
                        url: '/proccessDataList.aspx',
                        type: 'POST',
                        async: false,
                        data: {
                            action: "getpagetoken", pagedata: strtokens[i]
                        },
                        dataType: 'text',
                        success: function (pdata) {
                            if (pdata) {
                                var token;
                                var jsondata = $.parseJSON(Decrypt(pdata));
                                for (var i = 0; i < jsondata.length; i++) {
                                    token = Encrypt("{\"token\":\"" + jsondata[i].token + "\"}");
                                    $.ajax({
                                        url: '/proccessDataList.aspx',
                                        type: 'POST',
                                        async: false,
                                        data: {
                                            action: "getdata", token: token
                                        },
                                        dataType: 'text',
                                        success: function (rtndata) {
                                            $.ajax({
                                                url: '/proccessDataList.aspx',
                                                type: 'POST',
                                                async: false,
                                                data: {
                                                    action: "savedata", jsondata: Decrypt(rtndata).replace(/<br\/>/g, "\r\n")
                                                },
                                                dataType: 'text',
                                                success: function (jdata) {
                                                    alert(jdata);
                                                }
                                            });

                                        }
                                    });
                                }
                            }
                        }
                    });
                }
            }
        }
    </script>
</head>
<body>
    <textarea rows="30" cols="180" id="data"></textarea>
    <br />
    <input type="button" value="保存" onclick="savedata()" />
</body>
</html>
