<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P9002E.aspx.cs" Inherits="OA.View.Account.P9001.P9002E" %>

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
                            <f:TextBox runat="server" ID="DRSY" Label="系统码"></f:TextBox>
                            <f:TextBox runat="server" ID="DRRT" Label="分类码"></f:TextBox>
                            <f:TextBox runat="server" ID="DRDEL1" Label="备注1"></f:TextBox>
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="RUKCOO,RUID" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="RPKCOO" ColumnID="RPKCOO" FieldType="String"
                        HeaderText="公司">

                        <Editor>
                            <f:TextBox ID="RPKCOO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPRUID" ColumnID="RPRUID" FieldType="String"
                        HeaderText="角色ID">

                        <Editor>
                            <f:TextBox ID="RPRUID" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPMENUID" ColumnID="RPMENUID" FieldType="Int"
                        HeaderText="菜单ID（程序ID）">

                        <Editor>
                            <f:TextBox ID="RPMENUID" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPPARENTID" ColumnID="RPPARENTID" FieldType="Int"
                        HeaderText="父项菜单ID">

                        <Editor>
                            <f:TextBox ID="RPPARENTID" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPAPID" ColumnID="RPAPID" FieldType="Int"
                        HeaderText="程序ID">

                        <Editor>
                            <f:TextBox ID="RPAPID" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPBARNEW" ColumnID="RPBARNEW" FieldType="Int"
                        HeaderText="新增">

                        <Editor>
                            <f:TextBox ID="RPBARNEW" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPBARSAVE" ColumnID="RPBARSAVE" FieldType="Int"
                        HeaderText="保存">

                        <Editor>
                            <f:TextBox ID="RPBARSAVE" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPBARSELECT" ColumnID="RPBARSELECT" FieldType="Int"
                        HeaderText="选择">

                        <Editor>
                            <f:TextBox ID="RPBARSELECT" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPBARDELETE" ColumnID="RPBARDELETE" FieldType="Int"
                        HeaderText="删除">

                        <Editor>
                            <f:TextBox ID="RPBARDELETE" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPBARCLOSE" ColumnID="RPBARCLOSE" FieldType="Int"
                        HeaderText="关闭">

                        <Editor>
                            <f:TextBox ID="RPBARCLOSE" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPBARFIND" ColumnID="RPBARFIND" FieldType="Int"
                        HeaderText="查找">

                        <Editor>
                            <f:TextBox ID="RPBARFIND" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPBARSAVEAS" ColumnID="RPBARSAVEAS" FieldType="Int"
                        HeaderText="另存为">

                        <Editor>
                            <f:TextBox ID="RPBARSAVEAS" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPSRP1" ColumnID="RPSRP1" FieldType="String"
                        HeaderText="销售码1">

                        <Editor>
                            <f:TextBox ID="RPSRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPSRP2" ColumnID="RPSRP2" FieldType="String"
                        HeaderText="销售码2">

                        <Editor>
                            <f:TextBox ID="RPSRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPSRP3" ColumnID="RPSRP3" FieldType="String"
                        HeaderText="销售码3">

                        <Editor>
                            <f:TextBox ID="RPSRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPSRP4" ColumnID="RPSRP4" FieldType="String"
                        HeaderText="销售码4">

                        <Editor>
                            <f:TextBox ID="RPSRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPSRP5" ColumnID="RPSRP5" FieldType="String"
                        HeaderText="销售码5">

                        <Editor>
                            <f:TextBox ID="RPSRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPPRP1" ColumnID="RPPRP1" FieldType="Int"
                        HeaderText="采购码1">

                        <Editor>
                            <f:TextBox ID="RPPRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPPRP2" ColumnID="RPPRP2" FieldType="Int"
                        HeaderText="采购码2">

                        <Editor>
                            <f:TextBox ID="RPPRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPPRP3" ColumnID="RPPRP3" FieldType="Int"
                        HeaderText="采购码3">

                        <Editor>
                            <f:TextBox ID="RPPRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPPRP4" ColumnID="RPPRP4" FieldType="Int"
                        HeaderText="采购码4">

                        <Editor>
                            <f:TextBox ID="RPPRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="RPPRP5" ColumnID="RPPRP5" FieldType="Int"
                        HeaderText="采购码5">

                        <Editor>
                            <f:TextBox ID="RPPRP5" Required="true" runat="server">
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

