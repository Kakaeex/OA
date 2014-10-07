﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SelectionMaster.Master" AutoEventWireup="true" CodeBehind="SelectAN8.aspx.cs" Inherits="OA.View.Selection.SelectAN8" %>

<%@ MasterType VirtualPath="~/Master/SelectionMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="findMainMaster" runat="server">
    <f:Panel ID="mainPanel" runat="server" BodyPadding="3px" ShowBorder="True" ShowHeader="false"
        Layout="Anchor" AnchorValue="100%">
        <Items>
            <f:Label runat="server" ID="PageMessage" EncodeText="false" ShowEmptyLabel="false"></f:Label>
        </Items>
        <Toolbars>
            <f:Toolbar ID="toolBar" runat="server" Position="Top">
                <Items>
                </Items>
            </f:Toolbar>
        </Toolbars>
        <Items>
            <f:SimpleForm ID="SimpleForm1" BodyPadding="5px" Title="" runat="server" ShowHeader="false">
                <Items>
                    <f:Panel ID="Panel1" ShowHeader="false" ShowBorder="false" Layout="Column" 
                        runat="server">
                        <Items>
                            <f:TextBox runat="server" ID="ABALPH" Label="说明1" Width="250px"></f:TextBox>
                        </Items>
                    </f:Panel>
                </Items>
            </f:SimpleForm>
        </Items>
        <Items>
            <f:Grid runat="server" ID="Grid1" ShowHeader="false" AllowPaging="true" PageSize="30" IsDatabasePaging="true" EnableCheckBoxSelect="true" 
                EnableMultiSelect="false" AutoScroll="true" Height="300px">
                <Columns>
                    <f:BoundField Width="100px" DataField="ABAN8" DataFormatString="{0}" HeaderText="值" ColumnID="DRKY" />
                    <f:BoundField Width="100px" DataField="ABALPH" DataFormatString="{0}" HeaderText="说明1" ColumnID="DRDEL1" />
                </Columns>
            </f:Grid>
        </Items>
    </f:Panel>
</asp:Content>
