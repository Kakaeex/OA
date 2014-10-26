<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0920E.aspx.cs" Inherits="OA.View.Finance.P0920.P0920E" %>

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
                            <f:TextBox ID="FHDOCO" runat="server" Label="费用项目号" Readonly="true" />
                            <f:TextBox ID="FHDCTO" runat="server" Label="费用项目类型" Readonly="true" />
                            <f:TriggerBox ID="FHSRP1" EnableEdit="true" Text="" Label="工作流"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true">
                            </f:TriggerBox>
                            <f:TriggerBox ID="FHMCU" EnableEdit="true" Text="" Label="部门BU"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true">
                            </f:TriggerBox>
                             <f:TextBox ID="FHKCOO" runat="server" Label="公司" Required="true" ShowRedStar="true" Readonly="true" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:DatePicker ID="FHYEAR" runat="server" Label="年份" Required="true" ShowRedStar="true" DateFormatString="yyyy"/>
                            <f:DatePicker ID="FHEFTJ" runat="server" Label="开始日期" Required="true" ShowRedStar="true"/>
                            <f:DatePicker ID="FHEDXJ" runat="server" Label="结束日期" Required="true" ShowRedStar="true" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="FHNAME" runat="server" Label="名称" Required="true" ShowRedStar="true" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="FHDSC1" runat="server" Label="说明1" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="FHDSC2" runat="server" Label="说明2" />
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="FDLNID"
                AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="false" EnableCheckBoxSelect="false"
                IsDatabasePaging="false" AllowPaging="false" AutoScroll="true" Height="500px" OnPreRowDataBound="Grid1_PreRowDataBound">
                <Columns>
                    <f:RenderField Width="80px" DataField="FDLNID" ColumnID="FDLNID" FieldType="Int"
                        HeaderText="行号">
                        <Editor>
                            <f:TextBox ID="FDLNID" Required="true" runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="150px" DataField="FDAID" ColumnID="FDAID" FieldType="String"
                        HeaderText="BU下费用类别">
                        <Editor>
                            <f:TriggerBox ID="FDAID" EnableEdit="false" Text="" Width="300px"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick">
                            </f:TriggerBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="300px" DataField="FDDSC1" ColumnID="FDDSC1" FieldType="String"
                        HeaderText="类别说明">
                        <Editor>
                            <f:TextBox ID="FDDSC1" runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="FDUPRC" ColumnID="FDUPRC" FieldType="Float"
                        HeaderText="划入金额">
                        <Editor>
                            <f:TextBox ID="FDUPRC" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="FDAPYN" ColumnID="FDAPYN" FieldType="Float"
                        HeaderText="占用金额">
                        <Editor>
                            <f:TextBox ID="FDAPYN" runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="FDAWTD" ColumnID="FDAWTD" FieldType="Int"
                        HeaderText="发生金额">
                        <Editor>
                            <f:TextBox ID="FDAWTD" runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="80px" DataField="KYJE" ColumnID="KYJE" FieldType="Float"
                        HeaderText="可用金额" Hidden="true">
                        <Editor>
                            <f:TextBox ID="KYJE" runat="server" Readonly="true">
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
            <f:HiddenField ID="lnid" runat="server"></f:HiddenField>
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
