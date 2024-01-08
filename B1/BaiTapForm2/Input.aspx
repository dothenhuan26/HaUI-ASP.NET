<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Input.aspx.cs" Inherits="BaiTapForm2.Input" %>
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
        .btn {
            padding: 0.5rem 1rem;
            margin: 0.5rem;
            width: 120px;
            min-width: 120px;
            border-radius: 0.5rem;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="content">
            <h1 class="heading">Thông tin nhân viên</h1>
            <form id="form1" runat="server" action="Output.aspx">
                <div class="form-control">
                    <label class="col-4">
                        Mã nhân viên
                    </label>
                    <input class="col-8" type="text" name="id" value="" />
                </div>
                <div class="form-control">
                    <label class="col-4">
                        Họ tên
                    </label>
                    <input class="col-8" type="text" name="fullname" value="" />
                </div>
                <div class="form-control">
                    <label class="col-4">
                        Giới tính
                    </label>
                    <div class="d-flex col-8">
                        <label for="gender_male">
                            <input id="gender_male" type="radio" name="gender" value="male" checked />
                            Nam
                        </label>
                        <label for="gender_female">
                            <input id="gender_female" type="radio" name="gender" value="female" />
                            Nữ
                        </label>
                    </div>
                </div>
                <div class="form-control">
                    <label class="col-4">
                        Giới tính
                    </label>
                    <div class="d-flex col-8">
                        <label for="el">
                            <input id="el" type="checkbox" name="languages" value="el" />
                            Anh
                        </label>
                        <label for="fr">
                            <input id="fr" type="checkbox" name="languages" value="fr" />
                            Pháp
                        </label>
                        <label for="rus">
                            <input id="rus" type="checkbox" name="languages" value="rus" />
                            Nga
                        </label>
                    </div>
                </div>
                <div class="form-control">
                    <label class="col-4">
                        Bậc lương
                    </label>
                    <input class="col-8" type="text" name="salary_level" value="" />
                </div>
                <div class="form-control">
                    <label class="col-4">
                        Số ngày công
                    </label>
                    <input class="col-8" type="text" name="workdays" value="" />
                </div>
                <div class="form-control">
                    <label class="col-4">
                        Chức vụ
                    </label>
                    <select class="col-8 select_role" name="select_role">
                        <option value="manager">Trưởng phòng</option>
                        <option value="deputy_manager">Phó phòng</option>
                        <option value="employee">Nhân viên</option>
                    </select>
                </div>
                <div class="form-control">
                    <button type="submit" class="btn">Tính lương</button>
                    <button type="reset" class="btn">Nhập lại</button>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
