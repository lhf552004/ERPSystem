using System;
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
namespace ERP.Web.Product
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSta_OID.Text.Trim().Length==0)
			{
				strErr+="Sta_OID不能为空！\\n";	
			}
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
			if(this.txtModifyUser.Text.Trim().Length==0)
			{
				strErr+="ModifyUser不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCategory.Text))
			{
				strErr+="Category格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreationDate.Text))
			{
				strErr+="CreationDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtModifyDate.Text))
			{
				strErr+="ModifyDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Sta_OID=this.txtSta_OID.Text;
			string Ident=this.txtIdent.Text;
			string Name=this.txtName.Text;
			string Description=this.txtDescription.Text;
			string ModifyUser=this.txtModifyUser.Text;
			int Category=int.Parse(this.txtCategory.Text);
			decimal Price=decimal.Parse(this.txtPrice.Text);
			DateTime CreationDate=DateTime.Parse(this.txtCreationDate.Text);
			DateTime ModifyDate=DateTime.Parse(this.txtModifyDate.Text);

			ERP.Model.Product model=new ERP.Model.Product();
			model.Sta_OID=Sta_OID;
			model.Ident=Ident;
			model.Name=Name;
			model.Description=Description;
			model.ModifyUser=ModifyUser;
			model.Category=Category;
			model.Price=Price;
			model.CreationDate=CreationDate;
			model.ModifyDate=ModifyDate;

			ERP.BLL.Product bll=new ERP.BLL.Product();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
