<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="P2012H.aspx.cs" Inherits="OA.View.Workflow.P2010.P2012H" %>

<%@ MasterType VirtualPath="~/Master/FindMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="findMainMaster" runat="server">
    <f:Panel ID="mainPanel" runat="server" BodyPadding="3px" ShowBorder="True" ShowHeader="false"
        Layout="Anchor" AnchorValue="100%">
        <Toolbars>
            <f:Toolbar ID="toolBar" runat="server" Position="Top">
                <Items>
                </Items>
            </f:Toolbar>
        </Toolbars>
        <Items>
            <f:Form ID="Form1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" Title="表单">
                <Rows>
                    <f:FormRow>
                        <Items>
                            <f:DropDownList ID="WFSRP1" runat="server" DataValueField="DRKY" DataTextField="DRDEL1"></f:DropDownList>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" Height="500px" AllowPaging="true" PageSize="20"
                DataKeyNames="WFDOCO,WFDCTO,WFLNID" EnableTextSelection="true" EnableCheckBoxSelect="true"
                EnableMultiSelect="false" IsDatabasePaging="true" ExpandAllRowExpanders="true">
                <Columns>
                    <f:BoundField Width="100px" DataField="WFDOCO" DataFormatString="{0}" HeaderText="工作流单号" />
                    <f:BoundField Width="100px" DataField="WFDCTO" DataFormatString="{0}" HeaderText="工作流类型" />
                    <f:BoundField Width="100px" DataField="WFLNID" DataFormatString="{0}" HeaderText="行号" />
                    <f:BoundField Width="100px" DataField="WFCDOC" DataFormatString="{0}" HeaderText="费用单号" />
                    <f:BoundField Width="100px" DataField="WFCDCT" DataFormatString="{0}" HeaderText="费用单类型" />
                    <f:BoundField Width="100px" DataField="WFDEL1" DataFormatString="{0}" HeaderText="费用单描述" />
                    <f:BoundField Width="100px" DataField="WFFDOC" DataFormatString="{0}" HeaderText="工作流程单号" />
                    <f:BoundField Width="100px" DataField="WFFDCT" DataFormatString="{0}" HeaderText="工作流程类型" />
                    <f:BoundField Width="100px" DataField="WFDSC1" DataFormatString="{0}" HeaderText="工作流程描述" />
                    <f:BoundField Width="100px" DataField="WFPRP1" DataFormatString="{0}" HeaderText="工作流程步骤" />
                    <f:BoundField Width="100px" DataField="WFDSC2" DataFormatString="{0}" HeaderText="工作流程步骤描述" />
                    <f:BoundField Width="100px" DataField="WFVR01" DataFormatString="{0}" HeaderText="审批人" />
                    <f:BoundField Width="100px" DataField="WFVR02" DataFormatString="{0}" HeaderText="审批人意见" />
                    <f:BoundField Width="100px" DataField="WFSRP1" DataFormatString="{0}" HeaderText="审批状态" />
                    <f:BoundField Width="100px" DataField="WFSRP2" DataFormatString="{0}" HeaderText="费用雇员" />
                    <f:BoundField Width="100px" DataField="WFSRP3" DataFormatString="{0}" HeaderText="制单人" />
                </Columns>
            </f:Grid>
            <f:Window ID="windows" Title="选择" Hidden="true" EnableIFrame="true" runat="server"
                EnableMaximize="false" EnableResize="false" Target="Self"
                IsModal="True" Width="750px" Height="550px">
            </f:Window>
            <f:HiddenField ID="mode" runat="server"></f:HiddenField>
            <f:HiddenField ID="lnid" runat="server"></f:HiddenField>
        </Items>
        <Items>
            <f:Label runat="server" ID="PageMessage" EncodeText="false" ShowEmptyLabel="false"></f:Label>
        </Items>
    </f:Panel>
</asp:Content>

