<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="ERP.Web.ExpectPayAccount.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		OID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ident
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIdent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Description
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDescription" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreationDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreationDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Lender
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLender" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Loaned
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLoaned" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModifyUser
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModifyUser" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayReason
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayReason" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Auditor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAuditor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Operator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GetMoneyPerson
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGetMoneyPerson" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




