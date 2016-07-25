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
namespace ERP.Web.ExpectPayAccount
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
		ERP.BLL.ExpectPayAccount bll=new ERP.BLL.ExpectPayAccount();
		ERP.Model.ExpectPayAccount model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.txtIdent.Text=model.Ident;
		this.txtDescription.Text=model.Description;
		this.txtCreationDate.Text=model.CreationDate.ToString();
		this.txtLender.Text=model.Lender.ToString();
		this.txtLoaned.Text=model.Loaned.ToString();
		this.txtModifyUser.Text=model.ModifyUser;
		this.txtPayReason.Text=model.PayReason;
		this.txtAuditor.Text=model.Auditor;
		this.txtOperator.Text=model.Operator;
		this.txtGetMoneyPerson.Text=model.GetMoneyPerson;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtIdent.Text.Trim().Length==0)
			{
				strErr+="Ident不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreationDate.Text))
			{
				strErr+="CreationDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLender.Text))
			{
				strErr+="Lender格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLoaned.Text))
			{
				strErr+="Loaned格式错误！\\n";	
			}
			if(this.txtModifyUser.Text.Trim().Length==0)
			{
				strErr+="ModifyUser不能为空！\\n";	
			}
			if(this.txtPayReason.Text.Trim().Length==0)
			{
				strErr+="PayReason不能为空！\\n";	
			}
			if(this.txtAuditor.Text.Trim().Length==0)
			{
				strErr+="Auditor不能为空！\\n";	
			}
			if(this.txtOperator.Text.Trim().Length==0)
			{
				strErr+="Operator不能为空！\\n";	
			}
			if(this.txtGetMoneyPerson.Text.Trim().Length==0)
			{
				strErr+="GetMoneyPerson不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long OID=long.Parse(this.lblOID.Text);
			string Ident=this.txtIdent.Text;
			string Description=this.txtDescription.Text;
			DateTime CreationDate=DateTime.Parse(this.txtCreationDate.Text);
			decimal Lender=decimal.Parse(this.txtLender.Text);
			decimal Loaned=decimal.Parse(this.txtLoaned.Text);
			string ModifyUser=this.txtModifyUser.Text;
			string PayReason=this.txtPayReason.Text;
			string Auditor=this.txtAuditor.Text;
			string Operator=this.txtOperator.Text;
			string GetMoneyPerson=this.txtGetMoneyPerson.Text;


			ERP.Model.ExpectPayAccount model=new ERP.Model.ExpectPayAccount();
			model.OID=OID;
			model.Ident=Ident;
			model.Description=Description;
			model.CreationDate=CreationDate;
			model.Lender=Lender;
			model.Loaned=Loaned;
			model.ModifyUser=ModifyUser;
			model.PayReason=PayReason;
			model.Auditor=Auditor;
			model.Operator=Operator;
			model.GetMoneyPerson=GetMoneyPerson;

			ERP.BLL.ExpectPayAccount bll=new ERP.BLL.ExpectPayAccount();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
