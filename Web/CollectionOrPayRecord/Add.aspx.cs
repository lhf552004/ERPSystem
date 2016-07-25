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
			if(this.txtExp_OID.Text.Trim().Length==0)
			{
				strErr+="Exp_OID不能为空！\\n";	
			}
			if(this.txtExp_OID2.Text.Trim().Length==0)
			{
				strErr+="Exp_OID2不能为空！\\n";	
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
			string OID=this.txtOID.Text;
			string Exp_OID=this.txtExp_OID.Text;
			string Exp_OID2=this.txtExp_OID2.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
