﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace ERP.Web.Dispatch
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOID.Text.Trim().Length==0)
			{
				strErr+="OID不能为空！\\n";	
			}
			if(this.txtAge_OID.Text.Trim().Length==0)
			{
				strErr+="Age_OID不能为空！\\n";	
			}
			if(this.txtIdent.Text.Trim().Length==0)
			{
				strErr+="Ident不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreationDate.Text))
			{
				strErr+="CreationDate格式错误！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtauditState.Text))
			{
				strErr+="auditState格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDispatchState.Text))
			{
				strErr+="DispatchState格式错误！\\n";	
			}
			if(this.txtModifyUser.Text.Trim().Length==0)
			{
				strErr+="ModifyUser不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDispatchDate.Text))
			{
				strErr+="DispatchDate格式错误！\\n";	
			}
			if(this.txtAuditor.Text.Trim().Length==0)
			{
				strErr+="Auditor不能为空！\\n";	
			}
			if(this.txtOperator.Text.Trim().Length==0)
			{
				strErr+="Operator不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string OID=this.txtOID.Text;
			string Age_OID=this.txtAge_OID.Text;
			string Ident=this.txtIdent.Text;
			DateTime CreationDate=DateTime.Parse(this.txtCreationDate.Text);
			string Description=this.txtDescription.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);
			int auditState=int.Parse(this.txtauditState.Text);
			int DispatchState=int.Parse(this.txtDispatchState.Text);
			string ModifyUser=this.txtModifyUser.Text;
			DateTime DispatchDate=DateTime.Parse(this.txtDispatchDate.Text);
			string Auditor=this.txtAuditor.Text;
			string Operator=this.txtOperator.Text;

			ERP.Model.Dispatch model=new ERP.Model.Dispatch();
			model.OID=OID;
			model.Age_OID=Age_OID;
			model.Ident=Ident;
			model.CreationDate=CreationDate;
			model.Description=Description;
			model.Price=Price;
			model.auditState=auditState;
			model.DispatchState=DispatchState;
			model.ModifyUser=ModifyUser;
			model.DispatchDate=DispatchDate;
			model.Auditor=Auditor;
			model.Operator=Operator;

			ERP.BLL.Dispatch bll=new ERP.BLL.Dispatch();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
