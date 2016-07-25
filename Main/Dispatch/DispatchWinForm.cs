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
    public partial class DispatchWinForm : Form
    {
        public DispatchWinForm()
        {
            InitializeComponent();
        }
        private BLL.Dispatch bllDispatch = new BLL.Dispatch();
        private BLL.IngredientCompoent bllIngredientCompoent = new BLL.IngredientCompoent();
        private BLL.Product bllProduct = new BLL.Product();
        private BLL.IngredientCompoentLog bllIngredientCompoentLog = new BLL.IngredientCompoentLog();
        private BLL.Agent bllAgent = new BLL.Agent();
        private BLL.ExpectReceiptAccount bllExpectReceiptAccount = new ERP.BLL.ExpectReceiptAccount();
        //private SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
        //private SqlDataAdapter sad;
        private DataSet ds;
        private void _loadData()
        {
            try
            {
                string strWhere = "DispatchState <> " + (int)DispatchStateEnum.Dispatched;
                ds = bllDispatch.GetList(strWhere);
                ds.Tables[0].Columns.Add("Agent");
                ds.Tables[0].Columns.Add("Audit_State");
                ds.Tables[0].Columns.Add("Dispatch_State");
                //ds.Tables[0].Columns["auditState"].DataType = System.Type.GetType("System.String"); 
                //ds.Tables[0].Columns["DispatchState"].DataType = System.Type.GetType("System.String"); 
                foreach (DataRow curRow in ds.Tables[0].Rows)
	            {
                    if (curRow["Age_OID"].ToString()!= "")
                    {
                        int Agent_OID = int.Parse(curRow["Age_OID"].ToString());
                        ERP.Model.Agent curAgent = bllAgent.GetModel(Agent_OID);
                        curRow["Agent"] = curAgent.Name;
                    }
                    //AuditStateEnum curAuditState = (AuditStateEnum)Enum.Parse(typeof(AuditStateEnum), curRow["auditState"].ToString());
                    //DispatchStateEnum curDispatchState = (DispatchStateEnum)Enum.Parse(typeof(DispatchStateEnum), curRow["DispatchState"].ToString());
                    //Type theType= curRow["auditState"].GetType();
                    curRow["Audit_State"] = Enum.GetName(typeof(AuditStateEnum), int.Parse(curRow["auditState"].ToString()));
                    curRow["Dispatch_State"] = Enum.GetName(typeof(DispatchStateEnum), int.Parse(curRow["DispatchState"].ToString()));
                   
                    
                }

                //ds.Tables[0].Columns.Remove("Age_OID");

                if(ds != null)
                {
                    DispatchGridView.DataSource = ds.Tables[0];
                    DispatchGridView.Columns["Age_OID"].Visible = false;
                    DispatchGridView.Columns["CreationDate"].Visible = false;
                    DispatchGridView.Columns["Description"].Visible = false;
                    DispatchGridView.Columns["ModifyUser"].Visible = false;
                    DispatchGridView.Columns["Auditor"].Visible = false;
                    DispatchGridView.Columns["Operator"].Visible = false;
                    DispatchGridView.Columns["Ident"].Visible = false;
                    DispatchGridView.Columns["DispatchDate"].Visible = false;
                    DispatchGridView.Columns["auditState"].Visible = false;
                    DispatchGridView.Columns["DispatchState"].Visible = false;

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
                MessageBox.Show(err.Message, this.Name);
            }
            

 
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //string theIdent = "";
            //string theName = "";
            //byte theCategory =0;
            
          

            try
            {
                ERP.Model.Dispatch newDispatch = new ERP.Model.Dispatch();
                newDispatch.auditState = AuditStateEnum.WaitAudit;
                newDispatch.DispatchState = DispatchStateEnum.WaitDispatch;
                newDispatch.CreationDate = DateTime.Now;
                newDispatch.Price = 0;
                //newDispatch.Operator;
                bllDispatch.Add(newDispatch);
                //if (DialogWinForm.ShowDialogWinForm(ref theIdent,ref theName,ref theCategory) == true)
                //{
                //    if (bllDispatch.GetModel(theIdent) != null)
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
                MessageBox.Show(err.Message, e.ToString());
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
        private Model.Dispatch curDispatch;
        private void _updateControlText(int theIndex)
        {
            try
            {

                int OID = int.Parse(DispatchGridView.Rows[theIndex].Cells[0].Value.ToString());
                curDispatch = bllDispatch.GetModel(OID);
                if (curDispatch != null)
                {
                    IdentText.Text = curDispatch.Ident;
                    //ReceiptName.Text = curDispatch.Name;

                    DispatchDescriptionText.Text = curDispatch.Description;
                    DispatchDateText.Text = curDispatch.DispatchDate.ToString();
                    CreationDateText.Text = curDispatch.CreationDate.ToString();
                    AuditorText.Text = curDispatch.Auditor;
                    OperatorText.Text = curDispatch.Operator;
                    DispatchtotalPriceText.Text = curDispatch.Price.ToString();
                    AuditStateComBox.Text = Enum.GetName(typeof(AuditStateEnum), curDispatch.auditState);
                    DispatchStateComBox.Text = Enum.GetName(typeof(DispatchStateEnum), curDispatch.DispatchState);
                    if (curDispatch.Agent != null)
                    {
                        AgentComboBox.Text = curDispatch.Agent.Ident.Trim() + "," + curDispatch.Agent.Name.Trim(); ;
                    }
                    else
                    {
                        AgentComboBox.Text = "";
                    }
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
                MessageBox.Show(e.Message);
            }

            
           
            
        }

        private int currentIndex; 
       

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (curDispatch != null)
                {
                    //bllDispatch.Clone(curDispatch);
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
                if (curDispatch != null)
                {
                    bllDispatch.Delete(curDispatch.OID);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
           
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (curDispatch != null)
            {
                //curDispatch.Ident = ReceiptIdent.Text;
                bllDispatch.Update(curDispatch);
                ModifyButton.Enabled = false;
                _loadData();
                currentIndex = DispatchGridView.CurrentRow.Index;
                _updateControlText(currentIndex);
            }
        }

       

        private void ProdDescription_TextChanged(object sender, EventArgs e)
        {
            if (curDispatch.Description != DispatchDescriptionText.Text)
            {
                curDispatch.Description = DispatchDescriptionText.Text;
                ModifyButton.Enabled = true;
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

       
        private ERP.BLL.Statistics bllStatistics = new ERP.BLL.Statistics();
        private void DispatchButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalPrice = 0;
                foreach (ERP.Model.IngredientCompoent  curIngr in bllDispatch.GetAllIngredientCompoentModels(curDispatch))
                {
                    ERP.Model.Product curProduct = curIngr.Product as ERP.Model.Product;
                    if (curProduct!=null)
                    {
                        // update the data of statistics
                        ERP.Model.Statistics curStatistics = bllStatistics.GetModelByProduct(curIngr.Product.OID);
                        curStatistics.Number -= curIngr.Num;
                        bllStatistics.Update(curStatistics);

                        //caculate the price
                        totalPrice =curProduct.Price * curIngr.Num;

                        //generate ingredient log
                        ERP.Model.IngredientCompoentLog newIngrLog = new ERP.Model.IngredientCompoentLog();
                        newIngrLog.ProductIdent = curProduct.Ident;
                        newIngrLog.Ingr_OIDText = curIngr.OID.ToString();
                        newIngrLog.IngredientCategory = curIngr.IngredientCategory;
                        newIngrLog.Num = curIngr.Num;
                        bllIngredientCompoentLog.Add(newIngrLog);

                    }
                   
                    //newIngrLog.ProductIdent=
                }
                curDispatch.DispatchState = DispatchStateEnum.Dispatched;
                curDispatch.DispatchDate = DateTime.Now;
                curDispatch.Operator = Program.CurrentUser.Name;
                curDispatch.Price = totalPrice;
                bllDispatch.Update(curDispatch);

                //create relative ExpectReceiptAccount
                ERP.Model.ExpectReceiptAccount newExpectReceiptAccount = new ERP.Model.ExpectReceiptAccount();
                newExpectReceiptAccount.Dispatch = curDispatch;
                newExpectReceiptAccount.CreationDate = DateTime.Now;
                newExpectReceiptAccount.Amount = curDispatch.Price;
                newExpectReceiptAccount.Lender = curDispatch.Agent.Name;
                newExpectReceiptAccount.Operator = Program.CurrentUser.Name;
                bllExpectReceiptAccount.Add(newExpectReceiptAccount);
               

            }
            catch(Exception ex)
            {
                curDispatch.DispatchState = DispatchStateEnum.Undefined;
                bllDispatch.Update(curDispatch);
                MessageBox.Show(ex.Message);
            }
            _loadData();
            currentIndex = DispatchGridView.CurrentRow.Index;
            _updateControlText(currentIndex);
        }

        private void AddIngre_Click(object sender, EventArgs e)
        {
            try
            {
                if (curDispatch != null)
                {
                    ERP.Model.IngredientCompoent newIngr = new ERP.Model.IngredientCompoent();
                    newIngr.IngredientCategory = IngredientCategoryEnum.DispatchComp;
                    newIngr.Dispatch = curDispatch;
                    bllIngredientCompoent.Add(newIngr);
                    _loadIngrData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
          
        }

        private int currentIngrIndex;
        private void RemoveIngre_Click(object sender, EventArgs e)
        {
            //currentIngrIndex = IngreListGridView.CurrentRow.Index;
            //int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());\
            try
            {
                if (_curIngredientCompoent != null)
                {
                    bllIngredientCompoent.Delete(_curIngredientCompoent.OID);
                    _loadIngrData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
          
            
        }

        private void DispatchWinForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string curState in Enum.GetNames(typeof(AuditStateEnum)))
                {
                    AuditStateComBox.Items.Add(curState);
                }
                foreach (string curState in Enum.GetNames(typeof(DispatchStateEnum)))
                {
                    DispatchStateComBox.Items.Add(curState);
                }
                foreach(DataRow  curRow in bllProduct.GetAllList().Tables[0].Rows)
                {
                    SelectedProductComBox.Items.Add(curRow[2].ToString().Trim() + "," + curRow[3].ToString().Trim());
                }
                foreach (DataRow  curRow in bllAgent.GetAllList().Tables[0].Rows)
                {
                    AgentComboBox.Items.Add(curRow[1].ToString().Trim() + "," + curRow[3].ToString().Trim());
                }
                _loadData();
               
                if (DispatchGridView.Rows.Count >0)
                {
                    _updateControlText(0);
                }
                _enableButton();
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
            try
            {
                if (Program.CurrentUser != null)
                {
                    if (Program.CurrentUser.Level >= 5 && curDispatch!= null )
                    {
                        AuditButton.Enabled = true;
                    }
                    else
                    {
                        AuditButton.Enabled = false;
                    }
                    if (curDispatch != null)
                    {
                        if (curDispatch.auditState == AuditStateEnum.Audited)
                        {
                            DispatchButton.Enabled = true;
                        }
                        else
                        {
                            DispatchButton.Enabled = false;
                        }
                    }
                    else
                    {
                        DispatchButton.Enabled = false;
                        AuditButton.Enabled = false;
                        DispatchDescriptionText.Enabled = false;
                        AgentComboBox.Enabled = false;
                    }
                }
                else
                {

                    this.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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
                AddIngreButton.Enabled = RemoveIngreButton.Enabled = true;
                ConfirmButton.Enabled = false;
            }
            else
            {
                AddIngreButton.Enabled = RemoveIngreButton.Enabled =false;
                ConfirmButton.Enabled = true;
               
            }
        }
        private void SelectedProduct_SelectedIndexChanged(object sender, EventArgs e)
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
                if (SelectedProductComBox.Text == "" && ProdNumText.Text == "")
                {
                    MessageBox.Show("没有需要更新");
                    return;
                }
                else
                {
                    if (SelectedProductComBox.Text != "")
                    {
                        _NewProdIdent = SelectedProductComBox.Text.Split(new char[] { ',' })[0].Trim();
                        _selectedProduct = bllProduct.GetModel(_NewProdIdent);
                        if (_selectedProduct != null)
                        {
                            _curIngredientCompoent.Product = _selectedProduct;
                        }
                    }
                    if (ProdNumText.Text != "")
                    {

                        if (int.TryParse(ProdNumText.Text, out _num))
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
            try
            {
                if (curDispatch != null)
                {
                    IngreListGridView.DataSource = bllDispatch.GetAllIngredientCompoents(curDispatch).Tables[0];
                    IngreListGridView.Columns["Dis_OID"].Visible = false;
                    IngreListGridView.Columns["Rec_OID"].Visible = false;
                    IngreListGridView.Columns["IngredientCategory"].Visible = false;
                    if (IngreListGridView.Rows.Count == 0)
                    {
                        SelectedProductComBox.Enabled = ProdNumText.Enabled = false;

                    }
                    else
                    {
                        SelectedProductComBox.Enabled = ProdNumText.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
      
        }

        private void IngreListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentIngrIndex = e.RowIndex;
                int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());
                _curIngredientCompoent = bllIngredientCompoent.GetModel(OID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
       
        }

        private void RecepitGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentIndex = e.RowIndex;
                _updateControlText(currentIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
          
        }

        private void AuditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_checkDispatch())
                {
                    curDispatch.auditState = AuditStateEnum.Audited;
                    curDispatch.Auditor = Program.CurrentUser.Name;
                    bllDispatch.Update(curDispatch);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
            
        }

        private bool _checkDispatch()
        {
            bool flag = true;
            if (curDispatch != null)
            {
                foreach (ERP.Model.IngredientCompoent curIngr in bllDispatch.GetAllIngredientCompoentModels(curDispatch))
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
                if (curDispatch.Agent == null)
                {
                    MessageBox.Show("请选择代理商");
                }
                //if (bllDispatch.GetAllIngredientCompoentModels(curDispatch).Count>0)
                //{
                //    foreach (DataRow curRow in bllDispatch.GetAllIngredientCompoents(curDispatch).Tables[0].Rows)
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

      

        private void ReceiptDescription_Enter(object sender, EventArgs e)
        {
            try
            {
                if (curDispatch.Description != DispatchDescriptionText.Text)
                {
                    curDispatch.Description = DispatchDescriptionText.Text;
                    ModifyButton.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
          
          
        }

        private void RecepitGridView_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    currentIndex = DispatchGridView.CurrentRow.Index;
                    _updateControlText(currentIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
           
        }

        private void AgentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bool needChange = false;
                string Ident = AgentComboBox.Text.Split(new char[] { ',' })[0].Trim();
                if (curDispatch.Agent == null)
                {
                    needChange = true;
                }
                else if (curDispatch.Agent.Ident.Trim() != Ident)
                {
                    needChange = true;
                }
                if (needChange)
                {
                    ERP.Model.Agent theAgent = bllAgent.GetModel(Ident);
                    if (theAgent != null)
                    {
                        curDispatch.Agent = theAgent;
                    }
                    ModifyButton.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
           

        }

       
       
       

       
       
    }
}
