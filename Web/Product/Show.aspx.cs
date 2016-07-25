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
namespace ERP.Web.Product
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
		ERP.BLL.Product bll=new ERP.BLL.Product();
		ERP.Model.Product model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.lblSta_OID.Text=model.Sta_OID.ToString();
		this.lblIdent.Text=model.Ident;
		this.lblName.Text=model.Name;
		this.lblDescription.Text=model.Description;
		this.lblModifyUser.Text=model.ModifyUser;
		this.lblCategory.Text=model.Category.ToString();
		this.lblPrice.Text=model.Price.ToString();
		this.lblCreationDate.Text=model.CreationDate.ToString();
		this.lblModifyDate.Text=model.ModifyDate.ToString();

	}


    }
}
