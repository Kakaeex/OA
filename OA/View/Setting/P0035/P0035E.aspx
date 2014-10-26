<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0035E.aspx.cs" Inherits="OA.View.Setting.P0035.P0035E" %>

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
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="MSKCOO,MSDCTO,MSCODE,MSLNGP" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="MSKCOO" ColumnID="MSKCOO" FieldType="String"
                        HeaderText="公司">
                        <Editor>
                            <f:TextBox ID="MSKCOO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="101px" DataField="MSDCTO" ColumnID="MSDCTO" FieldType="String"
                        HeaderText="类型">

                        <Editor>
                            <f:TextBox ID="MSDCTO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="102px" DataField="MSCODE" ColumnID="MSCODE" FieldType="String"
                        HeaderText="消息码">

                        <Editor>
                            <f:TextBox ID="MSCODE" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="103px" DataField="MSLNGP" ColumnID="MSLNGP" FieldType="String"
                        HeaderText="语言">

                        <Editor>
                            <f:TextBox ID="MSLNGP" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="104px" DataField="MSDSC1" ColumnID="MSDSC1" FieldType="String"
                        HeaderText="描述1">

                        <Editor>
                            <f:TextBox ID="MSDSC1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="105px" DataField="MSDSC2" ColumnID="MSDSC2" FieldType="String"
                        HeaderText="描述2">

                        <Editor>
                            <f:TextBox ID="MSDSC2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="106px" DataField="MSSRP1" ColumnID="MSSRP1" FieldType="String"
                        HeaderText="销售码1">

                        <Editor>
                            <f:TextBox ID="MSSRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="107px" DataField="MSSRP2" ColumnID="MSSRP2" FieldType="String"
                        HeaderText="销售码2">

                        <Editor>
                            <f:TextBox ID="MSSRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="108px" DataField="MSSRP3" ColumnID="MSSRP3" FieldType="String"
                        HeaderText="销售码3">

                        <Editor>
                            <f:TextBox ID="MSSRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="109px" DataField="MSSRP4" ColumnID="MSSRP4" FieldType="String"
                        HeaderText="销售码4">

                        <Editor>
                            <f:TextBox ID="MSSRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="110px" DataField="MSSRP5" ColumnID="MSSRP5" FieldType="String"
                        HeaderText="销售码5">

                        <Editor>
                            <f:TextBox ID="MSSRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="111px" DataField="MSPRP1" ColumnID="MSPRP1" FieldType="Int"
                        HeaderText="采购码1">

                        <Editor>
                            <f:TextBox ID="MSPRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="112px" DataField="MSPRP2" ColumnID="MSPRP2" FieldType="Int"
                        HeaderText="采购码2">

                        <Editor>
                            <f:TextBox ID="MSPRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="113px" DataField="MSPRP3" ColumnID="MSPRP3" FieldType="Int"
                        HeaderText="采购码3">

                        <Editor>
                            <f:TextBox ID="MSPRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="114px" DataField="MSPRP4" ColumnID="MSPRP4" FieldType="Int"
                        HeaderText="采购码4">

                        <Editor>
                            <f:TextBox ID="MSPRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="115px" DataField="MSPRP5" ColumnID="MSPRP5" FieldType="Int"
                        HeaderText="采购码5">

                        <Editor>
                            <f:TextBox ID="MSPRP5" Required="true" runat="server">
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

