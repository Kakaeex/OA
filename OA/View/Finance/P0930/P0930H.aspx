<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="P0930H.aspx.cs" Inherits="OA.View.Finance.P0930.P0930H" %>

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
            <f:Form ID="FORM1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" RegionPosition="Top">
                <Rows>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="CHDSC1" Label="说明1" runat="server"></f:TextBox>
                            <f:TriggerBox ID="CHDCTO" EnableEdit="false" Text="" Width="300px"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick">
                            </f:TriggerBox>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" Height="500px" AllowPaging="true" PageSize="30"
                DataKeyNames="CHDOCO,CHDCTO" EnableTextSelection="true" EnableCheckBoxSelect="true"
                EnableMultiSelect="false" IsDatabasePaging="true" ExpandAllRowExpanders="true">
                <Columns>
                    <f:BoundField Width="100px" DataField="CHDOCO" DataFormatString="{0}" HeaderText="费用单号" />
                    <f:BoundField Width="100px" DataField="CHDCTO" DataFormatString="{0}" HeaderText="费用类型" />
                    <f:BoundField Width="100px" DataField="CHDOC" DataFormatString="{0}" HeaderText="工作流程" />
                    <f:BoundField Width="100px" DataField="CHDCT" DataFormatString="{0}" HeaderText="工作流程类型" />
                    <f:BoundField Width="100px" DataField="CHDSC1" DataFormatString="{0}" HeaderText="说明1" />
                    <f:BoundField Width="100px" DataField="CHDSC2" DataFormatString="{0}" HeaderText="说明2" />
                    <f:BoundField Width="100px" DataField="CHMCU" DataFormatString="{0}" HeaderText="费用项目" />
                    <f:BoundField Width="100px" DataField="CHTRDJ" DataFormatString="{0}" HeaderText="日期" />
                    <f:BoundField Width="100px" DataField="CHUSER" DataFormatString="{0}" HeaderText="用户号" />
                </Columns>
            </f:Grid>
            <f:Window ID="windows" Title="选择" Hidden="true" EnableIFrame="true" runat="server"
                EnableMaximize="false" EnableResize="false" Target="Self"
                IsModal="True" Width="750px" Height="550px">
            </f:Window>
        </Items>
        <Items>
            <f:Label runat="server" ID="PageMessage" EncodeText="false" ShowEmptyLabel="false"></f:Label>
        </Items>
    </f:Panel>
    <script type="text/javascript">

    </script>
</asp:Content>
