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
namespace ERP.Web.Warehouse
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
		ERP.BLL.Warehouse bll=new ERP.BLL.Warehouse();
		ERP.Model.Warehouse model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.txtIdent.Text=model.Ident;
		this.txtName.Text=model.Name;
		this.txtDescription.Text=model.Description;
		this.txtModifyUser.Text=model.ModifyUser;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtModifyUser.Text.Trim().Length==0)
			{
				strErr+="ModifyUser不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long OID=long.Parse(this.lblOID.Text);
			string Ident=this.txtIdent.Text;
			string Name=this.txtName.Text;
			string Description=this.txtDescription.Text;
			string ModifyUser=this.txtModifyUser.Text;


			ERP.Model.Warehouse model=new ERP.Model.Warehouse();
			model.OID=OID;
			model.Ident=Ident;
			model.Name=Name;
			model.Description=Description;
			model.ModifyUser=ModifyUser;

			ERP.BLL.Warehouse bll=new ERP.BLL.Warehouse();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
