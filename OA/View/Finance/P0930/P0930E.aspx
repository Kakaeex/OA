<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0930E.aspx.cs" Inherits="OA.View.Finance.P0930.P0930E" %>

<%@ MasterType VirtualPath="~/Master/EditMaster.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="findMainMaster" runat="server">
    <f:Panel ID="mainPanel" runat="server" BodyPadding="3px" ShowBorder="True" ShowHeader="false"
        Layout="Anchor" AnchorValue="100%">
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
                            <f:TriggerBox ID="CHMCU" EnableEdit="false" Text="" Label="费用项目" 
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true" />
                            <f:Label ID="CHDSC2" runat="server" />
                            <f:TriggerBox ID="CHDCTO" EnableEdit="false" Text="" Label="费用类型"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true" />
                            <f:TextBox ID="CHDOCO" runat="server" Label="费用单号" Readonly="true" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TriggerBox ID="AN8" EnableEdit="true" Text="" Label="受款人"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true" />
                            <f:DropDownList ID="CHSRP2" runat="server" Label="受款方式"  
                                DataValueField="DRKY" DataTextField="DRDEL1" Required="true" ShowRedStar="true"/>
                            <f:TextBox ID="CHVR01" runat="server" Label="开户银行" />
                            <f:TextBox ID="CHVR02" runat="server" Label="银行帐号" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="CHDSC1" runat="server" Label="说明1" />
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="CDDLNID"  EnableRowClickEvent="true"
                AllowCellEditing="true" ClicksToEdit="2" EnableMultiSelect="false" EnableCheckBoxSelect="false" OnAfterEdit="Grid1_AfterEdit"
                IsDatabasePaging="false" AllowPaging="false" AutoScroll="true" Height="500px" EnableAfterEditEvent="true" OnRowClick="Grid1_RowClick"
                OnPreRowDataBound="Grid1_PreRowDataBound">
                <Columns>
                    <f:RenderField Width="60px" DataField="CDDLNID" ColumnID="CDDLNID" FieldType="Int"
                        HeaderText="行号">
                        <Editor>
                            <f:TextBox ID="CDDLNID" Readonly="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="200px" DataField="CDDSC1" ColumnID="CDDSC1" FieldType="String"
                        HeaderText="备注">
                        <Editor>
                            <f:TextBox ID="CDDSC1" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="CDPRP1" ColumnID="CDPRP1" FieldType="Int"
                        HeaderText="项目行号">
                        <Editor>
                            <f:TriggerBox ID="CDPRP1" EnableEdit="false" Text="" Width="300px" Required="true"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick">
                            </f:TriggerBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="CDMAID" ColumnID="CDMAID" FieldType="String"
                        HeaderText="项目类别">
                        <Editor>
                            <f:TextBox ID="CDMAID" runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="150px" DataField="CDDEL1" ColumnID="CDDEL1" FieldType="String"
                        HeaderText="项目类别说明">
                        <Editor>
                            <f:TextBox ID="CDDEL1" runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="100px" DataField="CDFAID" ColumnID="CDFAID" FieldType="String"
                        HeaderText="发票类别">
                        <Editor>
                            <f:TriggerBox ID="CDFAID" EnableEdit="false" Text="" Width="300px" Required="true"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick">
                            </f:TriggerBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="150px" DataField="CDDEL2" ColumnID="CDDEL2" FieldType="String"
                        HeaderText="发票类别说明">
                        <Editor>
                            <f:TextBox ID="CDDEL2" runat="server" Readonly="true">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="60px" DataField="CDUPRC" ColumnID="CDUPRC" FieldType="Float"
                        HeaderText="金额">
                        <Editor>
                            <f:TextBox ID="CDUPRC" runat="server">
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
            <f:HiddenField ID="selected" runat="server"></f:HiddenField>
        </Items>
        <Items>
            <f:Label runat="server" ID="PageMessage" EncodeText="false" ShowEmptyLabel="false"></f:Label>
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
