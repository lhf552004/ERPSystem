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
namespace ERP.Web.ExpectPayAccount
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
		ERP.BLL.ExpectPayAccount bll=new ERP.BLL.ExpectPayAccount();
		ERP.Model.ExpectPayAccount model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.lblIdent.Text=model.Ident;
		this.lblDescription.Text=model.Description;
		this.lblCreationDate.Text=model.CreationDate.ToString();
		this.lblLender.Text=model.Lender.ToString();
		this.lblLoaned.Text=model.Loaned.ToString();
		this.lblModifyUser.Text=model.ModifyUser;
		this.lblPayReason.Text=model.PayReason;
		this.lblAuditor.Text=model.Auditor;
		this.lblOperator.Text=model.Operator;
		this.lblGetMoneyPerson.Text=model.GetMoneyPerson;

	}


    }
}
