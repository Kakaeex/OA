<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0010E.aspx.cs" Inherits="OA.View.Setting.P0010.P0010E" %>

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
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="CCCO" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="CCCO" ColumnID="CCCO" FieldType="String"
                        HeaderText="公司">

                        <Editor>
                            <f:TextBox ID="CCCO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="101px" DataField="CCNAME" ColumnID="CCNAME" FieldType="String"
                        HeaderText="名称">

                        <Editor>
                            <f:TextBox ID="CCNAME" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="102px" DataField="CCDSC1" ColumnID="CCDSC1" FieldType="String"
                        HeaderText="说明1">

                        <Editor>
                            <f:TextBox ID="CCDSC1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="103px" DataField="CCDSC2" ColumnID="CCDSC2" FieldType="String"
                        HeaderText="说明2">

                        <Editor>
                            <f:TextBox ID="CCDSC2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="104px" DataField="CCCTRY" ColumnID="CCCTRY" FieldType="Int"
                        HeaderText="世纪">

                        <Editor>
                            <f:TextBox ID="CCCTRY" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="105px" DataField="CCFY" ColumnID="CCFY" FieldType="String"
                        HeaderText="年">

                        <Editor>
                            <f:TextBox ID="CCFY" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="106px" DataField="CCCRCD" ColumnID="CCCRCD" FieldType="String"
                        HeaderText="货币码">

                        <Editor>
                            <f:TextBox ID="CCCRCD" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="107px" DataField="CCAN8" ColumnID="CCAN8" FieldType="Int"
                        HeaderText="地址号">

                        <Editor>
                            <f:TextBox ID="CCAN8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="108px" DataField="CCADDZ" ColumnID="CCADDZ" FieldType="String"
                        HeaderText="国家">

                        <Editor>
                            <f:TextBox ID="CCADDZ" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="109px" DataField="CCCTY1" ColumnID="CCCTY1" FieldType="String"
                        HeaderText="城市">

                        <Editor>
                            <f:TextBox ID="CCCTY1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="110px" DataField="CCCOUN" ColumnID="CCCOUN" FieldType="String"
                        HeaderText="地区">

                        <Editor>
                            <f:TextBox ID="CCCOUN" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="111px" DataField="CCADDS" ColumnID="CCADDS" FieldType="String"
                        HeaderText="地址">

                        <Editor>
                            <f:TextBox ID="CCADDS" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="112px" DataField="CCSRP1" ColumnID="CCSRP1" FieldType="String"
                        HeaderText="销售码1">

                        <Editor>
                            <f:TextBox ID="CCSRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="113px" DataField="CCSRP2" ColumnID="CCSRP2" FieldType="String"
                        HeaderText="销售码2">

                        <Editor>
                            <f:TextBox ID="CCSRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="114px" DataField="CCSRP3" ColumnID="CCSRP3" FieldType="String"
                        HeaderText="销售码3">

                        <Editor>
                            <f:TextBox ID="CCSRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="115px" DataField="CCSRP4" ColumnID="CCSRP4" FieldType="String"
                        HeaderText="销售码4">

                        <Editor>
                            <f:TextBox ID="CCSRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="116px" DataField="CCSRP5" ColumnID="CCSRP5" FieldType="String"
                        HeaderText="销售码5">

                        <Editor>
                            <f:TextBox ID="CCSRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="117px" DataField="CCSRP6" ColumnID="CCSRP6" FieldType="String"
                        HeaderText="销售码6">

                        <Editor>
                            <f:TextBox ID="CCSRP6" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="118px" DataField="CCSRP7" ColumnID="CCSRP7" FieldType="String"
                        HeaderText="销售码7">

                        <Editor>
                            <f:TextBox ID="CCSRP7" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="119px" DataField="CCSRP8" ColumnID="CCSRP8" FieldType="String"
                        HeaderText="销售码8">

                        <Editor>
                            <f:TextBox ID="CCSRP8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="120px" DataField="CCSRP9" ColumnID="CCSRP9" FieldType="String"
                        HeaderText="销售码9">

                        <Editor>
                            <f:TextBox ID="CCSRP9" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="121px" DataField="CCSRP0" ColumnID="CCSRP0" FieldType="String"
                        HeaderText="销售码10">

                        <Editor>
                            <f:TextBox ID="CCSRP0" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="122px" DataField="CCPRP1" ColumnID="CCPRP1" FieldType="Int"
                        HeaderText="采购码1">

                        <Editor>
                            <f:TextBox ID="CCPRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="123px" DataField="CCPRP2" ColumnID="CCPRP2" FieldType="Int"
                        HeaderText="采购码2">

                        <Editor>
                            <f:TextBox ID="CCPRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="124px" DataField="CCPRP3" ColumnID="CCPRP3" FieldType="Int"
                        HeaderText="采购码3">

                        <Editor>
                            <f:TextBox ID="CCPRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="125px" DataField="CCPRP4" ColumnID="CCPRP4" FieldType="Int"
                        HeaderText="采购码4">

                        <Editor>
                            <f:TextBox ID="CCPRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="126px" DataField="CCPRP5" ColumnID="CCPRP5" FieldType="Int"
                        HeaderText="采购码5">

                        <Editor>
                            <f:TextBox ID="CCPRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="127px" DataField="CCPRP6" ColumnID="CCPRP6" FieldType="Int"
                        HeaderText="采购码6">

                        <Editor>
                            <f:TextBox ID="CCPRP6" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="128px" DataField="CCPRP7" ColumnID="CCPRP7" FieldType="Int"
                        HeaderText="采购码7">

                        <Editor>
                            <f:TextBox ID="CCPRP7" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="129px" DataField="CCPRP8" ColumnID="CCPRP8" FieldType="Int"
                        HeaderText="采购码8">

                        <Editor>
                            <f:TextBox ID="CCPRP8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="130px" DataField="CCPRP9" ColumnID="CCPRP9" FieldType="Int"
                        HeaderText="采购码9">

                        <Editor>
                            <f:TextBox ID="CCPRP9" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="131px" DataField="CCPRP0" ColumnID="CCPRP0" FieldType="Int"
                        HeaderText="采购码10">

                        <Editor>
                            <f:TextBox ID="CCPRP0" Required="true" runat="server">
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
