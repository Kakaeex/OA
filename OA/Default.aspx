<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OA.Default" %>

<!DOCTYPE html>

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
    </style>
    <link rel="stylesheet" type="text/css" href="Content/Site.css" />
</head>
<body>
    <form id="form1" runat="server">
        <f:PageManager ID="PageManager1" AutoSizePanelID="RegionPanel1" runat="server"></f:PageManager>
        <f:RegionPanel ID="RegionPanel1" ShowBorder="false" runat="server">
            <Regions>
                <f:Region ID="Region1" Margins="0 0 0 0" ShowBorder="false" Height="65px" ShowHeader="false"
                    Position="Top" Layout="Fit" runat="server">
                    <Items>
                        <f:ContentPanel ShowBorder="false" ShowHeader="false" ID="ContentPanel1"
                            runat="server">
                            <div class="headerTop">
                                <div class="templateTitle">
                                    <a id="TitleLink" href="~/" runat="server">
                                        <img src="/Images/suibao.png" width="150" />
                                    </a>
                                </div>
                                <div class="float-right">
                                    <section id="login">
                                        <asp:LoginView ID="HeadLoginView" runat="server" EnableViewState="false">
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
                    </Items>
                </f:Region>
                <f:Region ID="Region2" Split="true" Width="200px" ShowHeader="true" Title="菜单"
                    EnableCollapse="true" Layout="Fit" Position="Left" runat="server">
                    <Items>
                        <f:Tree runat="server" ShowBorder="false" ShowHeader="false" EnableArrows="true" EnableLines="true" ID="leftMenuTree" OnInit="leftMenuTree_Init">
                        </f:Tree>
                    </Items>
                </f:Region>
                <f:Region ID="mainRegion" ShowHeader="false" Layout="Fit" Margins="0 0 0 0" Position="Center"
                    runat="server">
                    <Items>
                        <f:TabStrip ID="mainTabStrip" EnableTabCloseMenu="true" ShowBorder="false" runat="server">
                            <Tabs>
                                <f:Tab ID="Tab1" Title="首页" Layout="Fit" Icon="House" runat="server">
                                    <Items>
                                        <f:ContentPanel ID="ContentPanel2" ShowBorder="false" BodyPadding="10px" ShowHeader="false" AutoScroll="true"
                                            runat="server">
                                        </f:ContentPanel>
                                    </Items>
                                </f:Tab>
                            </Tabs>
                        </f:TabStrip>
                    </Items>
                </f:Region>
            </Regions>
        </f:RegionPanel>
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

