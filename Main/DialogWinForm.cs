using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP;
using ERP.Model;

namespace ERP
{
    public partial class DialogWinForm : Form
    {
        public DialogWinForm()
        {
            InitializeComponent();
        }
        public static bool ShowDialogWinForm(ref string theIdent,ref string theName,ref byte theCategory)
        {
            DialogWinForm theForm = new DialogWinForm();
            theForm.ShowDialog();

            bool theResult = false;
            if (theForm.DialogResult == DialogResult.OK)
            {
                theIdent = theForm.ProdIdent.Text;
                theName = theForm.ProdName.Text;
                theCategory = (byte)(ProductCategory)Enum.Parse(typeof(ProductCategory), theForm.ProdCategory.Text);
                theResult= true;
            }
            else if (theForm.DialogResult == DialogResult.Cancel)
            {
                
            }
            theForm.Close();
            return theResult;

        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }

        private void _setEnableOfConfirmButton(object sender,EventArgs e)
        {
            if (this.ProdIdent.Text.Trim() != "" && this.ProdName.Text.Trim() != "" && this.ProdCategory.Text.Trim() != "")
            {
                this.ConfirmButton.Enabled = true;
            }
            else
            {
                this.ConfirmButton.Enabled = false ;
 
            }
 
        }
       

        private void DialogWinForm_Load(object sender, EventArgs e)
        {
            foreach(string temp in Enum.GetNames(typeof(ProductCategory)))
            {
                ProdCategory.Items.Add(temp);
            }
            // to do for the product category
            ProdCategory.Text = Enum.GetName(typeof(ProductCategory), ProductCategory.Undefined);
            
            if (this.ProdIdent.Visible)
            {
                this.ProdIdent.TextChanged += new System.EventHandler(this._setEnableOfConfirmButton);
            }
            if (this.ProdName.Visible)
            {
                this.ProdName.TextChanged += new System.EventHandler(this._setEnableOfConfirmButton);
            }
            if (this.ProdCategory.Visible)
            {
                this.ProdCategory.TextChanged += new System.EventHandler(this._setEnableOfConfirmButton);
            }
            
        }

        public static bool ShowDialogWinForm(ref string theName)
        {
            DialogWinForm theForm = new DialogWinForm();
            theForm.ProdIdent.Visible = false;
            theForm.ProdCategory.Visible = false;
            theForm.ProdIdent.Text = "None";
            theForm.ProdCategory.Text = "None";
            theForm.ShowDialog();
            bool theResult = false;
            if (theForm.DialogResult == DialogResult.OK)
            {
                
                theName = theForm.ProdName.Text;
               
                theResult = true;
            }
            else if (theForm.DialogResult == DialogResult.Cancel)
            {

            }
            theForm.Close();
            return theResult;
        }






        public static bool ShowDialogWinForm(ref string theIdent, ref string theName, ref ProductCategory theCategory)
        {
            //throw new NotImplementedException();
            DialogWinForm theForm = new DialogWinForm();
            theForm.ShowDialog();

            bool theResult = false;
            if (theForm.DialogResult == DialogResult.OK)
            {
                theIdent = theForm.ProdIdent.Text;
                theName = theForm.ProdName.Text;
                theCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), theForm.ProdCategory.Text);
                theResult = true;
            }
            else if (theForm.DialogResult == DialogResult.Cancel)
            {

            }
            theForm.Close();
            return theResult;
        }
    }
}
