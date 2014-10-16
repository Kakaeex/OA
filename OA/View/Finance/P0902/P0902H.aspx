<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="P0902H.aspx.cs" Inherits="OA.View.Finance.P0902.P0902H" %>

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
            <f:Form ID="FORM1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" RegionPosition="Top">
                <Rows>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="DSC1" Label="描述1" runat="server"></f:TextBox>
                            <f:TriggerBox ID="WHDCT" EnableEdit="false" Text="" Width="300px"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick">
                            </f:TriggerBox>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" Height="500px" AllowPaging="true" PageSize="30" 
                DataKeyNames="WHKCOO,WHDOCO,WHDCTO" EnableTextSelection="true" EnableCheckBoxSelect="true" 
                EnableMultiSelect="false" IsDatabasePaging="true" ExpandAllRowExpanders="true">
                <Columns>
                    <f:BoundField Width="100px" DataField="WHKCOO" DataFormatString="{0}" HeaderText="公司" Hidden="true"/>
                    <f:BoundField Width="80px" DataField="WHDOCO" DataFormatString="{0}" HeaderText="单号" />
                    <f:BoundField Width="80px" DataField="WHDCTO" DataFormatString="{0}" HeaderText="单据类型" />
                    <f:BoundField Width="200px" DataField="WHDSC1" DataFormatString="{0}" HeaderText="描述1" />
                    <f:BoundField Width="200px" DataField="WHDSC2" DataFormatString="{0}" HeaderText="描述2" />
                    <f:BoundField Width="80px" DataField="WHDCT" DataFormatString="{0}" HeaderText="类型" />
                    <f:BoundField Width="100px" DataField="WHUPRC" DataFormatString="{0}" HeaderText="单行金额" />
                    <f:BoundField Width="100px" DataField="WHAEXP" DataFormatString="{0}" HeaderText="总金额" />
                    <f:BoundField Width="100px" DataField="WHSOQS" DataFormatString="{0}" HeaderText="要求数量" Hidden="true"/>
                    <f:BoundField Width="100px" DataField="WHVR01" DataFormatString="{0}" HeaderText="备注1" Hidden="true"/>
                    <f:BoundField Width="100px" DataField="WHVR02" DataFormatString="{0}" HeaderText="备注2" Hidden="true"/>
                </Columns>
            </f:Grid>
            <f:Window ID="windows" Title="选择" Hidden="true" EnableIFrame="true" runat="server"
                EnableMaximize="false" EnableResize="false" Target="Self"
                IsModal="True" Width="750px" Height="550px">
            </f:Window>
        </Items>
    </f:Panel>
    <script type="text/javascript">
        var basePath = '<%= ResolveUrl("~/") %>';
        function closeActiveTab() {
            parent.removeActiveTab();
        }
        function AddActiveTab(url) {
            parent.newActiveTab.apply(null, ['', basePath + url, '用户修订', null, true]);
        }
    </script>
</asp:Content>
