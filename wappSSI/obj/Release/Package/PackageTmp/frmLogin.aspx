<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="wappSSI.frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <!--<link href="Template.css" rel="stylesheet" type="text/css" />-->
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 201px;
        }
        .style3
        {
            width: 93px;
        }
        .style4
        {
            height: 201px;
            width: 93px;
        }
    </style>
</head>
<body style="height: 373px">
    <form id="form1" runat="server">
    <!--<asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false">
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification"
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Account Information</legend>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                             CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required."
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                             CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required."
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:CheckBox ID="RememberMe" runat="server"/>
                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Keep me logged in</asp:Label>
                    </p>
                </fieldset>
                <p class="submitButton">
                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="LoginUserValidationGroup"/>
                </p>
            </div>
        </LayoutTemplate>
    </asp:Login>-->
        <div>    
            <table class="style1" style="width: 100%; height: 100%;">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                    </td>
                    <td class="style4">
                        <asp:Login ID="Login" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
                            BorderStyle="Solid" BorderWidth="1px" 
                            FailureText="Falha no login. Por favor, tente novamente." Font-Names="Calibri" 
                            Font-Size="Large" onauthenticate="Login_Authenticate" PasswordLabelText="Senha:" 
                            PasswordRequiredErrorMessage="Informar a senha." RememberMeText="Lembrar" 
                            TitleText="SSI" UserNameLabelText="Usuário:" 
                            UserNameRequiredErrorMessage="Informar usuário." Width="47%" 
                            BorderPadding="4" ForeColor="#666666" LoginButtonText="Entrar" 
                            Font-Bold="False" Font-Overline="False" Font-Strikeout="False" 
                            Height="91px" TextLayout="TextOnTop" EnableTheming="True">
                            <CheckBoxStyle Font-Size="Small" />
                            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                            <LabelStyle Font-Size="Medium" />
                            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                            <TextBoxStyle Font-Size="Small" />
                            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="#FFFFFF" 
                                Font-Size="XX-Large" Font-Italic="True" Font-Names="Arial Rounded MT Bold" 
                                Font-Overline="False" Font-Underline="False" />
                            <ValidatorTextStyle BackColor="White" Font-Bold="True" Font-Italic="True" 
                                Font-Size="Medium" />
                        </asp:Login>
                    </td>
                    <td class="style2">
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>    
        </div>
    </form>
</body>
</html>
