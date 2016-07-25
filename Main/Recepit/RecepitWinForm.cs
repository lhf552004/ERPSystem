using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ERP.BLL;
using ERP.Model;
namespace ERP
{
    public partial class RecepitWinForm : Form
    {
        public RecepitWinForm()
        {
            InitializeComponent();
        }
        public static BLL.Receival bllReceival = new BLL.Receival();
        public static BLL.IngredientCompoent bllIngredientCompoent = new BLL.IngredientCompoent();
        public static BLL.Product bllProduct = new BLL.Product();
        private BLL.IngredientCompoentLog bllIngredientCompoentLog = new BLL.IngredientCompoentLog();
        //private SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
        //private SqlDataAdapter sad;
        private DataSet ds;
        private void _loadData()
        {
            try
            {
                string strWhere = "ReceivalState <> " + (int)ReceiveStateEnum.Finished;
                ds = bllReceival.GetList(strWhere);
                if (ds != null)
                {

                    RecepitGridView.DataSource = ds.Tables[0];
                    RecepitGridView.Columns["ReceivalState"].Visible = false;
                    RecepitGridView.Columns["CreationDate"].Visible = false;
                    RecepitGridView.Columns["FinishReceiptDate"].Visible = false;
                    RecepitGridView.Columns["auditState"].Visible = false;
                    RecepitGridView.Columns["Description"].Visible = false;

                }
                //if (connt.State == ConnectionState.Closed) { connt.Open(); }
                //string sql = "select Ident as 代码,Name as 名称,Category as 种类,Price as 价格 from Product group by Name,Ident,Category,Price order by Price";
                //sad = new SqlDataAdapter(sql, connt);
                //ds = new DataSet();
                //sad.Fill(ds, "sel");
                //ProductGridView.DataSource = ds.Tables["sel"];
            }
            catch (Exception err)
            {
                throw err;
            }
            

 
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //string theIdent = "";
            //string theName = "";
            //byte theCategory =0;
            
          

            try
            {
                ERP.Model.Receival newReceival =new ERP.Model.Receival();
                newReceival.auditState = AuditStateEnum.WaitAudit;
                newReceival.ReceivalState = ReceiveStateEnum.WaitReceive;
                newReceival.CreationDate = DateTime.Now;
                //newReceival.Operator;
                bllReceival.Add(newReceival);
                //if (DialogWinForm.ShowDialogWinForm(ref theIdent,ref theName,ref theCategory) == true)
                //{
                //    if (bllReceival.GetModel(theIdent) != null)
                //    {
                //        throw new Exception("物料代码已存在!");
                //    }
                //    else
                //    {
                //        Model.Product newProduct = new Model.Product();
                //        newProduct.Ident = theIdent;
                //        newProduct.Name = theName;
                //        newProduct.Price = 0;
                //        newProduct.Category = theCategory;
                //        newProduct.CreationDate = DateTime.Now;
                //        bllProduct.Add(newProduct);


 
                //    }
                //    //if (connt.State == ConnectionState.Closed) { connt.Open(); }
                //    //sel = "select count(*) from [ERPDatabase].[dbo].[Product] where [Ident] = '" + theIdent + "'";
                //    //SqlCommand cmd = new SqlCommand(sel, connt);
                //    //int theNum = int.Parse(cmd.ExecuteScalar().ToString());
                //    //if (theNum > 0)
                //    //{
                //    //    throw new Exception("物料代码已存在!");
                //    //}
                //    //else
                //    //{
                //    //    sel = "insert into [ERPDatabase].[dbo].[Product] ([Ident],[Name],[Category],[Price],[ModifyUser],[CreationDate]) values('" + theIdent + "','" + theName + "'," + theCategory +",0,'" + SearchStr.CurrentUser +"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                //    //    SqlCommand insertCmd = new SqlCommand(sel, connt);
                //    //    insertCmd.ExecuteNonQuery();
                //    //}
                //}
            }
            catch (Exception  err)
            {
                throw err;
            }

            _loadData();
        }

      
        ///// <summary>
        ///// get all field from the database
        ///// </summary>
        ///// <param name="theIdent"></param>
        ///// <returns></returns>
        //private DataRow _getCurrentRow(string theIdent)
        //{
        //    try
        //    {
        //        //string sql = "select [Ident],[Name],[Category],[Price],[Description],[ModifyUser],[CreationDate],[ModifyDate] from [ERPDatabase].[dbo].[Product] Where [Ident] = '" + theIdent + "'";
        //        //sad = new SqlDataAdapter(sql, connt);
        //        //ds = new DataSet();
        //        //sad.Fill(ds, "sel");
        //        //currentTable = ds.Tables["sel"];
        //        //if (currentTable != null)
        //        //{
        //        //    return currentTable.Rows[0];
        //        //}
        //        //else
        //        //{
        //        //    return null;
        //        //}

