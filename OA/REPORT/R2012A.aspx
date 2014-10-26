<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="R2012A.aspx.cs" Inherits="OA.REPORT.R2012A" MasterPageFile="~/Master/BlankMaster.Master" %>


<%@ MasterType VirtualPath="~/Master/BlankMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>报销流水</h1>
    <br />
    <f:Label runat="server" ID="KCOO" Label="公司" />
    <f:Label runat="server" ID="from" Label="从" />
    <f:Label runat="server" ID="to" Label="至" />
    <asp:Table runat="server" ID="table" BorderColor="Black" BorderWidth="1px">
    </asp:Table>
</asp:Content>

