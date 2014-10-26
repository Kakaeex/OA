<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P9005E.aspx.cs" Inherits="OA.View.Account.P9005.P9005E" %>

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
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="APKCOO,APID" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="APKCOO" ColumnID="APKCOO" FieldType="String"
                        HeaderText="公司">
                        <Editor>
                            <f:TextBox ID="APKCOO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APID" ColumnID="APID" FieldType="Int"
                        HeaderText="程序ID">

                        <Editor>
                            <f:TextBox ID="APID" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APDEL1" ColumnID="APDEL1" FieldType="String"
                        HeaderText="说明1">

                        <Editor>
                            <f:TextBox ID="APDEL1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APDEL2" ColumnID="APDEL2" FieldType="String"
                        HeaderText="说明2">

                        <Editor>
                            <f:TextBox ID="APDEL2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="200px" DataField="APURL" ColumnID="APURL" FieldType="String"
                        HeaderText="地址">

                        <Editor>
                            <f:TextBox ID="APURL" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APSRP1" ColumnID="APSRP1" FieldType="String"
                        HeaderText="销售码1">

                        <Editor>
                            <f:TextBox ID="APSRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APSRP2" ColumnID="APSRP2" FieldType="String"
                        HeaderText="销售码2">

                        <Editor>
                            <f:TextBox ID="APSRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APSRP3" ColumnID="APSRP3" FieldType="String"
                        HeaderText="销售码3">

                        <Editor>
                            <f:TextBox ID="APSRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APSRP4" ColumnID="APSRP4" FieldType="String"
                        HeaderText="销售码4">

                        <Editor>
                            <f:TextBox ID="APSRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APSRP5" ColumnID="APSRP5" FieldType="String"
                        HeaderText="销售码5">

                        <Editor>
                            <f:TextBox ID="APSRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APPRP1" ColumnID="APPRP1" FieldType="Int"
                        HeaderText="采购码1">

                        <Editor>
                            <f:TextBox ID="APPRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APPRP2" ColumnID="APPRP2" FieldType="Int"
                        HeaderText="采购码2">

                        <Editor>
                            <f:TextBox ID="APPRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APPRP3" ColumnID="APPRP3" FieldType="Int"
                        HeaderText="采购码3">

                        <Editor>
                            <f:TextBox ID="APPRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APPRP4" ColumnID="APPRP4" FieldType="Int"
                        HeaderText="采购码4">

                        <Editor>
                            <f:TextBox ID="APPRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="APPRP5" ColumnID="APPRP5" FieldType="Int"
                        HeaderText="采购码5">

                        <Editor>
                            <f:TextBox ID="APPRP5" Required="true" runat="server">
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
