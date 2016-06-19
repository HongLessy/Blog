<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Share/Admin.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="GridViewHelper" %>
<%@ Import Namespace="System.Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPage" runat="server">

<h2>测试Admin.master</h2>
    <%
        string[] arr={"as","rewq","2134","阿发"};
        var result = arr.AsQueryable().ToPagedList(1, 5);
        TableDataOption Options = new TableDataOption();
    %>
    <%= Html.TableDataGridView<string>(result, new string[]{ "lie1", "lie2"}, Options)%>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