        //    }
        //    catch (SqlException e)
        //    {

        //        throw e;
        //    }
            
        //}
        //private DataTable currentTable;
        //private DataGridViewRow currentGridViewRow;
        private Model.Receival curReceival;
        private void _updateControlText(int theIndex)
        {
            try
            {

                int OID = int.Parse(RecepitGridView.Rows[theIndex].Cells[0].Value.ToString());
                curReceival = bllReceival.GetModel(OID);
                if (curReceival != null)
                {
                    ReceiptIdent.Text = curReceival.Ident;
                    ReceiptName.Text = curReceival.Name;
                   
                    ReceiptDescription.Text = curReceival.Description;
                    FinishReceiptDate.Text = curReceival.FinishReceiptDate.ToString();
                    CreationDate.Text = curReceival.CreationDate.ToString();
                    Auditor.Text = curReceival.Auditor;
                    Operator.Text = curReceival.Operator;

                    auditStateComBox.Text = Enum.GetName(typeof(AuditStateEnum), curReceival.auditState);
                    ReceivalStateComBox.Text = Enum.GetName(typeof(ReceiveStateEnum), curReceival.ReceivalState);
                    _loadIngrData();
                  
                }
                //if (currentGridViewRow == null)
                //{
                //    throw new Exception("the row is null");

                //}
                //else
                //{
                //    //get the data from the gridview directly
                //    ProdIdent.Text = currentGridViewRow.Cells[0].Value.ToString();
                //    ProdName.Text = currentGridViewRow.Cells[1].Value.ToString();
                //    ProdCategory.Text = Enum.GetName(typeof(ProductCategory), int.Parse(currentGridViewRow.Cells[2].Value.ToString()));
                //    ProdPrice.Text = currentGridViewRow.Cells[3].Value.ToString();
                //    // update other control
                //    DataRow currentRow = _getCurrentRow(ProdIdent.Text);
                //    ProdDescription.Text = currentRow[4].ToString();
                //    ModifyUser.Text = currentRow[5].ToString();
                //    CreationDate.Text = currentRow[6].ToString();
                //    ModifyDate.Text = currentRow[7].ToString();

                //}
            }
            catch (Exception e)
            {
                throw e;
            }

            
           
            
        }

        private int currentIndex; 
       

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (curReceival != null)
                {
                    //bllReceival.Clone(curReceival);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
            //if (connt.State == ConnectionState.Closed) { connt.Open(); }

            //string sel = "insert into [ERPDatabase].[dbo].[Product] ([Ident],[Name],[Category],[Price],[ModifyUser],[CreationDate]) values('" + ProdIdent.Text.Trim() + "-1','" + ProdName.Text.Trim() + "'," + (byte)(ProductCategory)Enum.Parse(typeof(ProductCategory),ProdCategory.Text) + ",0,'" + SearchStr.CurrentUser + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            //SqlCommand insertCmd = new SqlCommand(sel, connt);
            //insertCmd.ExecuteNonQuery();
            //_loadData();
            //_updateControlText(currentIndex);

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (curReceival != null)
                {
                    bllReceival.Delete(curReceival.OID);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (curReceival != null)
            {
                //curReceival.Ident = ReceiptIdent.Text;
                bllReceival.Update(curReceival);
                ModifyButton.Enabled = false;
            }
        }

        private void ProdName_TextChanged(object sender, EventArgs e)
        {
            if (curReceival.Name != ReceiptName.Text)
            {
                curReceival.Name = ReceiptName.Text;
                ModifyButton.Enabled = true;
            }
        }

        private void ProdDescription_TextChanged(object sender, EventArgs e)
        {
            if (curReceival.Description != ReceiptDescription.Text)
            {
                curReceival.Description = ReceiptDescription.Text;
                ModifyButton.Enabled = true;
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void RecepitGridView_CursorChanged(object sender, EventArgs e)
        {
            currentIndex = RecepitGridView.CurrentRow.Index ;
            _updateControlText(currentIndex);
        }
        private ERP.BLL.Statistics bllStatistics = new ERP.BLL.Statistics();
        private void ReceiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ERP.Model.IngredientCompoent  curIngr in bllReceival.GetAllIngredientCompoentModels(curReceival))
                {
                    ERP.Model.Product curProduct = curIngr.Product as ERP.Model.Product;
                    if (curProduct!=null)
                    {
                        ERP.Model.Statistics curStatistics = bllStatistics.GetModelByProduct(curIngr.Product.OID);
                        curStatistics.Number += curIngr.Num;
                        bllStatistics.Update(curStatistics);

                        ERP.Model.IngredientCompoentLog newIngrLog = new ERP.Model.IngredientCompoentLog();
                        newIngrLog.ProductIdent = curProduct.Ident;
                        newIngrLog.Ingr_OIDText = curIngr.OID.ToString();
                        newIngrLog.IngredientCategory = curIngr.IngredientCategory;
                        newIngrLog.Num = curIngr.Num;
                        bllIngredientCompoentLog.Add(newIngrLog);

                    }
                   
                    //newIngrLog.ProductIdent=
                }
                curReceival.ReceivalState = ReceiveStateEnum.Finished;
                curReceival.FinishReceiptDate = DateTime.Now;
                curReceival.Operator = Program.CurrentUser.Name;
                bllReceival.Update(curReceival);
                _loadData();
               

            }
            catch(Exception ex)
            {
                curReceival.ReceivalState = ReceiveStateEnum.Undefined;
                bllReceival.Update(curReceival);
                MessageBox.Show(ex.Message);
            }
            _loadData();
        }

