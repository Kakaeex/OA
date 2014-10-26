<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="P0005H.aspx.cs" Inherits="OA.View.Setting.P0005.P0005H" %>

<%@ MasterType VirtualPath="~/Master/FindMaster.Master" %>
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
            <f:Form ID="FORM1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" Title="表单">
                <Rows>
                    <f:FormRow>
                        <Items>
                             <f:TextBox runat="server" ID="DRSY" Label="系统码"></f:TextBox>
                             <f:TextBox runat="server" ID="DRRT" Label="分类码"></f:TextBox>
                             <f:TextBox runat="server" ID="DRDEL1" Label="备注1"></f:TextBox>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="DRKCOO,DRLNGP,DRSY,DRRT,DRKY" AllowCellEditing="false"
                IsDatabasePaging="true" AllowPaging="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:BoundField Width="100px" DataField="DRKCOO" DataFormatString="{0}" HeaderText="公司" />
                    <f:BoundField Width="100px" DataField="DRLNGP" DataFormatString="{0}" HeaderText="语言" />
                    <f:BoundField Width="100px" DataField="DRSY" DataFormatString="{0}" HeaderText="系统码" />
                    <f:BoundField Width="100px" DataField="DRRT" DataFormatString="{0}" HeaderText="分类码" />
                    <f:BoundField Width="100px" DataField="DRKY" DataFormatString="{0}" HeaderText="定义码" />
                    <f:BoundField Width="100px" DataField="DRDEL1" DataFormatString="{0}" HeaderText="备注1" />
                    <f:BoundField Width="100px" DataField="DRDEL2" DataFormatString="{0}" HeaderText="备注2" />
                    <f:BoundField Width="100px" DataField="DRSRP1" DataFormatString="{0}" HeaderText="销售码1" />
                    <f:BoundField Width="100px" DataField="DRSRP2" DataFormatString="{0}" HeaderText="销售码2" />
                    <f:BoundField Width="100px" DataField="DRSRP3" DataFormatString="{0}" HeaderText="销售码3" />
                    <f:BoundField Width="100px" DataField="DRSRP4" DataFormatString="{0}" HeaderText="销售码4" />
                    <f:BoundField Width="100px" DataField="DRSRP5" DataFormatString="{0}" HeaderText="销售码5" />
                    <f:BoundField Width="100px" DataField="DRPRP1" DataFormatString="{0}" HeaderText="采购码1" />
                    <f:BoundField Width="100px" DataField="DRPRP2" DataFormatString="{0}" HeaderText="采购码2" />
                    <f:BoundField Width="100px" DataField="DRPRP3" DataFormatString="{0}" HeaderText="采购码3" />
                    <f:BoundField Width="100px" DataField="DRPRP4" DataFormatString="{0}" HeaderText="采购码4" />
                    <f:BoundField Width="100px" DataField="DRPRP5" DataFormatString="{0}" HeaderText="采购码5" />
                    <f:BoundField Width="100px" DataField="DRUSER" DataFormatString="{0}" HeaderText="用户" />
                    <f:BoundField Width="100px" DataField="DRPID" DataFormatString="{0}" HeaderText="程序" />
                    <f:BoundField Width="100px" DataField="DRDATE" DataFormatString="{0}" HeaderText="日期" />
                    <f:BoundField Width="100px" DataField="DRTIME" DataFormatString="{0}" HeaderText="时间" />
                </Columns>
            </f:Grid>
            <f:Window ID="windows" Title="选择" Hidden="true" EnableIFrame="true" runat="server"
                EnableMaximize="false" EnableResize="false" Target="Self"
                IsModal="True" Width="750px" Height="550px">
            </f:Window>
        </Items>
    </f:Panel>
    <script type="text/javascript">
        function closeActiveTab() {
            parent.removeActiveTab();
        }
        function newActiveTab() {
        };
    </script>
</asp:Content>
