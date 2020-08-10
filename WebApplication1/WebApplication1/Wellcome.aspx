<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wellcome.aspx.cs" Inherits="WebApplication1.Wellcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wellcome</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
   
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
</head>
<body>
    <form id="form1" runat="server">
        <div class="container ">
            <br />
            <h2  style="color:black; text-align: center; font-family :'Century Gothic'">WELCOME</h2>
            <h4  style="color:black; text-align: center; font-family :'Century Gothic'">Select the function you need,Get you video ready no time.</h4>
            <br />
            <center>
             <a type="button" style="color:black; color:white; width: 40%; font-family :'Century Gothic'" href="/MergeVideo.aspx"   class="btn btn-danger mt-3  text-center">VIDEO MERGER</a><br />
                <a type="button" style="color:black; color:white; width: 40%; font-family :'Century Gothic'" href="/RepeatVideo.aspx"   class="btn btn-danger mt-3 text-center">Audio+VIDEO MERGE</a><br />
                <a  href="/DeleteFrames.aspx" type="button" style="color:black; color:white; width: 40%; font-family :'Century Gothic'"  class="btn btn-danger mt-3 text-center">Frame Cutting</a>
               
            </center>

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
