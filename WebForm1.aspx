<%@ Page Title="" Language="C#" MasterPageFile="~/WebTest.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel runat="server" ID="pnlMain">

        <ContentTemplate>
           <div><asp:TextBox ID="tbcInOut" runat="server" TextMode="MultiLine" Width="600px" Height="100px" ></asp:TextBox></div><br />
            <div>
                <asp:Button ID="btnDecode" Text="Decode" runat="server" OnClick="btnDecode_Click" /><asp:Button id="btnCopy" runat="server" OnClick="btnCopy_Click" Text="Copy" /><asp:Button runat="server" ID="btnGoToPage" Text="Go to page2" OnClick="btnGoToPage_Click" />
            </div>
    <div>
    <asp:TextBox ID="tbxInput" runat="server" AutoPostBack="true" OnTextChanged="tbxInput_TextChanged" TextMode="SingleLine" Width="488px"></asp:TextBox><br />
        </div>
    <div><br/>
        <asp:TextBox ID="tbxOutput" runat="server" AutoPostBack="true" TextMode="MultiLine" Width="600px" Height="100px" OnTextChanged="tbxOutput_TextChanged"></asp:TextBox>
    </div>
    <div>
    <asp:Button ID="btnSubmit" runat="server" Text="Decode" OnClick="btnSubmit_Click" /><asp:Button ID="btnEncode" runat="server" OnClick="btnEncode_Click" Text="Encode" /><asp:Button ID="btnGo" runat="server" Text="GO" OnClick="btnGo_Click" /><br />
        <asp:Label ID="lblResult" runat="server"></asp:Label><br />
    <asp:LinkButton ID="lnkbtnCopy" runat="server"></asp:LinkButton>
        </div>
    <div>
        <div><asp:TextBox ID="tbxDateDifference" runat="server" ></asp:TextBox></div>
        <div><asp:Label ID="lblDateDifference" runat="server"></asp:Label></div>
        <div><asp:Label ID="lblDateDifference2" runat="server"></asp:Label></div>
        <div><asp:Label ID="lblMileage" runat="server"></asp:Label></div>
        <div><asp:Label ID="lblMisc1" runat="server"></asp:Label></div>
</div>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
