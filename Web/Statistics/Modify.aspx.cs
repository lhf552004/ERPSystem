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
namespace ERP.Web.Statistics
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
		ERP.BLL.Statistics bll=new ERP.BLL.Statistics();
		ERP.Model.Statistics model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.txtDis_OID.Text=model.Dis_OID.ToString();
		this.txtWar_OID.Text=model.War_OID.ToString();
		this.txtPro_OID.Text=model.Pro_OID.ToString();
		this.txtIdent.Text=model.Ident;
		this.txtDescription.Text=model.Description;
		this.txtModifyUser.Text=model.ModifyUser;
		this.txtNumber.Text=model.Number.ToString();
		this.txtStatisticMonth.Text=model.StatisticMonth.ToString();
		this.txtReceivalStatistic.Text=model.ReceivalStatistic.ToString();
		this.txtDispatchStatistic.Text=model.DispatchStatistic.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtDis_OID.Text))
			{
				strErr+="Dis_OID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtWar_OID.Text))
			{
				strErr+="War_OID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPro_OID.Text))
			{
				strErr+="Pro_OID格式错误！\\n";	
			}
			if(this.txtIdent.Text.Trim().Length==0)
			{
				strErr+="Ident不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(this.txtModifyUser.Text.Trim().Length==0)
			{
				strErr+="ModifyUser不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtNumber.Text))
			{
				strErr+="Number格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatisticMonth.Text))
			{
				strErr+="StatisticMonth格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtReceivalStatistic.Text))
			{
				strErr+="ReceivalStatistic格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDispatchStatistic.Text))
			{
				strErr+="DispatchStatistic格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long OID=long.Parse(this.lblOID.Text);
			long Dis_OID=long.Parse(this.txtDis_OID.Text);
			long War_OID=long.Parse(this.txtWar_OID.Text);
			long Pro_OID=long.Parse(this.txtPro_OID.Text);
			string Ident=this.txtIdent.Text;
			string Description=this.txtDescription.Text;
			string ModifyUser=this.txtModifyUser.Text;
			int Number=int.Parse(this.txtNumber.Text);
			int StatisticMonth=int.Parse(this.txtStatisticMonth.Text);
			int ReceivalStatistic=int.Parse(this.txtReceivalStatistic.Text);
			int DispatchStatistic=int.Parse(this.txtDispatchStatistic.Text);


			ERP.Model.Statistics model=new ERP.Model.Statistics();
			model.OID=OID;
			model.Dis_OID=Dis_OID;
			model.War_OID=War_OID;
			model.Pro_OID=Pro_OID;
			model.Ident=Ident;
			model.Description=Description;
			model.ModifyUser=ModifyUser;
			model.Number=Number;
			model.StatisticMonth=StatisticMonth;
			model.ReceivalStatistic=ReceivalStatistic;
			model.DispatchStatistic=DispatchStatistic;

			ERP.BLL.Statistics bll=new ERP.BLL.Statistics();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
