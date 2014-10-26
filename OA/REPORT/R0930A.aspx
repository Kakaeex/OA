<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="R0930A.aspx.cs" Inherits="OA.REPORT.R0930A" MasterPageFile="~/Master/BlankMaster.Master" %>

<%@ MasterType VirtualPath="~/Master/BlankMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>报销单</h1>
    <br />
    <table>
        <tr>
            <td>
                <f:Label ID="CHMCU" runat="server" Label="费用项目" Width="50px" />
            </td>
            <td>
                <f:Label ID="CHDSC2" runat="server" Width="80px" />
            </td>
            <td>
                <f:Label ID="CHKCOO" runat="server" Width="30px" />
            </td>
        </tr>
        <tr>
            <td>
                <f:Label ID="CHDCTO" runat="server" Label="费用类型" Width="200px" />
            </td>
            <td>
                <f:Label ID="CHDOCO" runat="server" Label="费用单号" Width="100px" />
            </td>
        </tr>
        <tr>
            <td>
                <f:Label ID="AN8" runat="server" Label="受款人" />
            </td>
            <td>
                <f:Label ID="CHSRP2" runat="server" Label="受款方式" />
            </td>
        </tr>
        <tr>
            <td>
                <f:Label ID="CHVR01" runat="server" Label="开户银行" />
            </td>
            <td>
                <f:Label ID="CHVR02" runat="server" Label="银行帐号" Width="100px" />
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <f:Label ID="CHDSC1" runat="server" Label="说明1" />
            </td>
        </tr>
    </table>
    <br />
    <asp:Table runat="server" ID="table" BorderColor="Black" BorderWidth="1px">
    </asp:Table>
    <table>
        <tr>
            <td>
                 <f:Label ID="CHUSER" runat="server" Label="制单人" Width="200px"/>
            </td>
            <td>
                 <f:Label ID="CHDATE" runat="server" Label="制单日期" Width="200px"/>
            </td>
        </tr>
    </table>
</asp:Content>
