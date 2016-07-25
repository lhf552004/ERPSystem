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
namespace ERP.Web.Receival
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
		ERP.BLL.Receival bll=new ERP.BLL.Receival();
		ERP.Model.Receival model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.txtIdent.Text=model.Ident;
		this.txtName.Text=model.Name;
		this.txtDescription.Text=model.Description;
		this.txtauditState.Text=model.auditState.ToString();
		this.txtReceivalState.Text=model.ReceivalState.ToString();
		this.txtFinishReceiptDate.Text=model.FinishReceiptDate.ToString();
		this.txtCreationDate.Text=model.CreationDate.ToString();
		this.txtAuditor.Text=model.Auditor;
		this.txtOperator.Text=model.Operator;

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
			if(!PageValidate.IsNumber(txtauditState.Text))
			{
				strErr+="auditState格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtReceivalState.Text))
			{
				strErr+="ReceivalState格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFinishReceiptDate.Text))
			{
				strErr+="FinishReceiptDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreationDate.Text))
			{
				strErr+="CreationDate格式错误！\\n";	
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
			long OID=long.Parse(this.lblOID.Text);
			string Ident=this.txtIdent.Text;
			string Name=this.txtName.Text;
			string Description=this.txtDescription.Text;
			int auditState=int.Parse(this.txtauditState.Text);
			int ReceivalState=int.Parse(this.txtReceivalState.Text);
			DateTime FinishReceiptDate=DateTime.Parse(this.txtFinishReceiptDate.Text);
			DateTime CreationDate=DateTime.Parse(this.txtCreationDate.Text);
			string Auditor=this.txtAuditor.Text;
			string Operator=this.txtOperator.Text;


			ERP.Model.Receival model=new ERP.Model.Receival();
			model.OID=OID;
			model.Ident=Ident;
			model.Name=Name;
			model.Description=Description;
			model.auditState=auditState;
			model.ReceivalState=ReceivalState;
			model.FinishReceiptDate=FinishReceiptDate;
			model.CreationDate=CreationDate;
			model.Auditor=Auditor;
			model.Operator=Operator;

			ERP.BLL.Receival bll=new ERP.BLL.Receival();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
