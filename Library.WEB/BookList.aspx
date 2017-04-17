<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="Library.WEB.BookList" %>

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

            <h1>LIST OF BOOKS</h1>
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
                        <th>Book Subject</th>
                        <th>Writer Name</th>
                        <th>Page</th>
                        <th>Rental State</th>
                        <th>Options</th>
                    </tr>

                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr class="<%#Eval("IsRented").ToString() == "True" ? "danger" : "success"%>">
                                <td><%#Eval("BookName") %></td>
                                <td><%#Eval("BookSubject") %></td>
                                <td><%#Eval("WriterName") %></td>
                                <td><%#Eval("PageCount") %></td>
                                <td><%#Eval("IsRented").ToString() == "True" ? "Alınamaz" : "Alınabilir" %></td>
                                <td>
                                    <a href="RentBook.aspx?ID=<%#Eval("BookID") %>" class="btn btn-info btn-block">Rent</a>
                                    <%--<a class="btn btn-warning" href="UpdateBook.aspx?ID=<%#Eval("BookID") %>">Update</a>
                                    <a class="btn btn-danger" href="BookList.aspx?ID=<%#Eval("BookID") %>">Delete</a>--%>
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
