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
    public partial class ProductStatisticsWinForm : Form
    {
        public ProductStatisticsWinForm()
        {
            InitializeComponent();
        }
        private  BLL.Product bllProduct= new BLL.Product();
        private  BLL.Warehouse bllWarehouse = new BLL.Warehouse();
        private  BLL.Statistics bllStatistics = new BLL.Statistics();
        private  Model.Warehouse curWarehouse =null;
        private  ERP.Model.Statistics _curStatistics = null;
        private BLL.IngredientCompoentLog bllIngredientCompoentLog = new BLL.IngredientCompoentLog();
        private void ProductStatisticsWinForm_Load(object sender, EventArgs e)
        {
            try
            {
                //if (bllWarehouse.GetRecordCount("") == 0)
                //{
                //    ERP.Model.Warehouse newWarehouse = new ERP.Model.Warehouse();
                //    bllWarehouse.Add(newWarehouse);

                //}
                //curWarehouse = bllWarehouse.GetTop1Model();
                //foreach (DataRow curRow in bllProduct.GetAllList().Tables[0].Rows)
                //{

                //    int Pro_OID = int.Parse(curRow[0].ToString());
                //    if (bllStatistics.GetModelByProduct(Pro_OID) == null)
                //    {
                //        ERP.Model.Statistics newStatistics = new ERP.Model.Statistics();
                //        newStatistics.War_OID = curWarehouse.OID;
                //        newStatistics.Pro_OID = Pro_OID;
                //        newStatistics.Ident = curRow[2].ToString();
                //        bllStatistics.Add(newStatistics);

                //    }
                //}
                //foreach (string curPrdCategory in Enum.GetNames(typeof(ProductCategory)))
                //{
                //    ProdCategory.Items.Add(curPrdCategory);
                //}
                foreach (ERP.Model.Product  curProd in bllProduct.GetModelList(""))
                {
                    ProdcomboBox.Items.Add(curProd.Ident.Trim() + "," + curProd.Name.Trim());
                }
                foreach (string curMonth in SearchStr.GetMonthList())
                {
                    MonthcomboBox.Items.Add(curMonth);
                }

                _loadData();
                _updateControlText(0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
 
            }
            
        }


        //private SqlConnection connt = new SqlConnection(SearchStr.connectingstring);
        //private SqlDataAdapter sad;
        private DataSet ds;
        private List<ERP.Model.Statistics> statisticsList;
        private void _loadData()
        {
            try
            {
                ds = bllStatistics.GetAllList();
                if (ds != null)
                {

                    ProStatisticsGridView.DataSource = ds.Tables[0];
                    ProStatisticsGridView.Columns["Dis_OID"].Visible = false;
                    ProStatisticsGridView.Columns["War_OID"].Visible = false;
                    ProStatisticsGridView.Columns["Pro_OID"].Visible = false;
                    ProStatisticsGridView.Columns["Description"].Visible = false;
                    ProStatisticsGridView.Columns["ModifyUser"].Visible = false;
                    ProStatisticsGridView.Columns["Description"].Visible = false;
                    ProStatisticsGridView.Columns["StatisticMonth"].Visible = false;
                    ProStatisticsGridView.Columns["ReceivalStatistic"].Visible = false;
                    ProStatisticsGridView.Columns["DispatchStatistic"].Visible = false;


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
            
          

            //try
            //{
            //    if (DialogWinForm.ShowDialogWinForm(ref theIdent,ref theName,ref theCategory) == true)
            //    {
            //        if (bllProduct.GetModel(theIdent) != null)
            //        {
            //            throw new Exception("物料代码已存在!");
            //        }
            //        else
            //        {
            //            Model.Product newProduct = new Model.Product();
            //            newProduct.Ident = theIdent;
            //            newProduct.Name = theName;
            //            newProduct.Price = 0;
            //            newProduct.Category = theCategory;
            //            newProduct.CreationDate = DateTime.Now;
            //            bllProduct.Add(newProduct);


 
            //        }
            //        //if (connt.State == ConnectionState.Closed) { connt.Open(); }
            //        //sel = "select count(*) from [ERPDatabase].[dbo].[Product] where [Ident] = '" + theIdent + "'";
            //        //SqlCommand cmd = new SqlCommand(sel, connt);
            //        //int theNum = int.Parse(cmd.ExecuteScalar().ToString());
            //        //if (theNum > 0)
            //        //{
            //        //    throw new Exception("物料代码已存在!");
            //        //}
            //        //else
            //        //{
            //        //    sel = "insert into [ERPDatabase].[dbo].[Product] ([Ident],[Name],[Category],[Price],[ModifyUser],[CreationDate]) values('" + theIdent + "','" + theName + "'," + theCategory +",0,'" + SearchStr.CurrentUser +"','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
            //        //    SqlCommand insertCmd = new SqlCommand(sel, connt);
            //        //    insertCmd.ExecuteNonQuery();
            //        //}
            //    }
            //}
            //catch (Exception  err)
            //{
            //    throw err;
            //}

            _loadData();
        }

        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {

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
        private Model.Product curProduct;
        private void _updateControlText(int theIndex)
        {
            try
            {

                int OID = int.Parse(ProStatisticsGridView.Rows[theIndex].Cells[0].Value.ToString());
                //curProduct = bllProduct.GetModel(OID);
                _curStatistics = bllStatistics.GetModel(OID);
                if (_curStatistics != null)
                {
                    ProdIdent.Text = _curStatistics.Ident;
                    ProdNum.Text = _curStatistics.Number.ToString();
                    //ProdCategory.Text = Enum.GetName(typeof(ProductCategory), curProduct.Category);
                    //ProdPrice.Text = curProduct.Price.ToString();
                    ProdDescription.Text = _curStatistics.Description;
                    ModifyUser.Text = _curStatistics.ModifyUser;
                    //CreationDate.Text = curProduct.CreationDate.ToString();
                    //ModifyDate.Text = curProduct.ModifyDate.ToString();
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
        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            _updateControlText(currentIndex);
            //currentGridViewRow = (DataGridViewRow)ProductGridView.Rows[e.RowIndex];
            
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (curProduct != null)
                //{
                //    bllProduct.Clone(curProduct);
                //}
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
                //if (curProduct != null)
                //{
                //    bllProduct.Delete(curProduct.OID);
                //}
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //if (curProduct != null )
            //{
            //    bllProduct.Update(curProduct);
            //}
        }

        
        private void ProdDescription_TextChanged(object sender, EventArgs e)
        {
            _curStatistics.Description = ProdDescription.Text;
        }

        

        private void ProductGridView_CursorChanged(object sender, EventArgs e)
        {

        }

        private void ProStatisticsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            _updateControlText(currentIndex);
        }

        private void ProStatisticsGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up||e.KeyCode == Keys.Down)
            //{
            //    currentIndex = ProStatisticsGridView.CurrentRow.Index;
            //    _updateControlText(currentIndex);
            //}
            //MessageBox.Show(e.Control.GetType().Name);

        }

        private void ProStatisticsGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                currentIndex = ProStatisticsGridView.CurrentRow.Index;
                _updateControlText(currentIndex);
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==1)
            {
                    DispatchStatistic.Text="";
                    ReceivalStatistic.Text = "";
                    SelectedMonth.Text = "";

            }
        }
       
        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            if (MonthcomboBox.Text != "" && ProdcomboBox.Text != "")
            {
                string[] strList = MonthcomboBox.Text.Split(new char[] { '/' });
                int selecedMonth = int.Parse(strList[0]);
                int selecedYear = int.Parse(strList[1]);
                string prodIdent = ProdcomboBox.Text.Split(new char[] { ',' })[0];
                ReceivalStatistic.Text=bllIngredientCompoentLog.GetMonthStatistics(prodIdent, selecedMonth, selecedYear, true).ToString();
                DispatchStatistic.Text = bllIngredientCompoentLog.GetMonthStatistics(prodIdent, selecedMonth, selecedYear, false).ToString();
                SelectedMonth.Text = selecedMonth.ToString();
            }
            else
            {
                MessageBox.Show("请选择物料和月份！");
            }
        }
        
       
    }
}
