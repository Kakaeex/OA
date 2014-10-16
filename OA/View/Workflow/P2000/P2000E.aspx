<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P2000E.aspx.cs" Inherits="OA.View.Workflow.P2000.P2000E" %>

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
            <f:Form ID="FORM1" runat="server" ShowBorder="True" BodyPadding="5px" ShowHeader="false" Title="表单">
                <Rows>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="WHDOCO" runat="server" Label="工作流程ID" Readonly="true">
                            </f:TextBox>
                            <f:TextBox ID="WHDCTO" runat="server" Label="工作流程类型" Readonly="true">
                            </f:TextBox>
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="WHDSC1" runat="server" Label="说明" Required="true">
                            </f:TextBox>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="WDLIND" 
                AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="false" EnableCheckBoxSelect="false"
                IsDatabasePaging="false" AllowPaging="false" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="80px" DataField="WDLIND" ColumnID="WDLIND" FieldType="Int"
                        HeaderText="行号">
                        <Editor>
                            <f:TextBox ID="WDLIND" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="300px" DataField="WDDSC1" ColumnID="WDDSC1" FieldType="String"
                        HeaderText="描述1">
                        <Editor>
                            <f:TextBox ID="WDDSC1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="WDDCT" ColumnID="WDDCT" FieldType="String"
                        HeaderText="审批模式">
                        <Editor>
                            <f:TriggerBox ID="WDDCT" EnableEdit="false" Text="" Width="300px"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick">
                            </f:TriggerBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="300px" DataField="WDVR01" ColumnID="WDVR01" FieldType="String"
                        HeaderText="审批模式说明">
                        <Editor>
                            <f:TextBox ID="WDVR01"  runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="200px" DataField="WDSRP1" ColumnID="WDSRP1" FieldType="String"
                        HeaderText="审批人">
                        <Editor>
                            <f:TriggerBox ID="WDSRP1" EnableEdit="true" Text="" Width="300px"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick">
                            </f:TriggerBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="200px" DataField="WDSRP2" ColumnID="WDSRP2" FieldType="String"
                        HeaderText="下一节点">
                        <Editor>
                             <f:TextBox ID="WDSRP2" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                </Columns>
            </f:Grid>
            <f:Window ID="windows" Title="选择" Hidden="true" EnableIFrame="true" runat="server"
                EnableMaximize="false" EnableResize="false" Target="Self"
                IsModal="True" Width="750px" Height="550px">
            </f:Window>
            <f:HiddenField ID="mode" runat="server"></f:HiddenField>
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


