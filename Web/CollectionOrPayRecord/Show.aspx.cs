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
namespace ERP.Web.CollectionOrPayRecord
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					long OID=(Convert.ToInt64(strid));
					ShowInfo(OID);
				}
			}
		}
		
	private void ShowInfo(long OID)
	{
		ERP.BLL.CollectionOrPayRecord bll=new ERP.BLL.CollectionOrPayRecord();
		ERP.Model.CollectionOrPayRecord model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.lblExp_OID.Text=model.Exp_OID.ToString();
		this.lblExp_OID2.Text=model.Exp_OID2.ToString();
		this.lblTradeDate.Text=model.TradeDate.ToString();
		this.lblMoney.Text=model.Money.ToString();
		this.lblAuditor.Text=model.Auditor;
		this.lblauditState.Text=model.auditState.ToString();
		this.lblOperator.Text=model.Operator;
		this.lblInvoice.Text=model.Invoice;
		this.lblDescription.Text=model.Description;

	}


    }
}
