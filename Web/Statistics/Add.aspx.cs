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
			if(this.txtDis_OID.Text.Trim().Length==0)
			{
				strErr+="Dis_OID不能为空！\\n";	
			}
			if(this.txtWar_OID.Text.Trim().Length==0)
			{
				strErr+="War_OID不能为空！\\n";	
			}
			if(this.txtPro_OID.Text.Trim().Length==0)
			{
				strErr+="Pro_OID不能为空！\\n";	
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
			string OID=this.txtOID.Text;
			string Dis_OID=this.txtDis_OID.Text;
			string War_OID=this.txtWar_OID.Text;
			string Pro_OID=this.txtPro_OID.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
