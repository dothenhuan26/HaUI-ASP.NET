<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Output.aspx.cs" Inherits="BaiTapForm2.Output" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
        }

        html {
        }


        .d-flex {
            display: flex;
        }

        .container {
            display: flex;
            margin: auto;
            flex-direction: column;
            height: 100vh;
        }


        .form-control {
            display: flex;
            align-items: center;
            align-content: center;
            margin: 0.5rem;
        }

        .col-4 {
            flex-basis: 30%;
        }

        .col-8 {
            flex-basis: 70%;
        }

        .content {
            width: 400px;
            margin: auto;
            border: 1px solid #000;
            border-radius: 1rem;
            padding: 1.5rem;
        }

        label {
            align-self: center;
        }

        input {
            align-self: center;
            margin: 0.5rem;
            padding: 0.5rem;
        }

        select {
            padding: 0.5rem;
        }

        .select_role {
            max-width: 50%;
        }

        .heading {
            color: blue;
            text-align: center;
        }

        .mt-3 {
            margin-top: 1rem;
        }

        .btn {
            padding: 0.5rem 1rem;
            margin: 0.5rem;
            width: 120px;
            min-width: 120px;
            border-radius: 0.5rem;
        }

        table {
            border-collapse: collapse;
        }

            table th {
                border: 1px solid #000;
                text-align: left;
                margin: 0.5rem;
                width: 30%;
            }

            table tr {
                border: 1px solid #000;
                text-align: left;
                margin: 0.5rem;
            }

            table td {
                border: 1px solid #000;
                text-align: left;
                margin: 0.5rem;
                width: 70%;
            }
    </style>
</head>
<body>
    <div class="container">

        <%

            string id = Request.Form["id"];
            string fullname = Request.Form["fullname"];
            string gender = Request.Form["gender"];
            string languages = "";
            string salary_level = Request.Form["salary_level"];
            string workdays = Request.Form["workdays"];
            string select_role = Request.Form["select_role"];

            string[] _languages = Request.Form["languages"].Split(',');
            if (_languages.Contains("el")) languages += "Anh ";
            if (_languages.Contains("fr")) languages += "Pháp ";
            if (_languages.Contains("rus")) languages += "Nga ";



            long basic_salary = 800000;
            int _salary_level = int.Parse(salary_level);
            int _workdays = int.Parse(workdays);
            int bonus = 0;
            if (_workdays > 25) bonus = (_workdays - 25) * 200000;
            int allowance = 0;
            if (select_role.Equals("manager")) allowance = 500000;
            else if (select_role.Equals("employee")) allowance = 100000;
            else if (select_role.Equals("deputy_manager")) allowance = 300000;
            long salary = basic_salary * _salary_level + bonus + allowance;
        %>


        <div class="content">
            <h1 class="heading">Tính lương nhân viên</h1>
            <table class="mt-3">
                <tr>
                    <th>Mã nhân viên:</th>
                    <td><%= id%></td>
                </tr>
                <tr>
                    <th>Họ tên:</th>
                    <td><%= fullname%></td>
                </tr>
                <tr>
                    <th>Giới tính:</th>
                    <td><%= gender.Equals("male")?"Nam":"Nữ" %></td>
                </tr>
                <tr>
                    <th>Ngoại ngữ:</th>
                    <td><%= languages %></td>
                </tr>
                <tr>
                    <th>Bậc lương:</th>
                    <td><%= salary_level %></td>
                </tr>
                <tr>
                    <th>Lương cơ bản:</th>
                    <td><%= basic_salary %></td>
                </tr>
                <tr>
                    <th>Ngày công:</th>
                    <td><%= workdays %></td>
                </tr>
                <tr>
                    <th>Chức vụ:</th>
                    <td><%= select_role %></td>
                </tr>
                <tr>
                    <th>Phụ cấp:</th>
                    <td><%=allowance %></td>
                </tr>
                <tr>
                    <th>Thưởng:</th>
                    <td><%= bonus %></td>
                </tr>
                <tr>
                    <th>Tổng lương:</th>
                    <td><%= salary %></td>
                </tr>
            </table>

        </div>


    </div>
</body>
</html>
