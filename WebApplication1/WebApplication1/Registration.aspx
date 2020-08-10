<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication1.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    
    <title>Registration</title>
</head>
    <header>
        <!-- Image and text -->
        <nav class="navbar navbar-light bg-light">
            <a class="navbar-brand" href="#">
            <img src="/docs/4.5/assets/brand/bootstrap-solid.svg" width="30" height="30" class="d-inline-block align-top" alt="" loading="lazy">
           Video Editor
          </a>
            <div>
            <a class="navbar-brand mr-3" style="float:right;" href="/WebForm1.aspx">/Login</a><a class="navbar-brand" style="float:right;" href="/Registration.aspx">Register</a>
           </div>
        </nav>
    </header>
<body>
    <form id="form1" class="text-center m-5" runat="server">
    <div>
        
    <h3 class="mb-1">Welcome</h3>
    
    <a href="/WebForm1.aspx" style="text-decoration: none;"><b>Login</b></a
    ><br />
    <label class="mt-5" style="color: #0a79df;"
      >Following information is for,to give to better application
      experiance.</label
    ><br />
     <asp:TextBox ID="TextBoxFirstName" runat="server"  type="text"
      style="padding: 5px; width: 250px;"
      placeholder="First name"
      name="Firstname"
      value=""></asp:TextBox>
    <asp:TextBox ID="TextBoxLastName" runat="server" type="text"
      class=""
      style="padding: 5px; width: 250px;"
      placeholder="Last name"
      name="Lastname"
      value=""></asp:TextBox>
    <br /><asp:TextBox ID="TextBoxEmail" runat="server" type="text"
      class="mt-3"
      style="padding: 5px; width: 500px;"
      placeholder="Email"
      name="Email"
      value=""></asp:TextBox><br />
    
         <asp:TextBox ID="TextBoxPassword" runat="server" type="password"
      class="mt-3"
      style="padding: 5px; width: 250px;"
      placeholder="Password"
      value=""
      name="password"></asp:TextBox>

    <asp:TextBox ID="TextBoxConfiPassword" runat="server" type="password"
      class="mt-3"
      style="padding: 5px; width: 250px;"
      placeholder="Confirm password"
      value=""
      name="passwordConfirm"></asp:TextBox><br />
  
        <asp:TextBox ID="TextBoxAge" runat="server" type="text"
      class="mt-3"
      style="padding: 5px; width: 250px;"
      placeholder="Age"
      value=""
      name="age"></asp:TextBox>

    <asp:TextBox ID="TextBoxNumber" runat="server" type="text"
      class="mt-3"
      style="padding: 5px; width: 250px;"
      placeholder="Mobile"
      value=""
      name="mobile"></asp:TextBox><br />
    



    
    <asp:DropDownList ID="DropDownListGender" class="mt-3"
      style="color: gray; padding: 5px; width: 210px;"
      
      name="sex" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
    
    <asp:DropDownList ID="DropDownListOccupation" class="mt-3"
      style="color: gray; padding: 5px; width: 210px;"
      
      name="sex" runat="server">
        <asp:ListItem>Student</asp:ListItem>
        <asp:ListItem>Job</asp:ListItem>
        </asp:DropDownList>
    <br />
    <b style="color: red;"><asp:Label ID="LabelErrorr" runat="server" Text=""></asp:Label></b>
    <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Create account" class="mt-5 btn"
      style="
        width: 200px;
        padding: 5px;
        background-color: #e71c23;
        color: white;
        border: none;
      "
      type="submit" OnClick="ButtonSubmit_Click"/>
  
    </div>
    </form>
</body>
     <footer>
        
    <div class="pt-5 pb-5 mt-5" style="border-bottom: 5px solid; border-color: #43BE31; overflow: hidden; background-color: #f8f9fa; color: black;">
       
        <br>
        <div class="container">
            <div class="row">
                <div class="col-sm">
                    <a style="text-decoration: none; color: black;" href="home.html"><b style="margin-left: 39px;">VideoEditor</b></a>
                    <ul>
                        <li><a style="text-decoration: none;  color: black;" href="#">About us</a></li>
                     
                        <li><a style="text-decoration: none; color: black;" href="#">Contact us</a></li>
                        <li><a style="text-decoration: none; color: black;" href="#">Terms and conditions</a></li>

                    </ul>
                </div>
               
                <div class="col-sm">
                    <b style="margin-left: 39px;">CONTACT INFORMATION</b>
                    <ul>
                        <li>
                            <b>Phone</b>
                        </li>
                        <li>
                            <label>0330-5032323</label>
                        </li>
                        <li>
                            <b>Email</b>
                        </li>
                        <li>
                            <label>me@gmail.com</label>
                        </li>
                       
                       
                    </ul>

                </div>
            </div>
        </div>
        <div class="container">
            <hr style="border-top: 1px solid white;"> Copyright &copy;
            <script>
                document.write(new Date().getFullYear());
            </script><a href="" style="text-decoration: none;"> videoEditor.com</a>.All rights reserved.</label>
            
        </div>
    </div>
    </footer>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
   
</html>
