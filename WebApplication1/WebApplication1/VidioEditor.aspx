<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VidioEditor.aspx.cs" Inherits="WebApplication1.VidioEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
   
<head runat="server">
    <title>Video Editor</title>
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
    <div class="container">
    <br />
        <br />
        <div class="row">
            <div class="col-10 border">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
               </asp:ScriptManager>
                <asp:Timer ID="Timer2" runat="server" OnTick="Timer2_Tick" Interval="40" OnLoad="Timer2_Load"></asp:Timer>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                          <Triggers>
                            <asp:AsyncPostBackTrigger controlid="Timer2" eventname="Tick" />
                            </Triggers>
                         <ContentTemplate>
                           
                             <br />
                             <div class="mt-2 justify-content-center" style="padding-left:230px";">
                             <b style="color:black; text-decoration:none;">Frame/s : </b> <asp:Label style="color:red" ID="LabelFramePS" runat="server" Text="44"></asp:Label>
                             <b class="ml-3" style="color:black; text-decoration:none;">Total Frames : </b> <asp:Label class="mr-3" style="color:red" ID="LabelTotal" runat="server" Text="44"></asp:Label>
                             <b style="color:black; text-decoration:none;"> Current Frame No : </b> <asp:Label class="mr-3" style="color:red" ID="LabelFrameNo" runat="server" Text="44"></asp:Label>
                             <br />
                                 </div>

                             <div class="mt-2 justify-content-center" style="padding-left:250px";>
                                 <asp:Button ID="ButtonStop" runat="server" Text="Stop" class="btn mr-3" OnClick="ButtonStop_Click"  style=" width: 100px; background-color: #e71c23;color: white;border: none;" />
                                <asp:Button ID="ButtonPlayFrame" runat="server" Text="Play" class="btn ml-3" OnClick="ButtonPlayFram_Click"  style=" width: 100px; background-color: #e71c23;color: white;border: none;" />
                                <asp:Button ID="ButtonDeleteFrame" runat="server" Text="Delete Frame" class="btn ml-3" OnClick="ButtonDelete_Click"  style=" border-style: none; border-color: inherit; border-width: medium; background-color: #e71c23; color: white;" Width="116px" />
                                                          
                             </div>
                              
                             <br/>
                             <div class="row">
                                 <div class="col-8">

                                 
                                <h5 class="justify-content-center ml-2" >Frames by Frames</h5>
                                <asp:Image ID="Image1" class="m-2" runat="server" Width=100% />
                                 </div>
                                 <div class="col-4 mt-4">
                                     <asp:ListBox ID="ListBoxDelete" runat="server" Class="ml-3" style=" width: 200px; color:black;
                                        background-color:white;
                                        font-family:'Times New Roman';
                                        font-size:large;
                                        font-style:italic;"></asp:ListBox>
                                    <br />

                                      <asp:Button ID="Button3" runat="server" Text="Remove from List" class="ml-3 btn" style="
                                        width: 200px;
                                        background-color: #e71c23;
                                        color: white;
                                        border: none;
                                      " OnClick="ButtonRemoveFromList_Click" />
                                        <br />
                                     
                                      
                                    
                                     <asp:Button ID="ButtonDeletFrames" runat="server" Text="Confirm Delete" class="ml-3 mt-2 btn" style="
                                        width: 200px;
                                        background-color: #e71c23;
                                        color: white;
                                        border: none;
                                      " OnClick="ButtonDeletFrames_Click" />
                                 </div>

                                 
                               
                             </div>
                        
                            
                             <br />
                             
                            
                            <br />
                             
                             
                               
                          </ContentTemplate>
                    </asp:UpdatePanel>
                <br />
                <h5 class="justify-content-center" >Video</h5>
                <br />
                <asp:Literal ID="Literal1"  runat="server"></asp:Literal>
                <br />
            </div>
            <div class="col-2" style="text-align:center;" >
                <div class="custom-file">
                     
                <asp:FileUpload ID="FileUpload1" runat="server" Font-Bold="True" Font-Italic="True" />
                    <br />
                    <b style="color:red;"><asp:Label ID="Label3" runat="server" Text=""></asp:Label> </b>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Upload And Play" class="mt-5 btn" OnClick="Button1_Click"  style="
        width: 200px;
        padding: 5px;
        background-color: #e71c23;
        color: white;
        border: none;
      "
      type="submit" />
                    <br />

                    <br />
                    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style=" width: 200px; color:black;
            background-color:white;
            font-family:'Times New Roman';
            font-size:large;
            font-style:italic;"></asp:ListBox>
                    <br />
                    <b style="color:red;"><asp:Label ID="Labelplay" runat="server" Text=""></asp:Label></b>
               
                    <asp:Button ID="ButtonPlay" runat="server" Text="Play" class="mt-5 btn" style="
        width: 200px;
        padding: 5px;
        background-color: #e71c23;
        color: white;
        border: none;
      " OnClick="ButtonPlay_Click" />
</div>
            </div>
            
        <br />
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
