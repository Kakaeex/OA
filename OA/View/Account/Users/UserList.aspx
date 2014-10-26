<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="OA.View.Account.Users.UserList" %>

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
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" Height="500px" AllowPaging="true" PageSize="30" DataKeyNames="UserName" EnableTextSelection="true"
                EnableCheckBoxSelect="true" EnableMultiSelect="false" IsDatabasePaging="true" ExpandAllRowExpanders="True">
                <Columns>
                    <f:BoundField Width="100px" DataField="UserName" DataFormatString="{0}" HeaderText="用户名" />
                    <f:BoundField Width="100px" DataField="ABAN8" DataFormatString="{0}" HeaderText="地址号" />
                    <f:BoundField Width="100px" DataField="ABALPH" DataFormatString="{0}" HeaderText="名称" />
                    <f:BoundField Width="100px" DataField="ABAT1" DataFormatString="{0}" HeaderText="类别" />
                    <f:BoundField Width="100px" DataField="ABMCU" DataFormatString="{0}" HeaderText="分部" />
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
