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
namespace ERP.Web.IngredientCompoent
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
		ERP.BLL.IngredientCompoent bll=new ERP.BLL.IngredientCompoent();
		ERP.Model.IngredientCompoent model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.lblPro_OID.Text=model.Pro_OID.ToString();
		this.lblDis_OID.Text=model.Dis_OID.ToString();
		this.lblRec_OID.Text=model.Rec_OID.ToString();
		this.lblIngredientCategory.Text=model.IngredientCategory.ToString();
		this.lbl数量.Text=model.数量.ToString();

	}


    }
}
