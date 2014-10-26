<%@ Page Title="" Language="C#" MasterPageFile="~/Master/SelectionMaster.Master" AutoEventWireup="true" CodeBehind="SelectAID.aspx.cs" Inherits="OA.View.Selection.SelectAID" %>

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
                            <f:TextBox runat="server" ID="GMDL01" Label="说明1" Width="250px"></f:TextBox>
                        </Items>
                    </f:Panel>
                </Items>
            </f:SimpleForm>
        </Items>
        <Items>
            <f:Grid runat="server" ID="Grid1" ShowHeader="false" AllowPaging="true" PageSize="30" IsDatabasePaging="true" EnableCheckBoxSelect="true"
                EnableMultiSelect="false" AutoScroll="true" Height="300px">
                <Columns>
                    <f:BoundField Width="100px" DataField="GBAID" DataFormatString="{0}" HeaderText="科目" ColumnID="GBAID" />
                    <f:BoundField Width="100px" DataField="GMDL01" DataFormatString="{0}" HeaderText="说明1" ColumnID="GMDL01" />
                    <f:BoundField Width="100px" DataField="GMDL02" DataFormatString="{0}" HeaderText="说明2" ColumnID="GMDL02" />
                    <f:BoundField Width="100px" DataField="GBAPYN" DataFormatString="{0}" HeaderText="可用" ColumnID="GBAPYN" />
                </Columns>
            </f:Grid>
            <f:HiddenField ID="mode" runat="server"></f:HiddenField>
        </Items>
    </f:Panel>
</asp:Content>
