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
namespace ERP.Web.CollectionOrPayRecord
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
		ERP.BLL.CollectionOrPayRecord bll=new ERP.BLL.CollectionOrPayRecord();
		ERP.Model.CollectionOrPayRecord model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.txtExp_OID.Text=model.Exp_OID.ToString();
		this.txtExp_OID2.Text=model.Exp_OID2.ToString();
		this.txtTradeDate.Text=model.TradeDate.ToString();
		this.txtMoney.Text=model.Money.ToString();
		this.txtAuditor.Text=model.Auditor;
		this.txtauditState.Text=model.auditState.ToString();
		this.txtOperator.Text=model.Operator;
		this.txtInvoice.Text=model.Invoice;
		this.txtDescription.Text=model.Description;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtExp_OID.Text))
			{
				strErr+="Exp_OID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtExp_OID2.Text))
			{
				strErr+="Exp_OID2格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTradeDate.Text))
			{
				strErr+="TradeDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMoney.Text))
			{
				strErr+="Money格式错误！\\n";	
			}
			if(this.txtAuditor.Text.Trim().Length==0)
			{
				strErr+="Auditor不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtauditState.Text))
			{
				strErr+="auditState格式错误！\\n";	
			}
			if(this.txtOperator.Text.Trim().Length==0)
			{
				strErr+="Operator不能为空！\\n";	
			}
			if(this.txtInvoice.Text.Trim().Length==0)
			{
				strErr+="Invoice不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long OID=long.Parse(this.lblOID.Text);
			long Exp_OID=long.Parse(this.txtExp_OID.Text);
			long Exp_OID2=long.Parse(this.txtExp_OID2.Text);
			DateTime TradeDate=DateTime.Parse(this.txtTradeDate.Text);
			decimal Money=decimal.Parse(this.txtMoney.Text);
			string Auditor=this.txtAuditor.Text;
			int auditState=int.Parse(this.txtauditState.Text);
			string Operator=this.txtOperator.Text;
			string Invoice=this.txtInvoice.Text;
			string Description=this.txtDescription.Text;


			ERP.Model.CollectionOrPayRecord model=new ERP.Model.CollectionOrPayRecord();
			model.OID=OID;
			model.Exp_OID=Exp_OID;
			model.Exp_OID2=Exp_OID2;
			model.TradeDate=TradeDate;
			model.Money=Money;
			model.Auditor=Auditor;
			model.auditState=auditState;
			model.Operator=Operator;
			model.Invoice=Invoice;
			model.Description=Description;

			ERP.BLL.CollectionOrPayRecord bll=new ERP.BLL.CollectionOrPayRecord();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
