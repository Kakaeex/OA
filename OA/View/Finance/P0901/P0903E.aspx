<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0903E.aspx.cs" Inherits="OA.View.Finance.P0901.P0903E" %>

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
            <f:Form ID="Form1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" Title="表单">
                <Rows>
                    <f:FormRow>
                        <Items>
                            <f:TriggerBox ID="GDMAID" EnableEdit="false" Text="" Label="管理科目" 
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true" />
                            <f:Label runat="server" ID="GDMDL01"></f:Label>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="RUKCOO,RUID" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="150px" DataField="GDFAID" ColumnID="GDFAID" FieldType="String"
                        HeaderText="财务科目">
                        <Editor>
                            <f:TriggerBox ID="GDFAID" EnableEdit="false" Text="" 
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true" />
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="200px" DataField="GDFOBJ" ColumnID="GDFOBJ" FieldType="String"
                        HeaderText="二级科目">
                        <Editor>
                            <f:TextBox ID="GDFOBJ" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="200px" DataField="GDFSUB" ColumnID="GDFSUB" FieldType="String"
                        HeaderText="三级科目">
                        <Editor>
                            <f:TextBox ID="GDFSUB" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="200px" DataField="GDFDL01" ColumnID="GDFDL01" FieldType="String"
                        HeaderText="描述">
                        <Editor>
                            <f:TextBox ID="GDFDL01" Required="true" runat="server">
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
        //function closeActiveTab() {
        //    parent.removeActiveTab();
        //}
        //function newActiveTab() {
        //};
    </script>
</asp:Content>
