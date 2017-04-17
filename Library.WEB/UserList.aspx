<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Library.WEB.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RED LIBRARY</title>

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style type="text/css">
        body {
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <h1>LIST OF USERS</h1>
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
                        <th>User Name</th>
                        <th>Address</th>
                        <th>Phone</th>
                        <th>Operation</th>
                    </tr>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("UserName") %></td>
                                <td><%#Eval("Address") %></td>
                                <td><%#Eval("PhoneNumber") %></td>
                                <td>
                                    <a href="####?ID=<%#Eval("UserID") %>" class="btn btn-warning btn-block">Update</a>
                                </td>
                            </tr>

                        </ItemTemplate>
                    </asp:Repeater>
                </table>               
                
            </div>
        </div>
    </form>
</body>
</html>
