<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SelectionMaster.Master" AutoEventWireup="true" CodeBehind="SelectApplication.aspx.cs" Inherits="OA.View.Selection.SelectApplication" %>
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
                            <f:TextBox runat="server" ID="APDEL1" Label="说明1" Width="250px"></f:TextBox>
                            <f:TextBox runat="server" ID="APURL" Label="地址" Width="250px"></f:TextBox>
                            <f:TextBox runat="server" ID="APSRP1" Label="类别码1" Width="250px"></f:TextBox>
                        </Items>
                    </f:Panel>
                </Items>
            </f:SimpleForm>
        </Items>
        <Items>
            <f:Grid runat="server" ID="Grid1" ShowHeader="false" AllowPaging="true" PageSize="30" IsDatabasePaging="true" EnableCheckBoxSelect="true"
                 EnableMultiSelect="false" AutoScroll="true" Height="300px">
                <Columns>
                    <f:BoundField Width="100px" DataField="APID" DataFormatString="{0}" HeaderText="程序ID" ColumnID="APID" />
                    <f:BoundField Width="100px" DataField="APDEL1" DataFormatString="{0}" HeaderText="说明1" ColumnID="APDEL1" />
                    <f:BoundField Width="100px" DataField="APDEL2" DataFormatString="{0}" HeaderText="说明2" ColumnID="APDEL2" />
                    <f:BoundField Width="100px" DataField="APURL" DataFormatString="{0}" HeaderText="地址" ColumnID="APURL" />
                    <f:BoundField Width="100px" DataField="APSRP1" DataFormatString="{0}" HeaderText="类别码1" ColumnID="APSRP1" />
                </Columns>
            </f:Grid>
        </Items>
    </f:Panel>
</asp:Content>
