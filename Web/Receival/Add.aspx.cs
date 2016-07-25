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
			string OID=this.txtOID.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
