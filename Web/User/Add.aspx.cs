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
namespace ERP.Web.User
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtIdent.Text.Trim().Length==0)
			{
				strErr+="Ident不能为空！\\n";	
			}
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtLevel.Text))
			{
				strErr+="Level格式错误！\\n";	
			}
			if(this.txtDepartment.Text.Trim().Length==0)
			{
				strErr+="Department不能为空！\\n";	
			}
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="password不能为空！\\n";	
			}
			if(this.txtModifyUser.Text.Trim().Length==0)
			{
				strErr+="ModifyUser不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Ident=this.txtIdent.Text;
			string Name=this.txtName.Text;
			string Description=this.txtDescription.Text;
			int Level=int.Parse(this.txtLevel.Text);
			string Department=this.txtDepartment.Text;
			string password=this.txtpassword.Text;
			string ModifyUser=this.txtModifyUser.Text;

			ERP.Model.User model=new ERP.Model.User();
			model.Ident=Ident;
			model.Name=Name;
			model.Description=Description;
			model.Level=Level;
			model.Department=Department;
			model.password=password;
			model.ModifyUser=ModifyUser;

			ERP.BLL.User bll=new ERP.BLL.User();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
