<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OA.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        body.theme-neptune .header {
            background-color: #005999;
            border-bottom: 1px solid #1E95EC;
        }

            body.theme-neptune .header .x-panel-body {
                background-color: transparent;
            }

            body.theme-neptune .header .title a {
                font-weight: bold;
                font-size: 24px;
                text-decoration: none;
                line-height: 50px;
                margin-left: 10px;
            }
            .float-right {
    float: right;
    margin-top: -30px;
    margin-right: 1px;
    font-size: 12px;
}
    </style>
</head>
<body>
    <form id="FORM1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server"></f:PageManager>
        <f:Panel ID="Panel1" Layout="Region" ShowBorder="false" ShowHeader="false" runat="server">
            <Items>
                <f:ContentPanel RegionPosition="Top" ShowBorder="false" CssClass="jumbotron" ShowHeader="false" runat="server">
                    <div class="headerTop">
                                <div class="templateTitle">
                                    <a id="A1" href="~/" runat="server">
                                        <img src="/res/icon/suibao.png" width="150" />
                                    </a>
                                </div>
                                <div>
                                    <section id="login" class="float-right">
                                        <asp:LoginView ID="LoginView1" runat="server" EnableViewState="false">
                                            <AnonymousTemplate>
                                                <a href="~/Account/Login.aspx" runat="server" id="loginLink">Log In</a>
                                            </AnonymousTemplate>
                                            <LoggedInTemplate>
                                                Welcome <span class="bold">
                                                    <asp:LoginName ID="HeadLoginName" runat="server" />
                                                </span>! [<asp:LoginStatus ID="HeadLoginStatus" runat="server" LogoutAction="Redirect" LogoutText="Log Out" />
                                                ]
                                            </LoggedInTemplate>
                                        </asp:LoginView>
                                    </section>
                                </div>
                            </div>
                </f:ContentPanel>
                <f:Panel ID="Panel2" RegionPosition="Left" RegionSplit="true" Width="200px" ShowHeader="true" Title="菜单" Icon="Outline"
                    EnableCollapse="true" Layout="Fit" runat="server">
                    <Items>
                        <f:Tree runat="server" ShowBorder="false" ShowHeader="false" EnableArrows="true"
                             EnableLines="true" ID="leftMenuTree" OnInit="leftMenuTree_Init">
                        </f:Tree>
                    </Items>
                </f:Panel>
                <f:TabStrip ID="mainTabStrip" RegionPosition="Center" EnableTabCloseMenu="true"  ShowBorder="true" runat="server">
                    <Tabs>
                        <f:Tab ID="Tab2" Title="首页" Layout="Fit" Icon="House" CssClass="maincontent" runat="server">
                            <Items>
                                <f:ContentPanel ID="ContentPanel3" ShowBorder="false" BodyPadding="10px" ShowHeader="false" AutoScroll="true"
                                    runat="server">
                                    首页内容
                                </f:ContentPanel>
                            </Items>
                        </f:Tab>
                    </Tabs>
                </f:TabStrip>
            </Items>
        </f:Panel>
    </form>
    <script>
        var menuClientID = '<%= leftMenuTree.ClientID %>';
        var tabStripClientID = '<%= mainTabStrip.ClientID %>';

        // 页面控件初始化完毕后，会调用用户自定义的onReady函数
        F.ready(function () {

            // 初始化主框架中的树(或者Accordion+Tree)和选项卡互动，以及地址栏的更新
            // treeMenu： 主框架中的树控件实例，或者内嵌树控件的手风琴控件实例
            // mainTabStrip： 选项卡实例
            // createToolbar： 创建选项卡前的回调函数（接受tabConfig参数）
            // updateLocationHash: 切换Tab时，是否更新地址栏Hash值
            // refreshWhenExist： 添加选项卡时，如果选项卡已经存在，是否刷新内部IFrame
            // refreshWhenTabChange: 切换选项卡时，是否刷新内部IFrame
            F.util.initTreeTabStrip(F(menuClientID), F(tabStripClientID), null, true, false, false);

            window.removeActiveTab = function () {
                var activeTab = F(tabStripClientID).getActiveTab();
                F(tabStripClientID).removeTab(activeTab.id);
            };
            window.newActiveTab = function (id, url, text, icon, refreshWhenExist) {
                // 动态添加一个标签页
                // mainTabStrip： 选项卡实例
                // id： 选项卡ID
                // url: 选项卡IFrame地址 
                // text： 选项卡标题
                // icon： 选项卡图标
                // addTabCallback： 创建选项卡前的回调函数（接受tabConfig参数）
                // refreshWhenExist： 添加选项卡时，如果选项卡已经存在，是否刷新内部IFrame
                F.util.addMainTab(F(tabStripClientID), id, url, text, icon, null, refreshWhenExist);
            };
        });
    </script>
</body>
</html>

