<%@ Page Title="" Language="C#" MasterPageFile="~/Master/FindMaster.Master" AutoEventWireup="true" CodeBehind="P2012E.aspx.cs" Inherits="OA.View.Workflow.P2010.P2012E" %>

<%@ MasterType VirtualPath="~/Master/FindMaster.Master" %>
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
                            <f:TriggerBox ID="AN8" EnableEdit="false" Text="" Label="处理者"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true">
                            </f:TriggerBox>
                            <f:Button ID="NEXT" runat="server" Text="流转" OnClick="NEXT_Click"></f:Button>
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="agreement" runat="server" Label="意见" />
                        </Items>
                        <Items>
                            <f:DropDownList ID="status" runat="server">
                                <f:ListItem Text="同意" Value="Y" Selected="true" />
                                <f:ListItem Text="不同意" Value="N" />
                            </f:DropDownList>
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TriggerBox ID="CHMCU" EnableEdit="false" Text="" Label="费用项目" Readonly="true"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true">
                            </f:TriggerBox>
                            <f:Label ID="CHDSC2" runat="server" />
                            <f:TriggerBox ID="CHDCTO" EnableEdit="false" Text="" Label="费用类型" Readonly="true"
                                TriggerIcon="Search" runat="server" OnTriggerClick="TriggerClick" Required="true" ShowRedStar="true">
                            </f:TriggerBox>
                            <f:TextBox ID="CHDOCO" runat="server" Label="费用单号" Readonly="true" Required="true" ShowRedStar="true" />
                        </Items>
                    </f:FormRow>
                    <f:FormRow>
                        <Items>
                            <f:TextBox ID="CHDSC1" runat="server" Label="说明1" Readonly="true" />
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" Height="500px" AllowPaging="true" PageSize="10000"
                DataKeyNames="CDDLNID" EnableTextSelection="true" EnableCheckBoxSelect="true"
                EnableMultiSelect="false" IsDatabasePaging="true" ExpandAllRowExpanders="true">
                <Columns>
                    <f:BoundField Width="100px" DataField="CDDLNID" DataFormatString="{0}" HeaderText="行号" />
                    <f:BoundField Width="100px" DataField="CDDSC1" DataFormatString="{0}" HeaderText="备注" />
                    <f:BoundField Width="100px" DataField="CDPRP1" DataFormatString="{0}" HeaderText="项目行号" />
                    <f:BoundField Width="100px" DataField="CDMAID" DataFormatString="{0}" HeaderText="项目类别" />
                    <f:BoundField Width="100px" DataField="CDDEL1" DataFormatString="{0}" HeaderText="项目类别说明" />
                    <f:BoundField Width="100px" DataField="CDFAID" DataFormatString="{0}" HeaderText="发票类别" />
                    <f:BoundField Width="100px" DataField="CDDEL2" DataFormatString="{0}" HeaderText="发票类别说明" />
                    <f:BoundField Width="100px" DataField="CDUPRC" DataFormatString="{0}" HeaderText="金额" />
                </Columns>
            </f:Grid>
            <f:Window ID="windows" Title="选择" Hidden="true" EnableIFrame="true" runat="server"
                EnableMaximize="false" EnableResize="false" Target="Self"
                IsModal="True" Width="750px" Height="550px">
            </f:Window>
            <f:HiddenField ID="mode" runat="server"></f:HiddenField>
            <f:HiddenField ID="lnid" runat="server"></f:HiddenField>
        </Items>
        <Items>
            <f:Label runat="server" ID="PageMessage" EncodeText="false" ShowEmptyLabel="false"></f:Label>
        </Items>
    </f:Panel>
</asp:Content>

