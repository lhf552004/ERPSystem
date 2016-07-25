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
			if(this.txtPro_OID.Text.Trim().Length==0)
			{
				strErr+="Pro_OID不能为空！\\n";	
			}
			if(this.txtDis_OID.Text.Trim().Length==0)
			{
				strErr+="Dis_OID不能为空！\\n";	
			}
			if(this.txtRec_OID.Text.Trim().Length==0)
			{
				strErr+="Rec_OID不能为空！\\n";	
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
			string OID=this.txtOID.Text;
			string Pro_OID=this.txtPro_OID.Text;
			string Dis_OID=this.txtDis_OID.Text;
			string Rec_OID=this.txtRec_OID.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
