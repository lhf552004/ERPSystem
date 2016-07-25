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
namespace ERP.Web.Dispatch
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
		ERP.BLL.Dispatch bll=new ERP.BLL.Dispatch();
		ERP.Model.Dispatch model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.lblAge_OID.Text=model.Age_OID.ToString();
		this.lblIdent.Text=model.Ident;
		this.lblCreationDate.Text=model.CreationDate.ToString();
		this.lblDescription.Text=model.Description;
		this.lblPrice.Text=model.Price.ToString();
		this.lblauditState.Text=model.auditState.ToString();
		this.lblDispatchState.Text=model.DispatchState.ToString();
		this.lblModifyUser.Text=model.ModifyUser;
		this.lblDispatchDate.Text=model.DispatchDate.ToString();
		this.lblAuditor.Text=model.Auditor;
		this.lblOperator.Text=model.Operator;

	}


    }
}
