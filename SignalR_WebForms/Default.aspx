<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SignalR_WebForms.Status" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Walk Saver</title>
    <style>
        .stall {
            width: 100px;
            height: 100px;
            /* display: none;  hidden by default */
        }

        .stall_container {
            margin: 20px;
        }

    </style>
</head>
<body>
    
    <h1>Walk Saver</h1>
    
    <div class="stall_container">
        <h3>8th Floor big</h3>
        <div id="stall_8_1" class="stall"></div>
    </div> 
    <div class="stall_container">
        <h3>8th Floor small</h3>
        <div id="stall_8_2" class="stall"></div>
    </div>
     <div class="stall_container">
        <h3>15th Floor</h3>
        <div id="stall_15_1" class="stall"></div>
    </div>
    
    

    <script src="Scripts/jquery-1.7.1.js"></script>
    <script src="Scripts/jquery-ui-1.8.20.js"></script>
    <script src="Scripts/jquery.signalR-1.0.1.js"></script>
    <script src="/signalr/hubs"></script>
    <script src="ChangeState.js"></script>
    
</body>
</html>
