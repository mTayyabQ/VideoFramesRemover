<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MergeVideo.aspx.cs" Inherits="WebApplication1.MergeVideo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    
    <title></title>
</head>
    <header>
        <!-- Image and text -->
        <nav class="navbar navbar-light bg-light">
            <a class="navbar-brand" href="#">
            <img src="/docs/4.5/assets/brand/bootstrap-solid.svg" width="30" height="30" class="d-inline-block align-top" alt="" loading="lazy">
           Video Editor
          </a>
            <div>
            <a class="navbar-brand mr-3" style="float:right;" href="/WebForm1.aspx">/Login</a>
                <a class="navbar-brand" style="float:right;" href="/Registration.aspx">Register</a>
           </div>
        </nav>
    </header>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br />
                <h2  style="color:black; text-align: center; font-family :'Century Gothic'">Video Marger Tool</h2>
            <br />
            <div class="row">
                <div class="col-8">
                    <br />
                     <asp:Label ID="LabelProcess" style="color:black; text-align: center; font-size:larger; font-family :'Century Gothic'" runat="server" Text="Video"></asp:Label>
                
                     <br />
                     <asp:Literal ID="Literal1"  runat="server"></asp:Literal>
                     <br />
                </div>
                <div class="col-4">
                    <br />
                            <div class="custom-file">
                                <br />
                                
                            <b style="color:black;"><asp:Label ID="Label2" runat="server" Text="choise Video Files:"></asp:Label> </b>
                            <asp:FileUpload ID="FileUpload1" runat="server" Font-Bold="True" Font-Italic="True" />
                            <br />
                            <b style="color:red;"><asp:Label ID="Label3" runat="server" Text=""></asp:Label> </b>
                                <br />
                            <asp:FileUpload ID="FileUpload2" runat="server" Font-Bold="True" Font-Italic="True" />
                            <br />
                            <b style="color:red;"><asp:Label ID="Label1" runat="server" Text=""></asp:Label> </b>
                             <br />
                    <asp:Button ID="Button1" runat="server" Text="Marge" class="mt-2 btn" OnClick="Button1_Click"  style="
        width: 200px;
        padding: 5px;
        background-color: #e71c23;
        color: white;
        border: none;
      "
      />
                    <br />

         <br />
                    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style=" width: 200px; color:black;
            background-color:white;
            font-family:'Times New Roman';
            font-size:large;
            font-style:italic;"></asp:ListBox>
                    <br />
                    <b style="color:red;"><asp:Label ID="Labelplay" runat="server" Text=""></asp:Label></b><br />
               <asp:Button ID="Button2" runat="server" Text="play" class="mt-2 btn" OnClick="Button2_Click"  style="
        width: 200px;
        padding: 5px;
        background-color: #e71c23;
        color: white;
        border: none;
      "
       />
                               

                    
                </div>

            </div>

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