        private void AddIngre_Click(object sender, EventArgs e)
        {
            if (curReceival!=null)
            {
                ERP.Model.IngredientCompoent newIngr = new ERP.Model.IngredientCompoent();
                newIngr.IngredientCategory = (int)IngredientCategoryEnum.ReceiveComp;
                newIngr.Receival = curReceival;
                bllIngredientCompoent.Add(newIngr);
                _loadIngrData();
            }
            


        }
        private int currentIngrIndex;
        private void RemoveIngre_Click(object sender, EventArgs e)
        {
            //currentIngrIndex = IngreListGridView.CurrentRow.Index;
            //int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());\
            if (_curIngredientCompoent!=null)
            {
                bllIngredientCompoent.Delete(_curIngredientCompoent.OID);
                _loadIngrData();
            }
            
        }

        private void RecepitWinForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string curState in Enum.GetNames(typeof(AuditStateEnum)))
                {
                    auditStateComBox.Items.Add(curState);
                }
                foreach (string curState in Enum.GetNames(typeof(AuditStateEnum)))
                {
                    ReceivalStateComBox.Items.Add(curState);
                }
                foreach(DataRow  curRow in bllProduct.GetAllList().Tables[0].Rows)
                {
                    SelectedProduct.Items.Add(curRow[2].ToString().Trim() + "," + curRow[3].ToString().Trim());
                }
                _loadData();
                _enableButton();
                if (RecepitGridView.Rows.Count >1)
                {
                    _updateControlText(0);
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            //string className = typeof(ERP.BLL.Receival).Name;
        }

