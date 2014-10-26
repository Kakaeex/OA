<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0005E.aspx.cs" Inherits="OA.View.Setting.P0005.P0005E" %>

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
                            <f:TextBox runat="server" ID="DRSY" Label="系统码"></f:TextBox>
                            <f:TextBox runat="server" ID="DRRT" Label="分类码"></f:TextBox>
                            <f:TextBox runat="server" ID="DRDEL1" Label="备注1"></f:TextBox>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="DRSY,DRRT,DRKY" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false"  EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="80px" DataField="DRSY" ColumnID="DRSY" FieldType="String"
                        HeaderText="系统码">
                        <Editor>
                            <f:TextBox ID="TextBox1" Required="true" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRRT" ColumnID="DRRT" FieldType="String"
                        HeaderText="分类码">
                        <Editor>
                            <f:TextBox ID="TextBox2" Required="true" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRKY" ColumnID="DRKY" FieldType="String"
                        HeaderText="定义码">
                        <Editor>
                            <f:TextBox ID="DRKY" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="300px" DataField="DRDEL1" ColumnID="DRDEL1" FieldType="String"
                        HeaderText="备注1">
                        <Editor>
                            <f:TextBox ID="TextBox3" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="300px" DataField="DRDEL2" ColumnID="DRDEL2" FieldType="String"
                        HeaderText="备注2">
                        <Editor>
                            <f:TextBox ID="DRDEL2" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRSRP1" ColumnID="DRSRP1" FieldType="String"
                        HeaderText="销售码1">
                        <Editor>
                            <f:TextBox ID="DRSRP1" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRSRP2" ColumnID="DRSRP2" FieldType="String"
                        HeaderText="销售码2">
                        <Editor>
                            <f:TextBox ID="DRSRP2" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRSRP3" ColumnID="DRSRP3" FieldType="String"
                        HeaderText="销售码3">
                        <Editor>
                            <f:TextBox ID="DRSRP3" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRSRP4" ColumnID="DRSRP4" FieldType="String"
                        HeaderText="销售码4">
                        <Editor>
                            <f:TextBox ID="DRSRP4" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRSRP5" ColumnID="DRSRP5" FieldType="String"
                        HeaderText="销售码5">
                        <Editor>
                            <f:TextBox ID="DRSRP5" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRPRP1" ColumnID="DRPRP1" FieldType="Int"
                        HeaderText="采购码1">
                        <Editor>
                            <f:TextBox ID="DRPRP1" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRPRP2" ColumnID="DRPRP2" FieldType="Int"
                        HeaderText="采购码2">
                        <Editor>
                            <f:TextBox ID="DRPRP2" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRPRP3" ColumnID="DRPRP3" FieldType="Int"
                        HeaderText="采购码3">
                        <Editor>
                            <f:TextBox ID="DRPRP3" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRPRP4" ColumnID="DRPRP4" FieldType="Int"
                        HeaderText="采购码4">
                        <Editor>
                            <f:TextBox ID="DRPRP4" Required="false" runat="server" EmptyText="">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="DRPRP5" ColumnID="DRPRP5" FieldType="Int"
                        HeaderText="采购码5">
                        <Editor>
                            <f:TextBox ID="DRPRP5" Required="false" runat="server" EmptyText="">
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

