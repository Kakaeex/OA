<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0101E.aspx.cs" Inherits="OA.View.BaseInfor.P0101.P0101E" %>

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
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="ABKCOO,ABAN8" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="ABKCOO" ColumnID="ABKCOO" FieldType="String"
                        HeaderText="公司">

                        <Editor>
                            <f:TextBox ID="ABKCOO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABAN8" ColumnID="ABAN8" FieldType="Int"
                        HeaderText="地址号">

                        <Editor>
                            <f:TextBox ID="ABAN8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABALKY" ColumnID="ABALKY" FieldType="String"
                        HeaderText="名称">

                        <Editor>
                            <f:TextBox ID="ABALKY" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABTAX" ColumnID="ABTAX" FieldType="String"
                        HeaderText="税号">

                        <Editor>
                            <f:TextBox ID="ABTAX" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABALPH" ColumnID="ABALPH" FieldType="String"
                        HeaderText="名称">

                        <Editor>
                            <f:TextBox ID="ABALPH" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABDC" ColumnID="ABDC" FieldType="String"
                        HeaderText="描述">

                        <Editor>
                            <f:TextBox ID="ABDC" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABMCU" ColumnID="ABMCU" FieldType="String"
                        HeaderText="分部">

                        <Editor>
                            <f:TextBox ID="ABMCU" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABLNGP" ColumnID="ABLNGP" FieldType="String"
                        HeaderText="语言">

                        <Editor>
                            <f:TextBox ID="ABLNGP" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABAT1" ColumnID="ABAT1" FieldType="String"
                        HeaderText="类型">

                        <Editor>
                            <f:TextBox ID="ABAT1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS01" ColumnID="ABCLASS01" FieldType="String"
                        HeaderText="销售码1">

                        <Editor>
                            <f:TextBox ID="ABCLASS01" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS02" ColumnID="ABCLASS02" FieldType="String"
                        HeaderText="销售码2">

                        <Editor>
                            <f:TextBox ID="ABCLASS02" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS03" ColumnID="ABCLASS03" FieldType="String"
                        HeaderText="销售码3">

                        <Editor>
                            <f:TextBox ID="ABCLASS03" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS04" ColumnID="ABCLASS04" FieldType="String"
                        HeaderText="销售码4">

                        <Editor>
                            <f:TextBox ID="ABCLASS04" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS05" ColumnID="ABCLASS05" FieldType="String"
                        HeaderText="销售码5">

                        <Editor>
                            <f:TextBox ID="ABCLASS05" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS06" ColumnID="ABCLASS06" FieldType="String"
                        HeaderText="销售码6">

                        <Editor>
                            <f:TextBox ID="ABCLASS06" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS07" ColumnID="ABCLASS07" FieldType="String"
                        HeaderText="销售码7">

                        <Editor>
                            <f:TextBox ID="ABCLASS07" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS08" ColumnID="ABCLASS08" FieldType="String"
                        HeaderText="销售码8">

                        <Editor>
                            <f:TextBox ID="ABCLASS08" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS09" ColumnID="ABCLASS09" FieldType="String"
                        HeaderText="销售码9">

                        <Editor>
                            <f:TextBox ID="ABCLASS09" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABCLASS10" ColumnID="ABCLASS10" FieldType="String"
                        HeaderText="销售码10">

                        <Editor>
                            <f:TextBox ID="ABCLASS10" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP1" ColumnID="ABPRP1" FieldType="Int"
                        HeaderText="采购码1">

                        <Editor>
                            <f:TextBox ID="ABPRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP2" ColumnID="ABPRP2" FieldType="Int"
                        HeaderText="采购码2">

                        <Editor>
                            <f:TextBox ID="ABPRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP3" ColumnID="ABPRP3" FieldType="Int"
                        HeaderText="采购码3">

                        <Editor>
                            <f:TextBox ID="ABPRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP4" ColumnID="ABPRP4" FieldType="Int"
                        HeaderText="采购码4">

                        <Editor>
                            <f:TextBox ID="ABPRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP5" ColumnID="ABPRP5" FieldType="Int"
                        HeaderText="采购码5">

                        <Editor>
                            <f:TextBox ID="ABPRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP6" ColumnID="ABPRP6" FieldType="Int"
                        HeaderText="采购码6">

                        <Editor>
                            <f:TextBox ID="ABPRP6" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP7" ColumnID="ABPRP7" FieldType="Int"
                        HeaderText="采购码7">

                        <Editor>
                            <f:TextBox ID="ABPRP7" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP8" ColumnID="ABPRP8" FieldType="Int"
                        HeaderText="采购码8">

                        <Editor>
                            <f:TextBox ID="ABPRP8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP9" ColumnID="ABPRP9" FieldType="Int"
                        HeaderText="采购码9">

                        <Editor>
                            <f:TextBox ID="ABPRP9" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="ABPRP0" ColumnID="ABPRP0" FieldType="Int"
                        HeaderText="采购码10">

                        <Editor>
                            <f:TextBox ID="ABPRP0" Required="true" runat="server">
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

