<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllRecords.aspx.cs" Inherits="Library.WEB.RentList" %>

<!DOCTYPE html>

<html lang="tr">
<head runat="server">
    <title>RED LIBRARY</title>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <meta name="viewport" content="width=device-width, initial-scale=1">

    <style type="text/css">
        body {
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">

            <h1>ALL RECORDS</h1>
            <br />

            <div class="dropdown">
                <button class="btn btn-primary dropdown-toggle" type="button" data-toggle="dropdown">
                    Operations                  
                        <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" role="menu">                    
                    <li><a href="AddNewBook.aspx">Add new book</a></li>
                    <li><a href="AddWriter.aspx">Add writer</a></li>
                    <li><a href="AddNewUser.aspx">Add new user</a></li>
                    <li><a href="BookList.aspx">All books</a></li>
                    <li><a href="UserList.aspx">All users</a></li>
                    <li><a href="WriterList.aspx">All writers</a></li>
                    <li><a href="AllRecords.aspx">All records</a></li>
                </ul>
            </div>
            <br />

            <div class="table-responsive">

                <table class="table table-bordered">
                    <tr>
                        <th>Book Name</th>
                        <th>User Name</th>
                        <th>Rent Date</th>
                        <th>Return Date</th>
                    </tr>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("BookName") %></td>
                                <td><%#Eval("UserName") %></td>
                                <td><%#Eval("RentDate") %></td>
                                <td><%#Eval("ReturnDate") %></td>                                                 
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
