<%@ Page Title="" Language="C#" MasterPageFile="~/Master/BlankMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OA.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <f:Panel ID="mainPanel" runat="server" BodyPadding="3px" ShowBorder="True" ShowHeader="false"
        Layout="Anchor" AnchorValue="100%">
        <Items>
            <f:Label runat="server" ID="PageMessage" EncodeText="false" ShowEmptyLabel="false"></f:Label>
        </Items>
        <Items>
            <f:Form ID="FORM1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" Title="表单">
                <Rows>
                    <f:FormRow>
                        <Items>
                            <f:TextBox runat="server" ID="UserID" Label="用户名" Width="300px" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox runat="server" ID="Pssd" TextMode="Password" Label="密码" Width="300px" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:DropDownList runat="server" ID="roles" DataValueField="RAID" Label="角色" DataTextField="RADEL1" Width="300px" Hidden="true">
                            </f:DropDownList>
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:Button runat="server" ID="login" Text="登录" OnClick="login_Click"></f:Button>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
    </f:Panel>
</asp:Content>
