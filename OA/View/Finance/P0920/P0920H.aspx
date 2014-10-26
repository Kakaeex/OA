<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="P0920H.aspx.cs" Inherits="OA.View.Finance.P0920.P0920H" %>

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
                DataKeyNames="FHDOCO,FHDCTO" EnableTextSelection="true" EnableCheckBoxSelect="true"
                EnableMultiSelect="false" IsDatabasePaging="true" ExpandAllRowExpanders="true">
                <Columns>
                    <f:BoundField Width="100px" DataField="MCKCOO" DataFormatString="{0}" HeaderText="公司" />
                    <f:BoundField Width="100px" DataField="FHMCU" DataFormatString="{0}" HeaderText="部门" />
                    <f:BoundField Width="100px" DataField="MCDC" DataFormatString="{0}" HeaderText="部门描述" />
                    <f:BoundField Width="100px" DataField="FHNAME" DataFormatString="{0}" HeaderText="项目名称" />
                    <f:BoundField Width="100px" DataField="FHDOCO" DataFormatString="{0}" HeaderText="费用项目号" />
                    <f:BoundField Width="100px" DataField="FHDCTO" DataFormatString="{0}" HeaderText="费用项目类型" />
                    <f:BoundField Width="100px" DataField="FHDSC1" DataFormatString="{0}" HeaderText="说明1" />
                    <f:BoundField Width="100px" DataField="FHDSC2" DataFormatString="{0}" HeaderText="说明2" />
                    <f:BoundField Width="100px" DataField="FHYAER" DataFormatString="{0}" HeaderText="项目年份" />
                    <f:BoundField Width="100px" DataField="FHEFTJ" DataFormatString="{0}" HeaderText="生效日期" />
                    <f:BoundField Width="100px" DataField="FHEDXJ" DataFormatString="{0}" HeaderText="失效日期" />
                    <f:BoundField Width="100px" DataField="FHUSER" DataFormatString="{0}" HeaderText="创建人" />
                    <f:BoundField Width="100px" DataField="FHDATE" DataFormatString="{0}" HeaderText="创建日期" />
                </Columns>
            </f:Grid>
            <f:Window ID="windows" Title="选择" Hidden="true" EnableIFrame="true" runat="server"
                EnableMaximize="false" EnableResize="false" Target="Self"
                IsModal="True" Width="750px" Height="550px">
            </f:Window>
        </Items>
    </f:Panel>
    <script type="text/javascript">
      <%--  var basePath = '<%= ResolveUrl("~/") %>';
        function closeActiveTab() {
            parent.removeActiveTab();
        }
        function AddActiveTab(url) {
            parent.newActiveTab.apply(null, ['', basePath + url, '用户修订', null, true]);
        }--%>
    </script>
</asp:Content>

