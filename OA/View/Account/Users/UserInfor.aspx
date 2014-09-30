<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="UserInfor.aspx.cs" Inherits="OA.View.Account.Users.UserInfor" %>

<%@ MasterType VirtualPath="~/Master/EditMaster.Master" %>

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
            <f:Form ID="form1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" Title="表单">
                <Rows>
                    <f:FormRow>
                        <Items>
                            <f:TriggerBox ID="ABAN8" EnableEdit="false" Text="" Width="300px" Label="用户"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" OnBlur="ABAN8_Blur">
                            </f:TriggerBox>
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox runat="server" ID="ABALPH" Label="名称" Width="300px" Readonly="true"></f:TextBox>
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox runat="server" ID="NewPassword1" TextMode="Password" Label="新密码" Width="300px"></f:TextBox>
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox runat="server" ID="NewPassword2" TextMode="Password" Label="再一次密码" Width="300px"></f:TextBox>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="AUMCU" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="true"
                IsDatabasePaging="true" AllowPaging="true" PageSize="30" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="AUMCU" ColumnID="AUMCU" FieldType="String"
                        HeaderText="部门">
                        <Editor>
                            <f:TextBox ID="AUMCU" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUDEL1" ColumnID="AUDEL1" FieldType="String"
                        HeaderText="描述1">
                        <Editor>
                            <f:TextBox ID="AUDEL1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUDEL2" ColumnID="AUDEL2" FieldType="String"
                        HeaderText="描述2">
                        <Editor>
                            <f:TextBox ID="AUDEL2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUSRP1" ColumnID="AUSRP1" FieldType="String"
                        HeaderText="销售码1">
                        <Editor>
                            <f:TextBox ID="AUSRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
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