        /// <summary>
        /// set audit button about current user
        /// </summary>
        private void _enableButton()
        {

            if (Program.CurrentUser != null)
            {
                if (Program.CurrentUser.Level >= 5)
                {
                    AuditButton.Enabled = true;
                }
                else
                {
                    AuditButton.Enabled = false;
                }
                if (curReceival!=null)
                {
                    if (curReceival.auditState == AuditStateEnum.Audited)
                    {
                        ReceiveButton.Enabled = true;
                    }
                    else
                    {
                        ReceiveButton.Enabled = false;
                    }
                }
            }
            else
            {
                
                this.Close();
            }
        }
        /// <summary>
        /// set the enable status of ingredient button
        /// </summary>
        /// <param name="enable"></param>
        private void _enableIngrButton(bool enable)
        {
            if (enable)
            {
                AddIngre.Enabled = RemoveIngre.Enabled = true;
                ConfirmButton.Enabled = false;
            }
            else
            {
                AddIngre.Enabled = RemoveIngre.Enabled =false;
                ConfirmButton.Enabled = true;
               
            }
        }
        private void SelectedProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            _enableIngrButton(false);
        }

        private void ProdNum_TextChanged(object sender, EventArgs e)
        {
            _enableIngrButton(false);
        }
        /// <summary>
        /// current ingredient
        /// </summary>
        private ERP.Model.IngredientCompoent _curIngredientCompoent = null;
        /// <summary>
        /// the selected product
        /// </summary>
        private ERP.Model.Product _selectedProduct = null;
        /// <summary>
        /// 
        /// </summary>
        private int _num = 0;

        /// <summary>
        /// update the ingredient data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
           
            _enableIngrButton(true);
            currentIngrIndex = IngreListGridView.CurrentRow.Index;
            int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());
            _curIngredientCompoent = bllIngredientCompoent.GetModel(OID);
            if (_curIngredientCompoent != null)
            {
                string _NewProdIdent = null;
                if (SelectedProduct.Text == "" && ProdNum.Text == "")
                {
                    MessageBox.Show("没有需要更新");
                    return;
                }
                else
                {
                    if (SelectedProduct.Text != "")
                    {
                        _NewProdIdent = SelectedProduct.Text.Split(new char[] { ',' })[0].Trim();
                        _selectedProduct = bllProduct.GetModel(_NewProdIdent);
                        if (_selectedProduct != null)
                        {
                            _curIngredientCompoent.Product = _selectedProduct;
                        }
                    }
                    if (ProdNum.Text != "")
                    {

                        if (int.TryParse(ProdNum.Text, out _num))
                        {
                            _curIngredientCompoent.Num = _num;
                        }
                        else
                        {
                            MessageBox.Show("不是数量字符！");
                            return;
                        }
                    }
                    bllIngredientCompoent.Update(_curIngredientCompoent);
                    _loadIngrData();
                    ConfirmButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("没有获得当前组份");
            }
            
            
        }
        /// <summary>
        /// fresh the ingrident list
        /// </summary>
        private void _loadIngrData()
        {
            if (curReceival!=null)
            {
                IngreListGridView.DataSource = bllReceival.GetAllIngredientCompoents(curReceival).Tables[0];
                IngreListGridView.Columns["Dis_OID"].Visible = false;
                IngreListGridView.Columns["Rec_OID"].Visible = false;
                IngreListGridView.Columns["IngredientCategory"].Visible = false;
                if (IngreListGridView.Rows.Count == 1)
                {
                    SelectedProduct.Enabled = ProdNum.Enabled = false;

                }
                else
                {
                    SelectedProduct.Enabled = ProdNum.Enabled = true;
                }
            }
           
      
        }

        private void IngreListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIngrIndex = e.RowIndex;
            int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());
            _curIngredientCompoent = bllIngredientCompoent.GetModel(OID);

        }

        private void RecepitGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            _updateControlText(currentIndex);
        }

        private void AuditButton_Click(object sender, EventArgs e)
        {
            if (_checkReceival())
            {
                curReceival.auditState = AuditStateEnum.Audited;
                curReceival.Auditor = Program.CurrentUser.Name;
                bllReceival.Update(curReceival);
                
            }
        }

        private bool _checkReceival()
        {
            bool flag = true;
            if (curReceival != null)
            {
                foreach (ERP.Model.IngredientCompoent curIngr in bllReceival.GetAllIngredientCompoentModels(curReceival))
                {
                    if (curIngr.Product == null || curIngr.Num == null)
                    {
                        flag = false;
                        MessageBox.Show("物料信息不全");
                    }
                    else if (curIngr.Num != null)
                    {
                        if (curIngr.Num ==0)
                        {
                            flag = false;
                            MessageBox.Show("数量不能为0！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("没有添加物料列表");
                        flag = false;
                    }
                }
                //if (bllReceival.GetAllIngredientCompoentModels(curReceival).Count>0)
                //{
                //    foreach (DataRow curRow in bllReceival.GetAllIngredientCompoents(curReceival).Tables[0].Rows)
                //    {
                //        if (curRow[1]==null||curRow[5]==null)
                //        {
                //            flag = false;
                //            MessageBox.Show("物料信息不全");
                            
                            
                //        }
                //        else if (curRow[5]!=null)
                //        {
                //            if (curRow[5].ToString() =="0")
                //            {
                //                flag = false;
                //                MessageBox.Show("数量不能为0！");
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("没有添加物料列表");
                //    flag = false;
                //}
            }
            else
            {
                MessageBox.Show("出现异常！");
                flag = false;
            }
            return flag;
        }

        private void ReceiptName_Enter(object sender, EventArgs e)
        {
            if (curReceival.Name!= ReceiptName.Text)
            {
                curReceival.Name = ReceiptName.Text;
                ModifyButton.Enabled = true;
            }
           
        }

        private void ReceiptDescription_Enter(object sender, EventArgs e)
        {
            if (curReceival.Description != ReceiptDescription.Text)
            {
                curReceival.Description = ReceiptDescription.Text;
                ModifyButton.Enabled = true;
            }
          
        }

        private void RecepitGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                currentIndex = RecepitGridView.CurrentRow.Index;
                _updateControlText(currentIndex);
            }
        }

       
       
       

       
       
    }
}
