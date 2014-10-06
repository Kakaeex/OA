<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P9008E.aspx.cs" Inherits="OA.View.Account.Users.P9008E" %>

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
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="RAKCOO,RAAN8,RAID" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="AUKCOO" ColumnID="AUKCOO" FieldType="String"
                        HeaderText="公司">

                        <Editor>
                            <f:TextBox ID="AUKCOO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUMCU" ColumnID="AUMCU" FieldType="String"
                        HeaderText="分部">

                        <Editor>
                            <f:TextBox ID="AUMCU" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUAN8" ColumnID="AUAN8" FieldType="Int"
                        HeaderText="地址号">

                        <Editor>
                            <f:TextBox ID="AUAN8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUDEL1" ColumnID="AUDEL1" FieldType="String"
                        HeaderText="备注1">

                        <Editor>
                            <f:TextBox ID="AUDEL1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUDEL2" ColumnID="AUDEL2" FieldType="String"
                        HeaderText="备注2">

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
                    <f:RenderField Width="100px" DataField="AUSRP2" ColumnID="AUSRP2" FieldType="String"
                        HeaderText="销售码2">

                        <Editor>
                            <f:TextBox ID="AUSRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUSRP3" ColumnID="AUSRP3" FieldType="String"
                        HeaderText="销售码3">

                        <Editor>
                            <f:TextBox ID="AUSRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUSRP4" ColumnID="AUSRP4" FieldType="String"
                        HeaderText="销售码4">

                        <Editor>
                            <f:TextBox ID="AUSRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUSRP5" ColumnID="AUSRP5" FieldType="String"
                        HeaderText="销售码5">

                        <Editor>
                            <f:TextBox ID="AUSRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUPRP1" ColumnID="AUPRP1" FieldType="Int"
                        HeaderText="采购码1">

                        <Editor>
                            <f:TextBox ID="AUPRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUPRP2" ColumnID="AUPRP2" FieldType="Int"
                        HeaderText="采购码2">

                        <Editor>
                            <f:TextBox ID="AUPRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUPRP3" ColumnID="AUPRP3" FieldType="Int"
                        HeaderText="采购码3">

                        <Editor>
                            <f:TextBox ID="AUPRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUPRP4" ColumnID="AUPRP4" FieldType="Int"
                        HeaderText="采购码4">

                        <Editor>
                            <f:TextBox ID="AUPRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="AUPRP5" ColumnID="AUPRP5" FieldType="Int"
                        HeaderText="采购码5">

                        <Editor>
                            <f:TextBox ID="AUPRP5" Required="true" runat="server">
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

