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
namespace ERP.Web.IngredientCompoent
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
		ERP.BLL.IngredientCompoent bll=new ERP.BLL.IngredientCompoent();
		ERP.Model.IngredientCompoent model=bll.GetModel(OID);
		this.lblOID.Text=model.OID.ToString();
		this.txtPro_OID.Text=model.Pro_OID.ToString();
		this.txtDis_OID.Text=model.Dis_OID.ToString();
		this.txtRec_OID.Text=model.Rec_OID.ToString();
		this.txtIngredientCategory.Text=model.IngredientCategory.ToString();
		this.txt数量.Text=model.数量.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtPro_OID.Text))
			{
				strErr+="Pro_OID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDis_OID.Text))
			{
				strErr+="Dis_OID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRec_OID.Text))
			{
				strErr+="Rec_OID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtIngredientCategory.Text))
			{
				strErr+="IngredientCategory格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txt数量.Text))
			{
				strErr+="数量格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long OID=long.Parse(this.lblOID.Text);
			long Pro_OID=long.Parse(this.txtPro_OID.Text);
			long Dis_OID=long.Parse(this.txtDis_OID.Text);
			long Rec_OID=long.Parse(this.txtRec_OID.Text);
			int IngredientCategory=int.Parse(this.txtIngredientCategory.Text);
			int 数量=int.Parse(this.txt数量.Text);


			ERP.Model.IngredientCompoent model=new ERP.Model.IngredientCompoent();
			model.OID=OID;
			model.Pro_OID=Pro_OID;
			model.Dis_OID=Dis_OID;
			model.Rec_OID=Rec_OID;
			model.IngredientCategory=IngredientCategory;
			model.数量=数量;

			ERP.BLL.IngredientCompoent bll=new ERP.BLL.IngredientCompoent();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
