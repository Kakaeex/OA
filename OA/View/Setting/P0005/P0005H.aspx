<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="P0005H.aspx.cs" Inherits="OA.View.Setting.P0005.P0005H" %>
<%@ MasterType VirtualPath="~/Master/FindMaster.Master" %>
<asp:Content ID="Content2" ContentPlaceHolderID="findMainMaster" runat="server">
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

                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="DRSY,DRRT,DRKY" AllowCellEditing="true" ClicksToEdit="1"
                IsDatabasePaging="true" AllowPaging="true" PageSize="30" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="DRSY" ColumnID="DRSY" FieldType="String"
                        HeaderText="SY">
                        <Editor>
                            <f:TextBox ID="tbxEditorName" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRRT" ColumnID="DRRT" FieldType="String"
                        HeaderText="RT">
                        <Editor>
                            <f:TextBox ID="TextBox1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRKY" ColumnID="DRKY" FieldType="String"
                        HeaderText="KY">
                        <Editor>
                            <f:TextBox ID="TextBox2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRDEL1" ColumnID="DRDEL1" FieldType="String"
                        HeaderText="说明1">
                        <Editor>
                            <f:TextBox ID="TextBox3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRDEL2" ColumnID="DRDEL2" FieldType="String"
                        HeaderText="说明1">
                        <Editor>
                            <f:TextBox ID="TextBox4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRSRP1" ColumnID="DRSRP1" FieldType="String"
                        HeaderText="类别码1">
                        <Editor>
                            <f:TextBox ID="TextBox5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRSRP2" ColumnID="DRSRP2" FieldType="String"
                        HeaderText="类别码2">
                        <Editor>
                            <f:TextBox ID="TextBox6" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRSRP3" ColumnID="DRSRP3" FieldType="String"
                        HeaderText="类别码3">
                        <Editor>
                            <f:TextBox ID="TextBox7" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRSRP4" ColumnID="DRSRP4" FieldType="String"
                        HeaderText="类别码4">
                        <Editor>
                            <f:TextBox ID="TextBox8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRSRP5" ColumnID="DRSRP5" FieldType="String"
                        HeaderText="类别码5">
                        <Editor>
                            <f:TextBox ID="TextBox9" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRPRP1" ColumnID="DRPRP1" FieldType="Int"
                        HeaderText="属性码1">
                        <Editor>
                            <f:TextBox ID="TextBox10" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRPRP2" ColumnID="DRPRP2" FieldType="Int"
                        HeaderText="属性码2">
                        <Editor>
                            <f:TextBox ID="TextBox11" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRPRP3" ColumnID="DRPRP3" FieldType="Int"
                        HeaderText="属性码3">
                        <Editor>
                            <f:TextBox ID="TextBox12" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRPRP4" ColumnID="DRPRP4" FieldType="Int"
                        HeaderText="属性码4">
                        <Editor>
                            <f:TextBox ID="TextBox13" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="DRPRP5" ColumnID="DRPRP5" FieldType="Int"
                        HeaderText="属性码5">
                        <Editor>
                           <f:TextBox ID="TextBox14" Required="true" runat="server">
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
