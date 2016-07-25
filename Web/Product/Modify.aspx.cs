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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long OID=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(OID);
				}
			}
		}
			
	private void ShowInfo(long OID)
	{
		ERP.BLL.Product bll=new ERP.BLL.Product();
		ERP.Model.Product model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.txtSta_OID.Text=model.Sta_OID.ToString();
		this.txtIdent.Text=model.Ident;
		this.txtName.Text=model.Name;
		this.txtDescription.Text=model.Description;
		this.txtModifyUser.Text=model.ModifyUser;
		this.txtCategory.Text=model.Category.ToString();
		this.txtPrice.Text=model.Price.ToString();
		this.txtCreationDate.Text=model.CreationDate.ToString();
		this.txtModifyDate.Text=model.ModifyDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtSta_OID.Text))
			{
				strErr+="Sta_OID格式错误！\\n";	
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
			long OID=long.Parse(this.lblOID.Text);
			long Sta_OID=long.Parse(this.txtSta_OID.Text);
			string Ident=this.txtIdent.Text;
			string Name=this.txtName.Text;
			string Description=this.txtDescription.Text;
			string ModifyUser=this.txtModifyUser.Text;
			int Category=int.Parse(this.txtCategory.Text);
			decimal Price=decimal.Parse(this.txtPrice.Text);
			DateTime CreationDate=DateTime.Parse(this.txtCreationDate.Text);
			DateTime ModifyDate=DateTime.Parse(this.txtModifyDate.Text);


			ERP.Model.Product model=new ERP.Model.Product();
			model.OID=OID;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
