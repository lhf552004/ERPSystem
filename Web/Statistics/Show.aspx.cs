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
namespace ERP.Web.Statistics
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
		ERP.BLL.Statistics bll=new ERP.BLL.Statistics();
		ERP.Model.Statistics model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.lblDis_OID.Text=model.Dis_OID.ToString();
		this.lblWar_OID.Text=model.War_OID.ToString();
		this.lblPro_OID.Text=model.Pro_OID.ToString();
		this.lblIdent.Text=model.Ident;
		this.lblDescription.Text=model.Description;
		this.lblModifyUser.Text=model.ModifyUser;
		this.lblNumber.Text=model.Number.ToString();
		this.lblStatisticMonth.Text=model.StatisticMonth.ToString();
		this.lblReceivalStatistic.Text=model.ReceivalStatistic.ToString();
		this.lblDispatchStatistic.Text=model.DispatchStatistic.ToString();

	}


    }
}
