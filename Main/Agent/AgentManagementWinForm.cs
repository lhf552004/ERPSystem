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
    public partial class AgentManagementWinForm : Form
    {
        public AgentManagementWinForm()
        {
            InitializeComponent();
        }
        //private BLL.Dispatch bllAgent = new BLL.Dispatch();
        //private BLL.Agent bllAgent = new BLL.Agent();
        private BLL.IngredientCompoent bllIngredientCompoent = new BLL.IngredientCompoent();
        private BLL.Product bllProduct = new BLL.Product();
        private BLL.IngredientCompoentLog bllIngredientCompoentLog = new BLL.IngredientCompoentLog();
        private BLL.Agent bllAgent = new BLL.Agent();
        //private SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
        //private SqlDataAdapter sad;
        private DataSet ds;
        private void _loadData()
        {
            try
            {
                //string strWhere = "DispatchState <> " + (int)DispatchStateEnum.Dispatched;
                ds = bllAgent.GetAllList();
                //ds.Tables[0].Columns.Add("Agent");
                //foreach (DataRow curRow in ds.Tables[0].Rows)
                //{
                //    int Agent_OID = int.Parse(curRow["Age_OID"].ToString());
                //    ERP.Model.Agent curAgent = bllAgent.GetModel(Agent_OID);
                //    curRow["Agent"]=curAgent.Name;
                    
                //}
                //ds.Tables[0].Columns.Remove("Age_OID");

                if(ds != null)
                {
                    AgentGridView.DataSource = ds.Tables[0];
                    AgentGridView.Columns["Address"].Visible = false;
                   
                    AgentGridView.Columns["Description"].Visible = false;
                    AgentGridView.Columns["ModifyUser"].Visible = false;
                  


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
            string theName = "";
            //byte theCategory =0;
            
          

            try
            {
                if (DialogWinForm.ShowDialogWinForm(ref theName) == true)
                {
                    ERP.Model.Agent newAgent = new ERP.Model.Agent();
                    newAgent.Name = theName;
                    bllAgent.Add(newAgent);
                }
               
                
                //newDispatch.Operator;
                //bllAgent.Add(newDispatch);
                //if (DialogWinForm.ShowDialogWinForm(ref theIdent,ref theName,ref theCategory) == true)
                //{
                //    if (bllAgent.GetModel(theIdent) != null)
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
            int currentIndex = AgentGridView.CurrentRow.Index;
            _updateControlText(currentIndex);
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
        private Model.Agent curAgent;
        private void _updateControlText(int theIndex)
        {
            try
            {

                int OID = int.Parse(AgentGridView.Rows[theIndex].Cells[0].Value.ToString());
                curAgent = bllAgent.GetModel(OID);
                if (curAgent != null)
                {
                    IdentText.Text = curAgent.Ident;
                    //ReceiptName.Text = curAgent.Name;
                    NameText.Text = curAgent.Name;
                    AddressText.Text = curAgent.Address;
                    DescriptionText.Text = curAgent.Description;
                    //FinishReceiptDate.Text = curAgent.DispatchDate.ToString();
                    //CreationDate.Text = curAgent.CreationDate.ToString();
                    //Auditor.Text = curAgent.Auditor;
                    //Operator.Text = curAgent.Operator;
                    LevelComboBox.Text = Enum.GetName(typeof(AgentLevelEnum), curAgent.AgentLevel);
                    ModifyUserText.Text = curAgent.ModifyUser;
                    //auditStateComBox.Text = Enum.GetName(typeof(AuditState), curAgent.auditState);
                    //DispatchStateComBox.Text = Enum.GetName(typeof(DispatchStateEnum), curAgent.DispatchState);
                    //_loadIngrData();
                  
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
                if (curAgent != null)
                {
                    //bllAgent.Clone(curAgent);
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
                if (curAgent != null)
                {
                    bllAgent.Delete(curAgent.OID);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
           
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (curAgent != null)
            {
                //curAgent.Ident = ReceiptIdent.Text;
                bllAgent.Update(curAgent);
                ModifyButton.Enabled = false;
            }
        }

       

        private void ProdDescription_TextChanged(object sender, EventArgs e)
        {
            if (curAgent.Description != DescriptionText.Text)
            {
                curAgent.Description = DescriptionText.Text;
                ModifyButton.Enabled = true;
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

       
        private ERP.BLL.Statistics bllStatistics = new ERP.BLL.Statistics();
        //private void DispatchButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        foreach (ERP.Model.IngredientCompoent  curIngr in bllAgent.GetAllIngredientCompoentModels(curAgent))
        //        {
        //            ERP.Model.Product curProduct = curIngr.Product as ERP.Model.Product;
        //            if (curProduct!=null)
        //            {
        //                // update the data of statistics
        //                ERP.Model.Statistics curStatistics = bllStatistics.GetModelByProduct(curIngr.Product.OID);
        //                curStatistics.Number += curIngr.Num;
        //                bllStatistics.Update(curStatistics);

        //                //generate ingredient log
        //                ERP.Model.IngredientCompoentLog newIngrLog = new ERP.Model.IngredientCompoentLog();
        //                newIngrLog.ProductIdent = curProduct.Ident;
        //                newIngrLog.Ingr_OIDText = curIngr.OID.ToString();
        //                newIngrLog.IngredientCategory = curIngr.IngredientCategory;
        //                newIngrLog.Num = curIngr.Num;
        //                bllIngredientCompoentLog.Add(newIngrLog);

        //            }
                   
        //            //newIngrLog.ProductIdent=
        //        }
        //        curAgent.DispatchState = DispatchStateEnum.Dispatched;
        //        curAgent.DispatchDate = DateTime.Now;
        //        curAgent.Operator = Program.CurrentUser.Name;
        //        bllAgent.Update(curAgent);
        //        _loadData();
               

        //    }
        //    catch(Exception ex)
        //    {
        //        curAgent.DispatchState = DispatchStateEnum.Undefined;
        //        bllAgent.Update(curAgent);
        //        MessageBox.Show(ex.Message);
        //    }
        //    _loadData();
        //}

        //private void AddIngre_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (curAgent != null)
        //        {
        //            ERP.Model.IngredientCompoent newIngr = new ERP.Model.IngredientCompoent();
        //            newIngr.IngredientCategory = IngredientCategoryEnum.DispatchComp;
        //            newIngr.Dispatch = curAgent;
        //            bllIngredientCompoent.Add(newIngr);
        //            //_loadIngrData();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, e.ToString());
        //    }
          
        //}

        //private int currentIngrIndex;
        //private void RemoveIngre_Click(object sender, EventArgs e)
        //{
        //    //currentIngrIndex = IngreListGridView.CurrentRow.Index;
        //    //int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());\
        //    try
        //    {
        //        if (_curIngredientCompoent != null)
        //        {
        //            bllIngredientCompoent.Delete(_curIngredientCompoent.OID);
        //            _loadIngrData();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, e.ToString());
        //    }
          
            
        //}

        private void DispatchWinForm_Load(object sender, EventArgs e)
        {
            try
            {
                //foreach (string curState in Enum.GetNames(typeof(AuditState)))
                //{
                //    auditStateComBox.Items.Add(curState);
                //}
                //foreach (string curState in Enum.GetNames(typeof(DispatchStateEnum)))
                //{
                //    DispatchStateComBox.Items.Add(curState);
                //}
                //foreach(DataRow  curRow in bllProduct.GetAllList().Tables[0].Rows)
                //{
                //    SelectedProduct.Items.Add(curRow[2].ToString().Trim() + "," + curRow[3].ToString().Trim());
                //}
               
                _loadData();
                _enableButton();
                if (AgentGridView.Rows.Count >0)
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
            try
            {
                if (Program.CurrentUser != null)
                {
                    
                    if (curAgent != null)
                    {
                        ModifyButton.Enabled = true;
                        NameText.Enabled = true;
                        DescriptionText.Enabled = true;
                        AddressText.Enabled = true;
                        LevelComboBox.Enabled = true;
                      
                    }
                    else
                    {
                        ModifyButton.Enabled = false;
                        NameText.Enabled = false;
                        DescriptionText.Enabled = false;
                        AddressText.Enabled = false;
                        LevelComboBox.Enabled = false;
                    }
                    // enable the modify button
                    if (Program.CurrentUser.Level >= 5)
                    {
                        //AuditButton.Enabled = true;
                        ModifyButton.Enabled = true;
                    }
                    else
                    {
                        //AuditButton.Enabled = false;
                        ModifyButton.Enabled = false;
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
        ///// <summary>
        ///// set the enable status of ingredient button
        ///// </summary>
        ///// <param name="enable"></param>
        //private void _enableIngrButton(bool enable)
        //{
        //    if (enable)
        //    {
        //        AddIngre.Enabled = RemoveIngre.Enabled = true;
        //        ConfirmButton.Enabled = false;
        //    }
        //    else
        //    {
        //        AddIngre.Enabled = RemoveIngre.Enabled =false;
        //        ConfirmButton.Enabled = true;
               
        //    }
        //}
        //private void SelectedProduct_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _enableIngrButton(false);
        //}

      
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

        ///// <summary>
        ///// update the ingredient data
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void ConfirmButton_Click(object sender, EventArgs e)
        //{
           
        //    _enableIngrButton(true);
        //    currentIngrIndex = IngreListGridView.CurrentRow.Index;
        //    int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());
        //    _curIngredientCompoent = bllIngredientCompoent.GetModel(OID);
        //    if (_curIngredientCompoent != null)
        //    {
        //        string _NewProdIdent = null;
        //        if (SelectedProduct.Text == "" && ProdNum.Text == "")
        //        {
        //            MessageBox.Show("没有需要更新");
        //            return;
        //        }
        //        else
        //        {
        //            if (SelectedProduct.Text != "")
        //            {
        //                _NewProdIdent = SelectedProduct.Text.Split(new char[] { ',' })[0].Trim();
        //                _selectedProduct = bllProduct.GetModel(_NewProdIdent);
        //                if (_selectedProduct != null)
        //                {
        //                    _curIngredientCompoent.Product = _selectedProduct;
        //                }
        //            }
        //            if (ProdNum.Text != "")
        //            {

        //                if (int.TryParse(ProdNum.Text, out _num))
        //                {
        //                    _curIngredientCompoent.Num = _num;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("不是数量字符！");
        //                    return;
        //                }
        //            }
        //            bllIngredientCompoent.Update(_curIngredientCompoent);
        //            _loadIngrData();
        //            ConfirmButton.Enabled = false;
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("没有获得当前组份");
        //    }
            
            
        //}
        ///// <summary>
        ///// fresh the ingrident list
        ///// </summary>
        //private void _loadIngrData()
        //{
        //    try
        //    {
        //        if (curAgent != null)
        //        {
        //            IngreListGridView.DataSource = bllAgent.GetAllIngredientCompoents(curAgent).Tables[0];
        //            IngreListGridView.Columns["Dis_OID"].Visible = false;
        //            IngreListGridView.Columns["Rec_OID"].Visible = false;
        //            IngreListGridView.Columns["IngredientCategory"].Visible = false;
        //            if (IngreListGridView.Rows.Count == 1)
        //            {
        //                SelectedProduct.Enabled = ProdNum.Enabled = false;

        //            }
        //            else
        //            {
        //                SelectedProduct.Enabled = ProdNum.Enabled = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
           
           
      
        //}

        //private void IngreListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        currentIngrIndex = e.RowIndex;
        //        int OID = int.Parse(IngreListGridView.Rows[currentIngrIndex].Cells[0].Value.ToString());
        //        _curIngredientCompoent = bllIngredientCompoent.GetModel(OID);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, e.ToString());
        //    }
       
        //}

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

        //private void AuditButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (_checkDispatch())
        //        {
        //            curAgent.auditState = AuditState.Audited;
        //            curAgent.Auditor = Program.CurrentUser.Name;
        //            bllAgent.Update(curAgent);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, e.ToString());
        //    }
            
        //}

        //private bool _checkDispatch()
        //{
        //    bool flag = true;
        //    if (curAgent != null)
        //    {
        //        foreach (ERP.Model.IngredientCompoent curIngr in bllAgent.GetAllIngredientCompoentModels(curAgent))
        //        {
        //            if (curIngr.Product == null || curIngr.Num == null)
        //            {
        //                flag = false;
        //                MessageBox.Show("物料信息不全");
        //            }
        //            else if (curIngr.Num != null)
        //            {
        //                if (curIngr.Num ==0)
        //                {
        //                    flag = false;
        //                    MessageBox.Show("数量不能为0！");
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("没有添加物料列表");
        //                flag = false;
        //            }
        //        }
        //        //if (bllAgent.GetAllIngredientCompoentModels(curAgent).Count>0)
        //        //{
        //        //    foreach (DataRow curRow in bllAgent.GetAllIngredientCompoents(curAgent).Tables[0].Rows)
        //        //    {
        //        //        if (curRow[1]==null||curRow[5]==null)
        //        //        {
        //        //            flag = false;
        //        //            MessageBox.Show("物料信息不全");
                            
                            
        //        //        }
        //        //        else if (curRow[5]!=null)
        //        //        {
        //        //            if (curRow[5].ToString() =="0")
        //        //            {
        //        //                flag = false;
        //        //                MessageBox.Show("数量不能为0！");
        //        //            }
        //        //        }
        //        //    }
        //        //}
        //        //else
        //        //{
        //        //    MessageBox.Show("没有添加物料列表");
        //        //    flag = false;
        //        //}
        //    }
        //    else
        //    {
        //        MessageBox.Show("出现异常！");
        //        flag = false;
        //    }
        //    return flag;
        //}

      

        private void ReceiptDescription_Enter(object sender, EventArgs e)
        {
            try
            {
                if (curAgent.Description != DescriptionText.Text)
                {
                    curAgent.Description = DescriptionText.Text;
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
                    currentIndex = AgentGridView.CurrentRow.Index;
                    _updateControlText(currentIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, e.ToString());
            }
           
        }

       
       
       

       
       
    }
}
