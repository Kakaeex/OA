<%@ Page Title="" Language="C#" MasterPageFile="~/Master/EditMaster.Master" AutoEventWireup="true" CodeBehind="P0006E.aspx.cs" Inherits="OA.View.Setting.P0006.P0006E" %>

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
                        </Items>
                    </f:FormRow>
                </Rows>
            </f:Form>
        </Items>
        <Items>
            <f:Grid ID="Grid1" runat="server" ShowHeader="false" DataKeyNames="MCKCOO,MCMCU" AllowCellEditing="true" ClicksToEdit="1" EnableMultiSelect="true" EnableCheckBoxSelect="false"
                IsDatabasePaging="true" AllowPaging="false" EnableAfterEditEvent="true" AutoScroll="true" Height="500px">
                <Columns>
                    <f:RenderField Width="100px" DataField="MCKCOO" ColumnID="MCKCOO" FieldType="String"
                        HeaderText="公司">

                        <Editor>
                            <f:TextBox ID="MCKCOO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="101px" DataField="MCMCU" ColumnID="MCMCU" FieldType="String"
                        HeaderText="分部">

                        <Editor>
                            <f:TextBox ID="MCMCU" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="102px" DataField="MCSTYL" ColumnID="MCSTYL" FieldType="String"
                        HeaderText="类型">

                        <Editor>
                            <f:TextBox ID="MCSTYL" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="103px" DataField="MCDC" ColumnID="MCDC" FieldType="String"
                        HeaderText="描述">

                        <Editor>
                            <f:TextBox ID="MCDC" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="104px" DataField="MCLDM" ColumnID="MCLDM" FieldType="Int"
                        HeaderText="等级">

                        <Editor>
                            <f:TextBox ID="MCLDM" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="105px" DataField="MCCO" ColumnID="MCCO" FieldType="String"
                        HeaderText="上级公司">

                        <Editor>
                            <f:TextBox ID="MCCO" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="106px" DataField="MCPMCU" ColumnID="MCPMCU" FieldType="String"
                        HeaderText="上级分部">

                        <Editor>
                            <f:TextBox ID="MCPMCU" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="107px" DataField="MCAN8" ColumnID="MCAN8" FieldType="Int"
                        HeaderText="地址号">

                        <Editor>
                            <f:TextBox ID="MCAN8" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="108px" DataField="MCAN8O" ColumnID="MCAN8O" FieldType="Int"
                        HeaderText="地址号2">

                        <Editor>
                            <f:TextBox ID="MCAN8O" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="109px" DataField="MCCNTY" ColumnID="MCCNTY" FieldType="String"
                        HeaderText="城市">

                        <Editor>
                            <f:TextBox ID="MCCNTY" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="110px" DataField="MCADDS" ColumnID="MCADDS" FieldType="String"
                        HeaderText="地址">

                        <Editor>
                            <f:TextBox ID="MCADDS" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="112px" DataField="MCDL01" ColumnID="MCDL01" FieldType="String"
                        HeaderText="备注1">

                        <Editor>
                            <f:TextBox ID="MCDL01" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="113px" DataField="MCDL02" ColumnID="MCDL02" FieldType="String"
                        HeaderText="备注2">

                        <Editor>
                            <f:TextBox ID="MCDL02" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="114px" DataField="MCDL03" ColumnID="MCDL03" FieldType="String"
                        HeaderText="备注3">

                        <Editor>
                            <f:TextBox ID="MCDL03" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="115px" DataField="MCDL04" ColumnID="MCDL04" FieldType="String"
                        HeaderText="备注4">

                        <Editor>
                            <f:TextBox ID="MCDL04" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="116px" DataField="MCSRP1" ColumnID="MCSRP1" FieldType="String"
                        HeaderText="销售码1">

                        <Editor>
                            <f:TextBox ID="MCSRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="117px" DataField="MCSRP2" ColumnID="MCSRP2" FieldType="String"
                        HeaderText="销售码2">

                        <Editor>
                            <f:TextBox ID="MCSRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="118px" DataField="MCSRP3" ColumnID="MCSRP3" FieldType="String"
                        HeaderText="销售码3">

                        <Editor>
                            <f:TextBox ID="MCSRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="119px" DataField="MCSRP4" ColumnID="MCSRP4" FieldType="String"
                        HeaderText="销售码4">

                        <Editor>
                            <f:TextBox ID="MCSRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="120px" DataField="MCSRP5" ColumnID="MCSRP5" FieldType="String"
                        HeaderText="销售码5">

                        <Editor>
                            <f:TextBox ID="MCSRP5" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="121px" DataField="MCPRP1" ColumnID="MCPRP1" FieldType="Int"
                        HeaderText="采购码1">

                        <Editor>
                            <f:TextBox ID="MCPRP1" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="122px" DataField="MCPRP2" ColumnID="MCPRP2" FieldType="Int"
                        HeaderText="采购码2">

                        <Editor>
                            <f:TextBox ID="MCPRP2" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="123px" DataField="MCPRP3" ColumnID="MCPRP3" FieldType="Int"
                        HeaderText="采购码3">

                        <Editor>
                            <f:TextBox ID="MCPRP3" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="124px" DataField="MCPRP4" ColumnID="MCPRP4" FieldType="Int"
                        HeaderText="采购码4">

                        <Editor>
                            <f:TextBox ID="MCPRP4" Required="true" runat="server">
                            </f:TextBox>
                        </Editor>
                    </f:RenderField>
                    <f:RenderField Width="125px" DataField="MCPRP5" ColumnID="MCPRP5" FieldType="Int"
                        HeaderText="采购码5">

                        <Editor>
                            <f:TextBox ID="MCPRP5" Required="true" runat="server">
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


